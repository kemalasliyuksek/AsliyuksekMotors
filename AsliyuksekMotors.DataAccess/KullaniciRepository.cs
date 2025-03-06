using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using AsliyuksekMotors.Entities;
using System.Security.Cryptography;
using System.Text;

namespace AsliyuksekMotors.DataAccess
{
    public class KullaniciRepository
    {
        private string SifreHashle(string sifre)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(sifre));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public int Ekle(Kullanici kullanici)
        {
            using (MySqlConnection connection = DbConnection.GetConnection())
            {
                string query = @"INSERT INTO Kullanicilar 
                    (Ad, Soyad, KullaniciAdi, Sifre, Email, Telefon, 
                    RolID, SubeID, SonGirisTarihi, Durum) 
                VALUES 
                    (@Ad, @Soyad, @KullaniciAdi, @Sifre, @Email, @Telefon, 
                    @RolID, @SubeID, @SonGirisTarihi, @Durum);
                SELECT LAST_INSERT_ID();";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Şifreyi hashle
                    string hashedSifre = SifreHashle(kullanici.Sifre);

                    cmd.Parameters.AddWithValue("@Ad", kullanici.Ad);
                    cmd.Parameters.AddWithValue("@Soyad", kullanici.Soyad);
                    cmd.Parameters.AddWithValue("@KullaniciAdi", kullanici.KullaniciAdi);
                    cmd.Parameters.AddWithValue("@Sifre", hashedSifre);
                    cmd.Parameters.AddWithValue("@Email", kullanici.Email);
                    cmd.Parameters.AddWithValue("@Telefon", kullanici.Telefon);
                    cmd.Parameters.AddWithValue("@RolID", kullanici.RolID);
                    cmd.Parameters.AddWithValue("@SubeID", kullanici.SubeID);
                    cmd.Parameters.AddWithValue("@SonGirisTarihi", kullanici.SonGirisTarihi);
                    cmd.Parameters.AddWithValue("@Durum", kullanici.Durum);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public Kullanici GirisYap(string kullaniciAdi, string sifre)
        {
            using (MySqlConnection connection = DbConnection.GetConnection())
            {
                string hashedSifre = SifreHashle(sifre);
                string query = "SELECT * FROM Kullanicilar WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre AND Durum = true";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                    cmd.Parameters.AddWithValue("@Sifre", hashedSifre);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Son giriş tarihini güncelle
                            AktifKullaniciGuncelle(Convert.ToInt32(reader["KullaniciID"]));

                            return new Kullanici
                            {
                                KullaniciID = Convert.ToInt32(reader["KullaniciID"]),
                                Ad = reader["Ad"].ToString(),
                                Soyad = reader["Soyad"].ToString(),
                                KullaniciAdi = reader["KullaniciAdi"].ToString(),
                                Email = reader["Email"].ToString(),
                                Telefon = reader["Telefon"].ToString(),
                                RolID = Convert.ToInt32(reader["RolID"]),
                                SubeID = Convert.ToInt32(reader["SubeID"]),
                                SonGirisTarihi = reader["SonGirisTarihi"] != DBNull.Value
                                    ? Convert.ToDateTime(reader["SonGirisTarihi"])
                                    : (DateTime?)null,
                                Durum = Convert.ToBoolean(reader["Durum"])
                            };
                        }
                    }
                }
            }
            return null;
        }

        private void AktifKullaniciGuncelle(int kullaniciId)
        {
            using (MySqlConnection connection = DbConnection.GetConnection())
            {
                string query = "UPDATE Kullanicilar SET SonGirisTarihi = @SonGirisTarihi WHERE KullaniciID = @KullaniciID";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@SonGirisTarihi", DateTime.Now);
                    cmd.Parameters.AddWithValue("@KullaniciID", kullaniciId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Kullanici> TumKullanicilarGetir()
        {
            List<Kullanici> kullaniciListesi = new List<Kullanici>();

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
                                SubeID = Convert.ToInt32(reader["SubeID"]),
                                SonGirisTarihi = reader["SonGirisTarihi"] != DBNull.Value
                                    ? Convert.ToDateTime(reader["SonGirisTarihi"])
                                    : (DateTime?)null,
                                Durum = Convert.ToBoolean(reader["Durum"])
                            });
                        }
                    }
                }
            }

            return kullaniciListesi;
        }

        public Kullanici KullaniciGetirById(int kullaniciId)
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
                            return new Kullanici
                            {
                                KullaniciID = Convert.ToInt32(reader["KullaniciID"]),
                                Ad = reader["Ad"].ToString(),
                                Soyad = reader["Soyad"].ToString(),
                                KullaniciAdi = reader["KullaniciAdi"].ToString(),
                                Email = reader["Email"].ToString(),
                                Telefon = reader["Telefon"].ToString(),
                                RolID = Convert.ToInt32(reader["RolID"]),
                                SubeID = Convert.ToInt32(reader["SubeID"]),
                                SonGirisTarihi = reader["SonGirisTarihi"] != DBNull.Value
                                    ? Convert.ToDateTime(reader["SonGirisTarihi"])
                                    : (DateTime?)null,
                                Durum = Convert.ToBoolean(reader["Durum"])
                            };
                        }
                    }
                }
            }

            return null;
        }

        public bool Guncelle(Kullanici kullanici)
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
                    Durum = @Durum 
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
                    cmd.Parameters.AddWithValue("@Durum", kullanici.Durum);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool SifreDegistir(int kullaniciId, string eskiSifre, string yeniSifre)
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

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Sil(int kullaniciId)
        {
            using (MySqlConnection connection = DbConnection.GetConnection())
            {
                string query = "DELETE FROM Kullanicilar WHERE KullaniciID = @KullaniciID";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@KullaniciID", kullaniciId);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}