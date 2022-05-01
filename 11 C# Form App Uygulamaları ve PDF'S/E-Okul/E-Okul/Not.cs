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
    public partial class Not : Form
    {
        public Not()
        {
            InitializeComponent();
        }

        SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-KE1HCSOF\SQLEXPRESS;Initial Catalog=deneme;Integrated Security=True");
        private void Not_Load(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM dTablo", cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            try
            {
                while (dr.Read())
                {
                    for (int i = 1; i < dr.VisibleFieldCount; i++)
                    {
                        listBox_Dersler.Items.Add(dr[i].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dr.Close();
            cnn.Close();
        }
        string ders;
        private void listBox_Dersler_SelectedIndexChanged(object sender, EventArgs e)
        {
            ders = listBox_Dersler.SelectedItem.ToString();
        }

        private void button_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Notlar(Ders, Not1, Not2, Kredi) values ('" + ders + "', '" + textBox_Not1.Text + "', '" + textBox_Not2.Text + "', '" + textBox_Kredi.Text + "')", cnn);
                int a = cmd.ExecuteNonQuery();
                if (a == 1)
                {
                    MessageBox.Show("Notlar Eklendi..!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cnn.Close();
        }

        private void button_Cik_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void Not_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
