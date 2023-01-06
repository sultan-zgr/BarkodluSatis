using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatis
{
    public partial class fFiyatGuncelle : Form
    {
        public fFiyatGuncelle()
        {
            InitializeComponent();
        }

        private void tBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                using (var db = new BarkodDBEntities())
                {
                    if (db.Urun.Any (x=> x.Barkod ==tBarkod.Text))
                    {
                        var getir = db.Urun.Where(x => x.Barkod == tBarkod.Text).SingleOrDefault();
                        lBarkod.Text = getir.Barkod;
                        lUrunAdi.Text = getir.UrunAdı;
                        double fiyat = Convert.ToDouble(getir.SatisFiyat);
                        lFiyat.Text = fiyat.ToString("C2");
                    }
                    else
                    {
                        MessageBox.Show("Ürün Kayıtlı Değil.");
                    }
                }
            }
        }

        private void bGuncelle_Click(object sender, EventArgs e)
        {
            if (tYeniFiyat.Text!="" && lBarkod.Text!="")
            {
                using (var db=new BarkodDBEntities())
                {
                    var guncelfiyat = db.Urun.Where(x => x.Barkod == lBarkod.Text).SingleOrDefault();
                    guncelfiyat.SatisFiyat = Islemler.DoubleYap(tYeniFiyat.Text);
                    int kdvorani = Convert.ToInt16(guncelfiyat.KdvOrani);
                    Math.Round(Islemler.DoubleYap(tYeniFiyat.Text) * kdvorani / 100, 2);
                    db.SaveChanges();
                    MessageBox.Show("Fiyat Güncellendi.");
                    lBarkod.Text = "";
                    lUrunAdi.Text = "";
                    lFiyat.Text = "";
                    tYeniFiyat.Clear();
                    tBarkod.Clear();
                    tBarkod.Focus();
                }
               
            } else
                {
                    MessageBox.Show("Hata !");
                tBarkod.Focus();
                }
        }

        private void fFiyatGuncelle_Load(object sender, EventArgs e)
        {
            lBarkod.Text = "";
            lUrunAdi.Text = "";
            lFiyat.Text = "";

        }
    }
}
