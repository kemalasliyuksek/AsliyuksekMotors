using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using AsliyuksekMotors.Entities;

namespace AsliyuksekMotors.DataAccess
{

    public class AracRepository
    {
        public int Ekle(Arac arac)
        {
            using (MySqlConnection connection = DbConnection.GetConnection())
            {
                string query = @"INSERT INTO Araclar 
                    (Plaka, MarkaID, ModelID, YapimYili, MotorNo, SasiNo, 
                    Renk, Kilometre, YakitTipi, VitesTipi, DurumID, 
                    AlinmaTarihi, AlisFiyati, SatisFiyati, KiraFiyati, 
                    AracKategoriID, SubeID) 
                VALUES 
                    (@Plaka, @MarkaID, @ModelID, @YapimYili, @MotorNo, @SasiNo, 
                    @Renk, @Kilometre, @YakitTipi, @VitesTipi, @DurumID, 
                    @AlinmaTarihi, @AlisFiyati, @SatisFiyati, @KiraFiyati, 
                    @AracKategoriID, @SubeID);
                SELECT LAST_INSERT_ID();";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Plaka", arac.Plaka);
                    cmd.Parameters.AddWithValue("@MarkaID", arac.MarkaID);
                    cmd.Parameters.AddWithValue("@ModelID", arac.ModelID);
                    cmd.Parameters.AddWithValue("@YapimYili", arac.YapimYili);
                    cmd.Parameters.AddWithValue("@MotorNo", arac.MotorNo);
                    cmd.Parameters.AddWithValue("@SasiNo", arac.SasiNo);
                    cmd.Parameters.AddWithValue("@Renk", arac.Renk);
                    cmd.Parameters.AddWithValue("@Kilometre", arac.Kilometre);
                    cmd.Parameters.AddWithValue("@YakitTipi", arac.YakitTipi);
                    cmd.Parameters.AddWithValue("@VitesTipi", arac.VitesTipi);
                    cmd.Parameters.AddWithValue("@DurumID", arac.DurumID);
                    cmd.Parameters.AddWithValue("@AlinmaTarihi", arac.AlinmaTarihi);
                    cmd.Parameters.AddWithValue("@AlisFiyati", arac.AlisFiyati);
                    cmd.Parameters.AddWithValue("@SatisFiyati", arac.SatisFiyati);
                    cmd.Parameters.AddWithValue("@KiraFiyati", arac.KiraFiyati);
                    cmd.Parameters.AddWithValue("@AracKategoriID", arac.AracKategoriID);
                    cmd.Parameters.AddWithValue("@SubeID", arac.SubeID);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public List<Arac> TumAraclariGetir()
        {
            List<Arac> aracListesi = new List<Arac>();

            using (MySqlConnection connection = DbConnection.GetConnection())
            {
                string query = "SELECT * FROM Araclar";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            aracListesi.Add(new Arac
                            {
                                AracID = Convert.ToInt32(reader["AracID"]),
                                Plaka = reader["Plaka"].ToString(),
                                MarkaID = Convert.ToInt32(reader["MarkaID"]),
                                ModelID = Convert.ToInt32(reader["ModelID"]),
                                YapimYili = Convert.ToInt32(reader["YapimYili"]),
                                MotorNo = reader["MotorNo"].ToString(),
                                SasiNo = reader["SasiNo"].ToString(),
                                Renk = reader["Renk"].ToString(),
                                Kilometre = Convert.ToInt32(reader["Kilometre"]),
                                YakitTipi = reader["YakitTipi"].ToString(),
                                VitesTipi = reader["VitesTipi"].ToString(),
                                DurumID = Convert.ToInt32(reader["DurumID"]),
                                AlinmaTarihi = Convert.ToDateTime(reader["AlinmaTarihi"]),
                                AlisFiyati = Convert.ToDecimal(reader["AlisFiyati"]),
                                SatisFiyati = Convert.ToDecimal(reader["SatisFiyati"]),
                                KiraFiyati = Convert.ToDecimal(reader["KiraFiyati"]),
                                AracKategoriID = Convert.ToInt32(reader["AracKategoriID"]),
                                SubeID = Convert.ToInt32(reader["SubeID"])
                            });
                        }
                    }
                }
            }

            return aracListesi;
        }

        public Arac AracGetirById(int aracId)
        {
            using (MySqlConnection connection = DbConnection.GetConnection())
            {
                string query = "SELECT * FROM Araclar WHERE AracID = @AracID";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@AracID", aracId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Arac
                            {
                                AracID = Convert.ToInt32(reader["AracID"]),
                                Plaka = reader["Plaka"].ToString(),
                                MarkaID = Convert.ToInt32(reader["MarkaID"]),
                                ModelID = Convert.ToInt32(reader["ModelID"]),
                                YapimYili = Convert.ToInt32(reader["YapimYili"]),
                                MotorNo = reader["MotorNo"].ToString(),
                                SasiNo = reader["SasiNo"].ToString(),
                                Renk = reader["Renk"].ToString(),
                                Kilometre = Convert.ToInt32(reader["Kilometre"]),
                                YakitTipi = reader["YakitTipi"].ToString(),
                                VitesTipi = reader["VitesTipi"].ToString(),
                                DurumID = Convert.ToInt32(reader["DurumID"]),
                                AlinmaTarihi = Convert.ToDateTime(reader["AlinmaTarihi"]),
                                AlisFiyati = Convert.ToDecimal(reader["AlisFiyati"]),
                                SatisFiyati = Convert.ToDecimal(reader["SatisFiyati"]),
                                KiraFiyati = Convert.ToDecimal(reader["KiraFiyati"]),
                                AracKategoriID = Convert.ToInt32(reader["AracKategoriID"]),
                                SubeID = Convert.ToInt32(reader["SubeID"])
                            };
                        }
                    }
                }
            }

            return null;
        }

        public bool Guncelle(Arac arac)
        {
            using (MySqlConnection connection = DbConnection.GetConnection())
            {
                string query = @"UPDATE Araclar SET 
                    Plaka = @Plaka, 
                    MarkaID = @MarkaID, 
                    ModelID = @ModelID, 
                    YapimYili = @YapimYili, 
                    MotorNo = @MotorNo, 
                    SasiNo = @SasiNo, 
                    Renk = @Renk, 
                    Kilometre = @Kilometre, 
                    YakitTipi = @YakitTipi, 
                    VitesTipi = @VitesTipi, 
                    DurumID = @DurumID, 
                    AlinmaTarihi = @AlinmaTarihi, 
                    AlisFiyati = @AlisFiyati, 
                    SatisFiyati = @SatisFiyati, 
                    KiraFiyati = @KiraFiyati, 
                    AracKategoriID = @AracKategoriID, 
                    SubeID = @SubeID 
                WHERE AracID = @AracID";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@AracID", arac.AracID);
                    cmd.Parameters.AddWithValue("@Plaka", arac.Plaka);
                    cmd.Parameters.AddWithValue("@MarkaID", arac.MarkaID);
                    cmd.Parameters.AddWithValue("@ModelID", arac.ModelID);
                    cmd.Parameters.AddWithValue("@YapimYili", arac.YapimYili);
                    cmd.Parameters.AddWithValue("@MotorNo", arac.MotorNo);
                    cmd.Parameters.AddWithValue("@SasiNo", arac.SasiNo);
                    cmd.Parameters.AddWithValue("@Renk", arac.Renk);
                    cmd.Parameters.AddWithValue("@Kilometre", arac.Kilometre);
                    cmd.Parameters.AddWithValue("@YakitTipi", arac.YakitTipi);
                    cmd.Parameters.AddWithValue("@VitesTipi", arac.VitesTipi);
                    cmd.Parameters.AddWithValue("@DurumID", arac.DurumID);
                    cmd.Parameters.AddWithValue("@AlinmaTarihi", arac.AlinmaTarihi);
                    cmd.Parameters.AddWithValue("@AlisFiyati", arac.AlisFiyati);
                    cmd.Parameters.AddWithValue("@SatisFiyati", arac.SatisFiyati);
                    cmd.Parameters.AddWithValue("@KiraFiyati", arac.KiraFiyati);
                    cmd.Parameters.AddWithValue("@AracKategoriID", arac.AracKategoriID);
                    cmd.Parameters.AddWithValue("@SubeID", arac.SubeID);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Sil(int aracId)
        {
            using (MySqlConnection connection = DbConnection.GetConnection())
            {
                string query = "DELETE FROM Araclar WHERE AracID = @AracID";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@AracID", aracId);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}