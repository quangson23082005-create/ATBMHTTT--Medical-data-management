using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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


    }
}
