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
    public partial class urun_sat : Form
    {
        public urun_sat()
        {
            InitializeComponent();
        }

        public int gelenUrunID;
        public string gelenUrunAdi;
        public double gelenUrunFiyati;

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection sqlCnn=new SqlConnection(@"Data Source=LAPTOP-KE1HCSOF\SQLEXPRESS;Initial Catalog=yazili;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into satislar (urun_id, satis_miktari, satis_fiyati,satis_tarihi,iskonto,fatura_tutari) " +
                "values (@urunid,@sm,@sf,@st,@is,@ft)", sqlCnn);
            cmd.Parameters.AddWithValue("@urunid", gelenUrunID);
            cmd.Parameters.AddWithValue("@sm", Convert.ToDouble(textBox1.Text));
            cmd.Parameters.AddWithValue("@sf", gelenUrunFiyati);
            cmd.Parameters.AddWithValue("@st", DateTime.Now);
            cmd.Parameters.AddWithValue("@is", Convert.ToDouble(textBox2.Text));
            cmd.Parameters.AddWithValue("@ft", faturaTutari);


            try
            {
                sqlCnn.Open();
                int sonuc = cmd.ExecuteNonQuery();
                if (sonuc > 0)
                {
                    MessageBox.Show("Satış Yapıldı");
                    sqlCnn.Close();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("yapılamadı...");
                    sqlCnn.Close();
                    this.Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void urun_sat_Load(object sender, EventArgs e)
        {
            label1.Text = gelenUrunAdi + "\n" + gelenUrunFiyati.ToString();

        }
        double satisMiktari;
        double iskonto=0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             satisMiktari= Convert.ToDouble(textBox1.Text);
            hesapla();



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            iskonto = Convert.ToDouble(textBox2.Text);
            hesapla();
        }
        double faturaTutari = 0;
        private void hesapla()
        {
            if (iskonto == 0)
            {
                faturaTutari = gelenUrunFiyati * satisMiktari;
                label4.Text = faturaTutari.ToString();
            }
            else
            {
                faturaTutari = gelenUrunFiyati * satisMiktari;
                faturaTutari = faturaTutari - faturaTutari * iskonto / 100;
                label4.Text = faturaTutari.ToString();

            }
        }
    }
}
