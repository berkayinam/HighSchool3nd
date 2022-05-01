using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text =textBox1.Text+ button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button10.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
        }
        int sayı1, sayı2;
        string islem; 
        private void topla_Click(object sender, EventArgs e)
        {
            sayı1 = int.Parse(textBox1.Text);
            textBox1.Clear();
            islem = "+";
        }
        int sonuç;
        private void cıkar_Click(object sender, EventArgs e)
        {
            sayı1 = int.Parse(textBox1.Text);
            textBox1.Clear();
            islem = "-";
        }

        private void esittir_Click(object sender, EventArgs e)
        {
            sayı2 = int.Parse(textBox1.Text);
            if (islem=="+")
            {
                sonuç= sayı1 + sayı2;
            }
            else if (islem=="-")
            {
                 sonuç= sayı1 - sayı2;
            }else if (islem=="*")
            {
                 sonuç= sayı1 * sayı2;
            }
            else if (islem == "/")
            {
                sonuç = sayı1 / sayı2;
            }
            
            textBox1.Text = sonuç.ToString();
        }

        private void carp_Click(object sender, EventArgs e)
        {
            sayı1 = int.Parse(textBox1.Text);
            textBox1.Clear();
            islem = "*";
        }

        private void bol_Click(object sender, EventArgs e)
        {
            sayı1 = int.Parse(textBox1.Text);
            textBox1.Clear();
            islem = "/";
        }

        private void clear_Click(object sender, EventArgs e)
        {
           // textBox1.Text = "";
            textBox1.Clear();
        }
    }
}
