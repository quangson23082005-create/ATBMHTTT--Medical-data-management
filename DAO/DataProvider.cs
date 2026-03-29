using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace QLBV.DAO
{
    public class DataProvider
    {
        // Tạo thực thể duy nhất (với cơ chế Thread-safe đơn giản)
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }
            private set { instance = value; }
        }

        // Đặt Constructor là private để không cho phép "new DataProvider()" từ ngoài
        private DataProvider() { }

        private string connectionSTR = "Data Source=localhost:1521/XEPDB1;User ID=ADMIN;Password=123";

        public DataTable ExecuteQuery(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                throw new ArgumentException("Query must not be null or empty.", nameof(query));

            query = query.Trim();
            while (query.EndsWith(";"))
            {
                query = query.Substring(0, query.Length - 1).TrimEnd();
            }

            try
            {
                using (var connection = new OracleConnection(connectionSTR))
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = query;
                    connection.Open();
                    using (var adapter = new OracleDataAdapter(command))
                    {
                        var data = new DataTable();
                        adapter.Fill(data);
                        return data;
                    }
                }
            }
            catch (OracleException ex)
            {
                throw new InvalidOperationException($"Database error while executing query: \"{query}\"", ex);
            }
        }
        public int ExecuteNonQuery(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                throw new ArgumentException("Query must not be null or empty.", nameof(query));

            query = query.Trim();
            while (query.EndsWith(";"))
            {
                query = query.Substring(0, query.Length - 1).TrimEnd();
            }

            int data = 0;
            try
            {
                using (var connection = new OracleConnection(connectionSTR))
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = query;
                    connection.Open();
                    data = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (OracleException ex)
            {
                throw new InvalidOperationException($"Database error while executing non-query: \"{query}\"", ex);
            }
            return data;
        }

        // Trả về ô đầu tiên của dòng đầu tiên (Dùng cho các lệnh COUNT, MAX, MIN...)
        public object ExecuteScalar(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                throw new ArgumentException("Query must not be null or empty.", nameof(query));

            query = query.Trim();
            while (query.EndsWith(";"))
            {
                query = query.Substring(0, query.Length - 1).TrimEnd();
            }

            object data = null;
            try
            {
                using (var connection = new OracleConnection(connectionSTR))
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = query;
                    connection.Open();
                    data = command.ExecuteScalar();
                    connection.Close();
                }
            }
            catch (OracleException ex)
            {
                throw new InvalidOperationException($"Database error while executing scalar: \"{query}\"", ex);
            }
            return data;
        }

        public void UpdateConnectionString(string newConnStr)
        {
            this.connectionSTR = newConnStr;
        }
    }
}