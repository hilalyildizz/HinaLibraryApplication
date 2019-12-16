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
    public partial class BookLend : Form
    {
        DBEntities db = new DBEntities();
        public BookLend()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtbTcKimlik_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbKitapKodu_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bttnKaydet_Click(object sender, EventArgs e)
        {
            if (txtbTcKimlik.Text == "" || txtbKitapKodu.Text == "" || dateAlımTarihi.Text == "" || dateTeslimTarihi.Text == "")
            {
                MessageBox.Show("Tüm Alanlar Doldurulmalıdır!!", "Uyarı");
            }
            else
            {
                var emanet = db.Odunc.Where(x => x.uye == Convert.ToInt64(txtbTcKimlik.Text));
                emanet.Any(x => x.onay == "Teslim Edilmedi");
                if (emanet == null)
                {
                    var kitap = db.Kitap.Where(x => x.kod == txtbKitapKodu.Text).FirstOrDefault();
                    Odunc odunc = new Odunc();
                    odunc.kitap = kitap.ISBNNo;
                    odunc.uye = Convert.ToInt64(txtbTcKimlik.Text);
                    odunc.oduncTarihi = dateAlımTarihi.Value;
                    odunc.teslimTarihi = dateTeslimTarihi.Value;
                    odunc.onay = "Teslim Edilmedi";

                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Ödünç Alma İşlemi Gerçekleştirilemedi. Ödünçdeki Kitabınızı Teslim Ettikten Sonra Deneyiniz.", "Uyarı");
                }
            }
        }
    }
}
