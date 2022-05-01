using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _57_contextmenustrip
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
        Button tıklananbuton;
        private void button13_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            if (e.Button==MouseButtons.Right)
            {
                tıklananbuton = btn;
            }
        }
        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tıklananbuton.Text = "O";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
