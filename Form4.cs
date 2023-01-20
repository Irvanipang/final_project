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

namespace Voucher
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            Form menu = new Form2();
            menu.Show();
            this.Hide();
        }

        private void btnbeli_Click(object sender, EventArgs e)
        {
                if (txthp.Text == "")
                {
                    MessageBox.Show("Nomor atau Paket tidak boleh kosong");
                }
                else if (cmbpaket.Text == "")
                {
                    MessageBox.Show("Nomor atau Paket tidak boleh kosong");
                }
                else
                {
                    MessageBox.Show("Berhasil");
                    Form menu = new Form6();
                    menu.Show();
                    this.Hide();
                }
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }
