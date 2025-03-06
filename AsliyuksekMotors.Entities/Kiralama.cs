using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsliyuksekMotors.Entities
{
    public class Kiralama
    {
        public int KiralamaID { get; set; }
        public int MusteriID { get; set; }
        public int AracID { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public DateTime? TeslimTarihi { get; set; }
        public int BaslangicKm { get; set; }
        public int BitisKm { get; set; }
        public decimal KiralamaTutari { get; set; }
        public decimal DepozitTutari { get; set; }
        public string OdemeTipi { get; set; }
        public string KiralamaNotlari { get; set; }
        public int KullaniciID { get; set; }
    }
}
