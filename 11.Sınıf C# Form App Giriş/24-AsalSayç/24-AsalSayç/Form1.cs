using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_AsalSayı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int boyut;

            if (textBox1.Text=="")
            {
                boyut = 1; 
            }
            else if (Convert.ToInt32(textBox1.Text)==0)
            {
                boyut = 1;
            }
            else if (Convert.ToInt32(textBox1.Text) <0)
            {
                boyut = -1 * Convert.ToInt32(textBox1.Text);
            }
            else
            {
                boyut = int.Parse(textBox1.Text);
            }
            int[] dizi=new int[boyut];
            int sayı;
            for (int i = 0; i < boyut; i++)
            {
                do
                {
                    sayı = rnd.Next(1000);
                } while (Array.IndexOf(dizi, sayı) > -1);
                dizi[i] = sayı;  
            }
            Array.Sort(dizi);
            Array.Reverse(dizi);
            checkedListBox1.Items.Clear();
            for (int i = 0; i < dizi.Length; i++)
            {
                checkedListBox1.Items.Add(dizi[i]);
            }
            
            
        }
        bool AsalKontrol(int sayı)
        {
            bool asal = true;           
            for (int j = 2; j < sayı; j++)
            {
                if (sayı % j == 0)
                {
                    asal = false;
                }
            }
            return asal;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                int s = Convert.ToInt32(checkedListBox1.CheckedItems[i]);
                if (AsalKontrol(s) == true)
                {
                    listBox1.Items.Add(checkedListBox1.CheckedItems[i]);
                }               
                
            }

        }
    }
}
