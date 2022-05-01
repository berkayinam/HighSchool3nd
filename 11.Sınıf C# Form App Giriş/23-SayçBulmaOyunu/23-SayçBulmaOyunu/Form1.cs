using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_SayıBulmaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tekSayı, btnSayı;
        private void Form1_Load(object sender, EventArgs e)
        {
            int x=0,y=0;
            Random rnd = new Random();
            btnSayı = rnd.Next(1, 10);
            for (int i = 1; i <= 256; i++)
            {
                Button btn = new Button();
                btn.Name = "btn" + i;
                btn.Text = btnSayı.ToString() ;
                btn.Size = new Size(25, 25);
                btn.Location = new Point(x, y);
                x = x + 25;
                if (i%16==0)
                {
                    x = 0;
                    y = y + 25;
                }
                btn.Click += btn_Click;
                this.Controls.Add(btn);
            }
            do
            {
                tekSayı = rnd.Next(1, 10);  
            } while (tekSayı==btnSayı);
            this.Controls["btn" + rnd.Next(1, 257)].Text = tekSayı.ToString();
        }

        void btn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Button tıklananbtn = (Button)sender;
            if (tıklananbtn.Text==tekSayı.ToString())
            {
                tıklananbtn.BackColor = Color.Green;
                timer1.Stop();
                MessageBox.Show("oyun bitti");
            }
            else
            {
                tıklananbtn.Visible = false;
            }
              
        }
        int sure = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sure++;
            lblSure.Text = sure.ToString();
        }
    }
}
