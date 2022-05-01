using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace ntpCozum
{
    public partial class urun_sec : Form
    {
        public urun_sec()
        {
            InitializeComponent();
        }
        SqlConnection sqlCnn=new SqlConnection(@"Data Source=LAPTOP-KE1HCSOF\SQLEXPRESS;Initial Catalog=yazili;Integrated Security=True");
        SqlCommand cmd;
        ArrayList idler = new ArrayList();
        ArrayList urunAdlari = new ArrayList();
       
        public int sayi = 100;


        private void urun_sec_Load(object sender, EventArgs e)
        {
            if (sayi == 200)
            {
                button1.Text = "Güncelle";
            }else if (sayi == 300)
            {
                button1.Text = "SİL";
            }

            
            //sqlCnn.ConnectionString = @"Data Source=DESKTOP-4LV22KO\SQLEXPRESS01;Initial Catalog=yazili;Integrated Security=True";
            cmd = new SqlCommand("select id,urun_adi from urunler_tablosu", sqlCnn);
            
           
            try
            {
                sqlCnn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    idler.Add(Convert.ToInt16(dr[0].ToString()));
                    urunAdlari.Add(dr[1].ToString());

                }
                sqlCnn.Close();
                dr.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            foreach (string item in urunAdlari)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sayi == 300)
            {
                //silme işlemi yap

                cmd = new SqlCommand("delete from urunler_tablosu where id=@urunID", sqlCnn);
                cmd.Parameters.AddWithValue("@urunID", idler[listBox1.SelectedIndex]);

                try
                {
                    sqlCnn.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Silindi");
                        sqlCnn.Close();
                        this.Close();

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }





            }else if (sayi == 200)
            {
                urun_ekle ue = new urun_ekle();
                ue.gelenID = Convert.ToInt16( idler[listBox1.SelectedIndex]);
                ue.ShowDialog();
                this.Close();
            }
        }
    }
}
