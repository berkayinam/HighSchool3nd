using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SırlamaAlgoritması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] dizi = new int[101];
        int gecici;
        Random r = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = r.Next(1, 10001);
            }
            foreach (int a in dizi)
            {
                listBox1.Items.Add(a);
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= dizi.Length - 1; i++)
            {
                for (int j = 0; j < dizi.Length - 1; j++)
                {
                    if (dizi[j + 1] > dizi[j])
                    {
                        gecici = dizi[j];
                        dizi[j] = dizi[j + 1];
                        dizi[j + 1] = gecici;
                    }
                }
            }
            foreach (int item in dizi)
            {
                listBox2.Items.Add(item);
            }
        }
    }
}
