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

        // ================================================================
        // ĐĂNG NHẬP
        // Kết nối bằng chính tài khoản user → Oracle tự enforce quyền
        // Sau đó cập nhật connectionString về ADMIN để các query khác dùng
        // ================================================================
        public bool Login(string username, string password)
        {
            string connStr = $"User Id={username};Password={password};Data Source=localhost:1521/XEPDB1";

            try
            {
                using (OracleConnection conn = new OracleConnection(connStr))
                {
                    conn.Open();
                    // Sau khi xác thực thành công, trở về connection ADMIN
                    // để các thao tác quản trị (phân hệ 1) vẫn hoạt động bình thường
                    DataProvider.Instance.UpdateConnectionString(
                        "Data Source=localhost:1521/XEPDB1;User ID=ADMIN;Password=123");
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

        // ================================================================
        // LẤY VAI TRÒ CỦA USER ĐỂ ĐIỀU HƯỚNG FORM
        // Dùng connection ADMIN để đọc bảng NHANVIEN
        // Trả về: "Kỹ thuật viên", "Bác sĩ", "Điều phối viên",
        //         "Bệnh nhân", hoặc "ADMIN" nếu không tìm thấy
        // ================================================================
        public string GetVaiTro(string username)
        {
            username = username.ToUpper();

            // Kiểm tra có phải ADMIN/DBA không (không có trong NHANVIEN hay BENHNHAN)
            if (username == "ADMIN" || username == "SYS" || username == "SYSTEM")
                return "ADMIN";

            // Kiểm tra trong bảng NHANVIEN
            string queryNV = $"SELECT VAITRO FROM ADMIN.NHANVIEN WHERE MANV = '{username}'";
            try
            {
                DataTable dt = DataProvider.Instance.ExecuteQuery(queryNV);
                if (dt.Rows.Count > 0)
                    return dt.Rows[0]["VAITRO"]?.ToString();
            }
            catch { }

            // Kiểm tra trong bảng BENHNHAN (username dạng BN***)
            if (username.StartsWith("BN"))
                return "Bệnh nhân";

            return "ADMIN"; // fallback
        }

        // ================================================================
        // CÁC HÀM PHỤC VỤ PHÂN HỆ 1 (giữ nguyên)
        // ================================================================
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
                list.Add(new UserDTO
                {
                    Username = row["USERNAME"]?.ToString(),
                    Status = row["ACCOUNT_STATUS"]?.ToString(),
                    CreatedDate = row["CREATED"]?.ToString()
                });
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
                list.Add(new UserDTO
                {
                    Username = row["USERNAME"]?.ToString(),
                    Status = row["ACCOUNT_STATUS"]?.ToString(),
                    CreatedDate = row["CREATED"]?.ToString()
                });
            }
            return list;
        }

        public List<RoleDTO> GetAllRolesDto()
        {
            DataTable dt = GetAllRoles();
            var list = new List<RoleDTO>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new RoleDTO
                {
                    RoleName = row["ROLENAME"]?.ToString()
                });
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
            if (!Regex.IsMatch(username, @"^[A-Za-z0-9_]+$"))
                throw new ArgumentException("Invalid username.");
            DataProvider.Instance.ExecuteNonQuery($"CREATE USER \"{username}\" IDENTIFIED BY \"{password}\"");
            return true;
        }

        public bool DropUser(string username)
        {
            DataProvider.Instance.ExecuteNonQuery($"DROP USER \"{username}\" CASCADE");
            return true;
        }

        public bool AlterUserPassword(string username, string newPassword)
        {
            DataProvider.Instance.ExecuteNonQuery($"ALTER USER \"{username}\" IDENTIFIED BY \"{newPassword}\"");
            return true;
        }

        public bool AlterRolePassword(string roleName, string newPassword)
        {
            if (!Regex.IsMatch(roleName, @"^[A-Za-z0-9_]+$"))
                throw new ArgumentException("Invalid role name.");
            DataProvider.Instance.ExecuteNonQuery($"ALTER ROLE \"{roleName}\" IDENTIFIED BY \"{newPassword}\"");
            return true;
        }

        public bool LockUser(string username)
        {
            DataProvider.Instance.ExecuteNonQuery($"ALTER USER \"{username}\" ACCOUNT LOCK");
            return true;
        }

        public bool UnlockUser(string username)
        {
            DataProvider.Instance.ExecuteNonQuery($"ALTER USER \"{username}\" ACCOUNT UNLOCK");
            return true;
        }

        public bool CreateRole(string roleName, string password = null)
        {
            if (!Regex.IsMatch(roleName, @"^[A-Za-z0-9_]+$"))
                throw new ArgumentException("Invalid role name.");
            string sql = password == null
                ? $"CREATE ROLE \"{roleName}\""
                : $"CREATE ROLE \"{roleName}\" IDENTIFIED BY \"{password}\"";
            DataProvider.Instance.ExecuteNonQuery(sql);
            return true;
        }

        public bool DropRole(string roleName)
        {
            DataProvider.Instance.ExecuteNonQuery($"DROP ROLE \"{roleName}\"");
            return true;
        }
    }
}
