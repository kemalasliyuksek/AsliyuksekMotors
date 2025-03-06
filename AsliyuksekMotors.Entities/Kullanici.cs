using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsliyuksekMotors.Entities
{
    public class Kullanici
    {
        public int KullaniciID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public int RolID { get; set; }
        public int SubeID { get; set; }
        public DateTime? SonGirisTarihi { get; set; }
        public bool Durum { get; set; }
    }
}
