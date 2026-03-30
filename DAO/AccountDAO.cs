using Oracle.ManagedDataAccess.Client;
using QLBV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QLBV.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string username, string password)
        {
            string connStr = $"User Id={username};Password={password};Data Source=localhost:1521/XEPDB1";

            try
            {
                using (OracleConnection conn = new OracleConnection(connStr))
                {
                    conn.Open();

                    DataProvider.Instance.UpdateConnectionString(connStr);

                    return true;
                }
            }
            catch (OracleException ex)
            {
                if (ex.Number == 1017 || ex.Number == 28000)
                    return false;

                throw new Exception("Lỗi hệ thống khi đăng nhập: " + ex.Message);
            }
        }

        public DataTable GetAllUsers()
        {
            string query = "SELECT USERNAME, ACCOUNT_STATUS, TO_CHAR(CREATED, 'YYYY-MM-DD') AS CREATED FROM DBA_USERS WHERE COMMON = 'NO' ORDER BY USERNAME";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetAllRoles()
        {
            string query = "SELECT ROLE AS ROLENAME FROM DBA_ROLES WHERE COMMON = 'NO' ORDER BY ROLE";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public List<UserDTO> GetAllUsersDto()
        {
            DataTable dt = GetAllUsers();
            var list = new List<UserDTO>();
            foreach (DataRow row in dt.Rows)
            {
                var user = new UserDTO
                {
                    Username = row.Table.Columns.Contains("USERNAME") ? row["USERNAME"]?.ToString() : null,
                    Status = row.Table.Columns.Contains("ACCOUNT_STATUS") ? row["ACCOUNT_STATUS"]?.ToString() : null,
                    CreatedDate = row.Table.Columns.Contains("CREATED") ? row["CREATED"]?.ToString() : null
                };
                list.Add(user);
            }
            return list;
        }

        public List<UserDTO> GetUsersLike(string term)
        {
            if (term == null) term = string.Empty;
            var esc = term.ToUpper().Replace("'", "''");
            string query = $"SELECT USERNAME, ACCOUNT_STATUS, TO_CHAR(CREATED, 'YYYY-MM-DD') AS CREATED FROM DBA_USERS WHERE COMMON = 'NO' AND UPPER(USERNAME) LIKE '%{esc}%' ORDER BY USERNAME";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            var list = new List<UserDTO>();
            foreach (DataRow row in dt.Rows)
            {
                var user = new UserDTO
                {
                    Username = row.Table.Columns.Contains("USERNAME") ? row["USERNAME"]?.ToString() : null,
                    Status = row.Table.Columns.Contains("ACCOUNT_STATUS") ? row["ACCOUNT_STATUS"]?.ToString() : null,
                    CreatedDate = row.Table.Columns.Contains("CREATED") ? row["CREATED"]?.ToString() : null
                };
                list.Add(user);
            }
            return list;
        }

        public List<RoleDTO> GetAllRolesDto()
        {
            DataTable dt = GetAllRoles();
            var list = new List<RoleDTO>();
            foreach (DataRow row in dt.Rows)
            {
                var r = new RoleDTO
                {
                    RoleName = row.Table.Columns.Contains("ROLENAME") ? row["ROLENAME"]?.ToString() : row[0]?.ToString()
                };
                list.Add(r);
            }
            return list;
        }

        public DataTable GetUserRoleMapping()
        {
            string q = @"
SELECT u.USERNAME,
       LISTAGG(r.GRANTED_ROLE, ', ') WITHIN GROUP (ORDER BY r.GRANTED_ROLE) AS ROLE
FROM DBA_USERS u
LEFT JOIN DBA_ROLE_PRIVS r ON u.USERNAME = r.GRANTEE
WHERE u.COMMON = 'NO'
GROUP BY u.USERNAME
ORDER BY u.USERNAME";
            return DataProvider.Instance.ExecuteQuery(q);
        }

        public List<string> GetRolesForUser(string username)
        {
            if (string.IsNullOrWhiteSpace(username)) return new List<string>();
            var esc = username.ToUpper().Replace("'", "''");
            string q = $"SELECT GRANTED_ROLE FROM DBA_ROLE_PRIVS WHERE UPPER(GRANTEE) = '{esc}' ORDER BY GRANTED_ROLE";
            var dt = DataProvider.Instance.ExecuteQuery(q);
            var list = new List<string>();
            foreach (DataRow r in dt.Rows)
            {
                var v = r[0]?.ToString();
                if (!string.IsNullOrEmpty(v)) list.Add(v);
            }
            return list;
        }

        public bool CreateUser(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("username required", nameof(username));
            if (password == null)
                throw new ArgumentNullException(nameof(password));

            if (!Regex.IsMatch(username, @"^[A-Za-z0-9_]+$"))
                throw new ArgumentException("Invalid username. Only letters, digits and underscore allowed.", nameof(username));

            string sql = $"CREATE USER \"{username}\" IDENTIFIED BY \"{password}\"";
            DataProvider.Instance.ExecuteNonQuery(sql);
            return true;
        }

        public bool DropUser(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("username required", nameof(username));
            string sql = $"DROP USER \"{username}\" CASCADE";
            DataProvider.Instance.ExecuteNonQuery(sql);
            return true;
        }

        public bool AlterUserPassword(string username, string newPassword)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("username required", nameof(username));
            if (newPassword == null)
                throw new ArgumentNullException(nameof(newPassword));

            string sql = $"ALTER USER \"{username}\" IDENTIFIED BY \"{newPassword}\"";
            DataProvider.Instance.ExecuteNonQuery(sql);
            return true;
        }

        public bool AlterRolePassword(string roleName, string newPassword)
        {
            if (string.IsNullOrWhiteSpace(roleName))
                throw new ArgumentException("roleName required", nameof(roleName));
            if (newPassword == null)
                throw new ArgumentNullException(nameof(newPassword));

            if (!Regex.IsMatch(roleName, @"^[A-Za-z0-9_]+$"))
                throw new ArgumentException("Invalid role name. Only letters, digits and underscore allowed.", nameof(roleName));

            string sql = $"ALTER ROLE \"{roleName}\" IDENTIFIED BY \"{newPassword}\"";
            DataProvider.Instance.ExecuteNonQuery(sql);
            return true;
        }

        public bool LockUser(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("username required", nameof(username));
            string sql = $"ALTER USER \"{username}\" ACCOUNT LOCK";
            DataProvider.Instance.ExecuteNonQuery(sql);
            return true;
        }

        public bool UnlockUser(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("username required", nameof(username));
            string sql = $"ALTER USER \"{username}\" ACCOUNT UNLOCK";
            DataProvider.Instance.ExecuteNonQuery(sql);
            return true;
        }

        public bool CreateRole(string roleName, string password = null)
        {
            if (string.IsNullOrWhiteSpace(roleName))
                throw new ArgumentException("roleName required", nameof(roleName));
            if (!Regex.IsMatch(roleName, @"^[A-Za-z0-9_]+$"))
                throw new ArgumentException("Invalid role name. Only letters, digits and underscore allowed.", nameof(roleName));

            string sql = password == null
                ? $"CREATE ROLE \"{roleName}\""
                : $"CREATE ROLE \"{roleName}\" IDENTIFIED BY \"{password}\"";
            DataProvider.Instance.ExecuteNonQuery(sql);
            return true;
        }

        public bool DropRole(string roleName)
        {
            if (string.IsNullOrWhiteSpace(roleName))
                throw new ArgumentException("roleName required", nameof(roleName));
            string sql = $"DROP ROLE \"{roleName}\"";
            DataProvider.Instance.ExecuteNonQuery(sql);
            return true;
        }
    }
}
