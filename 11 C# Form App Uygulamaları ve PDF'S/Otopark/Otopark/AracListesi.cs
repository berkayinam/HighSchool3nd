using System;
using System.Collections;
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
    public partial class AracListesi : Form
    {
        public AracListesi()
        {
            InitializeComponent();
        }
        List<arac> araclarim = new List<arac>();

        private void AracListesi_Load(object sender, EventArgs e)
        {
            ListeyiDoldur();
        }

        private void ListeyiDoldur()
        {
            listBox1.Items.Clear();
            araclarim.Clear();
            string vtYolu = @"Data Source=LAPTOP-KE1HCSOF\SQLEXPRESS;Initial Catalog=oto;Integrated Security=True";
            try
            {
                SqlConnection cnn = new SqlConnection(vtYolu);
                cnn.Open();
                SqlCommand cmd = new SqlCommand("select * from araclar", cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    arac a = new arac();
                    a.id = Convert.ToInt32(dr[0]);
                    a.plaka = (dr[1]).ToString();
                    a.girisTarihi = Convert.ToDateTime(dr[2]);
                    a.cikisTarihi = Convert.ToDateTime(dr[3]);
                    a.ucret = Convert.ToInt32(dr[4]);
                    araclarim.Add(a);
                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "hata2");
            }

            foreach (arac a in araclarim)
            {
                listBox1.Items.Add(a.plaka);
            }
            listBox1.SelectedIndex = 0;
        }
        int seciliIndex = -1;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliIndex = listBox1.SelectedIndex;
            label6.Text = araclarim[seciliIndex].girisTarihi.ToString();
            label5.Text = araclarim[seciliIndex].cikisTarihi.ToString();
            label4.Text = araclarim[seciliIndex].ucret.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vtYolu = @"Data Source=LAPTOP-KE1HCSOF\SQLEXPRESS;Initial Catalog=oto;Integrated Security=True";
            try
            {
                SqlConnection cnn = new SqlConnection(vtYolu);
                cnn.Open();
                SqlCommand cmd = new SqlCommand("update araclar set cikisTarihi=@ct, ucret=@u where id=@id", cnn);
                cmd.Parameters.AddWithValue("@ct", DateTime.Now);
                cmd.Parameters.AddWithValue("@id", araclarim[seciliIndex].id);
                ///listeyi güncelle(içeride olmayan araçlar gösterilmeyecek)
                cmd.Parameters.AddWithValue("@u",ucretHesapla(araclarim[seciliIndex]));
                int d = cmd.ExecuteNonQuery();
                if (d > 0)
                {
                    UcretFormu uf = new UcretFormu();
                    uf.id = araclarim[seciliIndex].id;
                    uf.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Hata3");
                }
                cnn.Close();
                ListeyiDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "hata2");
            }
        }

        private int ucretHesapla(arac a)
        {
            TimeSpan zamanFarki=DateTime.Now - a.girisTarihi;
            if (zamanFarki.TotalMinutes / 60 < 1)
            {
                return 10;
            }
            else
            {
                return Convert.ToInt16((zamanFarki.TotalMinutes / 60) + 1) * 10;
            }
           
        }
    }
}
