using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saniye =0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            label1.Text = saniye.ToString();
        }    

       

        private void radioButonOrtakOlay(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                timer1.Start();
            }
            else if (radioButton2.Checked==true)
            {
                timer1.Stop();
            }
        }

        
    }
}
