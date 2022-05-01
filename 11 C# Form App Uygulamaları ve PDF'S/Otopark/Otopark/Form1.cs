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

namespace Otopark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string vtYolu = @"Data Source=LAPTOP-KE1HCSOF\SQLEXPRESS;Initial Catalog=oto;Integrated Security=True";
            try
            {
                SqlConnection cnn = new SqlConnection(vtYolu);
                SqlCommand cmd = new SqlCommand("insert into araclar(plaka,girisTarihi,cikisTarihi,ucret) values (@p,@gt,@ct,@u)", cnn);
                cmd.Parameters.AddWithValue("@p", textBox1.Text);
                cmd.Parameters.AddWithValue("@gt", DateTime.Now);
                cmd.Parameters.AddWithValue("@ct", new DateTime(2000, 1, 1));
                cmd.Parameters.AddWithValue("@u", 0);
                Debug.Print(cmd.CommandText);
                cnn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Eklendi");
                }
                else
                {
                    MessageBox.Show("eklenemedi");
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "hata1");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AracListesi al = new AracListesi();
            al.ShowDialog();
        }
    }
}
