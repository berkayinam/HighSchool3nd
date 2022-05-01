using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ulong a = 0, b = 1;
        ulong asal = 5;
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Convert.ToInt16(textBox1.Text); i++)
            {
                ulong c = a + b;
                listBox1.Items.Add(a);
                a = b;
                b = c;                
            }
            timer1.Stop();
        }
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ulong.Parse(listBox1.Text) == 0)
            {
                label1.Text = "Asal Değildir.";
            }
            else
            {
                for (ulong i = 2; i < ulong.Parse(listBox1.Text); i++)
                {
                    if (ulong.Parse(listBox1.Text) % i == 0)
                    {
                        asal = 0;
                    }
                }
                if (asal == 0)
                {
                    label1.Text = "Asal Değildir.";
                }
                else
                {
                    label1.Text = "Asal Sayıdır.";
                }
                asal = 1;
            }           
        }

        private void button_Gir_Click(object sender, EventArgs e)
        {
            timer1.Start();           
        }
    }
}
