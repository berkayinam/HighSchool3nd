
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
    public partial class QR_ve_Excel : Form
    {
        public QR_ve_Excel()
        {
            InitializeComponent();
        }

        public static Button secilenYer;
        List<string> anaYerler = new List<string>();
        List<string> adetler = new List<string>();
        List<string> yerler = new List<string>();
        List<string> barkodString = new List<string>();
        int secilenAnaYerID, secilenYerID;

        private void QR_ve_Excel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            Goruntule f1 = new Goruntule();
            f1.Show();
            this.Hide();
        }

        private void QR_ve_Excel_Load(object sender, EventArgs e)
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


            for (int i = 0; i < anaYerler.Count; i++)
            {
                if (Goruntule.secilenAnaYer.Text == anaYerler[i])
                {
                    secilenAnaYerID = anaYerler.IndexOf(anaYerler[i]) + 1;
                    MySqlConnection cnn = new MySqlConnection(@"Server=94.73.148.47;Database=u8412932_bahadir;Uid=u8412932_bahadir;Pwd='RPqz76F2';");
                    MySqlCommand cmd = new MySqlCommand("SELECT Yer_Adi FROM yer_tablosu WHERE Ana_Yer_ID = @anaYerID", cnn);
                    cmd.Parameters.AddWithValue("@anaYerID", anaYerler.IndexOf(anaYerler[i]) + 1);
                    try
                    {
                        cnn.Open();
                        MySqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            yerler.Add(dr[0].ToString());
                        }
                        dr.Close();
                        cnn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    for (int g = 0; g < yerler.Count; g++)
                    {
                        if (secilenYer.Text == yerler[g])
                        {
                            secilenYerID = yerler.IndexOf(yerler[g]) + 1;
                            Lbl_Yer.Text = secilenYer.Text;
                            MySqlConnection connect = new MySqlConnection(@"Server=94.73.148.47;Database=u8412932_bahadir;Uid=u8412932_bahadir;Pwd='RPqz76F2';");
                            MySqlCommand command = new MySqlCommand("SELECT Malzeme_Adi, Malzeme_Adedi, BarkodString FROM okul_malzeme_tablosu WHERE Ana_Yer_ID = @AnaYerID AND Yer_ID = @yerID", connect);
                            command.Parameters.AddWithValue("@AnaYerID", secilenAnaYerID);
                            command.Parameters.AddWithValue("@yerID", secilenYerID);
                            try
                            {
                                connect.Open();
                                MySqlDataReader dr = command.ExecuteReader();
                                while (dr.Read())
                                {
                                    List_Malzeme.Items.Add(dr[0].ToString());
                                    barkodString.Add(dr[2].ToString());
                                    adetler.Add(dr[1].ToString());
                                }
                                dr.Close();
                                connect.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
            }
        }
        string resimAd;
        private void List_Malzeme_SelectedIndexChanged(object sender, EventArgs e)
        {
            QrYap(Pic_Qr, barkodString[List_Malzeme.SelectedIndex]);
            Lbl_Adet.Text = "Adet: " + adetler[List_Malzeme.SelectedIndex];
            resimAd = anaYerler[List_Malzeme.SelectedIndex] + "_" + yerler[List_Malzeme.SelectedIndex] + "_" + List_Malzeme.SelectedItem.ToString() + ".jpg";
            Btn_Qr_Kaydet.Enabled = true;
        }

        private void Btn_Qr_Kaydet_Click(object sender, EventArgs e)
        {
            Pic_Qr.Image.Save(resimAd);
        }

        private void QrYap(PictureBox pictureBox, string link)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox.Image = qrcode.Draw(link, 50);
        }
    }
}

