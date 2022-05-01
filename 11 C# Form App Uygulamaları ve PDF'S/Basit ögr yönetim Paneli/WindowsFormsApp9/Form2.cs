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

namespace WindowsFormsApp9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-KE1HCSOF\SQLEXPRESS;Initial Catalog=kullaniciGirisi;Integrated Security=True");
            string cmdText = "insert into ogrenciler(ogrenciAdi, ogrenciSoyad, ogrenciTc, telefon)values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')";
            Debug.Print(cmdText);
            SqlCommand cmd = new SqlCommand(cmdText, cnn);
            cnn.Open();

            try
            {
                int donenDeger = cmd.ExecuteNonQuery();
                Debug.Print(donenDeger.ToString());
                if (donenDeger == 1)
                {
                    MessageBox.Show("Eklendi.....");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                }
                else
                {
                    MessageBox.Show("başarılı değil.....");
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
            cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}
