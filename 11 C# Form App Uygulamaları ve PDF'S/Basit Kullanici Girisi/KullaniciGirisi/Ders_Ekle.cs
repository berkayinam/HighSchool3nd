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

namespace KullaniciGirisi
{
    public partial class Ders_Ekle : Form
    {
        public Ders_Ekle()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = new SqlConnection(@"Data Source=PC1;Initial Catalog=eokul;Integrated Security=True");
 
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand ekleCmd;
            int etkilenen = -1;
            ekleCmd = new SqlCommand("Insert into Derss(dersler,kredisi)values('" + textBox1.Text + "'," + textBox2.Text + ")", sqlCon);
            try
            {
                sqlCon.Open();
                etkilenen = ekleCmd.ExecuteNonQuery();
                if (etkilenen!=-1|| etkilenen!=0)
                {
                    MessageBox.Show("ders kaydı oldu");
                }
                else
                {
                    MessageBox.Show("olmadı");
                }
                etkilenen = -1;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            try
            {
                sqlCon.Open();

                ekleCmd = new SqlCommand("CREATE TABLE " + textBox1.Text + " (id int, Ogrenci_Adi varchar(255), Ogrenci_soyadi varchar(255),ilkyazılı NVARCHAR(225),ikinciyazılı NVARCHAR(225),PRIMARY KEY(ID))", sqlCon);
                ekleCmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("tablo oluştu");
            }
            catch (Exception)
            {
                MessageBox.Show("tablo oluşmadı");
            }
            
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnaForm fr = new AnaForm();
            fr.Show();
            this.Hide();
        }

        private void Ders_Ekle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
