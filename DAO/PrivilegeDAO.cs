using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;

//namespace QLBV.DAO
//{
//    /// <summary>
//    /// Helper DAO to manage grants/revokes and metadata queries.
//    /// Designed for Oracle (uses DBA_* / ALL_* views). Caller must be connected with a user that can read DBA views and issue GRANT/REVOKE.
//    /// </summary>
//    public class PrivilegeDAO
//    {
//        private static PrivilegeDAO instance;
//        public static PrivilegeDAO Instance
//        {
//            get
//            {
//                if (instance == null) instance = new PrivilegeDAO();
//                return instance;
//            }
//            private set { instance = value; }
//        }

//        private PrivilegeDAO() { }

//        private static void ValidateSqlName(string name, string paramName)
//        {
//            if (string.IsNullOrWhiteSpace(name))
//                throw new ArgumentException(paramName + " is required", paramName);

//            // Allow letters, digits, underscore, dollar, dot (owner.table). Prevent dangerous characters.
//            if (!Regex.IsMatch(name, @"^[A-Za-z0-9_\$\.]+$"))
//                throw new ArgumentException($"Invalid {paramName}. Only letters, digits, underscore, dollar sign and dot are allowed.", paramName);
//        }

//        public DataTable GetDbObjects()
//        {
//            // Return only objects owned by the current connected user (no system-wide objects).
//            // This limits results to tables, views, procedures and functions created by the DBA/admin account
//            // that the application is connected with (OWNER = USER).
//            string qObj = @"
//SELECT OBJECT_TYPE, OWNER, OBJECT_NAME
//FROM ALL_OBJECTS
//WHERE OBJECT_TYPE IN ('TABLE','VIEW','PROCEDURE','FUNCTION')
//  AND OWNER = USER
//ORDER BY OBJECT_TYPE, OWNER, OBJECT_NAME";
//            return DataProvider.Instance.ExecuteQuery(qObj);
//        }

//        public DataTable GetColumns(string owner, string tableName)
//        {
//            ValidateSqlName(owner, nameof(owner));
//            ValidateSqlName(tableName, nameof(tableName));
//            string q = $"SELECT COLUMN_NAME FROM ALL_TAB_COLUMNS WHERE OWNER = '{owner.ToUpper()}' AND TABLE_NAME = '{tableName.ToUpper()}' ORDER BY COLUMN_ID";
//            return DataProvider.Instance.ExecuteQuery(q);
//        }

//        public DataTable GetPrivilegesForGranteeLike(string pattern, bool forUser)
//        {
//            if (pattern == null) pattern = "";
//            string like = pattern.ToUpper().Replace("'", "''");
//            if (!like.Contains("%")) like = $"%{like}%";

//            string qTab = $@"
//SELECT GRANTEE, PRIVILEGE, OWNER, TABLE_NAME, NULL AS COLUMN_NAME, 'OBJECT' AS OBJECT_TYPE, GRANTABLE
//FROM DBA_TAB_PRIVS
//WHERE UPPER(GRANTEE) LIKE '{like}'
//";

//            string qCol = $@"
//SELECT GRANTEE, PRIVILEGE, OWNER, TABLE_NAME, COLUMN_NAME, 'COLUMN' AS OBJECT_TYPE, GRANTABLE
//FROM DBA_COL_PRIVS
//WHERE UPPER(GRANTEE) LIKE '{like}'
//";

//            string qRole = $@"
//SELECT GRANTEE, GRANTED_ROLE AS PRIVILEGE, NULL AS OWNER, NULL AS TABLE_NAME, NULL AS COLUMN_NAME, 'ROLE' AS OBJECT_TYPE, ADMIN_OPTION AS GRANTABLE
//FROM DBA_ROLE_PRIVS
//WHERE UPPER(GRANTEE) LIKE '{like}'
//";

//            var dt = DataProvider.Instance.ExecuteQuery(qTab);
//            var dt2 = DataProvider.Instance.ExecuteQuery(qCol);
//            var dt3 = DataProvider.Instance.ExecuteQuery(qRole);
//            dt.Merge(dt2);
//            dt.Merge(dt3);
//            return dt;
//        }

//        // Helper: build sanitized view name following convention V_<Table>_<Principal>
//        private string BuildViewName(string tableName, string principal)
//        {
//            // remove any non-alphanumeric/underscore chars just in case
//            var cleanTable = Regex.Replace(tableName ?? "", @"[^A-Za-z0-9_]", "_").ToUpper();
//            var cleanPrincipal = Regex.Replace(principal ?? "", @"[^A-Za-z0-9_]", "_").ToUpper();
//            return $"V_{cleanTable}_{cleanPrincipal}";
//        }

//        // Drop view if exists (ignore ORA-00942)
//        private void DropViewIfExists(string viewName)
//        {
//            if (string.IsNullOrWhiteSpace(viewName)) return;
//            // Use anonymous PL/SQL block to ignore "view does not exist"
//            string plsql = $@"
//BEGIN
//  EXECUTE IMMEDIATE 'DROP VIEW {viewName}';
//EXCEPTION
//  WHEN OTHERS THEN
//    IF SQLCODE != -942 THEN
//      RAISE;
//    END IF;
//END;";
//            DataProvider.Instance.ExecuteNonQuery(plsql);
//        }

//        // Create view with selected columns (view created in connected schema)
//        private void CreateViewForColumns(string owner, string tableName, string viewName, string[] columns)
//        {
//            if (columns == null || columns.Length == 0)
//                throw new ArgumentException("columns required to create view", nameof(columns));

//            var cols = string.Join(", ", columns.Select(c => c.ToUpper()));
//            string createSql = $"CREATE VIEW {viewName} AS SELECT {cols} FROM {owner.ToUpper()}.{tableName.ToUpper()}";
//            DataProvider.Instance.ExecuteNonQuery(createSql);
//        }

//        /// <summary>
//        /// Grants object-level privileges. Implements view-creation strategy for column-level SELECT (and SELECT for UPDATE).
//        /// For roles: GRANT role TO grantee [WITH ADMIN OPTION].
//        /// For SELECT with columnList: create view V_Table_Principal, grant SELECT on that view (drop old view first).
//        /// For UPDATE with columnList: grant UPDATE (cols) ON owner.table, and ensure SELECT is granted by creating view and granting SELECT on view.
//        /// INSERT/DELETE: only whole-object grants (columnList ignored).
//        /// </summary>
//        public void GrantPrivilege(string grantee, string objectType, string owner, string objectName, string[] privileges, string[] columnList, bool withGrantOption, bool granteeIsUser)
//        {
//            ValidateSqlName(grantee, nameof(grantee));
//            if (objectType == "ROLE")
//            {
//                ValidateSqlName(objectName, nameof(objectName));
//                string roleName = objectName.ToUpper();
//                var sql = $"GRANT {roleName} TO {grantee.ToUpper()}";
//                if (withGrantOption) sql += " WITH ADMIN OPTION";
//                DataProvider.Instance.ExecuteNonQuery(sql);
//                return;
//            }

//            ValidateSqlName(owner, nameof(owner));
//            ValidateSqlName(objectName, nameof(objectName));

//            foreach (var priv in privileges)
//            {
//                string p = priv.ToUpper();

//                // PROCEDURE/FUNCTION -> EXECUTE (no column handling)
//                if (objectType == "PROCEDURE" || objectType == "FUNCTION")
//                {
//                    string sql = $"GRANT EXECUTE ON {owner.ToUpper()}.{objectName.ToUpper()} TO {grantee.ToUpper()}";
//                    if (withGrantOption && granteeIsUser) sql += " WITH GRANT OPTION";
//                    DataProvider.Instance.ExecuteNonQuery(sql);
//                    continue;
//                }

//                // INSERT/DELETE: only whole-object grants (ignore any columnList)
//                if (p == "INSERT" || p == "DELETE")
//                {
//                    string sql = $"GRANT {p} ON {owner.ToUpper()}.{objectName.ToUpper()} TO {grantee.ToUpper()}";
//                    if (withGrantOption && granteeIsUser) sql += " WITH GRANT OPTION";
//                    DataProvider.Instance.ExecuteNonQuery(sql);
//                    continue;
//                }

//                // SELECT handling: column-level via view creation (Oracle does not support SELECT(col1, col2) syntax)
//                if (p == "SELECT")
//                {
//                    if (columnList != null && columnList.Length > 0)
//                    {
//                        // create view name using convention and drop existing view if any
//                        string viewName = BuildViewName(objectName, grantee);
//                        // drop previous view first (per requirement)
//                        DropViewIfExists(viewName);
//                        // create view with chosen columns
//                        CreateViewForColumns(owner, objectName, viewName, columnList);
//                        // grant select on the view to the principal
//                        string grantView = $"GRANT SELECT ON {viewName} TO {grantee.ToUpper()}";
//                        if (withGrantOption && granteeIsUser) grantView += " WITH GRANT OPTION";
//                        DataProvider.Instance.ExecuteNonQuery(grantView);
//                    }
//                    else
//                    {
//                        // grant whole-object SELECT
//                        string sql = $"GRANT SELECT ON {owner.ToUpper()}.{objectName.ToUpper()} TO {grantee.ToUpper()}";
//                        if (withGrantOption && granteeIsUser) sql += " WITH GRANT OPTION";
//                        DataProvider.Instance.ExecuteNonQuery(sql);
//                    }
//                    continue;
//                }

//                // UPDATE: allow column-level update, and also ensure grantee can SELECT the relevant columns (create view + grant SELECT)
//                if (p == "UPDATE")
//                {
//                    if (columnList != null && columnList.Length > 0)
//                    {
//                        // grant UPDATE on columns
//                        var cols = string.Join(", ", columnList.Select(c => c.ToUpper()));
//                        string sqlUpdate = $"GRANT UPDATE ({cols}) ON {owner.ToUpper()}.{objectName.ToUpper()} TO {grantee.ToUpper()}";
//                        if (withGrantOption && granteeIsUser) sqlUpdate += " WITH GRANT OPTION";
//                        DataProvider.Instance.ExecuteNonQuery(sqlUpdate);

//                        // create or replace view: per requirement drop old view and create new
//                        string viewName = BuildViewName(objectName, grantee);
//                        DropViewIfExists(viewName);
//                        CreateViewForColumns(owner, objectName, viewName, columnList);

//                        // grant SELECT on the view so grantee can see data needed for update
//                        string grantView = $"GRANT SELECT ON {viewName} TO {grantee.ToUpper()}";
//                        if (withGrantOption && granteeIsUser) grantView += " WITH GRANT OPTION";
//                        DataProvider.Instance.ExecuteNonQuery(grantView);
//                    }
//                    else
//                    {
//                        // grant UPDATE on whole object
//                        string sql = $"GRANT UPDATE ON {owner.ToUpper()}.{objectName.ToUpper()} TO {grantee.ToUpper()}";
//                        if (withGrantOption && granteeIsUser) sql += " WITH GRANT OPTION";
//                        DataProvider.Instance.ExecuteNonQuery(sql);

//                        // also grant SELECT on whole object so user can see data
//                        string sqlSelect = $"GRANT SELECT ON {owner.ToUpper()}.{objectName.ToUpper()} TO {grantee.ToUpper()}";
//                        if (withGrantOption && granteeIsUser) sqlSelect += " WITH GRANT OPTION";
//                        DataProvider.Instance.ExecuteNonQuery(sqlSelect);
//                    }
//                    continue;
//                }

//                // fallback: try direct grant
//                {
//                    string sql = $"GRANT {p} ON {owner.ToUpper()}.{objectName.ToUpper()} TO {grantee.ToUpper()}";
//                    if (withGrantOption && granteeIsUser) sql += " WITH GRANT OPTION";
//                    DataProvider.Instance.ExecuteNonQuery(sql);
//                }
//            }
//        }

//        /// <summary>
//        /// Revokes privileges from grantee. For role revocation pass objectType='ROLE' and objectName=role name (owner ignored).
//        /// For SELECT/UPDATE column-level revocations, we will revoke on the view and drop it.
//        /// </summary>
//        public void RevokePrivilege(string grantee, string objectType, string owner, string objectName, string[] privileges, string[] columnList)
//        {
//            ValidateSqlName(grantee, nameof(grantee));

//            if (objectType == "ROLE")
//            {
//                ValidateSqlName(objectName, nameof(objectName));
//                string sql = $"REVOKE {objectName.ToUpper()} FROM {grantee.ToUpper()}";
//                DataProvider.Instance.ExecuteNonQuery(sql);
//                return;
//            }

//            ValidateSqlName(owner, nameof(owner));
//            ValidateSqlName(objectName, nameof(objectName));

//            foreach (var priv in privileges)
//            {
//                string p = priv.ToUpper();

//                if (p == "SELECT")
//                {
//                    if (columnList != null && columnList.Length > 0)
//                    {
//                        // revoke select on the view and drop the view
//                        string viewName = BuildViewName(objectName, grantee);
//                        string revokeView = $"REVOKE SELECT ON {viewName} FROM {grantee.ToUpper()}";
//                        // attempt revoke (ignore errors if not granted)
//                        try { DataProvider.Instance.ExecuteNonQuery(revokeView); } catch { }
//                        // drop view (ignore if doesn't exist)
//                        try { DropViewIfExists(viewName); } catch { }
//                    }
//                    else
//                    {
//                        string sql = $"REVOKE SELECT ON {owner.ToUpper()}.{objectName.ToUpper()} FROM {grantee.ToUpper()}";
//                        DataProvider.Instance.ExecuteNonQuery(sql);
//                    }
//                    continue;
//                }

//                if (p == "UPDATE")
//                {
//                    if (columnList != null && columnList.Length > 0)
//                    {
//                        var cols = string.Join(", ", columnList.Select(c => c.ToUpper()));
//                        string sql = $"REVOKE UPDATE ({cols}) ON {owner.ToUpper()}.{objectName.ToUpper()} FROM {grantee.ToUpper()}";
//                        DataProvider.Instance.ExecuteNonQuery(sql);

//                        // revoke select on view and drop view
//                        string viewName = BuildViewName(objectName, grantee);
//                        try { DataProvider.Instance.ExecuteNonQuery($"REVOKE SELECT ON {viewName} FROM {grantee.ToUpper()}"); } catch { }
//                        try { DropViewIfExists(viewName); } catch { }
//                    }
//                    else
//                    {
//                        string sql = $"REVOKE UPDATE ON {owner.ToUpper()}.{objectName.ToUpper()} FROM {grantee.ToUpper()}";
//                        DataProvider.Instance.ExecuteNonQuery(sql);
//                        // also revoke select granted previously for UPDATE whole-object case
//                        try { DataProvider.Instance.ExecuteNonQuery($"REVOKE SELECT ON {owner.ToUpper()}.{objectName.ToUpper()} FROM {grantee.ToUpper()}"); } catch { }
//                    }
//                    continue;
//                }

//                if (p == "INSERT" || p == "DELETE")
//                {
//                    string sql = $"REVOKE {p} ON {owner.ToUpper()}.{objectName.ToUpper()} FROM {grantee.ToUpper()}";
//                    DataProvider.Instance.ExecuteNonQuery(sql);
//                    continue;
//                }

//                if (p == "EXECUTE")
//                {
//                    string sql = $"REVOKE EXECUTE ON {owner.ToUpper()}.{objectName.ToUpper()} FROM {grantee.ToUpper()}";
//                    DataProvider.Instance.ExecuteNonQuery(sql);
//                    continue;
//                }

//                // fallback
//                string fallback = $"REVOKE {p} ON {owner.ToUpper()}.{objectName.ToUpper()} FROM {grantee.ToUpper()}";
//                DataProvider.Instance.ExecuteNonQuery(fallback);
//            }
//        }
//    }
//}

namespace QLBV.DAO
{
    /// <summary>
    /// Helper DAO to manage grants/revokes and metadata queries.
    /// Designed for Oracle (uses DBA_* / ALL_* views). Caller must be connected with a user that can read DBA views and issue GRANT/REVOKE.
    /// </summary>
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

        private static void ValidateSqlName(string name, string paramName)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(paramName + " is required", paramName);

            // Allow letters, digits, underscore, dollar, dot (owner.table). Prevent dangerous characters.
            if (!Regex.IsMatch(name, @"^[A-Za-z0-9_\$\.]+$"))
                throw new ArgumentException($"Invalid {paramName}. Only letters, digits, underscore, dollar sign and dot are allowed.", paramName);
        }

        public DataTable GetDbObjects()
        {
            // Return only objects owned by the current connected user (no system-wide objects).
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

        /// <summary>
        /// Search privileges (or principals) for a pattern. If forUser==true return privileges where GRANTEE is a database user;
        /// otherwise only where GRANTEE is a role. This uses DBA_USERS / DBA_ROLES to restrict.
        /// </summary>
        public DataTable GetPrivilegesForGranteeLike(string pattern, bool forUser)
        {
            if (pattern == null) pattern = "";
            string like = pattern.ToUpper().Replace("'", "''");
            if (!like.Contains("%")) like = $"%{like}%";

            // grantee filter: limit GRANTEE to users or roles
            string granteeFilter = forUser
                ? "AND GRANTEE IN (SELECT USERNAME FROM DBA_USERS WHERE COMMON = 'NO')"
                : "AND GRANTEE IN (SELECT ROLE FROM DBA_ROLES WHERE COMMON = 'NO')";

            // table/view privileges
            string qTab = $@"
SELECT GRANTEE, PRIVILEGE, OWNER, TABLE_NAME, NULL AS COLUMN_NAME, 'OBJECT' AS OBJECT_TYPE, GRANTABLE
FROM DBA_TAB_PRIVS
WHERE UPPER(GRANTEE) LIKE '{like}'
{granteeFilter}
";

            // column-level
            string qCol = $@"
SELECT GRANTEE, PRIVILEGE, OWNER, TABLE_NAME, COLUMN_NAME, 'COLUMN' AS OBJECT_TYPE, GRANTABLE
FROM DBA_COL_PRIVS
WHERE UPPER(GRANTEE) LIKE '{like}'
{granteeFilter}
";

            // roles granted (ROLE grants to this grantee)
            // For role-grants, ADMIN_OPTION indicates ability to further grant that role.
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

        // Helper: build sanitized view name following convention V_<Table>_<Principal>
        private string BuildViewName(string tableName, string principal)
        {
            var cleanTable = Regex.Replace(tableName ?? "", @"[^A-Za-z0-9_]", "_").ToUpper();
            var cleanPrincipal = Regex.Replace(principal ?? "", @"[^A-Za-z0-9_]", "_").ToUpper();
            return $"V_{cleanTable}_{cleanPrincipal}";
        }

        // Drop view if exists (ignore "view does not exist"). Use PL/SQL block.
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

        // Create view with selected columns (view created in connected schema)
        private void CreateViewForColumns(string owner, string tableName, string viewName, string[] columns)
        {
            if (columns == null || columns.Length == 0)
                throw new ArgumentException("columns required to create view", nameof(columns));

            var cols = string.Join(", ", columns.Select(c => c.ToUpper()));
            string createSql = $"CREATE VIEW {viewName} AS SELECT {cols} FROM {owner.ToUpper()}.{tableName.ToUpper()}";
            DataProvider.Instance.ExecuteNonQuery(createSql);
        }

        /// <summary>
        /// Grants privileges. withGrantOption => append WITH GRANT OPTION for object privileges,
        /// WITH ADMIN OPTION for role grants.
        /// Column-level SELECT implemented by creating view V_<Table>_<Grantee> and granting SELECT on that view.
        /// UPDATE column grants also create a view (SELECT) so the grantee can see updated data.
        /// INSERT/DELETE: whole-table only.
        /// </summary>
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

                // fallback
                {
                    string sql = $"GRANT {p} ON {owner.ToUpper()}.{objectName.ToUpper()} TO {grantee.ToUpper()}";
                    if (withGrantOption) sql += " WITH GRANT OPTION";
                    DataProvider.Instance.ExecuteNonQuery(sql);
                }
            }
        }

        /// <summary>
        /// Revoke all common privileges from grantee on the object and remove any view created for column-level grants.
        /// If objectType == 'ROLE' it revokes the role from grantee.
        /// </summary>
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

            // Per requirement: when revoke is triggered, revoke "sạch" tất cả quyền trên object cho grantee
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
                    // ignore individual revoke errors
                }
            }

            // If a view was created for column-level SELECT/UPDATE, drop it and revoke select on it if necessary
            string viewName = BuildViewName(objectName, grantee);
            try
            {
                // attempt revoke SELECT ON VIEW (ignore errors)
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