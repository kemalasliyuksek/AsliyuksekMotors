using System;
using System.Collections.Generic;
using System.Linq;
using AsliyuksekMotors.Entities;
using AsliyuksekMotors.DataAccess;

namespace AsliyuksekMotors.Business
{
    public class AracManager
    {
        private readonly AracRepository _aracRepository;
        private readonly AracMarkaRepository _markaRepository;
        private readonly AracModelRepository _modelRepository;
        private readonly AracDurumRepository _durumRepository;

        public AracManager()
        {
            _aracRepository = new AracRepository();
            _markaRepository = new AracMarkaRepository();
            _modelRepository = new AracModelRepository();
            _durumRepository = new AracDurumRepository();
        }

        public int AracEkle(Arac arac)
        {
            // Araç ekleme için iş kuralları
            if (string.IsNullOrWhiteSpace(arac.Plaka))
            {
                throw new ArgumentException("Plaka boş olamaz");
            }

            if (arac.YapimYili < 1900 || arac.YapimYili > DateTime.Now.Year + 1)
            {
                throw new ArgumentException("Geçersiz yapım yılı");
            }

            if (arac.AlisFiyati <= 0 || arac.SatisFiyati <= 0 || arac.KiraFiyati <= 0)
            {
                throw new ArgumentException("Fiyatlar sıfırdan büyük olmalıdır");
            }

            return _aracRepository.Ekle(arac);
        }

        public List<AracViewModel> TumAraclariGetir()
        {
            var araclar = _aracRepository.TumAraclariGetir();
            var markalar = _markaRepository.TumMarkalariGetir();
            var modeller = _modelRepository.TumModelleriGetir();
            var durumlar = _durumRepository.TumDurumlariGetir();

            var viewModels = new List<AracViewModel>();

            foreach (var arac in araclar)
            {
                var marka = markalar.FirstOrDefault(m => m.MarkaID == arac.MarkaID)?.MarkaAdi ?? "Bilinmiyor";
                var model = modeller.FirstOrDefault(m => m.ModelID == arac.ModelID)?.ModelAdi ?? "Bilinmiyor";
                var durum = durumlar.FirstOrDefault(d => d.DurumID == arac.DurumID)?.DurumAdi ?? "Bilinmiyor";

                // Fiyat bilgisi duruma göre formatlanıyor
                string fiyat;
                if (arac.DurumID == 4 || arac.DurumID == 5) // Satılık veya Satıldı durumları
                {
                    fiyat = $"{arac.SatisFiyati:N0} TL";
                }
                else // Diğer durumlar (kiralanabilir)
                {
                    fiyat = $"{arac.KiraFiyati:N0} TL/Gün";
                }

                viewModels.Add(new AracViewModel
                {
                    AracID = arac.AracID,
                    Plaka = arac.Plaka,
                    Marka = marka,
                    Model = model,
                    YapimYili = arac.YapimYili,
                    Durum = durum,
                    Fiyat = fiyat,
                    // Diğer gerekli bilgiler de buraya eklenebilir
                });
            }

            return viewModels;
        }

        public Arac AracGetirById(int aracId)
        {
            if (aracId <= 0)
            {
                throw new ArgumentException("Geçersiz araç ID'si");
            }

            return _aracRepository.AracGetirById(aracId);
        }

        public bool AracGuncelle(Arac arac)
        {
            // Güncelleme için iş kuralları
            if (arac == null)
            {
                throw new ArgumentNullException(nameof(arac), "Araç nesnesi boş olamaz");
            }

            if (string.IsNullOrWhiteSpace(arac.Plaka))
            {
                throw new ArgumentException("Plaka boş olamaz");
            }

            if (arac.YapimYili < 1900 || arac.YapimYili > DateTime.Now.Year + 1)
            {
                throw new ArgumentException("Geçersiz yapım yılı");
            }

            if (arac.AlisFiyati <= 0 || arac.SatisFiyati <= 0 || arac.KiraFiyati <= 0)
            {
                throw new ArgumentException("Fiyatlar sıfırdan büyük olmalıdır");
            }

            return _aracRepository.Guncelle(arac);
        }

        public bool AracSil(int aracId)
        {
            if (aracId <= 0)
            {
                throw new ArgumentException("Geçersiz araç ID'si");
            }

            return _aracRepository.Sil(aracId);
        }

        public List<AracViewModel> AraclariFiltrele(
            string searchText = null,
            int? markaId = null,
            int? modelId = null,
            int? kategoriId = null,
            int? durumId = null)
        {
            // Önce tüm araçları getir
            var tumAraclar = TumAraclariGetir();

            // Arama metni varsa filtreleme yap
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                searchText = searchText.ToLower();
                tumAraclar = tumAraclar.Where(a =>
                    a.Plaka.ToLower().Contains(searchText) ||
                    a.Marka.ToLower().Contains(searchText) ||
                    a.Model.ToLower().Contains(searchText) ||
                    a.YapimYili.ToString().Contains(searchText) ||
                    a.Durum.ToLower().Contains(searchText) ||
                    a.Fiyat.ToLower().Contains(searchText)
                ).ToList();
            }

            // Diğer filtreleri de uygula
            if (markaId.HasValue)
            {
                // Bu örnek için markaId değeri kullanılmıyor çünkü viewModel'de sadece marka adı var
                // Gerçek uygulamada burası için ayrı bir query veya join gerekebilir
            }

            if (modelId.HasValue)
            {
                // Benzer şekilde
            }

            if (durumId.HasValue)
            {
                // Gerçek uygulamada ayrı query veya join
            }

            return tumAraclar;
        }

        public bool AracMusaitMi(int aracId)
        {
            var arac = AracGetirById(aracId);

            if (arac == null)
            {
                throw new ArgumentException("Araç bulunamadı");
            }

            // Varsayılan olarak 1 numaralı durum kodu "Müsait" olarak kabul edilir
            return arac.DurumID == 1;
        }

        public bool AracDurumunuGuncelle(int aracId, int yeniDurumId)
        {
            var arac = AracGetirById(aracId);
            if (arac == null)
            {
                throw new ArgumentException("Araç bulunamadı");
            }

            arac.DurumID = yeniDurumId;
            return _aracRepository.Guncelle(arac);
        }
    }

    public class AracViewModel
    {
        public int AracID { get; set; }
        public string Plaka { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int YapimYili { get; set; }
        public string Durum { get; set; }
        public string Fiyat { get; set; }
    }
}