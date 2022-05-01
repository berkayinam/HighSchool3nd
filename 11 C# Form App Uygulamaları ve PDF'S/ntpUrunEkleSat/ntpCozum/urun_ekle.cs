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

namespace ntpCozum
{
    public partial class urun_ekle : Form
    {
        public urun_ekle()
        {
            InitializeComponent();
        }

        public int gelenID = -500;


        SqlConnection sqlCnn = new SqlConnection();
        SqlCommand cmd;




        private void button1_Click(object sender, EventArgs e)
        {

            if (gelenID == -500)
            {
                sqlCnn.ConnectionString = @"Data Source=LAPTOP-KE1HCSOF\SQLEXPRESS;Initial Catalog=yazili;Integrated Security=True";
                cmd = new SqlCommand("insert into urunler_tablosu (urun_adi, birim_fiyati, alis_tarihi, satis_fiyati, kar_marji) " +
                    "values (@ad, @bf,@alistarihi,@satisfiyati, @karmarji)", sqlCnn);
                cmd.Parameters.AddWithValue("@ad", textBox1.Text);
                cmd.Parameters.AddWithValue("@bf", Convert.ToDouble(textBox2.Text));
                cmd.Parameters.AddWithValue("@alistarihi", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@satisfiyati", Convert.ToDouble(textBox4.Text));
                cmd.Parameters.AddWithValue("@karmarji", Convert.ToDouble(textBox3.Text));

                try
                {
                    sqlCnn.Open();
                    int sonuc = cmd.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Ürün Eklendi");
                        sqlCnn.Close();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Ürün Eklenemedi....");
                        sqlCnn.Close();
                        this.Close();
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                //güncelleme yap

                sqlCnn.ConnectionString = @"Data Source=LAPTOP-KE1HCSOF\SQLEXPRESS;Initial Catalog=yazili;Integrated Security=True";
                cmd = new SqlCommand("update  urunler_tablosu set urun_adi=@ad, birim_fiyati=@bf, alis_tarihi=@alistarihi, satis_fiyati=@satisfiyati, kar_marji=@karmarji where id=@gelenID" , sqlCnn);
                cmd.Parameters.AddWithValue("@ad", textBox1.Text);
                cmd.Parameters.AddWithValue("@bf", Convert.ToDouble(textBox2.Text));
                cmd.Parameters.AddWithValue("@alistarihi", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@satisfiyati", Convert.ToDouble(textBox4.Text));
                cmd.Parameters.AddWithValue("@gelenID", gelenID);
                cmd.Parameters.AddWithValue("@karmarji", Convert.ToDouble(textBox3.Text));

                try
                {
                    sqlCnn.Open();
                    int sonuc = cmd.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Ürün güncellendi");
                        sqlCnn.Close();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Ürün güncellenemedi....");
                        sqlCnn.Close();
                        this.Close();
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


            }



        }

        double satis_fiyati = 0;



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            degerKontrolu();





        }

        private void degerKontrolu()
        {
            if (textBox2.Text != "" && textBox3.Text != "")
            {
                satis_fiyati = Convert.ToDouble(textBox2.Text) + (Convert.ToDouble(textBox3.Text) / 100)
                               * Convert.ToDouble(textBox2.Text);
                textBox4.Text = satis_fiyati.ToString();
            }
            else
            {
                MessageBox.Show("Alanları doldurunuz....");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //degerKontrolu();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urun_sec us = new urun_sec();
            us.sayi = 200;
            us.ShowDialog();

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urun_sec us = new urun_sec();
            us.sayi = 300;

            us.ShowDialog();

        }

        private void urun_ekle_Load(object sender, EventArgs e)
        {
            if (gelenID != -500)
            {
                button1.Text = "GÜNCELLE";



                sqlCnn.ConnectionString = @"Data Source=LAPTOP-KE1HCSOF\SQLEXPRESS;Initial Catalog=yazili;Integrated Security=True";
                cmd = new SqlCommand("select * from urunler_tablosu where id=@gelenID", sqlCnn);
                cmd.Parameters.AddWithValue("@gelenID", gelenID);

                try
                {
                    sqlCnn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        textBox1.Text = dr[1].ToString();
                        textBox2.Text = dr[2].ToString();
                        textBox3.Text = dr[5].ToString();
                        textBox4.Text = dr[4].ToString();
                        dateTimePicker1.Value = Convert.ToDateTime(dr[3]);

                    }
                    sqlCnn.Close();
                    dr.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
