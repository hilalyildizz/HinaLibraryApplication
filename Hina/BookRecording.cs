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
    public partial class BookRecording : Form
    {
        DBEntities db = new DBEntities();
        public BookRecording()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void bttnKaydet_Click(object sender, EventArgs e)
        {
            if (txtbIsbn.Text == "" || txtbKod.Text == "" || txtbKitapAdi.Text == "" || txtbYazar.Text == "" ||
                txtbYayinevi.Text == "" || txtbBasimTarihi.Text == "" ||
                txtbTur.Text == "" || txtbDurum.Text == "" || txtbKategori.Text == "")
            {
                MessageBox.Show("Tüm Alanlar Doldurulmalıdır!!", "Uyarı");
            }
            else
            {
                var kitap = db.Kitap.Where(x => x.ISBNNo == Convert.ToInt64(txtbIsbn.Text)).FirstOrDefault();
                if (kitap == null)
                {
                    var yazar = db.Yazar.Where(x => x.ad + x.soyad == txtbYazar.Text).FirstOrDefault();
                    if (yazar == null)
                    {
                        Yazar yzr = new Yazar();

                    }
                    Kitap ktp = new Kitap();
                    ktp.ISBNNo = Convert.ToInt64(txtbIsbn.Text);
                    ktp.ad = txtbKitapAdi.Text;
                    
                }
                else
                {
                    MessageBox.Show("Girilen ISBN Numarasına Sahip Bir Kitap Zaten Var!", "Uyarı");
                }
            }
        }


        private void txtbDurum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
