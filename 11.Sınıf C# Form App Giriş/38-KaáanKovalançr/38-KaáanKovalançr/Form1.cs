using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _38_KaçanKovalanır
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Location = new Point(rnd.Next(1, this.Width - 100), rnd.Next(1, this.Height - 100));

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap resim = new Bitmap(new Bitmap("çaki.jpg"), 25, 25);
            Cursor yeniimlec = new Cursor(resim.GetHicon());
            this.Cursor = yeniimlec;
        }
    }
}
