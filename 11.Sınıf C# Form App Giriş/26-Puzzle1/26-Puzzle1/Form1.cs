using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_Puzzle1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void PictureboxSilme(int adet)
        {
            for (int i = 1; i <= adet; i++)
            {
                this.Controls.RemoveByKey("pbx"+i);
            }
            
        }
        void PictureboxOlustur(int adet)
        {
           // MessageBox.Show(this.Controls.Count.ToString());
            PictureboxSilme(this.Controls.Count-1);
           
            int x = 30, y = 30;
            for (int i = 1; i <= adet*adet; i++)
            {
                PictureBox pbx = new PictureBox();
                pbx.Name = "pbx" + i;
                pbx.Size = new Size(50, 50);
                pbx.Location = new Point(x, y);
                pbx.BackColor = Color.Red;
                this.Controls.Add(pbx);
                x = x + 55;
                if (i % adet == 0) 
                {
                    y += 55;
                    x = 30;
                }
            }
        }
        private void x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            PictureboxOlustur(3);
           
        }

        private void x4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureboxOlustur(4);
        }

        private void x5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureboxOlustur(5);
        }

        private void x6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureboxOlustur(6);
        }

        private void x7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureboxOlustur(7);
        }

        private void x8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureboxOlustur(8);
        }

        private void x9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureboxOlustur(9);
        }

        private void x10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureboxOlustur(10);
        }
    }
}
