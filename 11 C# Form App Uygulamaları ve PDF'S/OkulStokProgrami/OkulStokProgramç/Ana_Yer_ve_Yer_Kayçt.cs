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
    public partial class Ana_Yer_ve_Yer_Kayıt : Form
    {
        public Ana_Yer_ve_Yer_Kayıt()
        {
            InitializeComponent();
        }

        private void Btn_Ana_Yer_Ekle_Click(object sender, EventArgs e)
        {
            MySqlConnection cnn = new MySqlConnection(@"Server=94.73.148.47;Database=u8412932_bahadir;Uid=u8412932_bahadir;Pwd='RPqz76F2';");
            MySqlCommand cmd = new MySqlCommand("INSERT INTO ana_yer_tablosu ( Ana_Yer_Adi ) VALUES ( @ana_yer_adi )", cnn);
            cmd.Parameters.AddWithValue("@ana_yer_adi", Txt_Ana_Yeri.Text);
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
        MySqlConnection baglanti = new MySqlConnection(@"Server=94.73.148.47;Database=u8412932_bahadir;Uid=u8412932_bahadir;Pwd='RPqz76F2';");
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txt_Yeri.Text = "";
            Txt_Ana_Yeri_ID.Text = comboBox1.SelectedValue.ToString();
            if (int.Parse(Txt_Ana_Yeri_ID.Text) > 7)
            {
                Txt_Yeri.Enabled = false;
                Txt_Yeri.Text = comboBox1.Text;
            }
            else
            {
                Txt_Yeri.Enabled = true;
            }
        }

        private void Ana_Yer_ve_Yer_Kayıt_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter sorgu = new MySqlDataAdapter("select * from ana_yer_tablosu ORDER BY Ana_Yer_ID ASC", baglanti);
            sorgu.Fill(dt);
            comboBox1.ValueMember = "Ana_Yer_ID";
            comboBox1.DisplayMember = "Ana_Yer_Adi";
            comboBox1.DataSource = dt;
            Txt_Ana_Yeri_ID.Text = comboBox1.SelectedValue.ToString();
        }

        private void Btn_Yer_Ekle_Click(object sender, EventArgs e)
        {
            MySqlConnection cnn = new MySqlConnection(@"Server=94.73.148.47;Database=u8412932_bahadir;Uid=u8412932_bahadir;Pwd='RPqz76F2';");
            MySqlCommand cmd = new MySqlCommand("INSERT INTO yer_tablosu ( Ana_Yer_ID, Yer_Adi ) VALUES ( @anaid, @yeradi)", cnn);
            cmd.Parameters.AddWithValue("@anaid", Txt_Ana_Yeri_ID.Text);
            cmd.Parameters.AddWithValue("@yeradi", Txt_Yeri.Text);
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
    }
}
