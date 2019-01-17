using System;
using System.Data.SqlClient;

namespace NameLabelWriter
{
    class DatabaseConnection
    {

        private const string connectionString =
        "Server=DESKTOP-MDRT003;Database=museumwinkel;Trusted_Connection=True;";

        public static SqlConnection Connection
        {
            get
            {
                var connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                }
                catch (Exception)
                {
                    throw new Exception("No connection could be made");
                }
                return connection;
            }
        }
    }
}