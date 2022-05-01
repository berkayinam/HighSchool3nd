using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _46_DokunmaYanarsın
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cursor.Position = new Point(0,0);
            Bitmap bmp = new Bitmap(new Bitmap("insan.png"), 25, 25);
            Cursor yenıCursor = new Cursor(bmp.GetHicon());
            this.Cursor = yenıCursor;
        }

        private void button18_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Position = new Point(0,0);
        }

        private void button19_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("bravo");
        }
    }
}
