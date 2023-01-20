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

namespace counter_pulsa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmasuk_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                MessageBox.Show("Username atau Password tidak boleh kosong");
            }
            else if (txtusername.Text == "admin" && txtpassword.Text == "123456" )
            {
                MessageBox.Show("Anda Berhasil Masuk");
                Form menu = new Form2();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password salah");
                
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void counter_Click(object sender, EventArgs e)
        {

        }
    }
}
