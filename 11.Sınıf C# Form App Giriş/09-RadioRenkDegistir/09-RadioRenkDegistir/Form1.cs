using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_RadioRenkDegistir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Blue;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Yellow; 
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Purple; 
        }

        private void radioButton6_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Blue;
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Yellow;
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Purple;
            //textBox1.BackColor =Color.FromKnownColor(KnownColor.Violet);
            //textBox1.BackColor = Color.FromName("red");
            //textBox1.BackColor = Color.FromArgb(110, 175, 255);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
