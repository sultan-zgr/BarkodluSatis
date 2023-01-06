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
    public partial class fAyarlar : Form
    {
        public fAyarlar()
        {
            InitializeComponent();
        }
        private void Temizle()
        {
            tAdSoyad.Clear();
            tTelefon.Clear();
            tEPosta.Clear();
            tKullaniciAdi.Clear();
            tSifre.Clear();
            cbSatisEkrani.Checked = false;
            chRaporEkrani.Checked = false;
            chStok.Checked = false;
            cbUrunGiris.Checked = false;
            cbAyarlar.Checked = false;
            cbFiyatGuncelle.Checked = false;
            cbYedekleme.Checked = false;
            tSifreTekrar.Clear();
        }

        private void bKaydet_Click(object sender, EventArgs e)
        {
            if (bKaydet.Text == "Kaydet")
            {
                if (tAdSoyad.Text != "" && tTelefon.Text != "" && tKullaniciAdi.Text != "" && tSifre.Text != "" && tSifreTekrar.Text != "")
                {
                    if (tSifre.Text == tSifreTekrar.Text)
                    {
                        try
                        {
                            using (var db = new BarkodDBEntities())
                            {
                                if (!db.Kullanici.Any(x => x.KullaniciAd == tKullaniciAdi.Text))
                                {
                                    Kullanici k = new Kullanici();
                                    k.AdSoyad = tAdSoyad.Text;
                                    k.Telefon = tTelefon.Text;
                                    k.EPosta = tEPosta.Text;
                                    k.KullaniciAd = tKullaniciAdi.Text;
                                    k.Sifre = tSifre.Text;
                                    k.Satis = cbSatisEkrani.Checked;
                                    k.Rapor = chRaporEkrani.Checked;
                                    k.Stok = chStok.Checked;
                                    k.UrunGiris = cbUrunGiris.Checked;
                                    k.Ayarlar = cbAyarlar.Checked;
                                    k.FiyatGuncelle = cbFiyatGuncelle.Checked;
                                    k.Yedekleme = cbYedekleme.Checked;
                                    db.Kullanici.Add(k);
                                    db.SaveChanges();
                                    gridListeKullanici.DataSource = db.Kullanici.Select(x => new { x.AdSoyad, x.KullaniciAd, x.Telefon }).ToList();
                                    Temizle();

                                }
                                else
                                {
                                    MessageBox.Show(" Bu kullanıcı zaten kayıtlı?");
                                }
                            }

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifreler uyuşmuyor!");
                    }
                }
                else
                {
                    MessageBox.Show("Eksik bilgi girişi yaptınız.");
                }
            }
            else if (bKaydet.Text == "Düzenle/Kaydet")
            {
                if (tAdSoyad.Text != "" && tTelefon.Text != "" && tKullaniciAdi.Text != "" && tSifre.Text != "")
                {
                    if (tSifre.Text == tSifreTekrar.Text)
                    {
                        if (tSifre.Text == tSifreTekrar.Text)
                        {
                            int id = Convert.ToInt32(lKullaniciId.Text);
                            using (var db = new BarkodDBEntities())
                            {
                                var guncelle = db.Kullanici.Where(x => x.Id == id).FirstOrDefault();
                                guncelle.AdSoyad = tAdSoyad.Text;
                                guncelle.Telefon = tTelefon.Text;
                                guncelle.EPosta = tEPosta.Text;
                                guncelle.KullaniciAd = tKullaniciAdi.Text.Trim();
                                guncelle.Sifre = tSifre.Text;
                                guncelle.Satis = cbSatisEkrani.Checked;
                                guncelle.Stok = chStok.Checked;
                                guncelle.UrunGiris = cbUrunGiris.Checked;
                                guncelle.Ayarlar = cbAyarlar.Checked;
                                guncelle.FiyatGuncelle = cbFiyatGuncelle.Checked;
                                guncelle.Yedekleme = cbYedekleme.Checked;
                                db.SaveChanges();
                                MessageBox.Show("Güncelleme Yapıldı");
                                bKaydet.Text = "Kaydet";
                                Temizle();
                                Doldur();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Şifreler uyuşmuyor.");
                        }
                    }
                }
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridListeKullanici.Rows.Count > 0)
            {
                int id = Convert.ToInt32(gridListeKullanici.CurrentRow.Cells["Id"].Value.ToString());
                lKullaniciId.Text = id.ToString();
                using (var db = new BarkodDBEntities())
                {
                    var getir = db.Kullanici.Where(x => x.Id == id).FirstOrDefault();
                    tAdSoyad.Text = getir.AdSoyad;
                    tTelefon.Text = getir.Telefon;
                    tEPosta.Text = getir.Telefon;
                    tKullaniciAdi.Text = getir.KullaniciAd;
                    tSifre.Text = getir.Sifre;
                    tSifreTekrar.Text = getir.Sifre;
                    cbSatisEkrani.AutoSize = (bool)getir.Satis;
                    chRaporEkrani.Checked = (bool)getir.Rapor;
                    chStok.Checked = (bool)getir.Stok;
                    cbUrunGiris.Checked = (bool)getir.UrunGiris;
                    cbAyarlar.Checked = (bool)getir.Ayarlar;
                    cbFiyatGuncelle.Checked = (bool)getir.FiyatGuncelle;
                    cbYedekleme.Checked = (bool)getir.Yedekleme;
                    bKaydet.Text = "Düzenle/Kaydet";
                    Doldur();
                }

            }
            else
            {
                MessageBox.Show("Kullanıcı Seçiniz.");
            }
        }
        private void Doldur()
        {
            using (var db = new BarkodDBEntities())
            {
                if (db.Kullanici.Any())
                {
                    gridListeKullanici.DataSource = db.Kullanici.Select(x => new { x.Id, x.AdSoyad, x.KullaniciAd, x.Telefon }).ToList();

                }
                Islemler.SabitVarsayilan();
                var yazici = db.Sabit.FirstOrDefault();
                chYaziciDurum.Checked = (bool)yazici.Yazici;

                var sabitler = db.Sabit.FirstOrDefault();
                tKartKomisyon.Text = sabitler.KartKomisyon.ToString();

                var terazionek = db.Terazi.ToList();
                cbTeraziOnEk.DisplayMember = "TeraziOnEk"; //Görünen alan
                cbTeraziOnEk.ValueMember = "Id"; //Görünmeyen alan
                cbTeraziOnEk.DataSource = terazionek;

                tIsyeriAdSoyad.Text = sabitler.AdSoyad;
                tIsyeriUnvan.Text = sabitler.Unvan;
                tIsyeriAdres.Text = sabitler.Adres;
                tIsyeriTelefon.Text = sabitler.Telefon;
                tIsyeriEposta.Text = sabitler.EPosta;
            }

        }

        private void fAyarlar_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Doldur();
            Islemler.SabitVarsayilan();
            Cursor.Current = Cursors.Default;
        }

        private void chYaziciDurum_CheckedChanged(object sender, EventArgs e)
        {
            using (var db = new BarkodDBEntities())
            {
                if (chYaziciDurum.Checked)
                {
                    Islemler.SabitVarsayilan();
                    var ayarla = db.Sabit.FirstOrDefault();
                    ayarla.Yazici = true;
                    chYaziciDurum.Text = "Yazıcı Aktif Değil";
                    db.SaveChanges();

                }
                else
                {
                    Islemler.SabitVarsayilan();
                    var ayarla = db.Sabit.FirstOrDefault();
                    ayarla.Yazici = false;
                    chYaziciDurum.Text = "Yazıcı Aktif";
                    db.SaveChanges();

                }
            }
        }

        private void bKartKomisyonAyarla_Click(object sender, EventArgs e)
        {
            if (tKartKomisyon.Text != "")
            {
                using (var db = new BarkodDBEntities())
                {
                    var sabit = db.Sabit.FirstOrDefault();
                    sabit.KartKomisyon = Convert.ToInt16(tKartKomisyon.Text);
                    db.SaveChanges();
                    MessageBox.Show("Kart Komisyon ayarlandı.");
                }

            }
            else
            {
                MessageBox.Show("Kart komisyon bilgisini giriniz.");
            }

        }

        private void bTeraziOnEkAyar_Click(object sender, EventArgs e)
        {
            if (tTeraziOnEk.Text != "")
            {
                int onek = Convert.ToInt16(tTeraziOnEk.Text);
                using (var db = new BarkodDBEntities())
                {
                    if (db.Terazi.Any(x => x.TeraziOnEk == onek))
                    {
                        MessageBox.Show(onek.ToString() + " önek zaten kayıtlı.");
                    }
                    else
                    {
                        Terazi t = new Terazi();
                        t.TeraziOnEk = onek;
                        db.Terazi.Add(t);
                        db.SaveChanges();
                        MessageBox.Show("Bilgiler kaydedilmiştir.");
                        cbTeraziOnEk.DataSource = db.Terazi.ToList();
                        cbTeraziOnEk.DisplayMember = "TeraziOnEk";
                        cbTeraziOnEk.ValueMember = "Id";

                        tTeraziOnEk.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Terazi önek bilgisini giriniz.");
            }
        }

        private void bTeraziOnEkSil_Click(object sender, EventArgs e)
        {
            if (cbTeraziOnEk.Text != "")
            {
                int onekid = Convert.ToInt16(cbTeraziOnEk.SelectedValue);
                DialogResult onay = MessageBox.Show(cbTeraziOnEk.Text + " öneki silmek istiyor musunuz?", "Terazi Önek Silme İşlemi", MessageBoxButtons.YesNo);
                if (onay == DialogResult.Yes)
                {
                    using (var db = new BarkodDBEntities())
                    {
                        var onek = db.Terazi.Find(onekid);
                        db.Terazi.Remove(onek);
                        db.SaveChanges();
                        cbTeraziOnEk.DisplayMember = "TeraziOnEk";
                        cbTeraziOnEk.ValueMember = "Id";
                        cbTeraziOnEk.DataSource = db.Terazi.ToList();
                        MessageBox.Show("Önek Silinmiştir");
                    }
                }
            }
            else
            {
                MessageBox.Show("Önek Seçiniz.");
            }
        }

        private void bIsyeriKaydet_Click(object sender, EventArgs e)
        {
            if (tIsyeriAdSoyad.Text != "" & tIsyeriUnvan.Text != "" & tIsyeriAdres.Text != "" & tIsyeriEposta.Text != "" & tIsyeriTelefon.Text != "")
            {
                using (var db = new BarkodDBEntities())
                {
                    var isyeri = db.Sabit.FirstOrDefault();
                    isyeri.AdSoyad = tIsyeriAdSoyad.Text;
                    isyeri.Unvan = tIsyeriUnvan.Text;
                    isyeri.Adres = tIsyeriAdres.Text;
                    isyeri.Telefon = tIsyeriTelefon.Text;
                    isyeri.EPosta = tIsyeriEposta.Text;
                    db.SaveChanges();
                    MessageBox.Show("İşyeri bilgileri kaydedilmiştir");
                    var yeni = db.Sabit.FirstOrDefault();
                    tIsyeriTelefon.Text = yeni.AdSoyad;
                    tIsyeriUnvan.Text = yeni.Unvan;
                    tIsyeriAdres.Text = yeni.Adres;
                    tIsyeriTelefon.Text = yeni.Telefon;
                    tIsyeriEposta.Text = yeni.EPosta;
                }
            }
            else
            {
                MessageBox.Show("İşyeri bilgileri tam girilmedi!");
            }
        }
    }
}
