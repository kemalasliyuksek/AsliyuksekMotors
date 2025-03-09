namespace AsliyuksekMotorsDesktop
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemAraclar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAracEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAracListele = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMusteriler = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMusteriEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMusteriListele = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemKiralama = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemYeniKiralama = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemKiralamaListele = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSatis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemYeniSatis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSatisListele = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUserManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemReports = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblWelcome = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAraclar,
            this.menuItemMusteriler,
            this.menuItemKiralama,
            this.menuItemSatis,
            this.menuItemUserManagement,
            this.menuItemReports});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemAraclar
            // 
            this.menuItemAraclar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAracEkle,
            this.menuItemAracListele});
            this.menuItemAraclar.Name = "menuItemAraclar";
            this.menuItemAraclar.Size = new System.Drawing.Size(56, 20);
            this.menuItemAraclar.Text = "Araçlar";
            // 
            // menuItemAracEkle
            // 
            this.menuItemAracEkle.Name = "menuItemAracEkle";
            this.menuItemAracEkle.Size = new System.Drawing.Size(142, 22);
            this.menuItemAracEkle.Text = "Yeni Araç";
            // 
            // menuItemAracListele
            // 
            this.menuItemAracListele.Name = "menuItemAracListele";
            this.menuItemAracListele.Size = new System.Drawing.Size(142, 22);
            this.menuItemAracListele.Text = "Araç Listesi";
            // 
            // menuItemMusteriler
            // 
            this.menuItemMusteriler.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemMusteriEkle,
            this.menuItemMusteriListele});
            this.menuItemMusteriler.Name = "menuItemMusteriler";
            this.menuItemMusteriler.Size = new System.Drawing.Size(72, 20);
            this.menuItemMusteriler.Text = "Müşteriler";
            // 
            // menuItemMusteriEkle
            // 
            this.menuItemMusteriEkle.Name = "menuItemMusteriEkle";
            this.menuItemMusteriEkle.Size = new System.Drawing.Size(158, 22);
            this.menuItemMusteriEkle.Text = "Yeni Müşteri";
            // 
            // menuItemMusteriListele
            // 
            this.menuItemMusteriListele.Name = "menuItemMusteriListele";
            this.menuItemMusteriListele.Size = new System.Drawing.Size(158, 22);
            this.menuItemMusteriListele.Text = "Müşteri Listesi";
            // 
            // menuItemKiralama
            // 
            this.menuItemKiralama.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemYeniKiralama,
            this.menuItemKiralamaListele});
            this.menuItemKiralama.Name = "menuItemKiralama";
            this.menuItemKiralama.Size = new System.Drawing.Size(65, 20);
            this.menuItemKiralama.Text = "Kiralama";
            // 
            // menuItemYeniKiralama
            // 
            this.menuItemYeniKiralama.Name = "menuItemYeniKiralama";
            this.menuItemYeniKiralama.Size = new System.Drawing.Size(164, 22);
            this.menuItemYeniKiralama.Text = "Yeni Kiralama";
            // 
            // menuItemKiralamaListele
            // 
            this.menuItemKiralamaListele.Name = "menuItemKiralamaListele";
            this.menuItemKiralamaListele.Size = new System.Drawing.Size(164, 22);
            this.menuItemKiralamaListele.Text = "Kiralama Listesi";
            // 
            // menuItemSatis
            // 
            this.menuItemSatis.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemYeniSatis,
            this.menuItemSatisListele});
            this.menuItemSatis.Name = "menuItemSatis";
            this.menuItemSatis.Size = new System.Drawing.Size(43, 20);
            this.menuItemSatis.Text = "Satış";
            // 
            // menuItemYeniSatis
            // 
            this.menuItemYeniSatis.Name = "menuItemYeniSatis";
            this.menuItemYeniSatis.Size = new System.Drawing.Size(142, 22);
            this.menuItemYeniSatis.Text = "Yeni Satış";
            // 
            // menuItemSatisListele
            // 
            this.menuItemSatisListele.Name = "menuItemSatisListele";
            this.menuItemSatisListele.Size = new System.Drawing.Size(142, 22);
            this.menuItemSatisListele.Text = "Satış Listesi";
            // 
            // menuItemUserManagement
            // 
            this.menuItemUserManagement.Name = "menuItemUserManagement";
            this.menuItemUserManagement.Size = new System.Drawing.Size(111, 20);
            this.menuItemUserManagement.Text = "Kullanıcı Yönetimi";
            // 
            // menuItemReports
            // 
            this.menuItemReports.Name = "menuItemReports";
            this.menuItemReports.Size = new System.Drawing.Size(63, 20);
            this.menuItemReports.Text = "Raporlar";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblWelcome,
            this.lblRole});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1024, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 17);
            // 
            // lblRole
            // 
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 60);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ASLIYÜKSEK MOTORS YÖNETİM PLATFORMU";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(937, 17);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Çıkış Yap";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASLIYÜKSEK MOTORS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemAraclar;
        private System.Windows.Forms.ToolStripMenuItem menuItemAracEkle;
        private System.Windows.Forms.ToolStripMenuItem menuItemAracListele;
        private System.Windows.Forms.ToolStripMenuItem menuItemMusteriler;
        private System.Windows.Forms.ToolStripMenuItem menuItemMusteriEkle;
        private System.Windows.Forms.ToolStripMenuItem menuItemMusteriListele;
        private System.Windows.Forms.ToolStripMenuItem menuItemKiralama;
        private System.Windows.Forms.ToolStripMenuItem menuItemYeniKiralama;
        private System.Windows.Forms.ToolStripMenuItem menuItemKiralamaListele;
        private System.Windows.Forms.ToolStripMenuItem menuItemSatis;
        private System.Windows.Forms.ToolStripMenuItem menuItemYeniSatis;
        private System.Windows.Forms.ToolStripMenuItem menuItemSatisListele;
        private System.Windows.Forms.ToolStripMenuItem menuItemUserManagement;
        private System.Windows.Forms.ToolStripMenuItem menuItemReports;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblWelcome;
        private System.Windows.Forms.ToolStripStatusLabel lblRole;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
    }
}