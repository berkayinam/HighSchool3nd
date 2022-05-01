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
    public partial class Guncelle : Form
    {
        public Guncelle()
        {
            InitializeComponent();
        }

        SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-KE1HCSOF\SQLEXPRESS;Initial Catalog=deneme;Integrated Security=True");
        private void Guncelle_Load(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM bilgTablo", cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBox_Ad.Text = dr[1].ToString();
                    textBox_Soyad.Text = dr[2].ToString();
                    textBox_TC.Text = dr[3].ToString();
                    textBox_Snf.Text = dr[4].ToString();
                    textBox_Sube.Text = dr[5].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cnn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE TO bilgTablo SET('" + textBox_Ad.Text + "','" + textBox_Soyad.Text + "','" + textBox_TC.Text + "','" + textBox_Snf.Text + "','" + textBox_Sube.Text + "',)", cnn);
                int a = cmd.ExecuteNonQuery();
                if (a == 1)
                {
                    MessageBox.Show("Kayıt Başarıyla Güncellendi..!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void Guncelle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
