using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22_Asal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı =Convert.ToInt32(textBox1.Text);
            bool asal = true;
            for (int i = 2; i < sayı; i++)
            {
                if (sayı%i==0)
                {
                    asal = false; 
                }
            }
            if (asal==true)
            {
                label1.Text = "asal sayı";
            }
            else
            {
                label1.Text = "asal sayı değil";
            }
        }
    }
}
