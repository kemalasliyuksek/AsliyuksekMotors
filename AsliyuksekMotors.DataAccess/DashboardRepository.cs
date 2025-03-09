using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace AsliyuksekMotors.DataAccess
{
    public class DashboardRepository
    {
        #region Kiralama İstatistikleri

        public int GetAktifKiralamaSayisi()
        {
            int count = 0;
            try
            {
                using (MySqlConnection connection = DbConnection.GetConnection())
                {
                    string query = @"SELECT COUNT(*) FROM Kiralamalar 
                                    WHERE BitisTarihi >= CURDATE() 
                                    AND TeslimTarihi IS NULL";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        count = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Aktif kiralama sayısı çekilirken hata: {ex.Message}");
            }
            return count;
        }

        public int GetBugunDonecekKiralamaSayisi()
        {
            int count = 0;
            try
            {
                using (MySqlConnection connection = DbConnection.GetConnection())
                {
                    string query = @"SELECT COUNT(*) FROM Kiralamalar 
                                    WHERE DATE(BitisTarihi) = CURDATE() 
                                    AND TeslimTarihi IS NULL";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        count = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Bugün dönecek kiralama sayısı çekilirken hata: {ex.Message}");
            }
            return count;
        }

        public int GetGecikmisKiralamaSayisi()
        {
            int count = 0;
            try
            {
                using (MySqlConnection connection = DbConnection.GetConnection())
                {
                    string query = @"SELECT COUNT(*) FROM Kiralamalar 
                                    WHERE BitisTarihi < CURDATE() 
                                    AND TeslimTarihi IS NULL";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        count = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Gecikmiş kiralama sayısı çekilirken hata: {ex.Message}");
            }
            return count;
        }

        #endregion

        #region Araç İstatistikleri

        public int GetMüsaitAracSayisi()
        {
            int count = 0;
            try
            {
                using (MySqlConnection connection = DbConnection.GetConnection())
                {
                    // DurumID'si 1 olan araçlar müsait kabul edilecek (veritabanı yapısına göre değişebilir)
                    string query = @"SELECT COUNT(*) FROM Araclar WHERE DurumID = 1 AND AktifMi = 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        count = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Müsait araç sayısı çekilirken hata: {ex.Message}");
            }
            return count;
        }

        public int GetKiralanmisAracSayisi()
        {
            int count = 0;
            try
            {
                using (MySqlConnection connection = DbConnection.GetConnection())
                {
                    // DurumID'si 2 olan araçlar kiralanmış kabul edilecek (veritabanı yapısına göre değişebilir)
                    string query = @"SELECT COUNT(*) FROM Araclar WHERE DurumID = 2 AND AktifMi = 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        count = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Kiralanmış araç sayısı çekilirken hata: {ex.Message}");
            }
            return count;
        }

        public int GetBakimdaAracSayisi()
        {
            int count = 0;
            try
            {
                using (MySqlConnection connection = DbConnection.GetConnection())
                {
                    // DurumID'si 3 olan araçlar bakımda kabul edilecek (veritabanı yapısına göre değişebilir)
                    string query = @"SELECT COUNT(*) FROM Araclar WHERE DurumID = 3 AND AktifMi = 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        count = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Bakımda araç sayısı çekilirken hata: {ex.Message}");
            }
            return count;
        }

        #endregion

        #region Bugünkü İşlemler

        public int GetBugunYeniKiralamaSayisi()
        {
            int count = 0;
            try
            {
                using (MySqlConnection connection = DbConnection.GetConnection())
                {
                    string query = @"SELECT COUNT(*) FROM Kiralamalar 
                                    WHERE DATE(EklenmeTarihi) = CURDATE()";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        count = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Bugünkü yeni kiralama sayısı çekilirken hata: {ex.Message}");
            }
            return count;
        }

        public int GetBugunIadeSayisi()
        {
            int count = 0;
            try
            {
                using (MySqlConnection connection = DbConnection.GetConnection())
                {
                    string query = @"SELECT COUNT(*) FROM Kiralamalar 
                                    WHERE DATE(TeslimTarihi) = CURDATE()";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        count = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Bugünkü iade sayısı çekilirken hata: {ex.Message}");
            }
            return count;
        }

        public int GetBugunSatisSayisi()
        {
            int count = 0;
            try
            {
                using (MySqlConnection connection = DbConnection.GetConnection())
                {
                    string query = @"SELECT COUNT(*) FROM Satislar 
                                    WHERE DATE(SatisTarihi) = CURDATE()";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        count = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Bugünkü satış sayısı çekilirken hata: {ex.Message}");
            }
            return count;
        }

        #endregion

        #region Finans Durumu

        public decimal GetBugunToplamGelir()
        {
            decimal total = 0;
            try
            {
                using (MySqlConnection connection = DbConnection.GetConnection())
                {
                    string query = @"SELECT COALESCE(SUM(Tutar), 0) FROM Odemeler 
                                    WHERE DATE(OdemeTarihi) = CURDATE() 
                                    AND Tutar > 0";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        total = Convert.ToDecimal(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Bugünkü toplam gelir çekilirken hata: {ex.Message}");
            }
            return total;
        }

        public decimal GetBugunToplamGider()
        {
            decimal total = 0;
            try
            {
                using (MySqlConnection connection = DbConnection.GetConnection())
                {
                    string query = @"SELECT COALESCE(SUM(ABS(Tutar)), 0) FROM Odemeler 
                                    WHERE DATE(OdemeTarihi) = CURDATE() 
                                    AND Tutar < 0";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        total = Convert.ToDecimal(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Bugünkü toplam gider çekilirken hata: {ex.Message}");
            }
            return total;
        }

        #endregion
    }
}