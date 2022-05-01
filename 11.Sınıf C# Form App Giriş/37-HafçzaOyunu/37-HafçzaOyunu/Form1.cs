using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _37_HafızaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] dizi = new int[16];
        Random rnd = new Random();
        void ResimYukle()
        {
            for (int i = 0; i < 16; i++)
            {
                dizi[i] = 17;
            }
            for (int i = 0; i < 16; i++)
            {
                int sayı;
                do
                {
                    sayı = rnd.Next(0,16);
                } while (Array.IndexOf(dizi,sayı)>-1);
                dizi[i] = sayı;
            }
            for (int i =1; i <= 16; i++)
            {
                ((Button)this.Controls["button" + i]).BackgroundImage = ımageList1.Images[dizi[i - 1]];
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ResimYukle();
            timer1.Start();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ResimYukle();
        }
        int butonno1,butonno2,tık=0;
        bool kapak = true;
        private void button13_Click(object sender, EventArgs e)
        {
            if (kapak)
            {
                tık++;
                Button tıklananButon = (Button)sender;
                if (tık == 1)
                {
                    butonno1 = Convert.ToInt32(tıklananButon.Name.Substring(6));
                    tıklananButon.BackgroundImage = ımageList1.Images[dizi[butonno1 - 1]];
                    tık1.BackgroundImage = ımageList1.Images[dizi[butonno1 - 1]];
                    ((Button)this.Controls["button" + butonno1]).Enabled = false;
                }
                else
                {
                    butonno2 = Convert.ToInt32(tıklananButon.Name.Substring(6));
                    tıklananButon.BackgroundImage = ımageList1.Images[dizi[butonno2 - 1]];
                    tık2.BackgroundImage = ımageList1.Images[dizi[butonno2 - 1]];
                    ((Button)this.Controls["button" + butonno2]).Enabled = false;
                    tık = 0;
                    if ((dizi[butonno1 - 1] % 8) == (dizi[butonno2 - 1] % 8))
                    {
                        label1.Text = "EŞİT";
                        
                       
                    }
                    else
                    {
                        kapak = false;
                        label1.Text = "EŞİT DEĞİL";
                        timer2.Start();
                    }
                } 
            }
            
            
        }
        int saniye = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            if (saniye==2)
            {
                for (int i = 1; i <= 16; i++)
                {
                    ((Button)this.Controls["button" + i]).BackgroundImage = ımageList1.Images[16];
                }
                saniye = 0;
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            saniye++;
            if (saniye==1)
            {
                 ((Button)this.Controls["button" + butonno1]).BackgroundImage = ımageList1.Images[16];
                    ((Button)this.Controls["button" + butonno2]).BackgroundImage = ımageList1.Images[16];
                    ((Button)this.Controls["button" + butonno1]).Enabled = true;
                    ((Button)this.Controls["button" + butonno2]).Enabled = true;
                saniye = 0;
                    kapak = true;
                    timer2.Stop();
            }

        }
    }
}
