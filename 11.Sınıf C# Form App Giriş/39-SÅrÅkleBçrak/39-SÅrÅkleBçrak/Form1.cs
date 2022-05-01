using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _39_SürükleBırak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool sürüklemedurumu = false;
        Point ilkkonum;
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            sürüklemedurumu = true;
            ilkkonum = e.Location;
            button1.Cursor = Cursors.NoMove2D;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (sürüklemedurumu == true)
            {
                button1.Left = e.X + (button1.Left - ilkkonum.X);
                button1.Top = e.Y + (button1.Top - ilkkonum.Y);
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            sürüklemedurumu = false;
            button1.Cursor = Cursors.Default;
        }
    }
}
