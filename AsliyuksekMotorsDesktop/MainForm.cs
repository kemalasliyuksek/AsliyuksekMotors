using System;
using System.Windows.Forms;
using System.Diagnostics;
using AsliyuksekMotors.Entities;
using AsliyuksekMotors.Business;

namespace AsliyuksekMotorsDesktop
{
    public partial class MainForm : Form
    {
        private readonly Kullanici _currentUser;
        private readonly DashboardManager _dashboardManager;
        private System.Windows.Forms.Timer _refreshTimer;

        public MainForm(Kullanici kullanici)
        {
            InitializeComponent();
            _currentUser = kullanici;
            _dashboardManager = new DashboardManager();

            // Form yüklendiğinde event handler ekle
            this.Load += MainForm_Load;
            // Form kapatıldığında uygulamayı sonlandır
            this.FormClosed += MainForm_FormClosed;

            // Menü öğeleri için event handler'ları ekle
            menuItemAraclar.Click += menuItemAraclar_Click;
            menuItemMusteriler.Click += menuItemMusteriler_Click;
            menuItemKiralama.Click += menuItemKiralama_Click;
            menuItemSatis.Click += menuItemSatis_Click;

            // Otomatik yenileme için timer oluştur
            _refreshTimer = new System.Windows.Forms.Timer();
            _refreshTimer.Interval = 60000; // 1 dakikada bir yenile
            _refreshTimer.Tick += RefreshTimer_Tick;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Kullanıcı bilgilerini göster
            lblWelcome.Text = $"Kullanıcı: {_currentUser.KullaniciAdi}";

            // Tarih ve sürüm bilgisi göster
            lblDate.Text = $"Tarih: {DateTime.Now.ToString("dd.MM.yyyy")}";
            lblVersion.Text = $"Sürüm: 1.0";

            // Dashboard verilerini yükle
            LoadDashboardData();

            // Timer'ı başlat
            _refreshTimer.Start();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _refreshTimer.Stop();
            Application.Exit();
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            // Timer her tetiklendiğinde dashboard verilerini yenile
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                // Veritabanından dashboard verilerini al
                var dashboardData = _dashboardManager.GetDashboardData();

                // UI thread'inde güncellemeleri yap
                this.Invoke((MethodInvoker)delegate
                {
                    // Aktif Kiralamalar Paneli
                    lblKiralama.Text = $"{dashboardData.AktifKiralamaSayisi} Kiralama";
                    lblDonecek.Text = $"{dashboardData.BugunDonecekSayisi} Bugün Dönecek";
                    lblGecikme.Text = $"{dashboardData.GecikmisKiralamaSayisi} Gecikmiş";

                    // Araç Durumu Paneli
                    lblMüsaitArac.Text = $"{dashboardData.MüsaitAracSayisi} Müsait";
                    lblKiralanmisArac.Text = $"{dashboardData.KiralanmisAracSayisi} Kiralanmış";
                    lblBakimdaArac.Text = $"{dashboardData.BakimdaAracSayisi} Bakımda";

                    // Bugünkü İşlemler Paneli
                    lblYeniKiralama.Text = $"{dashboardData.BugunYeniKiralamaSayisi} Yeni Kiralama";
                    lblIade.Text = $"{dashboardData.BugunIadeSayisi} İade";
                    lblSatis.Text = $"{dashboardData.BugunSatisSayisi} Satış";

                    // Finans Durumu Paneli
                    lblGelir.Text = $"{dashboardData.BugunToplamGelir.ToString("N2")} TL Gelir";
                    lblGider.Text = $"{dashboardData.BugunToplamGider.ToString("N2")} TL Gider";
                    lblNet.Text = $"{dashboardData.BugunNetGelir.ToString("N2")} TL Net";
                });
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Dashboard verileri yüklenirken hata: {ex.Message}");
                MessageBox.Show($"Veri yükleme hatası: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuItemAraclar_Click(object sender, EventArgs e)
        {
            // Araç yönetimi formu açılacak
            MessageBox.Show("Araç Yönetimi formu açılacak", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuItemMusteriler_Click(object sender, EventArgs e)
        {
            // Müşteri yönetimi formu açılacak
            MessageBox.Show("Müşteri Yönetimi formu açılacak", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuItemKiralama_Click(object sender, EventArgs e)
        {
            // Kiralama yönetimi formu açılacak
            MessageBox.Show("Kiralama Yönetimi formu açılacak", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuItemSatis_Click(object sender, EventArgs e)
        {
            // Satış yönetimi formu açılacak
            MessageBox.Show("Satış Yönetimi formu açılacak", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Dashboard panellerine tıklama eventleri buraya eklenebilir
        private void panelAktifKiralamalar_Click(object sender, EventArgs e)
        {
            // Kiralamalar listesini gösteren form açılabilir
            menuItemKiralama_Click(sender, e);
        }

        private void panelAracDurumu_Click(object sender, EventArgs e)
        {
            // Araçlar listesini gösteren form açılabilir
            menuItemAraclar_Click(sender, e);
        }
    }
}