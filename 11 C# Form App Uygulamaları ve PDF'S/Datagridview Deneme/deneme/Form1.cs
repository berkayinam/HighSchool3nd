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

namespace deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList ad = new ArrayList();
        SqlConnection cnn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
        SqlCommandBuilder cb = new SqlCommandBuilder();
         private void Form1_Load(object sender, EventArgs e)
        {
            veriYukle();
        }

        private void listele()
        {
            string cmdText = "select * from Kayit";
            Debug.Print(cmdText);
            SqlCommand cmd = new SqlCommand(cmdText, cnn);
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ad.Add(dr[1]);
            }
        }

        private void veriYukle()
        {
            cnn = new SqlConnection(@"Data Source=LAPTOP-KE1HCSOF\SQLEXPRESS;Initial Catalog=Kayitlar;Integrated Security=True");
            da = new SqlDataAdapter("select * from Kayit", cnn);
            cb = new SqlCommandBuilder(da);
            da.Fill(dt);
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            dataGridView1.Columns.Remove("id");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlCommand ekleCmd;
            int etkilenen = -1;
            try
            {
                string sqlekle = "Insert into Kayit (ad,soyad,tc) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                ekleCmd = new SqlCommand(sqlekle, cnn);
                cnn.Open();
                etkilenen = ekleCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cnn.Close();
            if (etkilenen == 1)
            {
                MessageBox.Show("ekleme işlemi başarılı");
            }
            else
            {
                MessageBox.Show("başarısız");
            }
            cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            da.Update((DataTable)bs.DataSource);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(@"Data Source=LAPTOP-KE1HCSOF\SQLEXPRESS;Initial Catalog=Kayitlar;Integrated Security=True");
            da = new SqlDataAdapter("select * from Kayit", cnn);
            cb = new SqlCommandBuilder(da);
            da.Fill(dt);
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
