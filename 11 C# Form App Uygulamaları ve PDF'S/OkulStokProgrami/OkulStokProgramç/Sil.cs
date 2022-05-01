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
    public partial class Sil : Form
    {
        public Sil()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection(@"Server=94.73.148.47;Database=u8412932_bahadir;Uid=u8412932_bahadir;Pwd='RPqz76F2';");
        private void Sil_Load(object sender, EventArgs e)
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
            comboBox3.Text = "";
            if (comboBox1.SelectedIndex != -1)
            {
                DataTable dt = new DataTable();
                MySqlDataAdapter sorgu2 = new MySqlDataAdapter("Select * from yer_tablosu where Ana_Yer_ID=" + comboBox1.SelectedValue + "", baglanti);
                sorgu2.Fill(dt);
                comboBox2.ValueMember = "Yer_ID";
                comboBox2.DisplayMember = "Yer_Adi";
                comboBox2.DataSource = dt;
            }
        }

        private void Gerceksiltablo()
        {
            MySqlConnection cnn = new MySqlConnection(@"Server=94.73.148.47;Database=u8412932_bahadir;Uid=u8412932_bahadir;Pwd='RPqz76F2';");
            MySqlCommand cmd = new MySqlCommand("DELETE FROM okul_malzeme_tablosu WHERE ID = @id", cnn);
            cmd.Parameters.AddWithValue("@id", comboBox3.SelectedValue);
            cnn.Open();
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Silindi!");
                }
                else
                {
                    MessageBox.Show("Silinemedi!");
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Sanalsiltablo()
        {
            MySqlConnection cnn = new MySqlConnection(@"Server=94.73.148.47;Database=u8412932_bahadir;Uid=u8412932_bahadir;Pwd='RPqz76F2';");
            MySqlCommand cmd = new MySqlCommand("DELETE FROM okul_malzeme_view WHERE ID = @id", cnn);
            cmd.Parameters.AddWithValue("@id", comboBox3.SelectedValue);
            cnn.Open();
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Silindi!");
                }
                else
                {
                    MessageBox.Show("Silinemedi!");
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            Gerceksiltablo();
            Sanalsiltablo();
        }


        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Text = "";
            if (comboBox1.SelectedIndex != -1)
            {
                DataTable dt = new DataTable();
                MySqlDataAdapter sorgu2 = new MySqlDataAdapter("Select * from okul_malzeme_tablosu where Yer_ID=" + comboBox2.SelectedValue + "", baglanti);
                sorgu2.Fill(dt);
                comboBox3.ValueMember = "ID";
                comboBox3.DisplayMember = "Malzeme_Adi";
                comboBox3.DataSource = dt;
            }
        }
    }
}
