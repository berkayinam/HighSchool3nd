using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27_ResimKesme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Bitmap ResimKes(int x,int y,int w,int h)
        {
            Bitmap resim = pictureBox1.Image as Bitmap;
            Rectangle dikdörtgenalan = new Rectangle(x, y, w, h);
            Bitmap klonParca = resim.Clone(dikdörtgenalan, resim.PixelFormat);
            return klonParca;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y=int.Parse(textBox2.Text);
            int w=int.Parse(textBox3.Text);
            int h=int.Parse(textBox4.Text);

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = pictureBox1.Image.Width.ToString();
            label2.Text = pictureBox1.Image.Height.ToString();
        }
        public Array RstSayı(Array dizi,int s1,int s2)
        {
            int sayı;
            Random rnd = new Random();
            for (int i = 0; i <dizi.Length; i++)
            {
                do
                {
                    sayı = rnd.Next(s1,s2);  
                } while (Array.IndexOf(dizi,sayı)>-1);
                dizi.SetValue(sayı, i);
            }
            return dizi;
        }
        private void button2_Click(object sender, EventArgs e)
        {
                     
            int[] dizi=new int[4];
            RstSayı(dizi, 3, 7);
            listBox1.Items.Clear();
            foreach (var item in dizi)
            {
                listBox1.Items.Add(item);
            }

            ((PictureBox)(this.Controls["pictureBox" + dizi[0]])).Image = ResimKes(0, 0, 100, 100);
            ((PictureBox)(this.Controls["pictureBox" + dizi[1]])).Image = ResimKes(100, 0, 100, 100);
            ((PictureBox)(this.Controls["pictureBox" + dizi[2]])).Image = ResimKes(0, 100, 100, 100);
            ((PictureBox)(this.Controls["pictureBox" + dizi[3]])).Image = ResimKes(100, 100, 100, 100);
        }
    }
}
