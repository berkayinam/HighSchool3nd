using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Okul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Cik_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Gir_Click(object sender, EventArgs e)
        {
            Giris f1 = new Giris();
            f1.Show();
            this.Hide();
        }

        private void button_Kayit_Click(object sender, EventArgs e)
        {
            Kayit kayit = new Kayit();
            kayit.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
