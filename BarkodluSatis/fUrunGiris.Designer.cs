
namespace BarkodluSatis
{
    partial class fUrunGiris
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chUrunTipi = new System.Windows.Forms.CheckBox();
            this.tAlisFiyati = new System.Windows.Forms.TextBox();
            this.tSatisFiyati = new System.Windows.Forms.TextBox();
            this.lKullanici = new BarkodluSatis.lStandart();
            this.lStandart = new BarkodluSatis.lStandart();
            this.tUrunSayisi = new BarkodluSatis.tStandart();
            this.lStandart6 = new BarkodluSatis.lStandart();
            this.tUrunAra = new BarkodluSatis.tStandart();
            this.lStandart5 = new BarkodluSatis.lStandart();
            this.bRapor = new BarkodluSatis.bStandart();
            this.bKaydet = new BarkodluSatis.bStandart();
            this.bIptal = new BarkodluSatis.bStandart();
            this.bBarkod = new BarkodluSatis.bStandart();
            this.bUrunGrubu = new BarkodluSatis.bStandart();
            this.tKdvOrani = new BarkodluSatis.tNumeric();
            this.tMiktar = new BarkodluSatis.tNumeric();
            this.lStandart1 = new BarkodluSatis.lStandart();
            this.lStandart2 = new BarkodluSatis.lStandart();
            this.lStandart3 = new BarkodluSatis.lStandart();
            this.lStandart4 = new BarkodluSatis.lStandart();
            this.tAciklama = new BarkodluSatis.tStandart();
            this.tUrunAdi = new BarkodluSatis.tStandart();
            this.tBarkod = new BarkodluSatis.tStandart();
            this.lUrunGrubu = new BarkodluSatis.lStandart();
            this.cmbUrunGrubu = new System.Windows.Forms.ComboBox();
            this.lAciklama = new BarkodluSatis.lStandart();
            this.lUrunAdi = new BarkodluSatis.lStandart();
            this.lBarkod = new BarkodluSatis.lStandart();
            this.gridUrunler = new BarkodluSatis.gridOzel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunler)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chUrunTipi);
            this.splitContainer1.Panel1.Controls.Add(this.tAlisFiyati);
            this.splitContainer1.Panel1.Controls.Add(this.tSatisFiyati);
            this.splitContainer1.Panel1.Controls.Add(this.lKullanici);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart);
            this.splitContainer1.Panel1.Controls.Add(this.tUrunSayisi);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart6);
            this.splitContainer1.Panel1.Controls.Add(this.tUrunAra);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart5);
            this.splitContainer1.Panel1.Controls.Add(this.bRapor);
            this.splitContainer1.Panel1.Controls.Add(this.bKaydet);
            this.splitContainer1.Panel1.Controls.Add(this.bIptal);
            this.splitContainer1.Panel1.Controls.Add(this.bBarkod);
            this.splitContainer1.Panel1.Controls.Add(this.bUrunGrubu);
            this.splitContainer1.Panel1.Controls.Add(this.tKdvOrani);
            this.splitContainer1.Panel1.Controls.Add(this.tMiktar);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart1);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart2);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart3);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart4);
            this.splitContainer1.Panel1.Controls.Add(this.tAciklama);
            this.splitContainer1.Panel1.Controls.Add(this.tUrunAdi);
            this.splitContainer1.Panel1.Controls.Add(this.tBarkod);
            this.splitContainer1.Panel1.Controls.Add(this.lUrunGrubu);
            this.splitContainer1.Panel1.Controls.Add(this.cmbUrunGrubu);
            this.splitContainer1.Panel1.Controls.Add(this.lAciklama);
            this.splitContainer1.Panel1.Controls.Add(this.lUrunAdi);
            this.splitContainer1.Panel1.Controls.Add(this.lBarkod);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridUrunler);
            this.splitContainer1.Size = new System.Drawing.Size(849, 515);
            this.splitContainer1.SplitterDistance = 302;
            this.splitContainer1.TabIndex = 0;
            // 
            // chUrunTipi
            // 
            this.chUrunTipi.Appearance = System.Windows.Forms.Appearance.Button;
            this.chUrunTipi.AutoSize = true;
            this.chUrunTipi.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.chUrunTipi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chUrunTipi.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chUrunTipi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chUrunTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chUrunTipi.ForeColor = System.Drawing.Color.White;
            this.chUrunTipi.Location = new System.Drawing.Point(111, 12);
            this.chUrunTipi.Name = "chUrunTipi";
            this.chUrunTipi.Size = new System.Drawing.Size(168, 27);
            this.chUrunTipi.TabIndex = 26;
            this.chUrunTipi.Text = "Barkodlu Ürün İşlemi";
            this.chUrunTipi.UseVisualStyleBackColor = false;
            this.chUrunTipi.CheckedChanged += new System.EventHandler(this.chUrunTipi_CheckedChanged);
            // 
            // tAlisFiyati
            // 
            this.tAlisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tAlisFiyati.Location = new System.Drawing.Point(478, 59);
            this.tAlisFiyati.Name = "tAlisFiyati";
            this.tAlisFiyati.Size = new System.Drawing.Size(115, 26);
            this.tAlisFiyati.TabIndex = 4;
            this.tAlisFiyati.Text = "0";
            this.tAlisFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tAlisFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tAlisFiyati_KeyPress);
            // 
            // tSatisFiyati
            // 
            this.tSatisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tSatisFiyati.Location = new System.Drawing.Point(478, 95);
            this.tSatisFiyati.Name = "tSatisFiyati";
            this.tSatisFiyati.Size = new System.Drawing.Size(115, 26);
            this.tSatisFiyati.TabIndex = 5;
            this.tSatisFiyati.Text = "0";
            this.tSatisFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tSatisFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tSatisFiyati_KeyPress);
            // 
            // lKullanici
            // 
            this.lKullanici.AutoSize = true;
            this.lKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lKullanici.ForeColor = System.Drawing.Color.DarkCyan;
            this.lKullanici.Location = new System.Drawing.Point(710, 9);
            this.lKullanici.Name = "lKullanici";
            this.lKullanici.Size = new System.Drawing.Size(14, 20);
            this.lKullanici.TabIndex = 25;
            this.lKullanici.Text = "-";
            // 
            // lStandart
            // 
            this.lStandart.AutoSize = true;
            this.lStandart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart.Location = new System.Drawing.Point(630, 9);
            this.lStandart.Name = "lStandart";
            this.lStandart.Size = new System.Drawing.Size(74, 20);
            this.lStandart.TabIndex = 24;
            this.lStandart.Text = "Kullanıcı :";
            // 
            // tUrunSayisi
            // 
            this.tUrunSayisi.BackColor = System.Drawing.Color.White;
            this.tUrunSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tUrunSayisi.Location = new System.Drawing.Point(476, 266);
            this.tUrunSayisi.Name = "tUrunSayisi";
            this.tUrunSayisi.ReadOnly = true;
            this.tUrunSayisi.Size = new System.Drawing.Size(228, 26);
            this.tUrunSayisi.TabIndex = 13;
            // 
            // lStandart6
            // 
            this.lStandart6.AutoSize = true;
            this.lStandart6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart6.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart6.Location = new System.Drawing.Point(377, 269);
            this.lStandart6.Name = "lStandart6";
            this.lStandart6.Size = new System.Drawing.Size(89, 20);
            this.lStandart6.TabIndex = 22;
            this.lStandart6.Text = "Ürün Sayısı";
            // 
            // tUrunAra
            // 
            this.tUrunAra.BackColor = System.Drawing.Color.White;
            this.tUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tUrunAra.Location = new System.Drawing.Point(111, 263);
            this.tUrunAra.Name = "tUrunAra";
            this.tUrunAra.Size = new System.Drawing.Size(228, 26);
            this.tUrunAra.TabIndex = 12;
            this.tUrunAra.TextChanged += new System.EventHandler(this.tUrunAra_TextChanged);
            // 
            // lStandart5
            // 
            this.lStandart5.AutoSize = true;
            this.lStandart5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart5.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart5.Location = new System.Drawing.Point(12, 266);
            this.lStandart5.Name = "lStandart5";
            this.lStandart5.Size = new System.Drawing.Size(73, 20);
            this.lStandart5.TabIndex = 20;
            this.lStandart5.Text = "Ürün Ara";
            // 
            // bRapor
            // 
            this.bRapor.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bRapor.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.bRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRapor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bRapor.ForeColor = System.Drawing.Color.White;
            this.bRapor.Location = new System.Drawing.Point(718, 206);
            this.bRapor.Margin = new System.Windows.Forms.Padding(0);
            this.bRapor.Name = "bRapor";
            this.bRapor.Size = new System.Drawing.Size(100, 53);
            this.bRapor.TabIndex = 19;
            this.bRapor.Text = "Rapor Al";
            this.bRapor.UseVisualStyleBackColor = false;
            // 
            // bKaydet
            // 
            this.bKaydet.BackColor = System.Drawing.Color.Firebrick;
            this.bKaydet.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.bKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bKaydet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bKaydet.ForeColor = System.Drawing.Color.White;
            this.bKaydet.Location = new System.Drawing.Point(609, 144);
            this.bKaydet.Margin = new System.Windows.Forms.Padding(0);
            this.bKaydet.Name = "bKaydet";
            this.bKaydet.Size = new System.Drawing.Size(112, 50);
            this.bKaydet.TabIndex = 8;
            this.bKaydet.Text = "Kaydet";
            this.bKaydet.UseVisualStyleBackColor = false;
            this.bKaydet.Click += new System.EventHandler(this.bKaydet_Click);
            // 
            // bIptal
            // 
            this.bIptal.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bIptal.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bIptal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bIptal.ForeColor = System.Drawing.Color.White;
            this.bIptal.Location = new System.Drawing.Point(609, 53);
            this.bIptal.Margin = new System.Windows.Forms.Padding(0);
            this.bIptal.Name = "bIptal";
            this.bIptal.Size = new System.Drawing.Size(112, 56);
            this.bIptal.TabIndex = 9;
            this.bIptal.Text = "İptal";
            this.bIptal.UseVisualStyleBackColor = false;
            this.bIptal.Click += new System.EventHandler(this.bIptal_Click);
            // 
            // bBarkod
            // 
            this.bBarkod.BackColor = System.Drawing.Color.Coral;
            this.bBarkod.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.bBarkod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBarkod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bBarkod.ForeColor = System.Drawing.Color.White;
            this.bBarkod.Location = new System.Drawing.Point(227, 196);
            this.bBarkod.Margin = new System.Windows.Forms.Padding(0);
            this.bBarkod.Name = "bBarkod";
            this.bBarkod.Size = new System.Drawing.Size(112, 53);
            this.bBarkod.TabIndex = 11;
            this.bBarkod.Text = "Barkod Oluştur";
            this.bBarkod.UseVisualStyleBackColor = false;
            this.bBarkod.Click += new System.EventHandler(this.bBarkod_Click);
            // 
            // bUrunGrubu
            // 
            this.bUrunGrubu.BackColor = System.Drawing.Color.Sienna;
            this.bUrunGrubu.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.bUrunGrubu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUrunGrubu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bUrunGrubu.ForeColor = System.Drawing.Color.White;
            this.bUrunGrubu.Location = new System.Drawing.Point(111, 196);
            this.bUrunGrubu.Margin = new System.Windows.Forms.Padding(0);
            this.bUrunGrubu.Name = "bUrunGrubu";
            this.bUrunGrubu.Size = new System.Drawing.Size(106, 53);
            this.bUrunGrubu.TabIndex = 10;
            this.bUrunGrubu.Text = "Ürün Grubu Ekle";
            this.bUrunGrubu.UseVisualStyleBackColor = false;
            this.bUrunGrubu.Click += new System.EventHandler(this.bUrunGrubu_Click);
            // 
            // tKdvOrani
            // 
            this.tKdvOrani.BackColor = System.Drawing.Color.White;
            this.tKdvOrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tKdvOrani.Location = new System.Drawing.Point(478, 168);
            this.tKdvOrani.Name = "tKdvOrani";
            this.tKdvOrani.Size = new System.Drawing.Size(115, 26);
            this.tKdvOrani.TabIndex = 7;
            this.tKdvOrani.Text = "8";
            this.tKdvOrani.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tMiktar
            // 
            this.tMiktar.BackColor = System.Drawing.Color.White;
            this.tMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tMiktar.Location = new System.Drawing.Point(478, 130);
            this.tMiktar.Name = "tMiktar";
            this.tMiktar.Size = new System.Drawing.Size(115, 26);
            this.tMiktar.TabIndex = 6;
            this.tMiktar.Text = "0";
            this.tMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lStandart1
            // 
            this.lStandart1.AutoSize = true;
            this.lStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart1.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart1.Location = new System.Drawing.Point(377, 171);
            this.lStandart1.Name = "lStandart1";
            this.lStandart1.Size = new System.Drawing.Size(84, 20);
            this.lStandart1.TabIndex = 11;
            this.lStandart1.Text = "KDV Oranı";
            // 
            // lStandart2
            // 
            this.lStandart2.AutoSize = true;
            this.lStandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart2.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart2.Location = new System.Drawing.Point(377, 133);
            this.lStandart2.Name = "lStandart2";
            this.lStandart2.Size = new System.Drawing.Size(52, 20);
            this.lStandart2.TabIndex = 10;
            this.lStandart2.Text = "Miktar";
            // 
            // lStandart3
            // 
            this.lStandart3.AutoSize = true;
            this.lStandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart3.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart3.Location = new System.Drawing.Point(377, 95);
            this.lStandart3.Name = "lStandart3";
            this.lStandart3.Size = new System.Drawing.Size(86, 20);
            this.lStandart3.TabIndex = 9;
            this.lStandart3.Text = "Satış Fiyatı";
            // 
            // lStandart4
            // 
            this.lStandart4.AutoSize = true;
            this.lStandart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart4.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart4.Location = new System.Drawing.Point(377, 59);
            this.lStandart4.Name = "lStandart4";
            this.lStandart4.Size = new System.Drawing.Size(75, 20);
            this.lStandart4.TabIndex = 8;
            this.lStandart4.Text = "Alış Fiyatı";
            // 
            // tAciklama
            // 
            this.tAciklama.BackColor = System.Drawing.Color.White;
            this.tAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tAciklama.Location = new System.Drawing.Point(111, 127);
            this.tAciklama.Name = "tAciklama";
            this.tAciklama.Size = new System.Drawing.Size(228, 26);
            this.tAciklama.TabIndex = 2;
            // 
            // tUrunAdi
            // 
            this.tUrunAdi.BackColor = System.Drawing.Color.White;
            this.tUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tUrunAdi.Location = new System.Drawing.Point(111, 89);
            this.tUrunAdi.Name = "tUrunAdi";
            this.tUrunAdi.Size = new System.Drawing.Size(228, 26);
            this.tUrunAdi.TabIndex = 1;
            // 
            // tBarkod
            // 
            this.tBarkod.BackColor = System.Drawing.Color.White;
            this.tBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tBarkod.Location = new System.Drawing.Point(111, 53);
            this.tBarkod.Name = "tBarkod";
            this.tBarkod.Size = new System.Drawing.Size(228, 26);
            this.tBarkod.TabIndex = 0;
            this.tBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBarkod_KeyDown);
            // 
            // lUrunGrubu
            // 
            this.lUrunGrubu.AutoSize = true;
            this.lUrunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lUrunGrubu.ForeColor = System.Drawing.Color.DarkCyan;
            this.lUrunGrubu.Location = new System.Drawing.Point(12, 168);
            this.lUrunGrubu.Name = "lUrunGrubu";
            this.lUrunGrubu.Size = new System.Drawing.Size(93, 20);
            this.lUrunGrubu.TabIndex = 4;
            this.lUrunGrubu.Text = "Ürün Grubu";
            // 
            // cmbUrunGrubu
            // 
            this.cmbUrunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUrunGrubu.FormattingEnabled = true;
            this.cmbUrunGrubu.Location = new System.Drawing.Point(111, 167);
            this.cmbUrunGrubu.Name = "cmbUrunGrubu";
            this.cmbUrunGrubu.Size = new System.Drawing.Size(228, 24);
            this.cmbUrunGrubu.TabIndex = 3;
            // 
            // lAciklama
            // 
            this.lAciklama.AutoSize = true;
            this.lAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lAciklama.ForeColor = System.Drawing.Color.DarkCyan;
            this.lAciklama.Location = new System.Drawing.Point(12, 130);
            this.lAciklama.Name = "lAciklama";
            this.lAciklama.Size = new System.Drawing.Size(73, 20);
            this.lAciklama.TabIndex = 2;
            this.lAciklama.Text = "Açıklama";
            // 
            // lUrunAdi
            // 
            this.lUrunAdi.AutoSize = true;
            this.lUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lUrunAdi.ForeColor = System.Drawing.Color.DarkCyan;
            this.lUrunAdi.Location = new System.Drawing.Point(12, 92);
            this.lUrunAdi.Name = "lUrunAdi";
            this.lUrunAdi.Size = new System.Drawing.Size(71, 20);
            this.lUrunAdi.TabIndex = 1;
            this.lUrunAdi.Text = "Ürün Adı";
            // 
            // lBarkod
            // 
            this.lBarkod.AutoSize = true;
            this.lBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lBarkod.ForeColor = System.Drawing.Color.DarkCyan;
            this.lBarkod.Location = new System.Drawing.Point(12, 56);
            this.lBarkod.Name = "lBarkod";
            this.lBarkod.Size = new System.Drawing.Size(60, 20);
            this.lBarkod.TabIndex = 0;
            this.lBarkod.Text = "Barkod";
            // 
            // gridUrunler
            // 
            this.gridUrunler.AllowUserToAddRows = false;
            this.gridUrunler.AllowUserToDeleteRows = false;
            this.gridUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUrunler.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridUrunler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridUrunler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUrunler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUrunler.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUrunler.EnableHeadersVisualStyles = false;
            this.gridUrunler.Location = new System.Drawing.Point(0, 0);
            this.gridUrunler.Name = "gridUrunler";
            this.gridUrunler.ReadOnly = true;
            this.gridUrunler.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.gridUrunler.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridUrunler.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.gridUrunler.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.gridUrunler.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.gridUrunler.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridUrunler.RowTemplate.Height = 30;
            this.gridUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUrunler.Size = new System.Drawing.Size(849, 209);
            this.gridUrunler.TabIndex = 0;
            this.gridUrunler.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.düzenleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 48);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // fUrunGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(849, 515);
            this.Controls.Add(this.splitContainer1);
            this.Name = "fUrunGiris";
            this.Text = "Ürün Giriş Formu";
            this.Load += new System.EventHandler(this.fUrunGiris_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunler)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private tStandart tAciklama;
        private tStandart tUrunAdi;
        private lStandart lUrunGrubu;
        private lStandart lAciklama;
        private lStandart lUrunAdi;
        private lStandart lBarkod;
        private tStandart tUrunSayisi;
        private lStandart lStandart6;
        private tStandart tUrunAra;
        private lStandart lStandart5;
        private bStandart bRapor;
        private bStandart bKaydet;
        private bStandart bIptal;
        private bStandart bBarkod;
        private bStandart bUrunGrubu;
        private tNumeric tKdvOrani;
        private tNumeric tMiktar;
        private lStandart lStandart1;
        private lStandart lStandart2;
        private lStandart lStandart3;
        private lStandart lStandart4;
        internal tStandart tBarkod;
        private lStandart lStandart;
        private gridOzel gridUrunler;
        public System.Windows.Forms.ComboBox cmbUrunGrubu;
        private System.Windows.Forms.TextBox tSatisFiyati;
        private System.Windows.Forms.TextBox tAlisFiyati;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.CheckBox chUrunTipi;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        internal lStandart lKullanici;
    }
}