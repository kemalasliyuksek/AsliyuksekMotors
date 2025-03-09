using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using AsliyuksekMotors.Entities;
using System.Security.Cryptography;
using System.Text;
using System.Diagnostics;

namespace AsliyuksekMotors.DataAccess
{
    public class KullaniciRepository
    {
        private string SifreHashle(string sifre)
        {
            try
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(sifre));

                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2"));
                    }
                    string hashedPassword = builder.ToString();
                    Debug.WriteLine($"Şifre hash'lendi: '{sifre}' -> '{hashedPassword}'");
                    return hashedPassword;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Şifre hash'leme hatası: {ex.Message}");
                throw;
            }
        }

        public int Ekle(Kullanici kullanici)
        {
            try
            {
                using (MySqlConnection connection = DbConnection.GetConnection())
                {
                    string query = @"INSERT INTO Kullanicilar 
                        (KullaniciAdi, Sifre, Ad, Soyad, Email, Telefon, 
                        RolID, SubeID, SonGirisTarihi, AktifMi) 
                    VALUES 
                        (@KullaniciAdi, @Sifre, @Ad, @Soyad, @Email, @Telefon, 
                        @RolID, @SubeID, @SonGirisTarihi, @AktifMi);
                    SELECT LAST_INSERT_ID();";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Şifreyi hashle
                        string hashedSifre = SifreHashle(kullanici.Sifre);

                        cmd.Parameters.AddWithValue("@KullaniciAdi", kullanici.KullaniciAdi);
                        cmd.Parameters.AddWithValue("@Sifre", hashedSifre);
                        cmd.Parameters.AddWithValue("@Ad", kullanici.Ad);
                        cmd.Parameters.AddWithValue("@Soyad", kullanici.Soyad);
                        cmd.Parameters.AddWithValue("@Email", kullanici.Email);
                        cmd.Parameters.AddWithValue("@Telefon", kullanici.Telefon);
                        cmd.Parameters.AddWithValue("@RolID", kullanici.RolID);
                        cmd.Parameters.AddWithValue("@SubeID", kullanici.SubeID);
                        cmd.Parameters.AddWithValue("@SonGirisTarihi", kullanici.SonGirisTarihi);
                        cmd.Parameters.AddWithValue("@AktifMi", kullanici.Durum);

                        int result = Convert.ToInt32(cmd.ExecuteScalar());
                        Debug.WriteLine($"Kullanıcı eklendi: ID={result}, KullaniciAdi={kullanici.KullaniciAdi}");
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Kullanıcı ekleme hatası: {ex.Message}");
                throw;
            }
        }

        public Kullanici GirisYap(string kullaniciAdi, string sifre)
        {
            try
            {
                Debug.WriteLine($"GirisYap metodu çağrıldı: KullaniciAdi={kullaniciAdi}");

                using (MySqlConnection connection = DbConnection.GetConnection())
                {
                    // Şifreyi hash'le
                    string hashedSifre = SifreHashle(sifre);

                    // Veritabanında test sorgulama (debug amaçlı)
                    string testQuery = "SELECT COUNT(*) FROM Kullanicilar";
                    using (MySqlCommand testCmd = new MySqlCommand(testQuery, connection))
                    {
                        int count = Convert.ToInt32(testCmd.ExecuteScalar());
                        Debug.WriteLine($"Veritabanındaki toplam kullanıcı sayısı: {count}");
                    }

                    // Şimdi asıl sorguyu yap
                    // Kullanıcı adı ve hashlenmis sifreyi kullanarak kullanıcıyı bul
                    string query = @"SELECT * FROM Kullanicilar 
                                    WHERE KullaniciAdi = @KullaniciAdi 
                                    AND Sifre = @Sifre 
                                    AND AktifMi = 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                        cmd.Parameters.AddWithValue("@Sifre", hashedSifre);

                        Debug.WriteLine($"Şu SQL çalıştırılıyor: {cmd.CommandText} " +
                                      $"Parametreler: KullaniciAdi='{kullaniciAdi}', HashedSifre='{hashedSifre}'");

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var kullanici = new Kullanici
                                {
                                    KullaniciID = Convert.ToInt32(reader["KullaniciID"]),
                                    Ad = reader["Ad"].ToString(),
                                    Soyad = reader["Soyad"].ToString(),
                                    KullaniciAdi = reader["KullaniciAdi"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    Telefon = reader["Telefon"].ToString(),
                                    RolID = Convert.ToInt32(reader["RolID"]),
                                    SubeID = reader["SubeID"] != DBNull.Value ? Convert.ToInt32(reader["SubeID"]) : 0,
                                    SonGirisTarihi = reader["SonGirisTarihi"] != DBNull.Value
                                        ? Convert.ToDateTime(reader["SonGirisTarihi"])
                                        : (DateTime?)null,
                                    Durum = Convert.ToBoolean(reader["AktifMi"])
                                };

                                Debug.WriteLine($"Kullanıcı bulundu: ID={kullanici.KullaniciID}, Ad={kullanici.Ad}, Soyad={kullanici.Soyad}");

                                // Son giriş tarihini güncelleyelim
                                AktifKullaniciGuncelle(kullanici.KullaniciID);

                                return kullanici;
                            }
                            else
                            {
                                Debug.WriteLine("Eşleşen kullanıcı bulunamadı");
                                return null;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"GirisYap metodu hatası: {ex.Message}");
                Debug.WriteLine($"Stack Trace: {ex.StackTrace}");
                throw;
            }
        }

        private void AktifKullaniciGuncelle(int kullaniciId)
        {
            try
            {
                using (MySqlConnection connection = DbConnection.GetConnection())
                {
                    string query = "UPDATE Kullanicilar SET SonGirisTarihi = @SonGirisTarihi WHERE KullaniciID = @KullaniciID";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@SonGirisTarihi", DateTime.Now);
                        cmd.Parameters.AddWithValue("@KullaniciID", kullaniciId);

                        int affectedRows = cmd.ExecuteNonQuery();
                        Debug.WriteLine($"Son giriş tarihi güncellendi: KullaniciID={kullaniciId}, Etkilenen satır={affectedRows}");
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Son giriş tarihi güncelleme hatası: {ex.Message}");
                // Bu hatayı yakalayıp logluyoruz ama fırlatmıyoruz çünkü kritik bir işlem değil
            }
        }

        public List<Kullanici> TumKullanicilarGetir()
        {
            List<Kullanici> kullaniciListesi = new List<Kullanici>();

            try
            {
                using (MySqlConnection connection = DbConnection.GetConnection())
                {
                    string query = "SELECT * FROM Kullanicilar";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                kullaniciListesi.Add(new Kullanici
                                {
                                    KullaniciID = Convert.ToInt32(reader["KullaniciID"]),
                                    Ad = reader["Ad"].ToString(),
                                    Soyad = reader["Soyad"].ToString(),
                                    KullaniciAdi = reader["KullaniciAdi"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    Telefon = reader["Telefon"].ToString(),
                                    RolID = Convert.ToInt32(reader["RolID"]),
                                    SubeID = reader["SubeID"] != DBNull.Value ? Convert.ToInt32(reader["SubeID"]) : 0,
                                    SonGirisTarihi = reader["SonGirisTarihi"] != DBNull.Value
                                        ? Convert.ToDateTime(reader["SonGirisTarihi"])
                                        : (DateTime?)null,
                                    Durum = Convert.ToBoolean(reader["AktifMi"])
                                });
                            }
                        }
                    }
                }

                Debug.WriteLine($"Toplam {kullaniciListesi.Count} kullanıcı listelendi");
                return kullaniciListesi;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Kullanıcı listesi hatası: {ex.Message}");
                throw;
            }
        }

        public Kullanici KullaniciGetirById(int kullaniciId)
        {
            try
            {
                using (MySqlConnection connection = DbConnection.GetConnection())
                {
                    string query = "SELECT * FROM Kullanicilar WHERE KullaniciID = @KullaniciID";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@KullaniciID", kullaniciId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var kullanici = new Kullanici
                                {
                                    KullaniciID = Convert.ToInt32(reader["KullaniciID"]),
                                    Ad = reader["Ad"].ToString(),
                                    Soyad = reader["Soyad"].ToString(),
                                    KullaniciAdi = reader["KullaniciAdi"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    Telefon = reader["Telefon"].ToString(),
                                    RolID = Convert.ToInt32(reader["RolID"]),
                                    SubeID = reader["SubeID"] != DBNull.Value ? Convert.ToInt32(reader["SubeID"]) : 0,
                                    SonGirisTarihi = reader["SonGirisTarihi"] != DBNull.Value
                                        ? Convert.ToDateTime(reader["SonGirisTarihi"])
                                        : (DateTime?)null,
                                    Durum = Convert.ToBoolean(reader["AktifMi"])
                                };

                                Debug.WriteLine($"Kullanıcı bulundu: ID={kullanici.KullaniciID}");
                                return kullanici;
                            }
                        }
                    }
                }

                Debug.WriteLine($"Kullanıcı bulunamadı: ID={kullaniciId}");
                return null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Kullanıcı getirme hatası: {ex.Message}");
                throw;
            }
        }

        public bool Guncelle(Kullanici kullanici)
        {
            try
            {
                using (MySqlConnection connection = DbConnection.GetConnection())
                {
                    string query = @"UPDATE Kullanicilar SET 
                        Ad = @Ad, 
                        Soyad = @Soyad, 
                        KullaniciAdi = @KullaniciAdi, 
                        Email = @Email, 
                        Telefon = @Telefon, 
                        RolID = @RolID, 
                        SubeID = @SubeID, 
                        AktifMi = @AktifMi 
                    WHERE KullaniciID = @KullaniciID";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@KullaniciID", kullanici.KullaniciID);
                        cmd.Parameters.AddWithValue("@Ad", kullanici.Ad);
                        cmd.Parameters.AddWithValue("@Soyad", kullanici.Soyad);
                        cmd.Parameters.AddWithValue("@KullaniciAdi", kullanici.KullaniciAdi);
                        cmd.Parameters.AddWithValue("@Email", kullanici.Email);
                        cmd.Parameters.AddWithValue("@Telefon", kullanici.Telefon);
                        cmd.Parameters.AddWithValue("@RolID", kullanici.RolID);
                        cmd.Parameters.AddWithValue("@SubeID", kullanici.SubeID);
                        cmd.Parameters.AddWithValue("@AktifMi", kullanici.Durum);

                        int affectedRows = cmd.ExecuteNonQuery();
                        Debug.WriteLine($"Kullanıcı güncellendi: ID={kullanici.KullaniciID}, Etkilenen satır={affectedRows}");
                        return affectedRows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Kullanıcı güncelleme hatası: {ex.Message}");
                throw;
            }
        }

        public bool SifreDegistir(int kullaniciId, string eskiSifre, string yeniSifre)
        {
            try
            {
                using (MySqlConnection connection = DbConnection.GetConnection())
                {
                    // Önce eski şifreyi kontrol et
                    string kontrolQuery = "SELECT * FROM Kullanicilar WHERE KullaniciID = @KullaniciID AND Sifre = @EskiSifre";

                    using (MySqlCommand kontrolCmd = new MySqlCommand(kontrolQuery, connection))
                    {
                        kontrolCmd.Parameters.AddWithValue("@KullaniciID", kullaniciId);
                        kontrolCmd.Parameters.AddWithValue("@EskiSifre", SifreHashle(eskiSifre));

                        using (MySqlDataReader reader = kontrolCmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                // Eski şifre yanlış
                                Debug.WriteLine($"Şifre değiştirme başarısız: Eski şifre yanlış, KullaniciID={kullaniciId}");
                                return false;
                            }
                        }
                    }

                    // Yeni şifreyi hashleyip güncelle
                    string guncelleQuery = "UPDATE Kullanicilar SET Sifre = @YeniSifre WHERE KullaniciID = @KullaniciID";

                    using (MySqlCommand cmd = new MySqlCommand(guncelleQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@KullaniciID", kullaniciId);
                        cmd.Parameters.AddWithValue("@YeniSifre", SifreHashle(yeniSifre));

                        int affectedRows = cmd.ExecuteNonQuery();
                        Debug.WriteLine($"Şifre değiştirildi: KullaniciID={kullaniciId}, Etkilenen satır={affectedRows}");
                        return affectedRows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Şifre değiştirme hatası: {ex.Message}");
                throw;
            }
        }

        public bool Sil(int kullaniciId)
        {
            try
            {
                using (MySqlConnection connection = DbConnection.GetConnection())
                {
                    string query = "DELETE FROM Kullanicilar WHERE KullaniciID = @KullaniciID";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@KullaniciID", kullaniciId);

                        int affectedRows = cmd.ExecuteNonQuery();
                        Debug.WriteLine($"Kullanıcı silindi: KullaniciID={kullaniciId}, Etkilenen satır={affectedRows}");
                        return affectedRows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Kullanıcı silme hatası: {ex.Message}");
                throw;
            }
        }
    }
}