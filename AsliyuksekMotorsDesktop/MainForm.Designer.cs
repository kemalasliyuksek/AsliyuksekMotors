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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.menuItemAraclar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMusteriler = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemKiralama = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSatis = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblWelcome = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSpacer = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSpacer2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelAktifKiralamalar = new System.Windows.Forms.Panel();
            this.lblAktifKiralamalar = new System.Windows.Forms.Label();
            this.lblKiralama = new System.Windows.Forms.Label();
            this.lblDonecek = new System.Windows.Forms.Label();
            this.lblGecikme = new System.Windows.Forms.Label();
            this.panelAracDurumu = new System.Windows.Forms.Panel();
            this.lblAracDurumu = new System.Windows.Forms.Label();
            this.lblMüsaitArac = new System.Windows.Forms.Label();
            this.lblKiralanmisArac = new System.Windows.Forms.Label();
            this.lblBakimdaArac = new System.Windows.Forms.Label();
            this.panelBugunIslemler = new System.Windows.Forms.Panel();
            this.lblBugunIslemler = new System.Windows.Forms.Label();
            this.lblYeniKiralama = new System.Windows.Forms.Label();
            this.lblIade = new System.Windows.Forms.Label();
            this.lblSatis = new System.Windows.Forms.Label();
            this.panelFinansDurumu = new System.Windows.Forms.Panel();
            this.lblFinansDurumu = new System.Windows.Forms.Label();
            this.lblGelir = new System.Windows.Forms.Label();
            this.lblGider = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelAktifKiralamalar.SuspendLayout();
            this.panelAracDurumu.SuspendLayout();
            this.panelBugunIslemler.SuspendLayout();
            this.panelFinansDurumu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAraclar,
            this.menuItemMusteriler,
            this.menuItemKiralama,
            this.menuItemSatis});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(60, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(12, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(40, 18);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // menuItemAraclar
            // 
            this.menuItemAraclar.Name = "menuItemAraclar";
            this.menuItemAraclar.Size = new System.Drawing.Size(90, 20);
            this.menuItemAraclar.Text = "Araç Yönetimi";
            // 
            // menuItemMusteriler
            // 
            this.menuItemMusteriler.Name = "menuItemMusteriler";
            this.menuItemMusteriler.Size = new System.Drawing.Size(72, 20);
            this.menuItemMusteriler.Text = "Müşteriler";
            // 
            // menuItemKiralama
            // 
            this.menuItemKiralama.Name = "menuItemKiralama";
            this.menuItemKiralama.Size = new System.Drawing.Size(77, 20);
            this.menuItemKiralama.Text = "Kiralamalar";
            // 
            // menuItemSatis
            // 
            this.menuItemSatis.Name = "menuItemSatis";
            this.menuItemSatis.Size = new System.Drawing.Size(43, 20);
            this.menuItemSatis.Text = "Satış";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblWelcome,
            this.lblSpacer,
            this.lblDate,
            this.lblSpacer2,
            this.lblVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(97, 17);
            this.lblWelcome.Text = "Kullanıcı: Admin";
            // 
            // lblSpacer
            // 
            this.lblSpacer.Name = "lblSpacer";
            this.lblSpacer.Size = new System.Drawing.Size(406, 17);
            this.lblSpacer.Spring = true;
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(96, 17);
            this.lblDate.Text = "Tarih: 05.03.2025";
            // 
            // lblSpacer2
            // 
            this.lblSpacer2.Name = "lblSpacer2";
            this.lblSpacer2.Size = new System.Drawing.Size(116, 17);
            this.lblSpacer2.Spring = true;
            // 
            // lblVersion
            // 
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(70, 17);
            this.lblVersion.Text = "Sürüm: 1.0";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelAktifKiralamalar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelAracDurumu, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelBugunIslemler, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelFinansDurumu, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 375);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panelAktifKiralamalar
            // 
            this.panelAktifKiralamalar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelAktifKiralamalar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAktifKiralamalar.Controls.Add(this.lblGecikme);
            this.panelAktifKiralamalar.Controls.Add(this.lblDonecek);
            this.panelAktifKiralamalar.Controls.Add(this.lblKiralama);
            this.panelAktifKiralamalar.Controls.Add(this.lblAktifKiralamalar);
            this.panelAktifKiralamalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAktifKiralamalar.Location = new System.Drawing.Point(10, 10);
            this.panelAktifKiralamalar.Margin = new System.Windows.Forms.Padding(10);
            this.panelAktifKiralamalar.Name = "panelAktifKiralamalar";
            this.panelAktifKiralamalar.Size = new System.Drawing.Size(368, 167);
            this.panelAktifKiralamalar.TabIndex = 0;
            // 
            // lblAktifKiralamalar
            // 
            this.lblAktifKiralamalar.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblAktifKiralamalar.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAktifKiralamalar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAktifKiralamalar.ForeColor = System.Drawing.Color.White;
            this.lblAktifKiralamalar.Location = new System.Drawing.Point(0, 0);
            this.lblAktifKiralamalar.Name = "lblAktifKiralamalar";
            this.lblAktifKiralamalar.Size = new System.Drawing.Size(366, 30);
            this.lblAktifKiralamalar.TabIndex = 0;
            this.lblAktifKiralamalar.Text = "Aktif Kiralamalar";
            this.lblAktifKiralamalar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKiralama
            // 
            this.lblKiralama.AutoSize = true;
            this.lblKiralama.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKiralama.Location = new System.Drawing.Point(15, 50);
            this.lblKiralama.Name = "lblKiralama";
            this.lblKiralama.Size = new System.Drawing.Size(91, 21);
            this.lblKiralama.TabIndex = 1;
            this.lblKiralama.Text = "5 Kiralama";
            // 
            // lblDonecek
            // 
            this.lblDonecek.AutoSize = true;
            this.lblDonecek.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDonecek.Location = new System.Drawing.Point(15, 85);
            this.lblDonecek.Name = "lblDonecek";
            this.lblDonecek.Size = new System.Drawing.Size(127, 21);
            this.lblDonecek.TabIndex = 2;
            this.lblDonecek.Text = "3 Bugün Dönecek";
            // 
            // lblGecikme
            // 
            this.lblGecikme.AutoSize = true;
            this.lblGecikme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGecikme.ForeColor = System.Drawing.Color.Crimson;
            this.lblGecikme.Location = new System.Drawing.Point(15, 120);
            this.lblGecikme.Name = "lblGecikme";
            this.lblGecikme.Size = new System.Drawing.Size(86, 21);
            this.lblGecikme.TabIndex = 3;
            this.lblGecikme.Text = "2 Gecikmiş";
            // 
            // panelAracDurumu
            // 
            this.panelAracDurumu.BackColor = System.Drawing.Color.PowderBlue;
            this.panelAracDurumu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAracDurumu.Controls.Add(this.lblBakimdaArac);
            this.panelAracDurumu.Controls.Add(this.lblKiralanmisArac);
            this.panelAracDurumu.Controls.Add(this.lblMüsaitArac);
            this.panelAracDurumu.Controls.Add(this.lblAracDurumu);
            this.panelAracDurumu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAracDurumu.Location = new System.Drawing.Point(398, 10);
            this.panelAracDurumu.Margin = new System.Windows.Forms.Padding(10);
            this.panelAracDurumu.Name = "panelAracDurumu";
            this.panelAracDurumu.Size = new System.Drawing.Size(368, 167);
            this.panelAracDurumu.TabIndex = 1;
            // 
            // lblAracDurumu
            // 
            this.lblAracDurumu.BackColor = System.Drawing.Color.DarkCyan;
            this.lblAracDurumu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAracDurumu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAracDurumu.ForeColor = System.Drawing.Color.White;
            this.lblAracDurumu.Location = new System.Drawing.Point(0, 0);
            this.lblAracDurumu.Name = "lblAracDurumu";
            this.lblAracDurumu.Size = new System.Drawing.Size(366, 30);
            this.lblAracDurumu.TabIndex = 0;
            this.lblAracDurumu.Text = "Araç Durumu";
            this.lblAracDurumu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMüsaitArac
            // 
            this.lblMüsaitArac.AutoSize = true;
            this.lblMüsaitArac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMüsaitArac.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblMüsaitArac.Location = new System.Drawing.Point(15, 50);
            this.lblMüsaitArac.Name = "lblMüsaitArac";
            this.lblMüsaitArac.Size = new System.Drawing.Size(76, 21);
            this.lblMüsaitArac.TabIndex = 1;
            this.lblMüsaitArac.Text = "15 Müsait";
            // 
            // lblKiralanmisArac
            // 
            this.lblKiralanmisArac.AutoSize = true;
            this.lblKiralanmisArac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKiralanmisArac.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblKiralanmisArac.Location = new System.Drawing.Point(15, 85);
            this.lblKiralanmisArac.Name = "lblKiralanmisArac";
            this.lblKiralanmisArac.Size = new System.Drawing.Size(108, 21);
            this.lblKiralanmisArac.TabIndex = 2;
            this.lblKiralanmisArac.Text = "22 Kiralanmış";
            // 
            // lblBakimdaArac
            // 
            this.lblBakimdaArac.AutoSize = true;
            this.lblBakimdaArac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBakimdaArac.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblBakimdaArac.Location = new System.Drawing.Point(15, 120);
            this.lblBakimdaArac.Name = "lblBakimdaArac";
            this.lblBakimdaArac.Size = new System.Drawing.Size(82, 21);
            this.lblBakimdaArac.TabIndex = 3;
            this.lblBakimdaArac.Text = "4 Bakımda";
            // 
            // panelBugunIslemler
            // 
            this.panelBugunIslemler.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panelBugunIslemler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBugunIslemler.Controls.Add(this.lblSatis);
            this.panelBugunIslemler.Controls.Add(this.lblIade);
            this.panelBugunIslemler.Controls.Add(this.lblYeniKiralama);
            this.panelBugunIslemler.Controls.Add(this.lblBugunIslemler);
            this.panelBugunIslemler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBugunIslemler.Location = new System.Drawing.Point(10, 197);
            this.panelBugunIslemler.Margin = new System.Windows.Forms.Padding(10);
            this.panelBugunIslemler.Name = "panelBugunIslemler";
            this.panelBugunIslemler.Size = new System.Drawing.Size(368, 168);
            this.panelBugunIslemler.TabIndex = 2;
            // 
            // lblBugunIslemler
            // 
            this.lblBugunIslemler.BackColor = System.Drawing.Color.Orange;
            this.lblBugunIslemler.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBugunIslemler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBugunIslemler.ForeColor = System.Drawing.Color.White;
            this.lblBugunIslemler.Location = new System.Drawing.Point(0, 0);
            this.lblBugunIslemler.Name = "lblBugunIslemler";
            this.lblBugunIslemler.Size = new System.Drawing.Size(366, 30);
            this.lblBugunIslemler.TabIndex = 0;
            this.lblBugunIslemler.Text = "Bugünkü İşlemler";
            this.lblBugunIslemler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYeniKiralama
            // 
            this.lblYeniKiralama.AutoSize = true;
            this.lblYeniKiralama.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYeniKiralama.Location = new System.Drawing.Point(15, 50);
            this.lblYeniKiralama.Name = "lblYeniKiralama";
            this.lblYeniKiralama.Size = new System.Drawing.Size(126, 21);
            this.lblYeniKiralama.TabIndex = 1;
            this.lblYeniKiralama.Text = "3 Yeni Kiralama";
            // 
            // lblIade
            // 
            this.lblIade.AutoSize = true;
            this.lblIade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIade.Location = new System.Drawing.Point(15, 85);
            this.lblIade.Name = "lblIade";
            this.lblIade.Size = new System.Drawing.Size(54, 21);
            this.lblIade.TabIndex = 2;
            this.lblIade.Text = "2 İade";
            // 
            // lblSatis
            // 
            this.lblSatis.AutoSize = true;
            this.lblSatis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSatis.Location = new System.Drawing.Point(15, 120);
            this.lblSatis.Name = "lblSatis";
            this.lblSatis.Size = new System.Drawing.Size(61, 21);
            this.lblSatis.TabIndex = 3;
            this.lblSatis.Text = "1 Satış";
            // 
            // panelFinansDurumu
            // 
            this.panelFinansDurumu.BackColor = System.Drawing.Color.MintCream;
            this.panelFinansDurumu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFinansDurumu.Controls.Add(this.lblNet);
            this.panelFinansDurumu.Controls.Add(this.lblGider);
            this.panelFinansDurumu.Controls.Add(this.lblGelir);
            this.panelFinansDurumu.Controls.Add(this.lblFinansDurumu);
            this.panelFinansDurumu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFinansDurumu.Location = new System.Drawing.Point(398, 197);
            this.panelFinansDurumu.Margin = new System.Windows.Forms.Padding(10);
            this.panelFinansDurumu.Name = "panelFinansDurumu";
            this.panelFinansDurumu.Size = new System.Drawing.Size(368, 168);
            this.panelFinansDurumu.TabIndex = 3;
            // 
            // lblFinansDurumu
            // 
            this.lblFinansDurumu.BackColor = System.Drawing.Color.ForestGreen;
            this.lblFinansDurumu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFinansDurumu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFinansDurumu.ForeColor = System.Drawing.Color.White;
            this.lblFinansDurumu.Location = new System.Drawing.Point(0, 0);
            this.lblFinansDurumu.Name = "lblFinansDurumu";
            this.lblFinansDurumu.Size = new System.Drawing.Size(366, 30);
            this.lblFinansDurumu.TabIndex = 0;
            this.lblFinansDurumu.Text = "Finans Durumu";
            this.lblFinansDurumu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGelir
            // 
            this.lblGelir.AutoSize = true;
            this.lblGelir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGelir.ForeColor = System.Drawing.Color.Green;
            this.lblGelir.Location = new System.Drawing.Point(15, 50);
            this.lblGelir.Name = "lblGelir";
            this.lblGelir.Size = new System.Drawing.Size(141, 21);
            this.lblGelir.TabIndex = 1;
            this.lblGelir.Text = "25.000 TL Gelir";
            // 
            // lblGider
            // 
            this.lblGider.AutoSize = true;
            this.lblGider.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGider.ForeColor = System.Drawing.Color.Brown;
            this.lblGider.Location = new System.Drawing.Point(15, 85);
            this.lblGider.Name = "lblGider";
            this.lblGider.Size = new System.Drawing.Size(131, 21);
            this.lblGider.TabIndex = 2;
            this.lblGider.Text = "5.000 TL Gider";
            // 
            // lblNet
            // 
            this.lblNet.AutoSize = true;
            this.lblNet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNet.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblNet.Location = new System.Drawing.Point(15, 120);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(127, 21);
            this.lblNet.TabIndex = 3;
            this.lblNet.Text = "20.000 TL Net";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASLIYÜKSEK MOTORS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelAktifKiralamalar.ResumeLayout(false);
            this.panelAktifKiralamalar.PerformLayout();
            this.panelAracDurumu.ResumeLayout(false);
            this.panelAracDurumu.PerformLayout();
            this.panelBugunIslemler.ResumeLayout(false);
            this.panelBugunIslemler.PerformLayout();
            this.panelFinansDurumu.ResumeLayout(false);
            this.panelFinansDurumu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.ToolStripMenuItem menuItemAraclar;
        private System.Windows.Forms.ToolStripMenuItem menuItemMusteriler;
        private System.Windows.Forms.ToolStripMenuItem menuItemKiralama;
        private System.Windows.Forms.ToolStripMenuItem menuItemSatis;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblWelcome;
        private System.Windows.Forms.ToolStripStatusLabel lblSpacer;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripStatusLabel lblSpacer2;
        private System.Windows.Forms.ToolStripStatusLabel lblVersion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelAktifKiralamalar;
        private System.Windows.Forms.Label lblGecikme;
        private System.Windows.Forms.Label lblDonecek;
        private System.Windows.Forms.Label lblKiralama;
        private System.Windows.Forms.Label lblAktifKiralamalar;
        private System.Windows.Forms.Panel panelAracDurumu;
        private System.Windows.Forms.Label lblBakimdaArac;
        private System.Windows.Forms.Label lblKiralanmisArac;
        private System.Windows.Forms.Label lblMüsaitArac;
        private System.Windows.Forms.Label lblAracDurumu;
        private System.Windows.Forms.Panel panelBugunIslemler;
        private System.Windows.Forms.Label lblSatis;
        private System.Windows.Forms.Label lblIade;
        private System.Windows.Forms.Label lblYeniKiralama;
        private System.Windows.Forms.Label lblBugunIslemler;
        private System.Windows.Forms.Panel panelFinansDurumu;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.Label lblGider;
        private System.Windows.Forms.Label lblGelir;
        private System.Windows.Forms.Label lblFinansDurumu;
    }
}