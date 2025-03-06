using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsliyuksekMotors.Entities
{
    public class Satis
    {
        public int SatisID { get; set; }
        public int MusteriID { get; set; }
        public int AracID { get; set; }
        public DateTime SatisTarihi { get; set; }
        public decimal SatisTutari { get; set; }
        public string OdemeTipi { get; set; }
        public int TaksitSayisi { get; set; }
        public DateTime NoterTarihi { get; set; }
        public string SozlesmeID { get; set; }
        public int KullaniciID { get; set; }
    }
}
