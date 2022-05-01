using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29_picturebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pictureBox2.ImageLocation="C:\\Users\\inan\\Desktop\\araba1.png";
            pictureBox2.ImageLocation = @"C:\Users\inan\Desktop\araba1.png";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Image.FromFile(@"C:\Users\inan\Desktop\araba1.png");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Image.FromFile("araba1.png");
        }
    }
}
