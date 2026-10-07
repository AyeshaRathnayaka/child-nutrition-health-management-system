using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace child_clinic.Database
{
    internal class DatabaseConnection
    {
        private static readonly string Server = "localhost";
        private static readonly string Database = "child_clinic";
        private static readonly string Username = "root";
        private static readonly string Password = "";  

        private static readonly string ConnectionString = $"Server={Server};Database={Database};Uid={Username};Pwd={Password};";

        // Connection test 
        public static bool TestConnection()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        // Connection object return 
        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection(ConnectionString);
            conn.Open();
            return conn;
        }
    }
}
