using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsliyuksekMotors.Entities
{
    public class Arac
    {
        public int AracID { get; set; }
        public string Plaka { get; set; }
        public int MarkaID { get; set; }
        public int ModelID { get; set; }
        public int YapimYili { get; set; }
        public string MotorNo { get; set; }
        public string SasiNo { get; set; }
        public string Renk { get; set; }
        public int Kilometre { get; set; }
        public string YakitTipi { get; set; }
        public string VitesTipi { get; set; }
        public int DurumID { get; set; }
        public DateTime AlinmaTarihi { get; set; }
        public decimal AlisFiyati { get; set; }
        public decimal SatisFiyati { get; set; }
        public decimal KiraFiyati { get; set; }
        public int AracKategoriID { get; set; }
        public int SubeID { get; set; }
    }
}
