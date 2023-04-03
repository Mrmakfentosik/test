using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace KK2.Model
{
    class DB
    {
        private static MySqlConnection dbConnection;
        public static MySqlConnection GetDbConnection
        {
            get
            {
                return dbConnection;
            }
        }
        public static void ConnectOpen()
        {
            string connStr = "server=localhost;user=root;database=ufa_haus;password=root;";
            dbConnection = new MySqlConnection(connStr);
            dbConnection.Open();
        }
        public static void ConnectClose()
        {
            dbConnection.Close();
        }
    }
}
