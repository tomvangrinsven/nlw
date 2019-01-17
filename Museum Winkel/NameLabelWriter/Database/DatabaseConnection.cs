using System;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace NameLabelWriter
{
    class DatabaseConnection
    {

        private const string connectionString =
            "server=127.0.0.1;uid=root;pwd=PBAWovST8!;database=museumwinkel;";

        public static MySqlConnection Connection
        {
            get
            {
                var connection = new MySqlConnection(connectionString);
                try
                {
                    connection.Open();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                return connection;
            }
        }
    }
}