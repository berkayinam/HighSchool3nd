using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _61_diziyiRstgeleSAyılariledoldurma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte[] sayılar = new byte[10];
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            rnd.NextBytes(sayılar);

            //for (int i = 0; i < 15; i++)
            //{
            //    dizi[i] = rnd.Next(0, 256);
            //}


            foreach (byte item in sayılar)
            {
                listBox1.Items.Add(item.ToString());
            }
        }
        int[] dizi = new int[15];

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                dizi[i] = rnd.Next(0, 256);
            }
            foreach (var item in dizi)
            {
                listBox1.Items.Add(item);
            }
           
        }
    }
}
