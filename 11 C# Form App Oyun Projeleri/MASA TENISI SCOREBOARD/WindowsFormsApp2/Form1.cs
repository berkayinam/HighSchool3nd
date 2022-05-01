using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Properties;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        int attırma = 0,set=0,set1=0;
        bool k;
        private void adam1_Click(object sender, EventArgs e)
        {
            
            attırma++;
            s++;
            if (attırma==11 && artı < 10)
            {
                attırma = 0;
                artı = 0;
                set++;
                label5.Text = set.ToString();
            }
            else
            {
                if (artı >= 10 && attırma >= 10)
                {
                    k = true;
                }
                
                if (k)
                {
                    if ((artı - attırma) == 2)
                    {
                        artı = 0;
                        attırma = 0;
                        set1++;
                        label6.Text = set1.ToString();
                    }
                }
            }

            kontrol();
            adam1.Text = attırma.ToString();
            adam2.Text = artı.ToString();
            if (set==3||set1==3)
            {
                adam1.Enabled = false;
                adam2.Enabled = false;
            }
        }
        ResourceManager rm = Resources.ResourceManager;
        int s = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = (Bitmap)rm.GetObject(1.ToString());
            pictureBox2.Image = null;
            
            if (attırma == artı || attırma - artı == 2)
            {

            }
            
        }
        int artı = 0;

        private void adam2_Click(object sender, EventArgs e)
        {
            artı++;
            s++;
            if (artı == 11 && attırma < 10)
            {
                artı = 0;
                attırma = 0;
                set1++;
                label6.Text = set1.ToString();
            }
            else
            {
                if (artı >= 10 && attırma >= 10)
                {
                    k = true;
                }

                if (k)
                {
                    if ((artı - attırma) == 2)
                    {
                        artı = 0;
                        attırma = 0;
                        set1++;
                        label6.Text = set1.ToString();
                    }
                }
            }
            kontrol();
            adam2.Text = artı.ToString();
            adam1.Text = attırma.ToString();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = textBox1.Text;
            label2.Text = textBox2.Text;
            textBox1.Visible = false;
            textBox2.Visible = false;
            button1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label7.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (s == 2)
            {
                if (pictureBox1.Image == null)
                {
                    pictureBox1.Image = (Bitmap)rm.GetObject(1.ToString());
                    pictureBox2.Image = null;
                }
                else if (pictureBox2.Image == null)
                {
                    pictureBox2.Image = (Bitmap)rm.GetObject(1.ToString());
                    pictureBox1.Image = null;
                }
                s = 0;
            }
            else if (artı >= 10 && attırma >= 10)
            {
                if (s == 1)
                {
                    if (pictureBox1.Image == null)
                    {
                        pictureBox1.Image = (Bitmap)rm.GetObject(1.ToString());
                        pictureBox2.Image = null;
                    }
                    else if (pictureBox2.Image == null)
                    {
                        pictureBox2.Image = (Bitmap)rm.GetObject(1.ToString());
                        pictureBox1.Image = null;
                    }
                    s = 0;
                }
            }
        }

        private void kontrol()
        {
            if (set==3)
            {
                MessageBox.Show(label1.Text + " kazandı");
            }
            else if (set1==3)
            {
                MessageBox.Show(label2.Text + " kazandı");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = (Bitmap)rm.GetObject(1.ToString());
            pictureBox1.Image = null;

        }
    }
}
