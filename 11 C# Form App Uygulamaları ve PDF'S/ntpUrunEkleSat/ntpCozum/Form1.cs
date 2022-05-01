using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ntpCozum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            urun_ekle ue = new urun_ekle();
            ue.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            satis_formu sf = new satis_formu();
            sf.ShowDialog();
        }
    }
}
