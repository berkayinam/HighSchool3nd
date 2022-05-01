using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _34_JackpotÖrneği
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Image[] ımg = new Image[7];
        Random rnd = new Random();
        int say1, say2, say3;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
                  }

        private void Form1_Load(object sender, EventArgs e)
        {
                ımg[0]= Image.FromFile(@"C:\Users\inan\Pictures\armut.jpg");
                ımg[1]= Image.FromFile(@"C:\Users\inan\Pictures\res.jpg");
                ımg[2] = Image.FromFile(@"C:\Users\inan\Pictures\indir.jpg");
                ımg[3] = Image.FromFile(@"C:\Users\inan\Pictures\res6.jpg");
                ımg[4] = Image.FromFile(@"C:\Users\inan\Pictures\res5.jpg");
                ımg[5] = Image.FromFile(@"C:\Users\inan\Pictures\res4.jpg");
                ımg[6] = Image.FromFile(@"C:\Users\inan\Pictures\res3.jpg");
               
        }
        int sayac = 0, puan =0;
        private void timer1_Tick(object sender, EventArgs e)
        {
           
                say1 = rnd.Next(0, 7);
                say2 = rnd.Next(0, 7);
                say3 = rnd.Next(0, 7);
                pictureBox1.Image = ımg[say1];
                pictureBox2.Image = ımg[say2];
                pictureBox3.Image = ımg[say3];
                sayac++;
                if (sayac == 7)
                {
                    timer1.Stop();
                    if (say1 == say2 && say2 == say3)
                    {
                        MessageBox.Show("KAZANDINIZ tüm resimler aynı +3 puan");
                        puan += 3;
                    }
                    else if (say1 == say2)
                    {
                        MessageBox.Show("KAZANDINIZ 2 resim aynı +1 puan");
                        puan += 1;
                    }
                    else if (say2 == say3)
                    {
                        MessageBox.Show("KAZANDINIZ 2 resim aynı +1 puan"); puan += 1;
                    }
                    else if (say1 == say3)
                    {
                        MessageBox.Show("KAZANDINIZ 2 resim aynı +1 puan"); puan += 1;
                    } 
                    else
                    {
                        MessageBox.Show("KAYBETTİNİZ -2 puan"); puan -= 2;
                    }
                    label2.Text = puan.ToString();
                    sayac = 0;
                }
         
            
        }
    }
}
