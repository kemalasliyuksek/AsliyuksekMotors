using System;
using System.Collections.Generic;
using AsliyuksekMotors.Entities;
using AsliyuksekMotors.DataAccess;

namespace AsliyuksekMotors.Business
{
    public class AracManager
    {
        private readonly AracRepository _aracRepository;

        public AracManager()
        {
            _aracRepository = new AracRepository();
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

        public List<Arac> TumAraclariGetir()
        {
            return _aracRepository.TumAraclariGetir();
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

        public List<Arac> AraclariFiltrele(
            int? markaId = null,
            int? modelId = null,
            int? kategoriId = null,
            int? durumId = null)
        {
            var tumAraclar = _aracRepository.TumAraclariGetir();
            var filtreliAraclar = tumAraclar;

            if (markaId.HasValue)
            {
                filtreliAraclar = filtreliAraclar.FindAll(a => a.MarkaID == markaId.Value);
            }

            if (modelId.HasValue)
            {
                filtreliAraclar = filtreliAraclar.FindAll(a => a.ModelID == modelId.Value);
            }

            if (kategoriId.HasValue)
            {
                filtreliAraclar = filtreliAraclar.FindAll(a => a.AracKategoriID == kategoriId.Value);
            }

            if (durumId.HasValue)
            {
                filtreliAraclar = filtreliAraclar.FindAll(a => a.DurumID == durumId.Value);
            }

            return filtreliAraclar;
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
    }
}