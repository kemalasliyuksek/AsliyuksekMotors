using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsliyuksekMotors.DataAccess;

namespace AsliyuksekMotors.Business
{
    public class DashboardManager
    {
        private readonly DashboardRepository _dashboardRepository;

        public DashboardManager()
        {
            _dashboardRepository = new DashboardRepository();
        }

        #region Kiralama İstatistikleri

        public int GetAktifKiralamaSayisi()
        {
            return _dashboardRepository.GetAktifKiralamaSayisi();
        }

        public int GetBugunDonecekKiralamaSayisi()
        {
            return _dashboardRepository.GetBugunDonecekKiralamaSayisi();
        }

        public int GetGecikmisKiralamaSayisi()
        {
            return _dashboardRepository.GetGecikmisKiralamaSayisi();
        }

        #endregion

        #region Araç İstatistikleri

        public int GetMüsaitAracSayisi()
        {
            return _dashboardRepository.GetMüsaitAracSayisi();
        }

        public int GetKiralanmisAracSayisi()
        {
            return _dashboardRepository.GetKiralanmisAracSayisi();
        }

        public int GetBakimdaAracSayisi()
        {
            return _dashboardRepository.GetBakimdaAracSayisi();
        }

        #endregion

        #region Bugünkü İşlemler

        public int GetBugunYeniKiralamaSayisi()
        {
            return _dashboardRepository.GetBugunYeniKiralamaSayisi();
        }

        public int GetBugunIadeSayisi()
        {
            return _dashboardRepository.GetBugunIadeSayisi();
        }

        public int GetBugunSatisSayisi()
        {
            return _dashboardRepository.GetBugunSatisSayisi();
        }

        #endregion

        #region Finans Durumu

        public decimal GetBugunToplamGelir()
        {
            return _dashboardRepository.GetBugunToplamGelir();
        }

        public decimal GetBugunToplamGider()
        {
            return _dashboardRepository.GetBugunToplamGider();
        }

        public decimal GetBugunNetGelir()
        {
            decimal gelir = GetBugunToplamGelir();
            decimal gider = GetBugunToplamGider();
            return gelir - gider;
        }

        #endregion

        public DashboardData GetDashboardData()
        {
            return new DashboardData
            {
                AktifKiralamaSayisi = GetAktifKiralamaSayisi(),
                BugunDonecekSayisi = GetBugunDonecekKiralamaSayisi(),
                GecikmisKiralamaSayisi = GetGecikmisKiralamaSayisi(),

                MüsaitAracSayisi = GetMüsaitAracSayisi(),
                KiralanmisAracSayisi = GetKiralanmisAracSayisi(),
                BakimdaAracSayisi = GetBakimdaAracSayisi(),

                BugunYeniKiralamaSayisi = GetBugunYeniKiralamaSayisi(),
                BugunIadeSayisi = GetBugunIadeSayisi(),
                BugunSatisSayisi = GetBugunSatisSayisi(),

                BugunToplamGelir = GetBugunToplamGelir(),
                BugunToplamGider = GetBugunToplamGider(),
                BugunNetGelir = GetBugunNetGelir()
            };
        }
    }

    public class DashboardData
    {
        // Kiralama İstatistikleri
        public int AktifKiralamaSayisi { get; set; }
        public int BugunDonecekSayisi { get; set; }
        public int GecikmisKiralamaSayisi { get; set; }

        // Araç İstatistikleri
        public int MüsaitAracSayisi { get; set; }
        public int KiralanmisAracSayisi { get; set; }
        public int BakimdaAracSayisi { get; set; }

        // Bugünkü İşlemler
        public int BugunYeniKiralamaSayisi { get; set; }
        public int BugunIadeSayisi { get; set; }
        public int BugunSatisSayisi { get; set; }

        // Finans Durumu
        public decimal BugunToplamGelir { get; set; }
        public decimal BugunToplamGider { get; set; }
        public decimal BugunNetGelir { get; set; }
    }
}