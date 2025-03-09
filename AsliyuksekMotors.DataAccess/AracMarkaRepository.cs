using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using AsliyuksekMotors.Entities;

namespace AsliyuksekMotors.DataAccess
{
    // Araç Marka Repository
    public class AracMarkaRepository
    {
        public List<AracMarka> TumMarkalariGetir()
        {
            List<AracMarka> markaListesi = new List<AracMarka>();

            using (MySqlConnection connection = DbConnection.GetConnection())
            {
                string query = "SELECT * FROM AracMarkalari";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            markaListesi.Add(new AracMarka
                            {
                                MarkaID = Convert.ToInt32(reader["MarkaID"]),
                                MarkaAdi = reader["MarkaAdi"].ToString(),
                                Ulke = reader["Aciklama"].ToString()
                            });
                        }
                    }
                }
            }

            return markaListesi;
        }

        public AracMarka MarkaGetirById(int markaId)
        {
            using (MySqlConnection connection = DbConnection.GetConnection())
            {
                string query = "SELECT * FROM AracMarkalari WHERE MarkaID = @MarkaID";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MarkaID", markaId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new AracMarka
                            {
                                MarkaID = Convert.ToInt32(reader["MarkaID"]),
                                MarkaAdi = reader["MarkaAdi"].ToString(),
                                Ulke = reader["Aciklama"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }
    }

    // Araç Model Repository
    public class AracModelRepository
    {
        public List<AracModel> TumModelleriGetir()
        {
            List<AracModel> modelListesi = new List<AracModel>();

            using (MySqlConnection connection = DbConnection.GetConnection())
            {
                string query = "SELECT * FROM AracModelleri";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            modelListesi.Add(new AracModel
                            {
                                ModelID = Convert.ToInt32(reader["ModelID"]),
                                MarkaID = Convert.ToInt32(reader["MarkaID"]),
                                ModelAdi = reader["ModelAdi"].ToString(),
                                Versiyon = reader["Aciklama"].ToString()
                            });
                        }
                    }
                }
            }

            return modelListesi;
        }

        public List<AracModel> MarkaninModelleriniGetir(int markaId)
        {
            List<AracModel> modelListesi = new List<AracModel>();

            using (MySqlConnection connection = DbConnection.GetConnection())
            {
                string query = "SELECT * FROM AracModelleri WHERE MarkaID = @MarkaID";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MarkaID", markaId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            modelListesi.Add(new AracModel
                            {
                                ModelID = Convert.ToInt32(reader["ModelID"]),
                                MarkaID = Convert.ToInt32(reader["MarkaID"]),
                                ModelAdi = reader["ModelAdi"].ToString(),
                                Versiyon = reader["Aciklama"].ToString()
                            });
                        }
                    }
                }
            }

            return modelListesi;
        }

        public AracModel ModelGetirById(int modelId)
        {
            using (MySqlConnection connection = DbConnection.GetConnection())
            {
                string query = "SELECT * FROM AracModelleri WHERE ModelID = @ModelID";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ModelID", modelId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new AracModel
                            {
                                ModelID = Convert.ToInt32(reader["ModelID"]),
                                MarkaID = Convert.ToInt32(reader["MarkaID"]),
                                ModelAdi = reader["ModelAdi"].ToString(),
                                Versiyon = reader["Aciklama"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }
    }

    // Araç Durum Repository
    public class AracDurumRepository
    {
        public List<AracDurum> TumDurumlariGetir()
        {
            List<AracDurum> durumListesi = new List<AracDurum>();

            using (MySqlConnection connection = DbConnection.GetConnection())
            {
                string query = "SELECT * FROM AracDurumlari";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            durumListesi.Add(new AracDurum
                            {
                                DurumID = Convert.ToInt32(reader["DurumID"]),
                                DurumAdi = reader["DurumAdi"].ToString(),
                                Aciklama = reader["Aciklama"].ToString()
                            });
                        }
                    }
                }
            }

            return durumListesi;
        }

        public AracDurum DurumGetirById(int durumId)
        {
            using (MySqlConnection connection = DbConnection.GetConnection())
            {
                string query = "SELECT * FROM AracDurumlari WHERE DurumID = @DurumID";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@DurumID", durumId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new AracDurum
                            {
                                DurumID = Convert.ToInt32(reader["DurumID"]),
                                DurumAdi = reader["DurumAdi"].ToString(),
                                Aciklama = reader["Aciklama"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }
    }

    // Araç Kategori Repository
    public class AracKategoriRepository
    {
        public List<AracKategori> TumKategorileriGetir()
        {
            List<AracKategori> kategoriListesi = new List<AracKategori>();

            using (MySqlConnection connection = DbConnection.GetConnection())
            {
                string query = "SELECT * FROM AracKategorileri";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            kategoriListesi.Add(new AracKategori
                            {
                                KategoriID = Convert.ToInt32(reader["KategoriID"]),
                                KategoriAdi = reader["KategoriAdi"].ToString(),
                                Aciklama = reader["Aciklama"].ToString()
                            });
                        }
                    }
                }
            }

            return kategoriListesi;
        }

        public AracKategori KategoriGetirById(int kategoriId)
        {
            using (MySqlConnection connection = DbConnection.GetConnection())
            {
                string query = "SELECT * FROM AracKategorileri WHERE KategoriID = @KategoriID";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@KategoriID", kategoriId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new AracKategori
                            {
                                KategoriID = Convert.ToInt32(reader["KategoriID"]),
                                KategoriAdi = reader["KategoriAdi"].ToString(),
                                Aciklama = reader["Aciklama"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}