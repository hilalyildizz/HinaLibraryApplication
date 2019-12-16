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
    public partial class About : Form
    {
        public About(int index)
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pctrbxGeri_Click(object sender, EventArgs e)
        {
            StaffHome sayfa = new StaffHome();
            sayfa.Show();
            this.Hide();

        }
    }
}
