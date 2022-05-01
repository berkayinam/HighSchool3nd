using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_RstgeleKelime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] dizi = new string[10];
            dizi[0] = "ali";
            dizi[1] = "mehmet";
            dizi[2] = "hasan";
            dizi[3] = "ayşe";
            dizi[4] = "asım";
            dizi[5] = "seval";
            dizi[6] = "oğuz";
            dizi[7] = "nuri";
            dizi[8] = "abuziddin";
            dizi[9] = "ürşAT";
            Random rnd = new Random();
            int sayı = rnd.Next(10);
            string kelime = dizi[sayı];
            textBox1.Text = kelime;
            int kelimeUzunlugu = kelime.Length;
            label1.Text = kelimeUzunlugu.ToString();
          

        }
    }
}
