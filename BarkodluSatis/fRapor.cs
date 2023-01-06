using System;
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
    public partial class fRapor : Form
    {
        public fRapor()
        {
            InitializeComponent();
        }

        public void bGoster_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DateTime baslangic = DateTime.Parse(dateBaslangic.Value.ToShortDateString()); //Parse bir veriyi belirtilen bir veri türüne dönüştürmede kullanılır.
            DateTime bitis = DateTime.Parse(dateBitis.Value.ToShortDateString());
            bitis = bitis.AddDays(1);
            using (var db = new BarkodDBEntities())
            {
                if (listeFiltrelemeTuru.SelectedIndex == 0) // Tümünü getir
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).OrderByDescending(x => x.Tarih).Load();
                    var islemozet = db.IslemOzet.Local.ToBindingList();
                    gridListe.DataSource = islemozet;

                    tSatisNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == false && x.Gelir == false && x.Gider == false).Sum(x => x.Nakit)).ToString("C2");
                    tSatisKart.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == false && x.Gelir == false && x.Gider == false).Sum(s => s.Kart)).ToString("C2");

                    tIadeKart.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == true).Sum(x => x.Nakit)).ToString("C2");
                    tIadeNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == true).Sum(x => x.Kart)).ToString("C2");

                    tGelirNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Gelir == true).Sum(x => x.Nakit)).ToString("C2");
                    tGelirKart.Text = Convert.ToDouble(islemozet.Where(x => x.Gelir == true).Sum(x => x.Kart)).ToString("C2");

                    tGiderNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Gider == true).Sum(x => x.Nakit)).ToString("C2");
                    tGiderKart.Text = Convert.ToDouble(islemozet.Where(x => x.Gider == true).Sum(x => x.Kart)).ToString("C2");

                    db.Satis.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).Load();
                    var satistablosu = db.Satis.Local.ToBindingList();
                    double kdvtutarisatis = Islemler.DoubleYap(satistablosu.Where(x => x.Iade == false).Sum(x => x.KdvTutari).ToString());
                    double kdvtutariiade = Islemler.DoubleYap(satistablosu.Where(x => x.Iade == true).Sum(x => x.KdvTutari).ToString());
                    tKdvToplam.Text = (kdvtutarisatis - kdvtutariiade).ToString("C2");
                }
                else if (listeFiltrelemeTuru.SelectedIndex == 1) //Satışlar
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Iade == false && x.Gider == false).Load();
                    var islemozet = db.IslemOzet.Local.ToBindingList();
                    gridListe.DataSource = islemozet;
                }
                else if (listeFiltrelemeTuru.SelectedIndex == 2 ) //İadeler
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Iade == true).Load();
                    gridListe.DataSource = db.IslemOzet.Local.ToBindingList();
                }
                else if (listeFiltrelemeTuru.SelectedIndex == 3) // Giderler
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Gider == true).Load();
                    gridListe.DataSource = db.IslemOzet.Local.ToBindingList();
                }
                else if (listeFiltrelemeTuru.SelectedIndex == 4)
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Gelir == true).Load();
                    gridListe.DataSource = db.IslemOzet.Local.ToBindingList();
                }
            }
            Islemler.GridDuzenle(gridListe);
            Cursor.Current = Cursors.WaitCursor;
        }

        private void fRapor_Load(object sender, EventArgs e)
        {
            listeFiltrelemeTuru.SelectedIndex = 0;
            tKartKomisyon.Text = Islemler.KartKomisyon().ToString();
            bGoster_Click(null, null);
        }

        private void gridListe_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex==2 || e.ColumnIndex==6 || e.ColumnIndex ==7)
            {
                if (e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = (value) ? "Evet" : "Hayır";
                    e.FormattingApplied = true;
                }
            }
        }
        private void bGelirEkle_Click(object sender, EventArgs e)
        {
            fGelirGider f = new fGelirGider();
            f.gelirgider = "GELIR";
            f.kullanici = lKullanici.Text;
            f.Enabled = true;
            f.ShowDialog();
        }

        private void bGiderEkle_Click(object sender, EventArgs e)
        {
            fGelirGider f = new fGelirGider();
            f.gelirgider = "GIDER";
            f.kullanici = lKullanici.Text;
            f.Enabled = true;
            f.ShowDialog();
        }

        private void detayGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridListe.Rows.Count >0)
            {
                int islemno = Convert.ToInt32(gridListe.CurrentRow.Cells["IslemNo"].Value.ToString());
                if (true)
                {
                    fDetayGoster f = new fDetayGoster();
                    f.islemno = islemno;
                    f.ShowDialog();

                }
            }
        }

        private void bRapor_Click(object sender, EventArgs e)
        {
            Raporlar.Baslik = "GENEL RAPOR";
            Raporlar.SatisKart = tSatisKart.Text;
            Raporlar.SatisNakit = tSatisNakit.Text;
            Raporlar.IadeKart = tIadeKart.Text;
            Raporlar.IadeNakit = tIadeNakit.Text;
            Raporlar.GelirKart = tGelirKart.Text;
            Raporlar.GelirNakit = tGelirKart.Text;
            Raporlar.GiderKart = tGiderKart.Text;
            Raporlar.GiderNakit = tGiderNakit.Text;
            Raporlar.TarihBaslangic = dateBaslangic.Value.ToShortDateString();
            Raporlar.TarihBitis = dateBitis.Value.ToShortDateString();
            Raporlar.KdvToplam = tKdvToplam.Text;
            Raporlar.KdvToplam = tKdvToplam.Text;
            Raporlar.KartKomisyon = tKartKomisyon.Text;
            Raporlar.RaporSayfasiRaporu(gridListe);
        }
    }
}
