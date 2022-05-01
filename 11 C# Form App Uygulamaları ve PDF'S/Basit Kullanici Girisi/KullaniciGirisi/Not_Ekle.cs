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
    public partial class Not_Ekle : Form
    {
        public Not_Ekle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnaForm frr = new AnaForm();
            frr.Show();
            this.Hide();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        private void Not_Ekle_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source = PC1; Initial Catalog = eokul; Integrated Security = True");
            cmd = new SqlCommand("SELECT * FROM Kayit", con);
            con.Open();
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            con = new SqlConnection(@"Data Source = PC1; Initial Catalog = eokul; Integrated Security = True");
            cmd = new SqlCommand("SELECT * FROM Derss", con);
            con.Open();
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i][1].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
