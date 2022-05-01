using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_SayıOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sıra = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            label1.Text = sıra.ToString();
            label2.Text = süre.ToString();
            int[] dizi=new int[100];
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                int sayı;
                do
                {
                    sayı = rnd.Next(1, 101);
                } while (Array.IndexOf(dizi, sayı) >= 0);
                dizi[i]=sayı;
            }


            
            
            
            
            
            int x = 0, y = 0;
            for (int i = 1; i <= 100; i++)
            {
                Button btn = new Button();
                btn.Name = "btn"+i;
                btn.Text = dizi[i-1].ToString();
                btn.Location = new Point(x, y);
                btn.Width = 50;
                btn.Height = 50;                
                btn.Click += btn_Click;
                this.Controls.Add(btn);
                x += 50;
                if (i%10==0)
                {
                    x = 0;
                    y += 50;
                }
                
            }
            
        }

        void btn_Click(object sender, EventArgs e)
        {
            if (sıra==1)
            {
                timer1.Start();  
            }
            Button tıklananButon = (Button)sender;
            if (tıklananButon.Text==sıra.ToString())
            {
                //tıklananButon.BackColor = Color.Yellow;
                tıklananButon.Visible = false;
                sıra++;
                label1.Text = sıra.ToString();
                if (sıra==101)
                {
                    MessageBox.Show("Oyun bitti");
                    timer1.Stop();
                }
            }
            else
            {
                tıklananButon.BackColor = Color.Red;  
            }
        }
        int süre = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = süre.ToString();
            süre++;
        }
    }
}
