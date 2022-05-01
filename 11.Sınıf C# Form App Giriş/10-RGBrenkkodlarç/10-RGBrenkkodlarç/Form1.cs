using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_RGBrenkkodları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
            label2.ForeColor = Color.Green;
            label3.ForeColor = Color.Blue;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //if (textBox1.Text==""||textBox2.Text==""||textBox3.Text=="")
            //{
            //    MessageBox.Show("renk kodu 0-255 arasında olmalı");
            //}else
            //{
            //    this.BackColor = Color.FromArgb(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            //}
                
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {           
            this.BackColor = Color.FromArgb(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value), Convert.ToInt32(numericUpDown3.Value));
        }
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            
            this.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
