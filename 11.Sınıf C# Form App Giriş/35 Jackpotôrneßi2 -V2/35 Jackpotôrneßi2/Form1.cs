using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _35_JackpotÖrneği2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int res1, res2, res3;
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            sayac = 0;
            pictureBox5.Visible = false;
            timer1.Start();   
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            res1 = rnd.Next(0, 3);
            res2 = rnd.Next(0, 3);
            res3 = rnd.Next(0, 3);
            pictureBox1.ImageLocation = res1 + ".jpg";
            pictureBox2.Image = Image.FromFile(res2 + ".jpg");
            pictureBox3.ImageLocation = res3 + ".jpg";
            sayac++;
            if (sayac==7)
            {
                timer1.Interval = 100;
            }
            if (sayac==14)
            {
                timer1.Stop();
                if (res1==res2&&res2==res3)
                {
                    pictureBox5.Visible = true;
                }
                
            }
           
        }
    }
}
