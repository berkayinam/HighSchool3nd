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

namespace Otopark
{
   
    public partial class UcretFormu : Form
    {
        //public arac a = new arac();
        public int id = -1;
        public UcretFormu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UcretFormu_Load(object sender, EventArgs e)
        {
            string vtYolu = @"Data Source=LAPTOP-KE1HCSOF\SQLEXPRESS;Initial Catalog=oto;Integrated Security=True";
            arac a = new arac();
            try
            {
                SqlConnection cnn = new SqlConnection(vtYolu);
                SqlCommand cmd = new SqlCommand("select * from araclar where id=@id", cnn);
                cmd.Parameters.AddWithValue("@id", id);
               
                cnn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    a.id = Convert.ToInt32(dr[0]);
                    a.plaka = (dr[1]).ToString();
                    a.girisTarihi = Convert.ToDateTime(dr[2]);
                    a.cikisTarihi = Convert.ToDateTime(dr[3]);
                    a.ucret = Convert.ToInt32(dr[4]);
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "hata1");
            }

            label1.Text = a.plaka;
            label2.Text = a.girisTarihi.ToString();
            label3.Text = a.cikisTarihi.ToString();
            label4.Text = a.ucret.ToString();
        }
    }
}
