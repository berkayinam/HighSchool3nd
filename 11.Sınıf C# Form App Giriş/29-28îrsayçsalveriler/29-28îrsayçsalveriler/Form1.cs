using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29_28örsayısalveriler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;
            for (int i = 1; i <=16; i++)
            {
                listBox1.Items.Add(x.ToString()+" - "+y.ToString());
                x += 50;
                if (i%4==0)
                {
                    x = 0;
                    y += 50;
                }
            }
        }
    }
}
