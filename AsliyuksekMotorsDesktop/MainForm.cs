using System;
using System.Windows.Forms;
using AsliyuksekMotors.Entities;

namespace AsliyuksekMotorsDesktop
{
    public partial class MainForm : Form
    {
        private readonly Kullanici _currentUser;

        public MainForm(Kullanici kullanici)
        {
            InitializeComponent();
            _currentUser = kullanici;

            // Form yüklendiğinde event handler ekle
            this.Load += MainForm_Load;
            // Form kapatıldığında uygulamayı sonlandır
            this.FormClosed += MainForm_FormClosed;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Kullanıcı bilgilerini göster
            lblWelcome.Text = $"Hoş geldiniz, {_currentUser.Ad} {_currentUser.Soyad}";
            lblRole.Text = $"Rol: {GetRoleName(_currentUser.RolID)}";

            // Yetkilere göre menü öğelerini ayarla
            SetMenuPermissions();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private string GetRoleName(int rolId)
        {
            // Rol bilgilerini veritabanından almanız gerekecek
            // Şimdilik basit bir switch-case yapısı kullanıyoruz
            switch (rolId)
            {
                case 1:
                    return "Yönetici";
                case 2:
                    return "Satış Temsilcisi";
                case 3:
                    return "Finansal Sorumlu";
                default:
                    return "Tanımlanmamış Rol";
            }
        }

        private void SetMenuPermissions()
        {
            // Rol ID'sine göre menü öğelerinin erişilebilirliğini ayarla
            // Örnek: Yönetici tüm menülere erişebilir, diğerleri sınırlı erişime sahip
            bool isAdmin = _currentUser.RolID == 1;

            // Menü öğelerini rol bazlı aktif/pasif yap
            menuItemUserManagement.Visible = isAdmin;
            menuItemReports.Enabled = isAdmin || _currentUser.RolID == 3; // Yönetici veya finansal sorumlu
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Kullanıcıyı çıkış yap ve login ekranına geri dön
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}