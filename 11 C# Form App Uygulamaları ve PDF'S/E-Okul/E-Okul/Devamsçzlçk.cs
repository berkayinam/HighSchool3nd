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
    public partial class Devamsızlık : Form
    {
        public Devamsızlık()
        {
            InitializeComponent();
        }

        SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-KE1HCSOF\SQLEXPRESS;Initial Catalog=deneme;Integrated Security=True");
        string secilenID;
        private void Devamsızlık_Load(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SELECT ID, Ad, Soyad, Sinif, Sube FROM bilgTablo", cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    secilenID = dr[0].ToString();
                    listBox1.Items.Add(dr[1].ToString() + " " + dr[2].ToString() + " " + dr[3].ToString() + " " + dr[4].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cnn.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT Ad, Soyad, Sinif, Sube FROM bilgTablo WHERE ID = " + int.Parse(secilenID) + "", cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBox_Ad.Text = dr[0].ToString();
                    textBox_Snf.Text = dr[2].ToString();
                    textBox_Sube.Text = dr[3].ToString();
                }
                dr.Read();
            }            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cnn.Close();
        }

        private void button_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO devamTablo(ogrenciAd, ogrenciSinif, ogrenciSube, Devamsizlik) values('" + textBox_Ad.Text + "', '" + textBox_Snf.Text + "', '" + textBox_Sube.Text + "', '" + textBox_Devam.Text + "')", cnn);
                int a = cmd.ExecuteNonQuery();
                if (a == 1)
                {
                    MessageBox.Show("Kayıt Eklendi..!");
                }
                else
                {
                    MessageBox.Show("Kayıt Eklenemedi..!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_Sube_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu fw = new Menu();
            fw.Show();
            this.Hide();
        }

        private void Devamsızlık_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
