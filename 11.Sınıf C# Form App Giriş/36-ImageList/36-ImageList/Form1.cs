using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _36_ImageList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ımageList1.Images[rnd.Next(0,3)];
        }
    }
}
