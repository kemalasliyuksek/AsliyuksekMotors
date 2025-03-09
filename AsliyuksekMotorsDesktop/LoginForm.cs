using System;
using System.Windows.Forms;
using System.Drawing;
using AsliyuksekMotors.Business;
using AsliyuksekMotors.Entities;
using System.Diagnostics;

namespace AsliyuksekMotorsDesktop
{
    public partial class LoginForm : Form
    {
        private readonly KullaniciManager _kullaniciManager;

        public LoginForm()
        {
            InitializeComponent();
            _kullaniciManager = new KullaniciManager();

            // Form yüklendiğinde çalışacak event
            this.Load += LoginForm_Load;

            // Enter tuşuna basılınca giriş yap
            this.AcceptButton = btnLogin;

            // Giriş butonuna tıklama eventi
            btnLogin.Click += BtnLogin_Click;

            // Şifre göster/gizle checkbox'ı
            chkShowPassword.CheckedChanged += ChkShowPassword_CheckedChanged;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Form açıldığında kullanıcı adı kısmına focus ver
            txtUsername.Focus();

            // Şifre gösterme checkbox'ını varsayılan olarak işaretsiz bırak
            chkShowPassword.Checked = false;

            // Status mesajı
            lblStatus.Text = "Lütfen giriş bilgilerinizi giriniz.";
            lblStatus.ForeColor = Color.Gray;
        }

        private void ChkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Şifre göster/gizle
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            lblStatus.Text = "Giriş yapılıyor...";
            lblStatus.ForeColor = Color.Blue;
            Application.DoEvents(); // UI'ın güncellenmesini sağla

            // Geçerlilik kontrolü
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblStatus.Text = "Kullanıcı adı ve şifre boş olamaz!";
                lblStatus.ForeColor = Color.Red;
                return;
            }

            try
            {
                // Detaylı hata ayıklama için bilgileri yazdır
                Debug.WriteLine($"Giriş denemesi: Kullanıcı Adı: {username}");

                // Giriş yapma denemesi
                Kullanici kullanici = _kullaniciManager.GirisYap(username, password);

                if (kullanici != null)
                {
                    lblStatus.Text = "Giriş başarılı! Yönlendiriliyorsunuz...";
                    lblStatus.ForeColor = Color.Green;
                    Application.DoEvents(); // UI'ın güncellenmesini sağla

                    // 1 saniye bekle ve sonra ana formu aç
                    System.Threading.Thread.Sleep(1000);

                    // Ana formu açma
                    OpenMainForm(kullanici);
                }
                else
                {
                    lblStatus.Text = "Giriş başarısız. Kullanıcı adı veya şifre hatalı!";
                    lblStatus.ForeColor = Color.Red;

                    // Şifre alanını temizle
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                lblStatus.Text = $"Giriş başarısız: {ex.Message}";
                lblStatus.ForeColor = Color.Red;
                Debug.WriteLine($"Yetki hatası: {ex.Message}");
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Bir hata oluştu. Lütfen tekrar deneyin.";
                lblStatus.ForeColor = Color.Red;
                Debug.WriteLine($"Giriş hatası: {ex.Message}");

                // Uygulama hata mesajını göster (geliştirme aşamasında)
                MessageBox.Show($"Hata detayı: {ex.Message}\n\nStack Trace: {ex.StackTrace}",
                    "Uygulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenMainForm(Kullanici kullanici)
        {
            try
            {
                var mainForm = new MainForm(kullanici);
                mainForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ana form açılırken hata oluştu: {ex.Message}",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine($"MainForm açılış hatası: {ex.Message}");
            }
        }

        // Form kapatılınca uygulamayı sonlandır
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }
    }
}