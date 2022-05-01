using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulStokProgramı
{
    public partial class Goruntule : Form
    {
        public Goruntule()
        {
            InitializeComponent();
        }
        int btnSay = 0, X = 0, Y = 0;
        List<string> anaYerler = new List<string>();
        List<string> yerler = new List<string>();
        public static Button secilenAnaYer;

        private void Goruntule_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            Listele f1 = new Listele();
            f1.Show();
            this.Hide();
        }

        private void Görüntüle_Load(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection(@"Server=94.73.148.47;Database=u8412932_bahadir;Uid=u8412932_bahadir;Pwd='RPqz76F2';");
            MySqlCommand komut = new MySqlCommand("SELECT Ana_Yer_Adi FROM ana_yer_tablosu", baglanti);
            try
            {
                baglanti.Open();
                MySqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    anaYerler.Add(dr[0].ToString());
                }
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




            for (int j = 0; j < anaYerler.Count; j++)
            {
                if (secilenAnaYer.Text == anaYerler[j])
                {
                    MySqlConnection cnn = new MySqlConnection(@"Server=94.73.148.47;Database=u8412932_bahadir;Uid=u8412932_bahadir;Pwd='RPqz76F2';");
                    MySqlCommand cmd = new MySqlCommand("SELECT Yer_Adi FROM yer_tablosu WHERE Ana_Yer_ID = @anaYerID", cnn);
                    cmd.Parameters.AddWithValue("@anaYerID", anaYerler.IndexOf(anaYerler[j]) + 1);
                    try
                    {
                        cnn.Open();
                        MySqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            yerler.Add(dr[0].ToString());
                        }
                        cnn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    for (int i = 0; i < yerler.Count; i++)
                    {
                        Button btn = new Button
                        {
                            Size = new Size(221, 155),
                            Location = new Point(5 + X, 25 + Y),
                            Text = yerler[i].ToString(),
                            Font = Btn_Font.Font
                        };
                        btn.Click += Btn_Click;
                        Controls.Add(btn);
                        if (this.Width < btn.Location.X + btn.Width)
                        {
                            this.Width += btn.Width / 2;
                        }
                        if (this.Height < btn.Location.Y + btn.Height)
                        {
                            this.Height += btn.Height - 30;
                        }
                        btnSay++;
                        X += btn.Width;
                        if (btnSay == 4)
                        {
                            X = 0;
                            Y += btn.Height;
                            btnSay = 0;
                        }
                    }
                } 
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            QR_ve_Excel.secilenYer = (Button)sender;
            QR_ve_Excel qr = new QR_ve_Excel();
            qr.Show();
            this.Hide();
        }
    }
}
