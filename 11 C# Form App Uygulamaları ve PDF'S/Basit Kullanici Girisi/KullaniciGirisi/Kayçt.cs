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

namespace KullaniciGirisi
{
    public partial class Kayıt : Form
    {
        public Kayıt()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon = new SqlConnection(@"Data Source=PC1;Initial Catalog=eokul;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand ekleCmd;
            int etkilenen = -1;
            try
            {
                string sqlekle = "Insert into Kayit(ad,soyad,tc,sinif,sube,parola)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','"+textBox6.Text+"')";
                ekleCmd = new SqlCommand(sqlekle, sqlCon);
                sqlCon.Open();
                etkilenen = ekleCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            sqlCon.Close();
            if (etkilenen == 1)
            {
                MessageBox.Show("ekleme işlemi başarılı");
            }
            else
            {
                MessageBox.Show("başarısız");
            }
            Giris gr = new Giris();
            gr.Show();
            this.Hide();

            sqlCon.Close();
        }

        private void Kayıt_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("UPDATE TO bilgTablo SET('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','"+textBox6.Text+"',)", sqlCon);
                int a = cmd.ExecuteNonQuery();
                if (a == 1)
                {
                    MessageBox.Show("Kayıt Başarıyla Güncellendi..!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kul_Gir fll = new Kul_Gir();
            fll.Show();
            this.Hide();
        }
    }
}
