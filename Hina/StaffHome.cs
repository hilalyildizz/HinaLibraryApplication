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
    public partial class StaffHome : Form
    {
        public StaffHome()
        {
            InitializeComponent();
        }

        private void pctrbxKitapIslemleri_Click(object sender, EventArgs e)
        {
            BookRecording sayfa = new BookRecording();
            sayfa.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            BookRecording sayfa = new BookRecording();
            sayfa.Show();
            this.Hide();
        }

        private void pctrbxUyeIslemleri_Click(object sender, EventArgs e)
        {
            PersonRecording sayfa = new PersonRecording();
            sayfa.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            PersonRecording sayfa = new PersonRecording();
            sayfa.Show();
            this.Hide();
        }

        private void pctrbxEmanetIslemleri_Click(object sender, EventArgs e)
        {
            BookLend sayfa = new BookLend();
            sayfa.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            BookLend sayfa = new BookLend();
            sayfa.Show();
            this.Hide();
        }

        private void pctrbxGecikmisKitaplar_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pctrbxAyarlar_Click(object sender, EventArgs e)
        {
            ChangePassword sayfa = new ChangePassword();
            sayfa.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ChangePassword sayfa = new ChangePassword();
            sayfa.Show();
            this.Hide();
        }

        private void pctrbxHakkinda_Click(object sender, EventArgs e)
        {
            About sayfa = new About(0);
            sayfa.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            About sayfa = new About(0);
            sayfa.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void StaffHome_Load(object sender, EventArgs e)
        {

        }
    }
}
