
namespace BarkodluSatis
{
    partial class fStok
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lStandart1 = new BarkodluSatis.lStandart();
            this.cmbIslemTuru = new System.Windows.Forms.ComboBox();
            this.bAra = new BarkodluSatis.bStandart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbUrunGrubunGore = new System.Windows.Forms.RadioButton();
            this.lStandart2 = new BarkodluSatis.lStandart();
            this.rbTumu = new System.Windows.Forms.RadioButton();
            this.panelTarihler = new System.Windows.Forms.Panel();
            this.dateBitis = new System.Windows.Forms.DateTimePicker();
            this.lStandart5 = new BarkodluSatis.lStandart();
            this.dateBaslangic = new System.Windows.Forms.DateTimePicker();
            this.lStandart4 = new BarkodluSatis.lStandart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbUrunGrubu = new System.Windows.Forms.ComboBox();
            this.lStandart3 = new BarkodluSatis.lStandart();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lKullanici = new BarkodluSatis.lStandart();
            this.bRapor = new BarkodluSatis.bStandart();
            this.tUrunAra = new BarkodluSatis.tStandart();
            this.lStandart6 = new BarkodluSatis.lStandart();
            this.gridListe = new BarkodluSatis.gridOzel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTarihler.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListe)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1.Controls.Add(this.bAra);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.panelTarihler);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1003, 379);
            this.splitContainer1.SplitterDistance = 276;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lStandart1);
            this.panel4.Controls.Add(this.cmbIslemTuru);
            this.panel4.Location = new System.Drawing.Point(16, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 49);
            this.panel4.TabIndex = 7;
            // 
            // lStandart1
            // 
            this.lStandart1.AutoSize = true;
            this.lStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart1.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart1.Location = new System.Drawing.Point(3, 0);
            this.lStandart1.Name = "lStandart1";
            this.lStandart1.Size = new System.Drawing.Size(83, 20);
            this.lStandart1.TabIndex = 0;
            this.lStandart1.Text = "İşlem Türü";
            this.lStandart1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbIslemTuru
            // 
            this.cmbIslemTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIslemTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIslemTuru.FormattingEnabled = true;
            this.cmbIslemTuru.Items.AddRange(new object[] {
            "Stok Durumu",
            "Stok Giriş İzleme"});
            this.cmbIslemTuru.Location = new System.Drawing.Point(7, 23);
            this.cmbIslemTuru.Name = "cmbIslemTuru";
            this.cmbIslemTuru.Size = new System.Drawing.Size(237, 24);
            this.cmbIslemTuru.TabIndex = 1;
            // 
            // bAra
            // 
            this.bAra.BackColor = System.Drawing.Color.YellowGreen;
            this.bAra.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.bAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bAra.ForeColor = System.Drawing.Color.White;
            this.bAra.Location = new System.Drawing.Point(185, 314);
            this.bAra.Margin = new System.Windows.Forms.Padding(0);
            this.bAra.Name = "bAra";
            this.bAra.Size = new System.Drawing.Size(78, 39);
            this.bAra.TabIndex = 0;
            this.bAra.Text = "Ara";
            this.bAra.UseVisualStyleBackColor = false;
            this.bAra.Click += new System.EventHandler(this.bAra_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbUrunGrubunGore);
            this.panel1.Controls.Add(this.lStandart2);
            this.panel1.Controls.Add(this.rbTumu);
            this.panel1.Location = new System.Drawing.Point(16, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 71);
            this.panel1.TabIndex = 4;
            // 
            // rbUrunGrubunGore
            // 
            this.rbUrunGrubunGore.AutoSize = true;
            this.rbUrunGrubunGore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbUrunGrubunGore.Location = new System.Drawing.Point(7, 47);
            this.rbUrunGrubunGore.Name = "rbUrunGrubunGore";
            this.rbUrunGrubunGore.Size = new System.Drawing.Size(141, 20);
            this.rbUrunGrubunGore.TabIndex = 4;
            this.rbUrunGrubunGore.TabStop = true;
            this.rbUrunGrubunGore.Text = "Ürün Grubuna Göre";
            this.rbUrunGrubunGore.UseVisualStyleBackColor = true;
            // 
            // lStandart2
            // 
            this.lStandart2.AutoSize = true;
            this.lStandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart2.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart2.Location = new System.Drawing.Point(3, 0);
            this.lStandart2.Name = "lStandart2";
            this.lStandart2.Size = new System.Drawing.Size(114, 20);
            this.lStandart2.TabIndex = 2;
            this.lStandart2.Text = "Filtreleme Türü";
            this.lStandart2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbTumu
            // 
            this.rbTumu.AutoSize = true;
            this.rbTumu.Checked = true;
            this.rbTumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbTumu.Location = new System.Drawing.Point(7, 24);
            this.rbTumu.Name = "rbTumu";
            this.rbTumu.Size = new System.Drawing.Size(60, 20);
            this.rbTumu.TabIndex = 3;
            this.rbTumu.TabStop = true;
            this.rbTumu.Text = "Tümü";
            this.rbTumu.UseVisualStyleBackColor = true;
            // 
            // panelTarihler
            // 
            this.panelTarihler.Controls.Add(this.dateBitis);
            this.panelTarihler.Controls.Add(this.lStandart5);
            this.panelTarihler.Controls.Add(this.dateBaslangic);
            this.panelTarihler.Controls.Add(this.lStandart4);
            this.panelTarihler.Location = new System.Drawing.Point(16, 203);
            this.panelTarihler.Name = "panelTarihler";
            this.panelTarihler.Size = new System.Drawing.Size(247, 108);
            this.panelTarihler.TabIndex = 6;
            // 
            // dateBitis
            // 
            this.dateBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateBitis.Location = new System.Drawing.Point(7, 80);
            this.dateBitis.Name = "dateBitis";
            this.dateBitis.Size = new System.Drawing.Size(200, 22);
            this.dateBitis.TabIndex = 5;
            // 
            // lStandart5
            // 
            this.lStandart5.AutoSize = true;
            this.lStandart5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart5.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart5.Location = new System.Drawing.Point(3, 56);
            this.lStandart5.Name = "lStandart5";
            this.lStandart5.Size = new System.Drawing.Size(81, 20);
            this.lStandart5.TabIndex = 4;
            this.lStandart5.Text = "Bitiş Tarihi";
            this.lStandart5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateBaslangic
            // 
            this.dateBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateBaslangic.Location = new System.Drawing.Point(7, 24);
            this.dateBaslangic.Name = "dateBaslangic";
            this.dateBaslangic.Size = new System.Drawing.Size(200, 22);
            this.dateBaslangic.TabIndex = 3;
            // 
            // lStandart4
            // 
            this.lStandart4.AutoSize = true;
            this.lStandart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart4.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart4.Location = new System.Drawing.Point(3, 0);
            this.lStandart4.Name = "lStandart4";
            this.lStandart4.Size = new System.Drawing.Size(120, 20);
            this.lStandart4.TabIndex = 2;
            this.lStandart4.Text = "Başlangıç Tarihi";
            this.lStandart4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbUrunGrubu);
            this.panel2.Controls.Add(this.lStandart3);
            this.panel2.Location = new System.Drawing.Point(16, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 52);
            this.panel2.TabIndex = 5;
            // 
            // cmbUrunGrubu
            // 
            this.cmbUrunGrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUrunGrubu.FormattingEnabled = true;
            this.cmbUrunGrubu.Location = new System.Drawing.Point(7, 23);
            this.cmbUrunGrubu.Name = "cmbUrunGrubu";
            this.cmbUrunGrubu.Size = new System.Drawing.Size(237, 24);
            this.cmbUrunGrubu.TabIndex = 3;
            // 
            // lStandart3
            // 
            this.lStandart3.AutoSize = true;
            this.lStandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart3.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart3.Location = new System.Drawing.Point(3, 0);
            this.lStandart3.Name = "lStandart3";
            this.lStandart3.Size = new System.Drawing.Size(93, 20);
            this.lStandart3.TabIndex = 2;
            this.lStandart3.Text = "Ürün Grubu";
            this.lStandart3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer2.Panel1.Controls.Add(this.lKullanici);
            this.splitContainer2.Panel1.Controls.Add(this.bRapor);
            this.splitContainer2.Panel1.Controls.Add(this.tUrunAra);
            this.splitContainer2.Panel1.Controls.Add(this.lStandart6);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gridListe);
            this.splitContainer2.Size = new System.Drawing.Size(723, 379);
            this.splitContainer2.SplitterDistance = 80;
            this.splitContainer2.TabIndex = 0;
            // 
            // lKullanici
            // 
            this.lKullanici.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lKullanici.AutoSize = true;
            this.lKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lKullanici.ForeColor = System.Drawing.Color.DarkCyan;
            this.lKullanici.Location = new System.Drawing.Point(610, 12);
            this.lKullanici.Name = "lKullanici";
            this.lKullanici.Size = new System.Drawing.Size(66, 20);
            this.lKullanici.TabIndex = 48;
            this.lKullanici.Text = "Kullanıcı";
            // 
            // bRapor
            // 
            this.bRapor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bRapor.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bRapor.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.bRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRapor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bRapor.ForeColor = System.Drawing.Color.White;
            this.bRapor.Location = new System.Drawing.Point(614, 36);
            this.bRapor.Margin = new System.Windows.Forms.Padding(0);
            this.bRapor.Name = "bRapor";
            this.bRapor.Size = new System.Drawing.Size(100, 35);
            this.bRapor.TabIndex = 47;
            this.bRapor.Text = "Rapor Al";
            this.bRapor.UseVisualStyleBackColor = false;
            this.bRapor.Click += new System.EventHandler(this.bRapor_Click);
            // 
            // tUrunAra
            // 
            this.tUrunAra.BackColor = System.Drawing.Color.White;
            this.tUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tUrunAra.Location = new System.Drawing.Point(82, 6);
            this.tUrunAra.Name = "tUrunAra";
            this.tUrunAra.Size = new System.Drawing.Size(250, 26);
            this.tUrunAra.TabIndex = 3;
            this.tUrunAra.TextChanged += new System.EventHandler(this.tUrunAra_TextChanged);
            // 
            // lStandart6
            // 
            this.lStandart6.AutoSize = true;
            this.lStandart6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart6.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart6.Location = new System.Drawing.Point(3, 9);
            this.lStandart6.Name = "lStandart6";
            this.lStandart6.Size = new System.Drawing.Size(73, 20);
            this.lStandart6.TabIndex = 2;
            this.lStandart6.Text = "Ürün Ara";
            this.lStandart6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridListe
            // 
            this.gridListe.AllowUserToAddRows = false;
            this.gridListe.AllowUserToDeleteRows = false;
            this.gridListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridListe.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridListe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListe.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridListe.EnableHeadersVisualStyles = false;
            this.gridListe.Location = new System.Drawing.Point(0, 0);
            this.gridListe.Margin = new System.Windows.Forms.Padding(0);
            this.gridListe.Name = "gridListe";
            this.gridListe.ReadOnly = true;
            this.gridListe.RowHeadersVisible = false;
            this.gridListe.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.gridListe.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.gridListe.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridListe.RowTemplate.Height = 30;
            this.gridListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridListe.Size = new System.Drawing.Size(723, 295);
            this.gridListe.TabIndex = 0;
            // 
            // fStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1003, 379);
            this.Controls.Add(this.splitContainer1);
            this.Name = "fStok";
            this.Text = "Stok İşlemleri";
            this.Load += new System.EventHandler(this.fStok_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTarihler.ResumeLayout(false);
            this.panelTarihler.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbUrunGrubunGore;
        private lStandart lStandart2;
        private System.Windows.Forms.RadioButton rbTumu;
        private System.Windows.Forms.ComboBox cmbIslemTuru;
        private lStandart lStandart1;
        private System.Windows.Forms.Panel panelTarihler;
        private System.Windows.Forms.DateTimePicker dateBitis;
        private lStandart lStandart5;
        private System.Windows.Forms.DateTimePicker dateBaslangic;
        private lStandart lStandart4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbUrunGrubu;
        private lStandart lStandart3;
        private System.Windows.Forms.Panel panel4;
        private bStandart bAra;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private tStandart tUrunAra;
        private lStandart lStandart6;
        private gridOzel gridListe;
        private bStandart bRapor;
        internal lStandart lKullanici;
    }
}