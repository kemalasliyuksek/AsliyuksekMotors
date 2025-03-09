namespace AsliyuksekMotorsDesktop
{
    partial class AracYonetimForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracYonetimForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.lblAracYonetimi = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.btnDetay = new System.Windows.Forms.Button();
            this.btnBakim = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnYeniArac = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.lblArama = new System.Windows.Forms.Label();
            this.dgvAraclar = new System.Windows.Forms.DataGridView();
            this.colPlaka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnSonrakiSayfa = new System.Windows.Forms.Button();
            this.btnOncekiSayfa = new System.Windows.Forms.Button();
            this.lblSayfa = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAraclar)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.btnCikis);
            this.panelHeader.Controls.Add(this.lblAracYonetimi);
            this.panelHeader.Controls.Add(this.btnGeri);
            this.panelHeader.Controls.Add(this.picLogo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(884, 40);
            this.panelHeader.TabIndex = 0;
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Location = new System.Drawing.Point(820, 5);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(50, 28);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // lblAracYonetimi
            // 
            this.lblAracYonetimi.AutoSize = true;
            this.lblAracYonetimi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAracYonetimi.Location = new System.Drawing.Point(128, 9);
            this.lblAracYonetimi.Name = "lblAracYonetimi";
            this.lblAracYonetimi.Size = new System.Drawing.Size(118, 21);
            this.lblAracYonetimi.TabIndex = 2;
            this.lblAracYonetimi.Text = "Araç Yönetimi";
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGeri.ForeColor = System.Drawing.Color.White;
            this.btnGeri.Location = new System.Drawing.Point(63, 5);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(50, 28);
            this.btnGeri.TabIndex = 1;
            this.btnGeri.Text = "< Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(10, 5);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(35, 28);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // panelButtons
            // 
            this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtons.Controls.Add(this.btnRaporlar);
            this.panelButtons.Controls.Add(this.btnDetay);
            this.panelButtons.Controls.Add(this.btnBakim);
            this.panelButtons.Controls.Add(this.btnSil);
            this.panelButtons.Controls.Add(this.btnDuzenle);
            this.panelButtons.Controls.Add(this.btnYeniArac);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 40);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(884, 40);
            this.panelButtons.TabIndex = 1;
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRaporlar.FlatAppearance.BorderSize = 0;
            this.btnRaporlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaporlar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRaporlar.ForeColor = System.Drawing.Color.White;
            this.btnRaporlar.Location = new System.Drawing.Point(355, 5);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(65, 28);
            this.btnRaporlar.TabIndex = 5;
            this.btnRaporlar.Text = "Raporlar";
            this.btnRaporlar.UseVisualStyleBackColor = false;
            this.btnRaporlar.Click += new System.EventHandler(this.btnRaporlar_Click);
            // 
            // btnDetay
            // 
            this.btnDetay.BackColor = System.Drawing.Color.SlateBlue;
            this.btnDetay.FlatAppearance.BorderSize = 0;
            this.btnDetay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDetay.ForeColor = System.Drawing.Color.White;
            this.btnDetay.Location = new System.Drawing.Point(290, 5);
            this.btnDetay.Name = "btnDetay";
            this.btnDetay.Size = new System.Drawing.Size(55, 28);
            this.btnDetay.TabIndex = 4;
            this.btnDetay.Text = "Detay";
            this.btnDetay.UseVisualStyleBackColor = false;
            this.btnDetay.Click += new System.EventHandler(this.btnDetay_Click);
            // 
            // btnBakim
            // 
            this.btnBakim.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBakim.FlatAppearance.BorderSize = 0;
            this.btnBakim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBakim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBakim.ForeColor = System.Drawing.Color.White;
            this.btnBakim.Location = new System.Drawing.Point(225, 5);
            this.btnBakim.Name = "btnBakim";
            this.btnBakim.Size = new System.Drawing.Size(55, 28);
            this.btnBakim.TabIndex = 3;
            this.btnBakim.Text = "Bakım";
            this.btnBakim.UseVisualStyleBackColor = false;
            this.btnBakim.Click += new System.EventHandler(this.btnBakim_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Crimson;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(175, 5);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(40, 28);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDuzenle.FlatAppearance.BorderSize = 0;
            this.btnDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuzenle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDuzenle.ForeColor = System.Drawing.Color.White;
            this.btnDuzenle.Location = new System.Drawing.Point(95, 5);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(70, 28);
            this.btnDuzenle.TabIndex = 1;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = false;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnYeniArac
            // 
            this.btnYeniArac.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnYeniArac.FlatAppearance.BorderSize = 0;
            this.btnYeniArac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniArac.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYeniArac.ForeColor = System.Drawing.Color.White;
            this.btnYeniArac.Location = new System.Drawing.Point(10, 5);
            this.btnYeniArac.Name = "btnYeniArac";
            this.btnYeniArac.Size = new System.Drawing.Size(75, 28);
            this.btnYeniArac.TabIndex = 0;
            this.btnYeniArac.Text = "+ Yeni Araç";
            this.btnYeniArac.UseVisualStyleBackColor = false;
            this.btnYeniArac.Click += new System.EventHandler(this.btnYeniArac_Click);
            // 
            // panelSearch
            // 
            this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearch.Controls.Add(this.btnFiltrele);
            this.panelSearch.Controls.Add(this.txtArama);
            this.panelSearch.Controls.Add(this.lblArama);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 80);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(884, 40);
            this.panelSearch.TabIndex = 2;
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrele.BackColor = System.Drawing.Color.DarkOrange;
            this.btnFiltrele.FlatAppearance.BorderSize = 0;
            this.btnFiltrele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrele.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFiltrele.ForeColor = System.Drawing.Color.White;
            this.btnFiltrele.Location = new System.Drawing.Point(790, 5);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(80, 28);
            this.btnFiltrele.TabIndex = 2;
            this.btnFiltrele.Text = "Filtrele ▼";
            this.btnFiltrele.UseVisualStyleBackColor = false;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // txtArama
            // 
            this.txtArama.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtArama.Location = new System.Drawing.Point(90, 6);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(688, 27);
            this.txtArama.TabIndex = 1;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // lblArama
            // 
            this.lblArama.AutoSize = true;
            this.lblArama.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArama.Location = new System.Drawing.Point(10, 9);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(59, 20);
            this.lblArama.TabIndex = 0;
            this.lblArama.Text = "Arama: ";
            // 
            // dgvAraclar
            // 
            this.dgvAraclar.AllowUserToAddRows = false;
            this.dgvAraclar.AllowUserToDeleteRows = false;
            this.dgvAraclar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAraclar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPlaka,
            this.colMarka,
            this.colModel,
            this.colYil,
            this.colDurum,
            this.colFiyat});
            this.dgvAraclar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAraclar.Location = new System.Drawing.Point(0, 120);
            this.dgvAraclar.MultiSelect = false;
            this.dgvAraclar.Name = "dgvAraclar";
            this.dgvAraclar.ReadOnly = true;
            this.dgvAraclar.RowHeadersVisible = false;
            this.dgvAraclar.RowTemplate.Height = 25;
            this.dgvAraclar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAraclar.Size = new System.Drawing.Size(884, 298);
            this.dgvAraclar.TabIndex = 3;
            // 
            // colPlaka
            // 
            this.colPlaka.DataPropertyName = "Plaka";
            this.colPlaka.HeaderText = "Plaka";
            this.colPlaka.Name = "colPlaka";
            this.colPlaka.ReadOnly = true;
            this.colPlaka.Width = 110;
            // 
            // colMarka
            // 
            this.colMarka.DataPropertyName = "Marka";
            this.colMarka.HeaderText = "Marka";
            this.colMarka.Name = "colMarka";
            this.colMarka.ReadOnly = true;
            this.colMarka.Width = 130;
            // 
            // colModel
            // 
            this.colModel.DataPropertyName = "Model";
            this.colModel.HeaderText = "Model";
            this.colModel.Name = "colModel";
            this.colModel.ReadOnly = true;
            this.colModel.Width = 150;
            // 
            // colYil
            // 
            this.colYil.DataPropertyName = "YapimYili";
            this.colYil.HeaderText = "Yıl";
            this.colYil.Name = "colYil";
            this.colYil.ReadOnly = true;
            this.colYil.Width = 80;
            // 
            // colDurum
            // 
            this.colDurum.DataPropertyName = "Durum";
            this.colDurum.HeaderText = "Durum";
            this.colDurum.Name = "colDurum";
            this.colDurum.ReadOnly = true;
            this.colDurum.Width = 150;
            // 
            // colFiyat
            // 
            this.colFiyat.DataPropertyName = "Fiyat";
            this.colFiyat.HeaderText = "Fiyat (G/A)";
            this.colFiyat.Name = "colFiyat";
            this.colFiyat.ReadOnly = true;
            this.colFiyat.Width = 150;
            // 
            // panelFooter
            // 
            this.panelFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFooter.Controls.Add(this.btnSonrakiSayfa);
            this.panelFooter.Controls.Add(this.btnOncekiSayfa);
            this.panelFooter.Controls.Add(this.lblSayfa);
            this.panelFooter.Controls.Add(this.lblToplam);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 378);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(884, 40);
            this.panelFooter.TabIndex = 4;
            // 
            // btnSonrakiSayfa
            // 
            this.btnSonrakiSayfa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSonrakiSayfa.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSonrakiSayfa.FlatAppearance.BorderSize = 0;
            this.btnSonrakiSayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSonrakiSayfa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSonrakiSayfa.ForeColor = System.Drawing.Color.Black;
            this.btnSonrakiSayfa.Location = new System.Drawing.Point(372, 7);
            this.btnSonrakiSayfa.Name = "btnSonrakiSayfa";
            this.btnSonrakiSayfa.Size = new System.Drawing.Size(25, 25);
            this.btnSonrakiSayfa.TabIndex = 3;
            this.btnSonrakiSayfa.Text = ">";
            this.btnSonrakiSayfa.UseVisualStyleBackColor = false;
            this.btnSonrakiSayfa.Click += new System.EventHandler(this.btnSonrakiSayfa_Click);
            // 
            // btnOncekiSayfa
            // 
            this.btnOncekiSayfa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOncekiSayfa.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOncekiSayfa.FlatAppearance.BorderSize = 0;
            this.btnOncekiSayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOncekiSayfa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOncekiSayfa.ForeColor = System.Drawing.Color.Black;
            this.btnOncekiSayfa.Location = new System.Drawing.Point(317, 7);
            this.btnOncekiSayfa.Name = "btnOncekiSayfa";
            this.btnOncekiSayfa.Size = new System.Drawing.Size(25, 25);
            this.btnOncekiSayfa.TabIndex = 2;
            this.btnOncekiSayfa.Text = "<";
            this.btnOncekiSayfa.UseVisualStyleBackColor = false;
            this.btnOncekiSayfa.Click += new System.EventHandler(this.btnOncekiSayfa_Click);
            // 
            // lblSayfa
            // 
            this.lblSayfa.AutoSize = true;
            this.lblSayfa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSayfa.Location = new System.Drawing.Point(350, 10);
            this.lblSayfa.Name = "lblSayfa";
            this.lblSayfa.Size = new System.Drawing.Size(31, 19);
            this.lblSayfa.TabIndex = 1;
            this.lblSayfa.Text = "1/2";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblToplam.Location = new System.Drawing.Point(10, 10);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(100, 19);
            this.lblToplam.TabIndex = 0;
            this.lblToplam.Text = "Toplam: 0 Araç";
            // 
            // AracYonetimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 418);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.dgvAraclar);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelHeader);
            this.Name = "AracYonetimForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Yönetimi";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAraclar)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label lblAracYonetimi;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.Button btnDetay;
        private System.Windows.Forms.Button btnBakim;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnYeniArac;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button btnFiltrele;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.DataGridView dgvAraclar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlaka;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarka;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYil;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDurum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFiyat;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnSonrakiSayfa;
        private System.Windows.Forms.Button btnOncekiSayfa;
        private System.Windows.Forms.Label lblSayfa;
        private System.Windows.Forms.Label lblToplam;
    }
}