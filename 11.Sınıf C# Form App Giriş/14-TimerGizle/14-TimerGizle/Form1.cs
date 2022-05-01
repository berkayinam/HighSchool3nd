using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_TimerGizle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int butonNo = 1, sonButonNo = 84;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            this.Controls["button" + butonNo].Visible = false;
            butonNo++;
            if (butonNo > sonButonNo)
            {
                timer1.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
