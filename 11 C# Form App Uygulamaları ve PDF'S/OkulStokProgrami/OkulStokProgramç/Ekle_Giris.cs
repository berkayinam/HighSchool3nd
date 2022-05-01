using MySql.Data.MySqlClient;
using OfficeOpenXml;
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
    public partial class Ekle_Giris : Form
    {
        public Ekle_Giris()
        {
            InitializeComponent();
        }

        MySqlConnection baglanti = new MySqlConnection(@"Server=94.73.148.47;Database=u8412932_bahadir;Uid=u8412932_bahadir;Pwd='RPqz76F2';");
        private void Ekle_Giris_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter sorgu = new MySqlDataAdapter("select * from ana_yer_tablosu ORDER BY Ana_Yer_ID ASC", baglanti);
            sorgu.Fill(dt);
            comboBox1.ValueMember = "Ana_Yer_ID";
            comboBox1.DisplayMember = "Ana_Yer_Adi";
            comboBox1.DataSource = dt;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            if (comboBox1.SelectedIndex != -1)
            {
                DataTable dt2 = new DataTable();
                MySqlDataAdapter sorgu2 = new MySqlDataAdapter("Select * from yer_tablosu where Ana_Yer_ID=" + comboBox1.SelectedValue + "", baglanti);
                sorgu2.Fill(dt2);
                comboBox2.ValueMember = "Yer_ID";
                comboBox2.DisplayMember = "Yer_Adi";
                comboBox2.DataSource = dt2;
            }
            if (Convert.ToInt32(comboBox1.SelectedValue) > 7)
            {
                Txt_Yeri.Text = comboBox1.Text;
            }
            else
            {
                Txt_Yeri.Text = comboBox2.Text;
            }
        }

        private void DataGridViewEkle()
        {
            DataTable dt3 = new DataTable();
            MySqlDataAdapter sorgu3 = new MySqlDataAdapter($"select * from okul_malzeme_view WHERE Ana_Yer_Adi = '{comboBox1.Text}' AND Yer_Adi = '{comboBox2.Text}';", baglanti);
            sorgu3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }

        private void Gercektablo()
        {
            barkodID = MalzemeID();
            barkod = "www.emrah.work/malzemephp?Id=" + barkodID;
            MySqlConnection cnn = new MySqlConnection(@"Server=94.73.148.47;Database=u8412932_bahadir;Uid=u8412932_bahadir;Pwd='RPqz76F2';");
            MySqlCommand cmd = new MySqlCommand("INSERT INTO okul_malzeme_tablosu (Ana_Yer_ID, Yer_ID, Malzeme_Adi, Malzeme_Adedi, BarkodString) VALUES (@anayerid, @yerid, @malzemeadi, @malzemeadedi, @barkod)", cnn);
            cmd.Parameters.AddWithValue("@anayerid", comboBox1.SelectedValue);
            cmd.Parameters.AddWithValue("@yerid", comboBox2.SelectedValue);
            cmd.Parameters.AddWithValue("@malzemeadi", Txt_Ad.Text);
            cmd.Parameters.AddWithValue("@malzemeadedi", Txt_Adedi.Text);
            cmd.Parameters.AddWithValue("@barkod", barkod);
            try
            {
                cnn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Eklendi!");
                }
                else
                {
                    MessageBox.Show("Eklenemedi!");
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Sanaltablo()
        {
            barkod = "www.emrah.work/malzemephp?Id=" + barkodID;
            MySqlConnection cnn = new MySqlConnection(@"Server=94.73.148.47;Database=u8412932_bahadir;Uid=u8412932_bahadir;Pwd='RPqz76F2';");
            MySqlCommand cmd = new MySqlCommand("INSERT INTO okul_malzeme_view (Ana_Yer_Adi, Yer_Adi, Malzeme_Adi, Malzeme_Adedi, BarkodString) VALUES (@anayeradi, @yeradi, @malzemeadi, @malzemeadedi, @barkod)", cnn);
            cmd.Parameters.AddWithValue("@anayeradi", comboBox1.Text);
            cmd.Parameters.AddWithValue("@yeradi", Txt_Yeri.Text);
            cmd.Parameters.AddWithValue("@malzemeadi", Txt_Ad.Text);
            cmd.Parameters.AddWithValue("@malzemeadedi", Txt_Adedi.Text);
            cmd.Parameters.AddWithValue("@barkod", barkod);
            try
            {
                cnn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Eklendi!");
                }
                else
                {
                    MessageBox.Show("Eklenemedi!");
                }
                cnn.Close();
            }
            catch (Exception ex)
            {

            }
        }

        string barkod, barkodID;
        private void Btn_Ekle_Click(object sender, EventArgs e)
        {
            Gercektablo();
            Sanaltablo();
            DataGridViewEkle();
        }
        private string MalzemeID()
        {
            Random rastgele = new Random();
            string harfler = "ABCDEFGHIJKLMNOPRSTUVYZabcdefghijklmnoprstuvyz1234567890";
            string uret = "";
            for (int i = 0; i < 8; i++)
            {
                uret += harfler[rastgele.Next(harfler.Length)];
            }
            return uret;
        }


        private void ComboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Txt_Yeri.Text = comboBox2.Text;
            DataGridViewEkle();
        }
    }
}
