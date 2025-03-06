using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using AsliyuksekMotors.Entities;
using AsliyuksekMotors.DataAccess;

namespace AsliyuksekMotors.Business
{
    public class KullaniciManager
    {
        private readonly KullaniciRepository _kullaniciRepository;

        public KullaniciManager()
        {
            _kullaniciRepository = new KullaniciRepository();
        }

        public int KullaniciEkle(Kullanici kullanici)
        {
            // Kullanıcı ekleme için doğrulamalar
            ValidasyonKontrol(kullanici);

            // Kullanıcı adının benzersizliğini kontrol et
            if (KullaniciAdiKontrol(kullanici.KullaniciAdi))
            {
                throw new ArgumentException("Bu kullanıcı adı zaten kullanılmaktadır.");
            }

            // Varsayılan olarak kullanıcı aktif
            kullanici.Durum = true;

            return _kullaniciRepository.Ekle(kullanici);
        }

        public Kullanici GirisYap(string kullaniciAdi, string sifre)
        {
            if (string.IsNullOrWhiteSpace(kullaniciAdi))
            {
                throw new ArgumentException("Kullanıcı adı boş olamaz");
            }

            if (string.IsNullOrWhiteSpace(sifre))
            {
                throw new ArgumentException("Şifre boş olamaz");
            }

            var kullanici = _kullaniciRepository.GirisYap(kullaniciAdi, sifre);

            if (kullanici == null)
            {
                throw new UnauthorizedAccessException("Kullanıcı adı veya şifre hatalı");
            }

            return kullanici;
        }

        public bool KullaniciGuncelle(Kullanici kullanici)
        {
            // Güncelleme için doğrulamalar
            ValidasyonKontrol(kullanici);

            return _kullaniciRepository.Guncelle(kullanici);
        }

        public bool SifreDegistir(int kullaniciId, string eskiSifre, string yeniSifre)
        {
            // Şifre doğrulama kuralları
            if (string.IsNullOrWhiteSpace(eskiSifre))
            {
                throw new ArgumentException("Eski şifre boş olamaz");
            }

            if (string.IsNullOrWhiteSpace(yeniSifre))
            {
                throw new ArgumentException("Yeni şifre boş olamaz");
            }

            if (eskiSifre == yeniSifre)
            {
                throw new ArgumentException("Yeni şifre eski şifre ile aynı olamaz");
            }

            if (!SifreKurallariniKontrolEt(yeniSifre))
            {
                throw new ArgumentException("Şifre belirlenen kurallara uymuyor");
            }

            return _kullaniciRepository.SifreDegistir(kullaniciId, eskiSifre, yeniSifre);
        }

        public List<Kullanici> TumKullanicilariGetir()
        {
            return _kullaniciRepository.TumKullanicilarGetir();
        }

        public Kullanici KullaniciGetirById(int kullaniciId)
        {
            if (kullaniciId <= 0)
            {
                throw new ArgumentException("Geçersiz kullanıcı ID'si");
            }

            return _kullaniciRepository.KullaniciGetirById(kullaniciId);
        }

        public bool KullaniciSil(int kullaniciId)
        {
            if (kullaniciId <= 0)
            {
                throw new ArgumentException("Geçersiz kullanıcı ID'si");
            }

            return _kullaniciRepository.Sil(kullaniciId);
        }

        private void ValidasyonKontrol(Kullanici kullanici)
        {
            if (kullanici == null)
            {
                throw new ArgumentNullException(nameof(kullanici), "Kullanıcı bilgileri boş olamaz");
            }

            // Ad ve soyad kontrolü
            if (string.IsNullOrWhiteSpace(kullanici.Ad))
            {
                throw new ArgumentException("Ad boş olamaz");
            }

            if (string.IsNullOrWhiteSpace(kullanici.Soyad))
            {
                throw new ArgumentException("Soyad boş olamaz");
            }

            // Kullanıcı adı kontrolü
            if (string.IsNullOrWhiteSpace(kullanici.KullaniciAdi))
            {
                throw new ArgumentException("Kullanıcı adı boş olamaz");
            }

            if (kullanici.KullaniciAdi.Length < 3)
            {
                throw new ArgumentException("Kullanıcı adı en az 3 karakter olmalıdır");
            }

            // Email formatı kontrolü
            if (!string.IsNullOrWhiteSpace(kullanici.Email) && !EmailFormatKontrol(kullanici.Email))
            {
                throw new ArgumentException("Geçersiz email formatı");
            }

            // Telefon formatı kontrolü
            if (!string.IsNullOrWhiteSpace(kullanici.Telefon) && !TelefonFormatKontrol(kullanici.Telefon))
            {
                throw new ArgumentException("Geçersiz telefon formatı");
            }
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

        private bool KullaniciAdiKontrol(string kullaniciAdi)
        {
            var tumKullanicilar = _kullaniciRepository.TumKullanicilarGetir();
            return tumKullanicilar.Exists(k => k.KullaniciAdi.Equals(kullaniciAdi, StringComparison.OrdinalIgnoreCase));
        }

        private bool SifreKurallariniKontrolEt(string sifre)
        {
            // Şifre kuralları:
            // - En az 8 karakter
            // - En az bir büyük harf
            // - En az bir küçük harf
            // - En az bir rakam
            // - En az bir özel karakter
            var regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$");
            return regex.IsMatch(sifre);
        }
    }
}