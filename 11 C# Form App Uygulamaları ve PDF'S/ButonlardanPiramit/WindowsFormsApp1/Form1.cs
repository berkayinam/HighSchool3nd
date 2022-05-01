using System;
using System.Collections;
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

        private void button_Start_Click_1(object sender, EventArgs e)
        {
            int adet = Int32.Parse(textBox1.Text);
            int basNokX = this.Width / 2 - 25;
            this.Height = adet * 50 + 39;
            int basNokY = -50;
            for (int i = 1; i <= adet; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Button button = new Button();
                    button.Enabled = false;
                    button.Width = 50;
                    button.Height = 50;
                    button.Location = new Point((basNokX + 50 * j) - (i * 25), basNokY + 50 * i);
                    Controls.Add(button);
                }
            }
        }
    }
}
