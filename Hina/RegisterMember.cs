using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hina
{
    public partial class RegisterMember : Form
    {
        DBEntities db = new DBEntities();
        public RegisterMember()
        {
            InitializeComponent();
        }

        private void bttnKayitOl_Click(object sender, EventArgs e)
        {
            if (txtbTcKimlik.Text == "" || txtbAd.Text == "" || txtbSoyad.Text == "" || txtbEPosta.Text == "" || txtbSifre.Text == "" ||
                txtbCadde.Text == "" || txtbSokak.Text == "" || txtbMahalle.Text == "" || txtbDaireAdi.Text == "" || txtbNo.Text == "" ||
                txtbDaireNo.Text == "" //---|| txtilce.Text == "" || txtil.Text == ""
                )
            {
                MessageBox.Show("Tüm Alanlar Doldurulmalıdır!!", "Uyarı");
            }
            else
            {
                var cnsyt = "";
                if (rdbttnKadin.Checked == true) { cnsyt = "Kadın"; }
                else if (rdbttnErkek.Checked == true) { cnsyt = "Erkek"; }
                else { MessageBox.Show("Cinsiyet bilgisi giriniz"); }
                
                long kimlikNo = Convert.ToInt64(txtbTcKimlik.Text);
                var uye = db.Kullanici.Any(x => x.tcNo == kimlikNo);
                if (uye == false)
                {
                    Adres yeniadres = new Adres();
                        yeniadres.cadde = txtbCadde.Text.ToString();
                        yeniadres.sokak = txtbSokak.Text.ToString();
                        yeniadres.mahalle = txtbMahalle.Text.ToString();
                        yeniadres.bina = txtbDaireAdi.Text.ToString();
                        yeniadres.binaNo = Convert.ToInt32(txtbNo.Text);
                        yeniadres.daireNo = Convert.ToInt32(txtbDaireNo.Text);
                        //ilce = txtilce.Text.ToString(),
                        //il = txtil.Text.ToString()
                    db.Adres.Add(yeniadres);
                    db.SaveChanges();

                    Kullanici yenikullanici = new Kullanici();
                        yenikullanici.tcNo = Convert.ToInt64(txtbTcKimlik.Text);
                        yenikullanici.ad = txtbAd.Text.ToString();
                        yenikullanici.soyad = txtbSoyad.Text.ToString();
                        yenikullanici.cinsiyet = cnsyt;
                        //yenikullanici.telefonNo = Convert.ToInt32(txtbtelefon.Text);
                        yenikullanici.adres = yeniadres.adresNo;
                        yenikullanici.eposta = txtbEPosta.Text.ToString();
                        yenikullanici.sifre = txtbSifre.Text.ToString();
                    db.Kullanici.Add(yenikullanici);
                    db.SaveChanges();

                    MessageBox.Show("Bilgileriniz Kaydedilmiştir. Lütfen Giriş Yapınız.", "Onay");
                }
                else
                {
                    MessageBox.Show("Bu kullanıcı zaten üye !");
                }
            }
        }

        private void pctrbxSayfayiKapat_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pctrbxGeri_Click(object sender, EventArgs e)
        {
            RegisterOption sayfa = new RegisterOption();
            sayfa.Show();
            this.Hide();
        }
    }
}