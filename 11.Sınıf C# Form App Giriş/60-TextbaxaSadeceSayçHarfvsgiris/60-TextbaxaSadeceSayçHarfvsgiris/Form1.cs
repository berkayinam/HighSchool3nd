using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _60_TextbaxaSadeceSayıHarfvsgiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //   e.Handled = true;//giriş yapılamaz. Değer False olmalı ki giriş yapılsın.
            //Sadece Rakam
            e.Handled = !char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sadece Harf
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
              
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sadece Harf ve boşluk
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
              && !char.IsSeparator(e.KeyChar);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ASCII karakter tablosuna göre özel karakter kısıtlama
            if (e.KeyChar == '£' || e.KeyChar == '½' ||
                e.KeyChar == '€' || e.KeyChar == '₺' ||
                e.KeyChar == '¨' || e.KeyChar == 'æ' ||
                e.KeyChar == 'ß' || e.KeyChar == '´')
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 33 && (int)e.KeyChar <= 47)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 58 && (int)e.KeyChar <= 64)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 91 && (int)e.KeyChar <= 96)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 123 && (int)e.KeyChar <= 127)
            {
                e.Handled = true;
            }
        }
        int sayı;
        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = sayı.ToString();
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            sayı = (int)e.KeyChar;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            //< = > ? KARAKTERLERİ HARİCİNDE GİRİŞE İZİN VERMEZ
            if ((int)e.KeyChar >= 60 && (int)e.KeyChar <= 63)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
