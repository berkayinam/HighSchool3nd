using System;
using System.Collections;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        ArrayList idler = new ArrayList();
        ArrayList adlar = new ArrayList();
        ArrayList soyadlar = new ArrayList();
        ArrayList tcler = new ArrayList();
        ArrayList telefonlar = new ArrayList();

        private void Form3_Load(object sender, EventArgs e)
        {
            listeyiDoldur();
        }

        private void listeyiDoldur()
        {
            listBox1.Items.Clear();
            idler.Clear();
            adlar.Clear();
            soyadlar.Clear();
            tcler.Clear();
            telefonlar.Clear();

            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-KE1HCSOF\SQLEXPRESS;Initial Catalog=kullaniciGirisi;Integrated Security=True");
            string cmdText = "select * from ogrenciler";
            Debug.Print(cmdText);
            SqlCommand cmd = new SqlCommand(cmdText, cnn);
            cnn.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                idler.Add(dr[0]);
                adlar.Add(dr[1]);
                soyadlar.Add(dr[2]);
                tcler.Add(dr[3]);
                telefonlar.Add(dr[4]);
            }

            cnn.Close();

            for (int i = 0; i < idler.Count; i++)
            {
                listBox1.Items.Add(adlar[i] + " " + soyadlar[i]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int si = listBox1.SelectedIndex;
            textBox2.Text = adlar[si].ToString();
            textBox3.Text = soyadlar[si].ToString();
            textBox4.Text = tcler[si].ToString();
            textBox5.Text = telefonlar[si].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-KE1HCSOF\SQLEXPRESS;Initial Catalog=kullaniciGirisi;Integrated Security=True");
            string cmdText = "delete from ogrenciler where ogrenciID=" + idler[listBox1.SelectedIndex];
            Debug.Print(cmdText);
            SqlCommand cmd = new SqlCommand(cmdText, cnn);
            cnn.Open();
            int donenDeger =cmd.ExecuteNonQuery();
            if (donenDeger == 1)
            {
                MessageBox.Show("silme başarılı");
                listeyiDoldur();
            }
            else
            {
                MessageBox.Show("silme baarısız");
            }
            cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-KE1HCSOF\SQLEXPRESS;Initial Catalog=kullaniciGirisi;Integrated Security=True");
            string cmdText = "update ogrenciler set ogrenciAdi='"+textBox2.Text+"',ogrenciSoyad='"+textBox3.Text+"',ogrenciTc='"+textBox4.Text+"',telefon='"+textBox5.Text+"'where ogrenciID = "+idler[listBox1.SelectedIndex]+"; ";
            Debug.Print(cmdText);
            SqlCommand cmd = new SqlCommand(cmdText, cnn);
            cnn.Open();
            int donenDeger = cmd.ExecuteNonQuery();
            if (donenDeger == 1)
            {
                MessageBox.Show("güncelleme başarılı");
                listeyiDoldur();
            }
            else
            {
                MessageBox.Show("güncelleme baarısız");
            }
            cnn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
