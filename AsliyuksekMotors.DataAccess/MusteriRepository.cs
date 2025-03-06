using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using AsliyuksekMotors.Entities;

namespace AsliyuksekMotors.DataAccess
{
    public class MusteriRepository
    {
        public int Ekle(Musteri musteri)
        {
            using (MySqlConnection connection = DbConnection.GetConnection())
            {
                string query = @"INSERT INTO Musteriler 
                    (Ad, Soyad, TC, DogumTarihi, EhliyetNo, EhliyetSinifi, 
                    EhliyetTarihi, TelefonNo, Email, Adres, KayitTarihi, 
                    MusaitlikDurumu, MusteriTipi) 
                VALUES 
                    (@Ad, @Soyad, @TC, @DogumTarihi, @EhliyetNo, @EhliyetSinifi, 
                    @EhliyetTarihi, @TelefonNo, @Email, @Adres, @KayitTarihi, 
                    @MusaitlikDurumu, @MusteriTipi);
                SELECT LAST_INSERT_ID();";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Ad", musteri.Ad);
                    cmd.Parameters.AddWithValue("@Soyad", musteri.Soyad);
                    cmd.Parameters.AddWithValue("@TC", musteri.TC);
                    cmd.Parameters.AddWithValue("@DogumTarihi", musteri.DogumTarihi);
                    cmd.Parameters.AddWithValue("@EhliyetNo", musteri.EhliyetNo);
                    cmd.Parameters.AddWithValue("@EhliyetSinifi", musteri.EhliyetSinifi);
                    cmd.Parameters.AddWithValue("@EhliyetTarihi", musteri.EhliyetTarihi);
                    cmd.Parameters.AddWithValue("@TelefonNo", musteri.TelefonNo);
                    cmd.Parameters.AddWithValue("@Email", musteri.Email);
                    cmd.Parameters.AddWithValue("@Adres", musteri.Adres);
                    cmd.Parameters.AddWithValue("@KayitTarihi", musteri.KayitTarihi);
                    cmd.Parameters.AddWithValue("@MusaitlikDurumu", musteri.MusaitlikDurumu);
                    cmd.Parameters.AddWithValue("@MusteriTipi", musteri.MusteriTipi);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public List<Musteri> TumMusterileriGetir()
        {
            List<Musteri> musteriListesi = new List<Musteri>();

            using (MySqlConnection connection = DbConnection.GetConnection())
            {
                string query = "SELECT * FROM Musteriler";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            musteriListesi.Add(new Musteri
                            {
                                MusteriID = Convert.ToInt32(reader["MusteriID"]),
                                Ad = reader["Ad"].ToString(),
                                Soyad = reader["Soyad"].ToString(),
                                TC = reader["TC"].ToString(),
                                DogumTarihi = Convert.ToDateTime(reader["DogumTarihi"]),
                                EhliyetNo = reader["EhliyetNo"].ToString(),
                                EhliyetSinifi = reader["EhliyetSinifi"].ToString(),
                                EhliyetTarihi = Convert.ToDateTime(reader["EhliyetTarihi"]),
                                TelefonNo = reader["TelefonNo"].ToString(),
                                Email = reader["Email"].ToString(),
                                Adres = reader["Adres"].ToString(),
                                KayitTarihi = Convert.ToDateTime(reader["KayitTarihi"]),
                                MusaitlikDurumu = Convert.ToBoolean(reader["MusaitlikDurumu"]),
                                MusteriTipi = reader["MusteriTipi"].ToString()
                            });
                        }
                    }
                }
            }

            return musteriListesi;
        }

        public Musteri MusteriGetirById(int musteriId)
        {
            using (MySqlConnection connection = DbConnection.GetConnection())
            {
                string query = "SELECT * FROM Musteriler WHERE MusteriID = @MusteriID";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MusteriID", musteriId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Musteri
                            {
                                MusteriID = Convert.ToInt32(reader["MusteriID"]),
                                Ad = reader["Ad"].ToString(),
                                Soyad = reader["Soyad"].ToString(),
                                TC = reader["TC"].ToString(),
                                DogumTarihi = Convert.ToDateTime(reader["DogumTarihi"]),
                                EhliyetNo = reader["EhliyetNo"].ToString(),
                                EhliyetSinifi = reader["EhliyetSinifi"].ToString(),
                                EhliyetTarihi = Convert.ToDateTime(reader["EhliyetTarihi"]),
                                TelefonNo = reader["TelefonNo"].ToString(),
                                Email = reader["Email"].ToString(),
                                Adres = reader["Adres"].ToString(),
                                KayitTarihi = Convert.ToDateTime(reader["KayitTarihi"]),
                                MusaitlikDurumu = Convert.ToBoolean(reader["MusaitlikDurumu"]),
                                MusteriTipi = reader["MusteriTipi"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }

        public bool Guncelle(Musteri musteri)
        {
            using (MySqlConnection connection = DbConnection.GetConnection())
            {
                string query = @"UPDATE Musteriler SET 
                    Ad = @Ad, 
                    Soyad = @Soyad, 
                    TC = @TC, 
                    DogumTarihi = @DogumTarihi, 
                    EhliyetNo = @EhliyetNo, 
                    EhliyetSinifi = @EhliyetSinifi, 
                    EhliyetTarihi = @EhliyetTarihi, 
                    TelefonNo = @TelefonNo, 
                    Email = @Email, 
                    Adres = @Adres, 
                    KayitTarihi = @KayitTarihi, 
                    MusaitlikDurumu = @MusaitlikDurumu, 
                    MusteriTipi = @MusteriTipi 
                WHERE MusteriID = @MusteriID";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MusteriID", musteri.MusteriID);
                    cmd.Parameters.AddWithValue("@Ad", musteri.Ad);
                    cmd.Parameters.AddWithValue("@Soyad", musteri.Soyad);
                    cmd.Parameters.AddWithValue("@TC", musteri.TC);
                    cmd.Parameters.AddWithValue("@DogumTarihi", musteri.DogumTarihi);
                    cmd.Parameters.AddWithValue("@EhliyetNo", musteri.EhliyetNo);
                    cmd.Parameters.AddWithValue("@EhliyetSinifi", musteri.EhliyetSinifi);
                    cmd.Parameters.AddWithValue("@EhliyetTarihi", musteri.EhliyetTarihi);
                    cmd.Parameters.AddWithValue("@TelefonNo", musteri.TelefonNo);
                    cmd.Parameters.AddWithValue("@Email", musteri.Email);
                    cmd.Parameters.AddWithValue("@Adres", musteri.Adres);
                    cmd.Parameters.AddWithValue("@KayitTarihi", musteri.KayitTarihi);
                    cmd.Parameters.AddWithValue("@MusaitlikDurumu", musteri.MusaitlikDurumu);
                    cmd.Parameters.AddWithValue("@MusteriTipi", musteri.MusteriTipi);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Sil(int musteriId)
        {
            using (MySqlConnection connection = DbConnection.GetConnection())
            {
                string query = "DELETE FROM Musteriler WHERE MusteriID = @MusteriID";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MusteriID", musteriId);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public Musteri MusteriGetirByTC(string tcNo)
        {
            using (MySqlConnection connection = DbConnection.GetConnection())
            {
                string query = "SELECT * FROM Musteriler WHERE TC = @TC";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@TC", tcNo);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Musteri
                            {
                                MusteriID = Convert.ToInt32(reader["MusteriID"]),
                                Ad = reader["Ad"].ToString(),
                                Soyad = reader["Soyad"].ToString(),
                                TC = reader["TC"].ToString(),
                                DogumTarihi = Convert.ToDateTime(reader["DogumTarihi"]),
                                EhliyetNo = reader["EhliyetNo"].ToString(),
                                EhliyetSinifi = reader["EhliyetSinifi"].ToString(),
                                EhliyetTarihi = Convert.ToDateTime(reader["EhliyetTarihi"]),
                                TelefonNo = reader["TelefonNo"].ToString(),
                                Email = reader["Email"].ToString(),
                                Adres = reader["Adres"].ToString(),
                                KayitTarihi = Convert.ToDateTime(reader["KayitTarihi"]),
                                MusaitlikDurumu = Convert.ToBoolean(reader["MusaitlikDurumu"]),
                                MusteriTipi = reader["MusteriTipi"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}