using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33_formlararasıgeçiş1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.MyProperty = textBox1.Text;
            frm2.değişken = textBox2.Text;
            //frm2.Show();
            //this.Hide();
            frm2.ShowDialog();

        }
    }
}
