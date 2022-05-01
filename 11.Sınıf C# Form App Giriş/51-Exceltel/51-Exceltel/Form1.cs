using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _51_Exceltel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Application.StartupPath+@"\tel.xlsx; Extended Properties='Excel 12.0 xml;HDR=YES;'");
        public void listele()
        {
            baglanti.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from [AA$] ", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;
            baglanti.Close();
            
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Insert into [AA$] (NUMARA,AD,SOYAD,TEL) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Update [AA$] set ad='" + textBox2.Text + "',soyad='" + textBox3.Text + "',tel='" + textBox4.Text + "' where numara=" + textBox1.Text + " ";
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();
        }
    }
}
