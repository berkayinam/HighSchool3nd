using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _57_contextmenustripsınıf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tıklananbuton.Text = "S";
        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tıklananbuton.Text = "O";
        }
        Button tıklananbuton;
        private void button9_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            if (e.Button==MouseButtons.Right)
            {
                tıklananbuton = btn;
            }
        }
    }
}
