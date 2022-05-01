using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _45_HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string metin = textBox1.Text;
            double[] dizi=new double[metin.Length];
            int sıra = 0;
            double sonuç = 0;
            for (int i = 0; i < metin.Length; i=i+2)
            {
                dizi[sıra] = Convert.ToDouble(metin.Substring(i, 1));
                sıra++;
            }
            sıra=1;
            sonuç = dizi[0];
            for (int i = 1; i < metin.Length; i = i + 2)
            {
                if (metin.Substring(i, 1)=="+")
                {
                    sonuç += dizi[sıra];
                }
                else if (metin.Substring(i, 1) == "-")
                {
                    sonuç -= dizi[sıra];
                }
                else if (metin.Substring(i, 1) == "*")
                {
                    sonuç *= dizi[sıra];
                }
                else if (metin.Substring(i, 1) == "/")
                {
                    sonuç /= dizi[sıra];
                }
                sıra ++;
            }
            label1.Text = sonuç.ToString();
           
            
        }
    }
}
