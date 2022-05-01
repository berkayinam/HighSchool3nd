using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _54_UygulamaAçma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Microsoft Office\root\Office16\EXCEL.exe");
        }
        //açılmaz çünkü sadece exe çalıştırabilir
        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C: \Users\inan\Desktop\a.xlsx");
        }
    }
}
