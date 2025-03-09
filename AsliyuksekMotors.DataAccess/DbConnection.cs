using System;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace AsliyuksekMotors.DataAccess
{
    public class DbConnection
    {
        private static string connectionString;

        static DbConnection()
        {
            try
            {
                connectionString = ConfigurationManager.ConnectionStrings["AsliyuksekMotorsDB"].ConnectionString;
                Debug.WriteLine($"Bağlantı stringi başarıyla alındı: {MaskConnectionString(connectionString)}");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Bağlantı stringi alınırken hata: {ex.Message}");
                throw new Exception("Veritabanı bağlantı stringi okunamadı. Lütfen app.config dosyasını kontrol edin.", ex);
            }
        }

        public static MySqlConnection GetConnection()
        {
            try
            {
                Debug.WriteLine("Veritabanı bağlantısı oluşturuluyor...");
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                Debug.WriteLine("Veritabanı bağlantısı başarıyla açıldı.");
                return connection;
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine($"MySQL Bağlantı hatası: {ex.Message}, Hata kodu: {ex.Number}");
                switch (ex.Number)
                {
                    case 0:
                        throw new Exception("Sunucuya bağlanılamadı. Sunucunun çalıştığından emin olun.", ex);
                    case 1042:
                        throw new Exception("Sunucu bulunamadı veya erişilemedi. Host adını kontrol edin.", ex);
                    case 1044:
                        throw new Exception("Veritabanına erişim reddedildi. Veritabanı adını kontrol edin.", ex);
                    case 1045:
                        throw new Exception("Kullanıcı adı veya şifre geçersiz.", ex);
                    default:
                        throw new Exception("Veritabanı bağlantısı kurulamadı.", ex);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Genel bağlantı hatası: {ex.Message}");
                throw new Exception("Veritabanı bağlantısı kurulurken beklenmeyen bir hata oluştu.", ex);
            }
        }

        public static void CloseConnection(MySqlConnection connection)
        {
            if (connection != null)
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                    Debug.WriteLine("Veritabanı bağlantısı kapatıldı.");
                }
            }
        }

        // Bağlantı stringindeki şifreyi maskeleyerek güvenli şekilde loglama
        private static string MaskConnectionString(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString)) return connectionString;

            // Şifre alanını bul ve maskele
            string maskedConnectionString = connectionString;
            int pwdIndex = maskedConnectionString.IndexOf("Pwd=");
            if (pwdIndex > 0)
            {
                int nextSemicolonIndex = maskedConnectionString.IndexOf(';', pwdIndex);
                if (nextSemicolonIndex > 0)
                {
                    maskedConnectionString = maskedConnectionString.Substring(0, pwdIndex) + "Pwd=********" +
                                           maskedConnectionString.Substring(nextSemicolonIndex);
                }
                else
                {
                    maskedConnectionString = maskedConnectionString.Substring(0, pwdIndex) + "Pwd=********";
                }
            }
            return maskedConnectionString;
        }
    }
}