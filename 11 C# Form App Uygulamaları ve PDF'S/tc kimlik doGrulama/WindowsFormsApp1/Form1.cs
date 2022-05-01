using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            string tc = textBox1.Text;

            string bir = tc.Substring(0, 1);
            string iki = tc.Substring(1, 1);
            string üc = tc.Substring(2, 1);
            string dort = tc.Substring(3, 1);
            string bes = tc.Substring(4, 1);
            string alti = tc.Substring(5, 1);
            string yedi = tc.Substring(6, 1);
            string sekiz = tc.Substring(7, 1);
            string dokuz = tc.Substring(8, 1);
            string on = tc.Substring(9, 1);
            string onbir = tc.Substring(10, 1);

            int i1 = Convert.ToInt32(bir);
            int i2 = Convert.ToInt32(iki);
            int i3 = Convert.ToInt32(üc);
            int i4 = Convert.ToInt32(dort);
            int i5 = Convert.ToInt32(bes);
            int i6 = Convert.ToInt32(alti);
            int i7 = Convert.ToInt32(yedi);
            int i8 = Convert.ToInt32(sekiz);
            int i9 = Convert.ToInt32(dokuz);
            int i10 = Convert.ToInt32(on);
            int i11 = Convert.ToInt32(onbir);


            int ilk;
            int sonuc = 0;

            ilk = i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10;

            sonuc = ilk % 10;
            if (sonuc == i11)
            {
                MessageBox.Show("TC DOĞRU");
            }
            else
            {
                MessageBox.Show("TC DOĞRU DEĞİL");
            }
        }

    }
}


