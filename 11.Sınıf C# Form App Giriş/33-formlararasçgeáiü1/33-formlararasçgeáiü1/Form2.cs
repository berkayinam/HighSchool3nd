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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string MyProperty
        {
            get;
            set;
        }
        public string değişken;
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = MyProperty;
            label2.Text = değişken;
        }
    }
}
