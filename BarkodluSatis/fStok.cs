﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatis
{
    public partial class fStok : Form
    {
        public fStok()
        {
            InitializeComponent();
        }

        private void bAra_Click(object sender, EventArgs e)
        {
            gridListe.DataSource = null;
            using (var db = new BarkodDBEntities())
            {
                if (cmbIslemTuru.Text != "")
                {
                    string urungrubu = cmbUrunGrubu.Text;
                    if (cmbIslemTuru.SelectedIndex == 0)
                    {
                        if (rbTumu.Checked)
                        {
                            db.Urun.OrderBy(x => x.Miktar).Load();
                            gridListe.DataSource = db.Urun.Local.ToBindingList();
                        }
                        else if (rbUrunGrubunGore.Checked)
                        {
                            db.Urun.Where(x => x.UrunGrup == urungrubu).OrderBy(x => x.Miktar).Load();
                            gridListe.DataSource = db.Urun.Local.ToBindingList();
                        }
                        else
                        {
                            MessageBox.Show("Lütfen ürün grubunu seçin.");
                        }
                    }
                    else if (cmbIslemTuru.SelectedIndex == 1)
                    {
                        DateTime baslangic = DateTime.Parse(dateBaslangic.Value.ToShortDateString());
                        DateTime bitis = DateTime.Parse(dateBitis.Value.ToShortDateString());
                        Convert.ToDateTime(baslangic);
                        Convert.ToDateTime(bitis);
                        bitis = bitis.AddDays(1);
                        if (rbTumu.Checked)
                        {
                            db.StokHareket.OrderByDescending(x => x.Tarih).Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).Load();
                            gridListe.DataSource = db.StokHareket.Local.ToBindingList();
                        }
                        else if (rbUrunGrubunGore.Checked)
                        {
                            db.StokHareket.OrderByDescending(x => x.Tarih).Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.UrunGrup.Contains(urungrubu)).Load();
                            gridListe.DataSource = db.StokHareket.Local.ToBindingList();
                        }
                        else
                        {
                            MessageBox.Show("Lütfen ürün grubunu seçin.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen işlem türünü seçin.");
                }
            }
            Islemler.GridDuzenle(gridListe);
        }
        BarkodDBEntities dbx = new BarkodDBEntities();
        private void fStok_Load(object sender, EventArgs e)
        {
            cmbUrunGrubu.DisplayMember = "UrunGrupAd";
            cmbUrunGrubu.ValueMember = "Id";
            cmbUrunGrubu.DataSource = dbx.UrunGrup.ToList();
        }

        private void tUrunAra_TextChanged(object sender, EventArgs e)
        {
            if (tUrunAra.Text.Length >= 3)
            {
                string urunad = tUrunAra.Text;
                using (var db = new BarkodDBEntities())
                {
                    if (cmbIslemTuru.SelectedIndex == 0)
                    {
                        db.Urun.Where(x => x.UrunAdı.Contains(urunad)).Load();
                        gridListe.DataSource = db.Urun.Local.ToBindingList();
                    }
                    else if (cmbIslemTuru.SelectedIndex == 1)
                    {
                        db.StokHareket.Where(x => x.UrunAd.Contains(urunad)).Load();
                        gridListe.DataSource = db.StokHareket.Local.ToBindingList();
                    }
                }
                Islemler.GridDuzenle(gridListe);
            }
        }

        private void bRapor_Click(object sender, EventArgs e)
        {
            if (cmbIslemTuru.SelectedIndex==0)
            {
                Raporlar.Baslik = cmbIslemTuru.Text + " RAPORU";
                Raporlar.TarihBaslangic = dateBaslangic.Value.ToShortDateString();
                Raporlar.TarihBitis = dateBitis.Value.ToShortDateString();
                Raporlar.StokRaporu(gridListe);
            }
            else if (cmbIslemTuru.SelectedIndex==1)
            {
                Raporlar.Baslik = cmbIslemTuru.Text + " RAPORU";
                Raporlar.TarihBaslangic = dateBaslangic.Value.ToShortDateString();
                Raporlar.TarihBitis = dateBitis.Value.ToShortDateString();
                Raporlar.StokIzlemeRaporu(gridListe);
            }

        }
    }
}
