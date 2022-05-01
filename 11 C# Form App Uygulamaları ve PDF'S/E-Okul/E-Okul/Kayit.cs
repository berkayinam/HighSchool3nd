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
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-KE1HCSOF\SQLEXPRESS;Initial Catalog=deneme;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO bilgTablo(Ad, Soyad, TC, Sinif, Sube) values('" + textBox_Ad.Text + "', '" + textBox_Soyad.Text + "', '" + textBox_TC.Text + "', '" + textBox_Snf.Text + "', '" + textBox_Sube.Text + "')", cnn);
            SqlCommand cmd2 = new SqlCommand("INSERT INTO girTablo(kullaniciAd, sifre) values('" + textBox_kAd.Text + "', '" + textBox_Sifr.Text + "')", cnn);
            cnn.Open();
            try
            {
                int b = cmd2.ExecuteNonQuery();
                int a = cmd.ExecuteNonQuery();
                if (a == 1 && b == 1)
                {
                    MessageBox.Show("Bilgiler Eklendi..!");
                    textBox_Ad.Text = "";
                    textBox_Soyad.Text = "";
                    textBox_TC.Text = "";
                    textBox_Snf.Text = "";
                    textBox_Sube.Text = "";
                    textBox_kAd.Text = "";
                    textBox_Sifr.Text = "";
                }
                else
                {
                    MessageBox.Show("Bilgiler Eklenemedi..!");
                    textBox_Ad.Text = "";
                    textBox_Soyad.Text = "";
                    textBox_TC.Text = "";
                    textBox_Snf.Text = "";
                    textBox_Sube.Text = "";
                    textBox_kAd.Text = "";
                    textBox_Sifr.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cnn.Close();
            Giris gir = new Giris();
            gir.Show();
            this.Hide();
        }

        private void Kayit_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
