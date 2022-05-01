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
            res1 = rnd.Next(0, 3);
            res2 = rnd.Next(0, 3);
            res3 = rnd.Next(0, 3);
            pictureBox1.ImageLocation = res1+".jpg";
            pictureBox2.Image = Image.FromFile(res2+".jpg");
            pictureBox3.ImageLocation = res3+".jpg";
            if (res1==res2&&res2==res3)
            {
                pictureBox5.Visible = true;

            }
        }
    }
}
