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
    public partial class Güncelle : Form
    {
        public Güncelle()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection(@"Server=94.73.148.47;Database=u8412932_bahadir;Uid=u8412932_bahadir;Pwd='RPqz76F2';");
        private void Güncelle_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter sorgu = new MySqlDataAdapter("select * from ana_yer_tablosu ORDER BY Ana_Yer_ID ASC", baglanti);
            sorgu.Fill(dt);
            comboBox1.ValueMember = "Ana_Yer_ID";
            comboBox1.DisplayMember = "Ana_Yer_Adi";
            comboBox1.DataSource = dt;

            DataTable dt2 = new DataTable();
            MySqlDataAdapter sorgu2 = new MySqlDataAdapter("Select * from okul_malzeme_tablosu where Ana_Yer_ID=" + comboBox1.SelectedValue + " AND Yer_ID =" + comboBox2.SelectedValue + " ", baglanti);
            sorgu2.Fill(dt2);
            comboBox3.ValueMember = "ID";
            comboBox3.DisplayMember = "Malzeme_Adi";
            comboBox3.DataSource = dt2;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            if (comboBox1.SelectedIndex != -1)
            {
                DataTable dt = new DataTable();
                MySqlDataAdapter sorgu2 = new MySqlDataAdapter("Select * from yer_tablosu where Ana_Yer_ID=" + comboBox1.SelectedValue + "", baglanti);
                sorgu2.Fill(dt);
                comboBox2.ValueMember = "Yer_ID";
                comboBox2.DisplayMember = "Yer_Adi";
                comboBox2.DataSource = dt;
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


        private void ComboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Txt_Yeri.Text = comboBox2.Text;
        }

        private void GercekGuncelleTablo()
        {
            MySqlConnection cnn = new MySqlConnection(@"Server=94.73.148.47;Database=u8412932_bahadir;Uid=u8412932_bahadir;Pwd='RPqz76F2';");
            MySqlCommand cmd = new MySqlCommand("UPDATE okul_malzeme_tablosu SET Malzeme_Adedi = @malzemeAdet WHERE ID = @id", cnn);
            cmd.Parameters.AddWithValue("@malzemeAdet", int.Parse(Txt_Adedi.Text));
            cmd.Parameters.AddWithValue("@id", comboBox3.SelectedValue);
            cnn.Open();
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Güncellendi!");
                }
                else
                {
                    MessageBox.Show("Güncellenemedi!");
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SanalGuncelleTablo()
        {
            MySqlConnection cnn = new MySqlConnection(@"Server=94.73.148.47;Database=u8412932_bahadir;Uid=u8412932_bahadir;Pwd='RPqz76F2';");
            MySqlCommand cmd = new MySqlCommand("UPDATE okul_malzeme_view SET Malzeme_Adedi = @malzemeAdet WHERE ID = @id", cnn);
            cmd.Parameters.AddWithValue("@malzemeAdet", int.Parse(Txt_Adedi.Text));
            cmd.Parameters.AddWithValue("@id", comboBox3.SelectedValue);
            cnn.Open();
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Güncellendi!");
                }
                else
                {
                    MessageBox.Show("Güncellenemedi!");
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            GercekGuncelleTablo();
            SanalGuncelleTablo();
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Text = " ";
            if (comboBox1.SelectedIndex != -1)
            {
                DataTable dt = new DataTable();
                MySqlDataAdapter sorgu3 = new MySqlDataAdapter("Select * from okul_malzeme_tablosu where Yer_ID=" + comboBox2.SelectedValue + "", baglanti);
                sorgu3.Fill(dt);
                comboBox3.ValueMember = "ID";
                comboBox3.DisplayMember = "Malzeme_Adi";
                comboBox3.DataSource = dt;
                Txt_Yeri.Text = comboBox2.Text;
            }

        }
    }
}
