using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;

namespace QLBV.DAO
{
    //Đây là một lớp hỗ trợ DAO quản lý quyền truy cập
    public class PrivilegeDAO
    {
        private static PrivilegeDAO instance;
        public static PrivilegeDAO Instance
        {
            get
            {
                if (instance == null) instance = new PrivilegeDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private PrivilegeDAO() { }
        // Kiểm tra tên SQL hợp lệ (chỉ chứa chữ, số, _, $, .)
        private static void ValidateSqlName(string name, string paramName)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(paramName + " is required", paramName);

           
            if (!Regex.IsMatch(name, @"^[A-Za-z0-9_\$\.]+$"))
                throw new ArgumentException($"Invalid {paramName}. Only letters, digits, underscore, dollar sign and dot are allowed.", paramName);
        }

        public DataTable GetDbObjects()
        {
            string qObj = @"
SELECT OBJECT_TYPE, OWNER, OBJECT_NAME
FROM ALL_OBJECTS
WHERE OBJECT_TYPE IN ('TABLE','VIEW','PROCEDURE','FUNCTION')
  AND OWNER = USER
ORDER BY OBJECT_TYPE, OWNER, OBJECT_NAME";
            return DataProvider.Instance.ExecuteQuery(qObj);
        }

        public DataTable GetColumns(string owner, string tableName)
        {
            ValidateSqlName(owner, nameof(owner));
            ValidateSqlName(tableName, nameof(tableName));
            string q = $"SELECT COLUMN_NAME FROM ALL_TAB_COLUMNS WHERE OWNER = '{owner.ToUpper()}' AND TABLE_NAME = '{tableName.ToUpper()}' ORDER BY COLUMN_ID";
            return DataProvider.Instance.ExecuteQuery(q);
        }
        // Lấy tất cả quyền của người dùng hoặc vai trò có tên giống pattern
        public DataTable GetPrivilegesForGranteeLike(string pattern, bool forUser)
        {
            if (pattern == null) pattern = "";
            string like = pattern.ToUpper().Replace("'", "''");
            if (!like.Contains("%")) like = $"%{like}%";

            string granteeFilter = forUser
                ? "AND GRANTEE IN (SELECT USERNAME FROM DBA_USERS WHERE COMMON = 'NO')"
                : "AND GRANTEE IN (SELECT ROLE FROM DBA_ROLES WHERE COMMON = 'NO')";

            string qTab = $@"
SELECT GRANTEE, PRIVILEGE, OWNER, TABLE_NAME, NULL AS COLUMN_NAME, 'OBJECT' AS OBJECT_TYPE, GRANTABLE
FROM DBA_TAB_PRIVS
WHERE UPPER(GRANTEE) LIKE '{like}'
{granteeFilter}
";

            string qCol = $@"
SELECT GRANTEE, PRIVILEGE, OWNER, TABLE_NAME, COLUMN_NAME, 'COLUMN' AS OBJECT_TYPE, GRANTABLE
FROM DBA_COL_PRIVS
WHERE UPPER(GRANTEE) LIKE '{like}'
{granteeFilter}
";


            string qRole = $@"
SELECT GRANTEE, GRANTED_ROLE AS PRIVILEGE, NULL AS OWNER, NULL AS TABLE_NAME, NULL AS COLUMN_NAME, 'ROLE' AS OBJECT_TYPE, ADMIN_OPTION AS GRANTABLE
FROM DBA_ROLE_PRIVS
WHERE UPPER(GRANTEE) LIKE '{like}'
{granteeFilter}
";

            var dt = DataProvider.Instance.ExecuteQuery(qTab);
            var dt2 = DataProvider.Instance.ExecuteQuery(qCol);
            var dt3 = DataProvider.Instance.ExecuteQuery(qRole);
            dt.Merge(dt2);
            dt.Merge(dt3);
            return dt;
        }
        // Tạo tên view tạm dựa trên tên bảng và người nhận quyền, đảm bảo chỉ chứa chữ, số và dấu gạch dưới
        private string BuildViewName(string tableName, string principal)
        {
            var cleanTable = Regex.Replace(tableName ?? "", @"[^A-Za-z0-9_]", "_").ToUpper();
            var cleanPrincipal = Regex.Replace(principal ?? "", @"[^A-Za-z0-9_]", "_").ToUpper();
            return $"V_{cleanTable}_{cleanPrincipal}";
        }

        private void DropViewIfExists(string viewName)
        {
            if (string.IsNullOrWhiteSpace(viewName)) return;
            string plsql = $@"
BEGIN
  EXECUTE IMMEDIATE 'DROP VIEW {viewName}';
EXCEPTION
  WHEN OTHERS THEN
    IF SQLCODE != -942 THEN
      RAISE;
    END IF;
END;";
            DataProvider.Instance.ExecuteNonQuery(plsql);
        }

        private void CreateViewForColumns(string owner, string tableName, string viewName, string[] columns)
        {
            if (columns == null || columns.Length == 0)
                throw new ArgumentException("columns required to create view", nameof(columns));

            var cols = string.Join(", ", columns.Select(c => c.ToUpper()));
            string createSql = $"CREATE VIEW {viewName} AS SELECT {cols} FROM {owner.ToUpper()}.{tableName.ToUpper()}";
            DataProvider.Instance.ExecuteNonQuery(createSql);
        }
        // Cấp quyền cho người dùng hoặc vai trò, hỗ trợ quyền trên đối tượng và cột, cũng như quyền vai trò
        public void GrantPrivilege(string grantee, string objectType, string owner, string objectName, string[] privileges, string[] columnList, bool withGrantOption, bool granteeIsUser)
        {
            ValidateSqlName(grantee, nameof(grantee));
            if (objectType == "ROLE")
            {
                ValidateSqlName(objectName, nameof(objectName));
                string roleName = objectName.ToUpper();
                var sql = $"GRANT {roleName} TO {grantee.ToUpper()}";
                if (withGrantOption) sql += " WITH ADMIN OPTION";
                DataProvider.Instance.ExecuteNonQuery(sql);
                return;
            }

            ValidateSqlName(owner, nameof(owner));
            ValidateSqlName(objectName, nameof(objectName));

            foreach (var priv in privileges)
            {
                string p = priv.ToUpper();

                if (objectType == "PROCEDURE" || objectType == "FUNCTION")
                {
                    string sql = $"GRANT EXECUTE ON {owner.ToUpper()}.{objectName.ToUpper()} TO {grantee.ToUpper()}";
                    if (withGrantOption) sql += " WITH GRANT OPTION";
                    DataProvider.Instance.ExecuteNonQuery(sql);
                    continue;
                }

                if (p == "INSERT" || p == "DELETE")
                {
                    string sql = $"GRANT {p} ON {owner.ToUpper()}.{objectName.ToUpper()} TO {grantee.ToUpper()}";
                    if (withGrantOption) sql += " WITH GRANT OPTION";
                    DataProvider.Instance.ExecuteNonQuery(sql);
                    continue;
                }

                if (p == "SELECT")
                {
                    if (columnList != null && columnList.Length > 0)
                    {
                        string viewName = BuildViewName(objectName, grantee);
                        DropViewIfExists(viewName);
                        CreateViewForColumns(owner, objectName, viewName, columnList);
                        string grantView = $"GRANT SELECT ON {viewName} TO {grantee.ToUpper()}";
                        if (withGrantOption) grantView += " WITH GRANT OPTION";
                        DataProvider.Instance.ExecuteNonQuery(grantView);
                    }
                    else
                    {
                        string sql = $"GRANT SELECT ON {owner.ToUpper()}.{objectName.ToUpper()} TO {grantee.ToUpper()}";
                        if (withGrantOption) sql += " WITH GRANT OPTION";
                        DataProvider.Instance.ExecuteNonQuery(sql);
                    }
                    continue;
                }

                if (p == "UPDATE")
                {
                    if (columnList != null && columnList.Length > 0)
                    {
                        var cols = string.Join(", ", columnList.Select(c => c.ToUpper()));
                        string sqlUpdate = $"GRANT UPDATE ({cols}) ON {owner.ToUpper()}.{objectName.ToUpper()} TO {grantee.ToUpper()}";
                        if (withGrantOption) sqlUpdate += " WITH GRANT OPTION";
                        DataProvider.Instance.ExecuteNonQuery(sqlUpdate);

                        string viewName = BuildViewName(objectName, grantee);
                        DropViewIfExists(viewName);
                        CreateViewForColumns(owner, objectName, viewName, columnList);

                        string grantView = $"GRANT SELECT ON {viewName} TO {grantee.ToUpper()}";
                        if (withGrantOption) grantView += " WITH GRANT OPTION";
                        DataProvider.Instance.ExecuteNonQuery(grantView);
                    }
                    else
                    {
                        string sql = $"GRANT UPDATE ON {owner.ToUpper()}.{objectName.ToUpper()} TO {grantee.ToUpper()}";
                        if (withGrantOption) sql += " WITH GRANT OPTION";
                        DataProvider.Instance.ExecuteNonQuery(sql);

                        string sqlSelect = $"GRANT SELECT ON {owner.ToUpper()}.{objectName.ToUpper()} TO {grantee.ToUpper()}";
                        if (withGrantOption) sqlSelect += " WITH GRANT OPTION";
                        DataProvider.Instance.ExecuteNonQuery(sqlSelect);
                    }
                    continue;
                }

                {
                    string sql = $"GRANT {p} ON {owner.ToUpper()}.{objectName.ToUpper()} TO {grantee.ToUpper()}";
                    if (withGrantOption) sql += " WITH GRANT OPTION";
                    DataProvider.Instance.ExecuteNonQuery(sql);
                }
            }
        }
        // Thu hồi quyền của người dùng hoặc vai trò, hỗ trợ cả quyền trên đối tượng và cột, cũng như quyền vai trò
        public void RevokePrivilege(string grantee, string objectType, string owner, string objectName, string[] privileges, string[] columnList)
        {
            ValidateSqlName(grantee, nameof(grantee));

            if (objectType == "ROLE")
            {
                ValidateSqlName(objectName, nameof(objectName));
                string sql = $"REVOKE {objectName.ToUpper()} FROM {grantee.ToUpper()}";
                DataProvider.Instance.ExecuteNonQuery(sql);
                return;
            }

            ValidateSqlName(owner, nameof(owner));
            ValidateSqlName(objectName, nameof(objectName));

            string[] allPrivs = new[] { "SELECT", "UPDATE", "INSERT", "DELETE", "EXECUTE" };
            foreach (var p in allPrivs)
            {
                try
                {
                    string revokeSql;
                    if (p == "EXECUTE")
                        revokeSql = $"REVOKE EXECUTE ON {owner.ToUpper()}.{objectName.ToUpper()} FROM {grantee.ToUpper()}";
                    else
                        revokeSql = $"REVOKE {p} ON {owner.ToUpper()}.{objectName.ToUpper()} FROM {grantee.ToUpper()}";

                    DataProvider.Instance.ExecuteNonQuery(revokeSql);
                }
                catch
                {

                }
            }


            string viewName = BuildViewName(objectName, grantee);
            try
            {

                DataProvider.Instance.ExecuteNonQuery($"REVOKE SELECT ON {viewName} FROM {grantee.ToUpper()}");
            }
            catch { }

            try
            {
                DropViewIfExists(viewName);
            }
            catch { }
        }
    }
}