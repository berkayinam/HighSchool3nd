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
    public partial class Karne : Form
    {
        public Karne()
        {
            InitializeComponent();
        }

        SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-KE1HCSOF\SQLEXPRESS;Initial Catalog=deneme;Integrated Security=True");
        int sayi;
        private void Karne_Load(object sender, EventArgs e)
        {
            label_Ders.Text = "";
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Ad,Soyad FROM bilgTablo", cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    label_Ad.Text = dr[0].ToString() + " " + dr[1].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cnn.Close();
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Ders FROM Notlar", cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    sayi = dr.VisibleFieldCount;
                    for (int i = 0; i < dr.VisibleFieldCount; i++)
                    {
                        label_Ders.Text += dr[i].ToString() + "           ";
                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cnn.Close();
        }

        private void Karne_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
