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
    public partial class ChangePassword : Form
    {
        DBEntities db = new DBEntities();
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void bttnKaydet_Click(object sender, EventArgs e)
        {
            if (txtbEMaİL.Text == "" || txtbEskiSifre.Text == "" || txtbYeniSifre.Text == "" || txtbYeniSifreTekrar.Text == "")
            {
                MessageBox.Show("Tüm Alanlar Doldurulmalıdır!!", "Uyarı");
            }
            else if (txtbYeniSifre.Text != txtbYeniSifreTekrar.Text)
            {
                MessageBox.Show("Yeni şifre değerleri aynı olmalıdır", "Uyarı");
            }
            else
            {
                var kullanici = db.Kullanici.Where(u => u.eposta == txtbEMaİL.Text).FirstOrDefault();                
                if (kullanici.sifre == txtbEskiSifre.Text)
                {
                    kullanici.sifre = txtbYeniSifreTekrar.Text;
                    db.SaveChanges();

                    MessageBox.Show("Şifreniz Başarıyla Değiştirildi", "Uyarı");
                }
                else
                {
                    MessageBox.Show("Girdiğiniz Eski Şifre Değeri Doğru Değil", "Uyarı");
                }
            }
        }
    }
}
