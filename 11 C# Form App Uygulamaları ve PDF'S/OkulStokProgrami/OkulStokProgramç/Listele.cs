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
    public partial class Listele : Form
    {
        public Listele()
        {
            InitializeComponent();
        }

        List<string> anaYerler = new List<string>();
        int btnSay = 0, X = 0, Y = 0;

        private void Listele_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            Giris f1 = new Giris();
            f1.Show();
            this.Hide();
        }

        private void Listele_Load(object sender, EventArgs e)
        {
            MySqlConnection cnn = new MySqlConnection(@"Server=94.73.148.47;Database=u8412932_bahadir;Uid=u8412932_bahadir;Pwd='RPqz76F2';");
            MySqlCommand cmd = new MySqlCommand("SELECT Ana_Yer_Adi FROM ana_yer_tablosu", cnn);
            try
            {
                cnn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    anaYerler.Add(dr[0].ToString());
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            for (int i = 0; i < anaYerler.Count; i++)
            {
                Button btn = new Button
                {
                    Size = new Size(221, 155),
                    Location = new Point(5 + X, 25 + Y),
                    Text = anaYerler[i].ToString(),
                    Font = Btn_Font.Font
                };
                btn.Size = new Size(221, 155);
                btn.Location = new Point(5 + X, 25 + Y);
                btn.Text = anaYerler[i].ToString();
                btn.Font = Btn_Font.Font;
                btn.Click += Btn_Click;
                Controls.Add(btn);
                if (this.Width < btn.Location.X + btn.Width)
                {
                    this.Width += btn.Width / 2;
                }
                if (this.Height < btn.Location.Y + btn.Height)
                {
                    this.Height += btn.Height - 30;
                }
                btnSay++;
                X += btn.Width;
                if (btnSay == 4)
                {
                    X = 0;
                    Y += btn.Height;
                    btnSay = 0;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Goruntule.secilenAnaYer = (Button)sender;
            Goruntule f1 = new Goruntule();
            f1.Show();
            this.Hide();
        }
    }
}
