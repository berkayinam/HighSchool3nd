using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciGirisi
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kul_Gir kul_Gir = new Kul_Gir();
            kul_Gir.Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kayıt kayıt = new Kayıt();
            kayıt.Show();
            this.Hide();

        }

        private void Giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
