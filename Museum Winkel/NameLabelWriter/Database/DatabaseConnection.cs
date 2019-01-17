using System;
using System.Data.SqlClient;

namespace NameLabelWriter
{
    class DatabaseConnection
    {

        private const string connectionString =
            //"Server=DESKTOP-MDRT003;Database=museumwinkel;Trusted_Connection=True;";
            //"Server=gt-hp-01;Database=museumwinkel;Uid=root;Pwd=PBAWovST8!;Trusted_Connection=True";
            "server=127.0.0.1;uid=root;pwd=PBAWovST8!;database=museumwinkel;Trusted_Connection=True;";

        public static SqlConnection Connection
        {
            get
            {
                var connection = new SqlConnection(connectionString);
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