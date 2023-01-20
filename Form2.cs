using Pulsa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Voucher;

namespace Menu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnpulsa_Click(object sender, EventArgs e)
        {
            Form menu = new Form3();
            menu.Show();
            this.Hide();
        }

        private void btnvoucher_Click(object sender, EventArgs e)
        {
            Form menu = new Form4();
            menu.Show();
            this.Hide();
        }
    }
}
