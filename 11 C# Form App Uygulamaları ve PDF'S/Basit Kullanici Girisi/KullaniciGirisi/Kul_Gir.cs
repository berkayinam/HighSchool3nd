using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciGirisi
{
    public partial class Kul_Gir : Form
    {
        public Kul_Gir()
        {
            InitializeComponent();
        }
        SqlConnection cnc;
        SqlCommand cmd;
        SqlDataReader dr;
        private void button1_Click(object sender, EventArgs e)
        {
            cnc = new SqlConnection(@"Data Source=PC1;Initial Catalog=eokul;Integrated Security=True");
            cmd = new SqlCommand("SELECT * FROM Kayit WHERE ad='" + textBox1.Text + "'AND parola='" + textBox2.Text + "'", cnc);
            try
            {
                cnc.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Giriş Yapıldı");
                    AnaForm fr2 = new AnaForm();
                    fr2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Yanlış");
                }
                
            }
            catch 
            {
                MessageBox.Show("HATA");
            }
        }

        private void Kul_Gir_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Giris gr = new Giris();
            gr.Show();
            this.Show();
        }
    }
}
