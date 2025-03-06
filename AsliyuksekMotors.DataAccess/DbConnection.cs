using System;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace AsliyuksekMotors.DataAccess
{

    public class DbConnection
    {
        private static string connectionString;

        static DbConnection()
        {
            connectionString = ConfigurationManager.ConnectionStrings["AsliyuksekMotorsDB"].ConnectionString;
        }

        public static MySqlConnection GetConnection()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                // TODO: Loglama mekanizması eklenecek
                throw new Exception("Veritabanı bağlantısı kurulamadı", ex);
            }
        }

        public static void CloseConnection(MySqlConnection connection)
        {
            if (connection != null)
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}