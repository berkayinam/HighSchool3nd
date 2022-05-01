using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void metot()
        {
            label1.Text = textBox1.Text + textBox2.Text;
        }
        void topla(int s1, int s2)
        {
            label1.Text = (s1 + s2).ToString();
        }
        void topla(int s1, int s2,int s3)
        {
            label1.Text = (s1 + s2-s3).ToString();
        }
        int topla1(int s1,int s2,int s3)
        {
           int  sonuc = s1 + s2 + s3;
            return sonuc ;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            metot();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            topla(4, 5);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            topla(12, 15);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = topla1(3, 4, 5).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            topla(4,5,9);
        }
    }
}
