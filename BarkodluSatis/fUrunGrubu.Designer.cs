﻿
namespace BarkodluSatis
{
    partial class fUrunGrubu
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
            this.lStandart1 = new BarkodluSatis.lStandart();
            this.tUrunGrupAd = new BarkodluSatis.tStandart();
            this.listUrunGrup = new System.Windows.Forms.ListBox();
            this.bEkle = new BarkodluSatis.bStandart();
            this.bSil = new BarkodluSatis.bStandart();
            this.SuspendLayout();
            // 
            // lStandart1
            // 
            this.lStandart1.AutoSize = true;
            this.lStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart1.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart1.Location = new System.Drawing.Point(13, 13);
            this.lStandart1.Name = "lStandart1";
            this.lStandart1.Size = new System.Drawing.Size(120, 20);
            this.lStandart1.TabIndex = 0;
            this.lStandart1.Text = "Ürün Grubu Adı";
            // 
            // tUrunGrupAd
            // 
            this.tUrunGrupAd.BackColor = System.Drawing.Color.White;
            this.tUrunGrupAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tUrunGrupAd.Location = new System.Drawing.Point(17, 36);
            this.tUrunGrupAd.Name = "tUrunGrupAd";
            this.tUrunGrupAd.Size = new System.Drawing.Size(211, 26);
            this.tUrunGrupAd.TabIndex = 1;
            // 
            // listUrunGrup
            // 
            this.listUrunGrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listUrunGrup.FormattingEnabled = true;
            this.listUrunGrup.ItemHeight = 18;
            this.listUrunGrup.Location = new System.Drawing.Point(17, 68);
            this.listUrunGrup.Name = "listUrunGrup";
            this.listUrunGrup.Size = new System.Drawing.Size(211, 184);
            this.listUrunGrup.TabIndex = 2;
            // 
            // bEkle
            // 
            this.bEkle.BackColor = System.Drawing.Color.Teal;
            this.bEkle.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.bEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEkle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bEkle.ForeColor = System.Drawing.Color.White;
            this.bEkle.Location = new System.Drawing.Point(129, 255);
            this.bEkle.Margin = new System.Windows.Forms.Padding(0);
            this.bEkle.Name = "bEkle";
            this.bEkle.Size = new System.Drawing.Size(87, 38);
            this.bEkle.TabIndex = 0;
            this.bEkle.Text = "Ekle";
            this.bEkle.UseVisualStyleBackColor = false;
            this.bEkle.Click += new System.EventHandler(this.bEkle_Click);
            // 
            // bSil
            // 
            this.bSil.BackColor = System.Drawing.Color.Tomato;
            this.bSil.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.bSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSil.ForeColor = System.Drawing.Color.White;
            this.bSil.Location = new System.Drawing.Point(27, 255);
            this.bSil.Margin = new System.Windows.Forms.Padding(0);
            this.bSil.Name = "bSil";
            this.bSil.Size = new System.Drawing.Size(82, 38);
            this.bSil.TabIndex = 3;
            this.bSil.Text = "Sil";
            this.bSil.UseVisualStyleBackColor = false;
            this.bSil.Click += new System.EventHandler(this.bSil_Click);
            // 
            // fUrunGrubu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(244, 324);
            this.Controls.Add(this.bSil);
            this.Controls.Add(this.bEkle);
            this.Controls.Add(this.listUrunGrup);
            this.Controls.Add(this.tUrunGrupAd);
            this.Controls.Add(this.lStandart1);
            this.Name = "fUrunGrubu";
            this.Text = "Ürün Grubu İşlemleri";
            this.Load += new System.EventHandler(this.fUrunGrubu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lStandart lStandart1;
        private tStandart tUrunGrupAd;
        private System.Windows.Forms.ListBox listUrunGrup;
        private bStandart bEkle;
        private bStandart bSil;
    }
}