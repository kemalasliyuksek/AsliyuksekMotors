using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using AsliyuksekMotors.Entities;
using AsliyuksekMotors.DataAccess;

namespace AsliyuksekMotors.Business
{
    public class MusteriManager
    {
        private readonly MusteriRepository _musteriRepository;

        public MusteriManager()
        {
            _musteriRepository = new MusteriRepository();
        }

        public int MusteriEkle(Musteri musteri)
        {
            // Müşteri ekleme için doğrulamalar
            ValidasyonKontrol(musteri);

            // TC numarası benzersizliğini kontrol et
            if (TCNoKontrol(musteri.TC))
            {
                throw new ArgumentException("Bu TC numarası zaten kayıtlı.");
            }

            // Kayıt tarihini şu an olarak ayarla
            musteri.KayitTarihi = DateTime.Now;

            // Varsayılan olarak müşteri müsait
            musteri.MusaitlikDurumu = true;

            return _musteriRepository.Ekle(musteri);
        }

        public bool MusteriGuncelle(Musteri musteri)
        {
            // Güncelleme için doğrulamalar
            ValidasyonKontrol(musteri);

            return _musteriRepository.Guncelle(musteri);
        }

        public List<Musteri> TumMusterileriGetir()
        {
            return _musteriRepository.TumMusterileriGetir();
        }

        public Musteri MusteriGetirById(int musteriId)
        {
            if (musteriId <= 0)
            {
                throw new ArgumentException("Geçersiz müşteri ID'si");
            }

            return _musteriRepository.MusteriGetirById(musteriId);
        }

        public Musteri MusteriGetirByTC(string tcNo)
        {
            if (string.IsNullOrWhiteSpace(tcNo))
            {
                throw new ArgumentException("TC numarası boş olamaz");
            }

            return _musteriRepository.MusteriGetirByTC(tcNo);
        }

        public bool MusteriSil(int musteriId)
        {
            if (musteriId <= 0)
            {
                throw new ArgumentException("Geçersiz müşteri ID'si");
            }

            return _musteriRepository.Sil(musteriId);
        }

        private void ValidasyonKontrol(Musteri musteri)
        {
            if (musteri == null)
            {
                throw new ArgumentNullException(nameof(musteri), "Müşteri bilgileri boş olamaz");
            }

            // Ad ve soyad kontrolü
            if (string.IsNullOrWhiteSpace(musteri.Ad))
            {
                throw new ArgumentException("Ad boş olamaz");
            }

            if (string.IsNullOrWhiteSpace(musteri.Soyad))
            {
                throw new ArgumentException("Soyad boş olamaz");
            }

            // TC numarası kontrolü
            if (string.IsNullOrWhiteSpace(musteri.TC))
            {
                throw new ArgumentException("TC numarası boş olamaz");
            }

            if (!TCNoFormatKontrol(musteri.TC))
            {
                throw new ArgumentException("Geçersiz TC numarası formatı");
            }

            // Doğum tarihi kontrolü
            if (musteri.DogumTarihi == default)
            {
                throw new ArgumentException("Doğum tarihi boş olamaz");
            }

            if (musteri.DogumTarihi > DateTime.Now.AddYears(-18))
            {
                throw new ArgumentException("Müşteri 18 yaşından küçük olamaz");
            }

            // Ehliyet kontrolü
            if (string.IsNullOrWhiteSpace(musteri.EhliyetNo))
            {
                throw new ArgumentException("Ehliyet numarası boş olamaz");
            }

            if (musteri.EhliyetTarihi == default)
            {
                throw new ArgumentException("Ehliyet tarihi boş olamaz");
            }

            // İletişim bilgileri kontrolü
            if (!string.IsNullOrWhiteSpace(musteri.Email) && !EmailFormatKontrol(musteri.Email))
            {
                throw new ArgumentException("Geçersiz email formatı");
            }

            if (!string.IsNullOrWhiteSpace(musteri.TelefonNo) && !TelefonFormatKontrol(musteri.TelefonNo))
            {
                throw new ArgumentException("Geçersiz telefon formatı");
            }
        }

        private bool TCNoFormatKontrol(string tcNo)
        {
            // TC numarası 11 haneli ve sadece rakamlardan oluşmalı
            if (tcNo.Length != 11)
                return false;

            // İlk hane 0 olamaz
            if (tcNo[0] == '0')
                return false;

            // Sadece rakamlardan oluşmalı
            foreach (char c in tcNo)
            {
                if (!char.IsDigit(c))
                    return false;
            }

            // TC no algoritması kontrolü
            return TCNoAlgoritmaKontrol(tcNo);
        }

        private bool TCNoAlgoritmaKontrol(string tcNo)
        {
            int tek = 0, cift = 0;
            for (int i = 0; i < 9; i++)
            {
                int rakam = int.Parse(tcNo[i].ToString());
                if (i % 2 == 0)
                    tek += rakam;
                else
                    cift += rakam;
            }

            int sonRakam10 = (tek * 7 - cift) % 10;
            int sonRakam11 = (tek + cift + sonRakam10) % 10;

            return (sonRakam10 == int.Parse(tcNo[9].ToString()) &&
                    sonRakam11 == int.Parse(tcNo[10].ToString()));
        }

        private bool EmailFormatKontrol(string email)
        {
            try
            {
                var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                return regex.IsMatch(email);
            }
            catch
            {
                return false;
            }
        }

        private bool TelefonFormatKontrol(string telefon)
        {
            // Temel Türkiye telefon numarası formatı kontrolü
            var regex = new Regex(@"^(05|5)(\d{9})$");
            return regex.IsMatch(telefon);
        }

        private bool TCNoKontrol(string tcNo)
        {
            var tumMusteriler = _musteriRepository.TumMusterileriGetir();
            return tumMusteriler.Exists(m => m.TC == tcNo);
        }

        public int MusteriYasHesapla(DateTime dogumTarihi)
        {
            var today = DateTime.Today;
            var age = today.Year - dogumTarihi.Year;

            if (dogumTarihi.Date > today.AddYears(-age))
                age--;

            return age;
        }

        public bool KiralamaUygunlukKontrol(Musteri musteri)
        {
            // Yaş kontrolü
            int yas = MusteriYasHesapla(musteri.DogumTarihi);
            if (yas < 21)
                return false;

            // Ehliyet yaş kontrolü
            if (yas - MusteriYasHesapla(musteri.EhliyetTarihi) < 2)
                return false;

            // Müşteri durumu kontrolü
            return musteri.MusaitlikDurumu;
        }
    }
}