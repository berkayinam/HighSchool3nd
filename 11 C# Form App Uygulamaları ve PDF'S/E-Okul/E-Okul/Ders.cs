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

namespace E_Okul
{
    public partial class Ders : Form
    {
        public Ders()
        {
            InitializeComponent();
        }

        private void button_Cik_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void button_Ekle_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-KE1HCSOF\SQLEXPRESS;Initial Catalog=deneme;Integrated Security=True");
            cnn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO dTablo(Dersler) values('" + textBox_Ders.Text + "')", cnn);
                int a = cmd.ExecuteNonQuery();
                if (a == 1)
                {
                    MessageBox.Show("Ders Eklendi..!");
                    textBox_Ders.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cnn.Close();
            
        }

        private void Ders_Load(object sender, EventArgs e)
        {

        }

        private void Ders_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
