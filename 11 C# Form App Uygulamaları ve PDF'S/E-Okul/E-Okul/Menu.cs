using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Okul
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button_dersEkle_Click(object sender, EventArgs e)
        {
            Ders ders = new Ders();
            ders.Show();
            this.Close();
        }

        private void button_notEkle_Click(object sender, EventArgs e)
        {
            Not not = new Not();
            not.Show();
            this.Close();
        }

        private void button_Cik_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void button_Guncl_Click(object sender, EventArgs e)
        {
            Guncelle guncelle = new Guncelle();
            guncelle.Show();
            this.Close();
        }

        private void button_Devam_Click(object sender, EventArgs e)
        {
            Devamsızlık devamsızlık = new Devamsızlık();
            devamsızlık.Show();
            this.Close();
        }

        private void button_Karne_Click(object sender, EventArgs e)
        {
            Karne karne = new Karne();
            karne.Show();
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
