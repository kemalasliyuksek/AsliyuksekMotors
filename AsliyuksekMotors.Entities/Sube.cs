using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsliyuksekMotors.Entities
{
    public class Sube
    {
        public int SubeID { get; set; }
        public string SubeAdi { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Yetkili { get; set; }
        public bool Aktif { get; set; }
    }
}
