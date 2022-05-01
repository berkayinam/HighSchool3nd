using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28_4x4_Mini_Puzzle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void PictureboxOlustur(int adet)
        {
            const int ilkX = 300;
            int gen = 50, yük = 50;
            int x = ilkX, y = 10;
            for (int i = 1; i <= adet * adet; i++)
            {
                PictureBox pbx = new PictureBox();
                pbx.Name = "pbx" + i;
                pbx.Size = new Size(gen, yük);
                pbx.Location = new Point(x, y);
                pbx.BackColor = Color.Red;
                this.Controls.Add(pbx);
                x = x + pbx.Width+5;
                if (i % adet == 0)
                {
                    y += pbx.Width + 5; ;
                    x = ilkX;
                }
            }
        }
        public Bitmap ResimKes(int x, int y, int w, int h)
        {
            Bitmap resim = resimDzn as Bitmap;
            Rectangle dikdörtgenalan = new Rectangle(x, y, w, h);
            Bitmap klonParca = resim.Clone(dikdörtgenalan, resim.PixelFormat);
            return klonParca;
        }
        public Array RstSayı(Array dizi, int s1, int s2)
        {
            int sayı;
            Random rnd = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
                do
                {
                    sayı = rnd.Next(s1, s2);
                } while (Array.IndexOf(dizi, sayı) > -1);
                dizi.SetValue(sayı, i);
            }
            return dizi;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            

            

        }
        Bitmap resimDzn;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Puzzle için resim seçin.";
                ofd.Filter = "BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff|" + "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";
                ofd.FilterIndex = 6;
                ofd.ShowDialog();
                //MessageBox.Show(ofd.FileName);
                //MessageBox.Show(ofd.SafeFileName);
                Bitmap resimOrj = (Bitmap)Bitmap.FromFile(ofd.FileName);
                pictureBox1.Image = resimOrj;
                MessageBox.Show(resimOrj.Width.ToString()+"-"+resimOrj.Height.ToString());           
                resimDzn = new Bitmap(resimOrj, 200, 200);
                MessageBox.Show(resimOrj.Width.ToString() + "-" + resimOrj.Height.ToString()); 
            }
            catch (Exception mesaj)
            {
                MessageBox.Show(mesaj.Message);
                MessageBox.Show("Resim Yüklenemedi");

            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PictureboxOlustur(4);
            this.Width = this.Controls["pbx4"].Right + 30;
            // button2.Location = new Point(button1.Right,button1.Top);
            // button2.Location = new Point(button1.Right, button1.Location.Y);
            int[] dizi = new int[16];
            RstSayı(dizi, 1, 17);
            int x = 0, y = 0, w = 50, h = 50;
            for (int i = 1; i <= 16; i++)
            {
                ((PictureBox)this.Controls["pbx" + dizi[i - 1]]).Image = ResimKes(x, y, w, h);
                x += 50;
                if (i % 4 == 0)
                {
                    x = 0;
                    y += 50;
                }
            }
        }
    }
}
