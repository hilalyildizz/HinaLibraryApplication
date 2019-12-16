using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace Hina
{
    public partial class Login : Form
    {
        DBEntities db = new DBEntities();
        public Login()
        {
            InitializeComponent();
        }

        private void txtbeposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            if (txtbeposta.Text != string.Empty && txtbsifre.Text != string.Empty)
            {
                var kullanici = db.Kullanici.FirstOrDefault(u => u.eposta == txtbeposta.Text);
                if (kullanici != null)
                {                    
                    if (kullanici.sifre == txtbsifre.Text)
                    {
                        var personel = kullanici.Personel.sicilNo.ToString();
                        if (personel != null)
                        {
                            StaffHome sayfa = new StaffHome();
                            sayfa.Show();
                            this.Hide();
                        }
                        else
                        {
                            //MemberHome sayfa = new MemberHome();
                            //sayfa.Show();
                            //this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Yanlış Şifre Girdiniz", "Uyarı");
                    }
                }
                else
                {
                    MessageBox.Show("Bu E-posta Adresi Kayıtlı Değil!", "Uyarı");
                }
            }
            else
            {
                MessageBox.Show("E-posta ve Şifre Alanları Boş Bırakılamaz", "Uyarı");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterOption sayfa = new RegisterOption();
            sayfa.Show();
            this.Hide();
        }

        private void pctrbxSayfayiKapat_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
