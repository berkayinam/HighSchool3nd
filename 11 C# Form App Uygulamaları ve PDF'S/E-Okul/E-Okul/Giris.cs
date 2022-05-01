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

namespace E_Okul
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        public static string secilenID;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-KE1HCSOF\SQLEXPRESS;Initial Catalog=deneme;Integrated Security=True");
            string cmdText = "select Count(*) from girTablo where kullaniciAd='" + textBox_kAd.Text + "' and sifre = '" + textBox_Sifr.Text + "'";
            Debug.Print(cmdText);
            SqlCommand cmd = new SqlCommand(cmdText, cnn);
            cnn.Open();
            int donenDeger = Convert.ToInt16(cmd.ExecuteScalar());

            Debug.Print(donenDeger.ToString());
            if (donenDeger == 1)
            {
                Menu f2 = new Menu();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı  parola hatası");
            }
            cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Giris_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
