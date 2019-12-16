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
    public partial class RegisterOption : Form
    {
        public RegisterOption()
        {
            InitializeComponent();
        }

        private void pctrbxSayfayiKapat_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bttnPersonel_Click(object sender, EventArgs e)
        {
            RegisterStaff sayfa = new RegisterStaff();
            sayfa.Show();
            this.Hide();
        }

        private void bttnKullanici_Click(object sender, EventArgs e)
        {
            RegisterMember sayfa = new RegisterMember();
            sayfa.Show();
            this.Hide();
        }

        private void pctrbxGeri_Click(object sender, EventArgs e)
        {
            Login sayfa = new Login();
            sayfa.Show();
            this.Hide();
        }
    }
}
