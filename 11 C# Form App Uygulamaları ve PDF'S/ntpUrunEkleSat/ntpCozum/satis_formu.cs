using System;
using System.Collections;
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
    public partial class satis_formu : Form
    {
        public satis_formu()
        {
            InitializeComponent();
        }

        SqlConnection sqlCnn=new SqlConnection(@"Data Source=LAPTOP-KE1HCSOF\SQLEXPRESS;Initial Catalog=yazili;Integrated Security=True");
        SqlCommand cmd;

        
        List<int> idler = new List<int>();
        List<string> adlar = new List<string>();
        List<double> satisFiyatlari = new List<double>();
        List<Button> butonlar = new List<Button>();


        private void satis_formu_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select id,urun_adi,satis_fiyati from urunler_tablosu", sqlCnn);


            try
            {
                sqlCnn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    idler.Add(Convert.ToInt16(dr[0].ToString()));
                    adlar.Add(dr[1].ToString());
                    satisFiyatlari.Add(Convert.ToDouble(dr[2].ToString()));


                }
                sqlCnn.Close();
                dr.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            butonEkle();

        }

        private void butonEkle()
        {
            for (int i = 0; i < idler.Count; i++)
            {
                Button btn = new Button();
                btn.Name = idler[i].ToString();
                btn.Text = adlar[i] + "\n" + satisFiyatlari[i].ToString();
                btn.Width = 80;
                btn.Height = 80;
                btn.Click += Btn_Click;
                butonlar.Add(btn);
            }
            butonYerlestir();
        }
        int sabitX = 50;
        int sabitY = 90;
        int ycarpan = 0;
        private void butonYerlestir()
        {
           for(int i = 0; i < butonlar.Count; i++)
            {
                if (i % 5 == 0)
                {
                    ycarpan++;
                }
                butonlar[i].Location = new Point(sabitX + (i % 5) * 90, sabitY * ycarpan);

                foreach (Button item in butonlar)
                {
                    this.Controls.Add(item);
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            urun_sat us = new urun_sat();
            us.gelenUrunID = Convert.ToInt32(b.Name);
            for (int i = 0; i < idler.Count; i++)
            {
                if (idler[i] == Convert.ToInt32(b.Name))
                {
                    us.gelenUrunAdi = adlar[i];
                    us.gelenUrunFiyati = satisFiyatlari[i];
                }
            }
            us.ShowDialog();
            this.Close();
        }
    }
}
