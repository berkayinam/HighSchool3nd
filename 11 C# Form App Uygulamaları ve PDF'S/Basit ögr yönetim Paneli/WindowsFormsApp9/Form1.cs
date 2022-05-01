using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-KE1HCSOF\SQLEXPRESS;Initial Catalog=kullaniciGirisi;Integrated Security=True");
            string cmdText= "select Count(*) from mudurler where kullaniciAdi='"+textBox1.Text+"' and parola = '"+textBox2.Text+"'";
            Debug.Print(cmdText);
            SqlCommand cmd = new SqlCommand(cmdText, cnn);
            cnn.Open();
            int donenDeger = Convert.ToInt16 ( cmd.ExecuteScalar());

            Debug.Print(donenDeger.ToString());
            if (donenDeger == 1)
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı  parola hatası");
            }
            cnn.Close(); 
        }
    }
}
