using counter_pulsa;
using Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pulsa
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnbeli_Click(object sender, EventArgs e)
        {
            if (txtnomor.Text == "")
            {
                MessageBox.Show("Nomor atau Nominal tidak boleh kosong");
            }
            else if(cmbnominal.Text == "")
            {
                MessageBox.Show("Nomor atau Nominal tidak boleh kosong");
            }
            else
            {
                MessageBox.Show("Berhasil");
                Form menu = new Form6();
                menu.Show();
                this.Hide();
            }
        }


        private void btnbatal_Click(object sender, EventArgs e)
        {
            Form menu = new Form2();
            menu.Show();
            this.Hide();
        }

        private void txtnomor_TextChanged(object sender, EventArgs e)
        {
            if (txtnomor.Text == "")
            {
                MessageBox.Show("Nomor atau Nominal tidak boleh kosong");
            }
        }

        private void cmbnominal_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
