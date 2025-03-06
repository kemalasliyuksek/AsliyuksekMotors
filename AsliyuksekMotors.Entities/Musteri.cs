using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsliyuksekMotors.Entities
{
    public class Musteri
    {
        public int MusteriID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string EhliyetNo { get; set; }
        public string EhliyetSinifi { get; set; }
        public DateTime EhliyetTarihi { get; set; }
        public string TelefonNo { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
        public DateTime KayitTarihi { get; set; }
        public bool MusaitlikDurumu { get; set; }
        public string MusteriTipi { get; set; }
    }
}
