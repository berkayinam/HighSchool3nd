using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _44_BirIslem2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool sürüklemeDurumu = false;
        Point ilkKonum, tıklananBtnPoint;
        Button tıklananBtn;
        int ilkTopKonum;
        int hamle = 8;
        private void button13_MouseDown(object sender, MouseEventArgs e)
        {
            tıklananBtn = (Button)sender;
            sürüklemeDurumu = true;
            ilkKonum = e.Location;
            tıklananBtnPoint = tıklananBtn.Location;
            ilkTopKonum = tıklananBtn.Top;
            tıklananBtn.Cursor = Cursors.NoMove2D;
        }

        private void button13_MouseMove(object sender, MouseEventArgs e)
        {
            tıklananBtn = (Button)sender;
            this.Text = e.Location.X + "-" + e.Location.Y;
            if (sürüklemeDurumu == true)
            {
                tıklananBtn.Left = e.X + (tıklananBtn.Left - ilkKonum.X);
                tıklananBtn.Top = e.Y + (tıklananBtn.Top - ilkKonum.Y);
            }
        }

        private void button13_MouseUp(object sender, MouseEventArgs e)
        {
            tıklananBtn = (Button)sender;
            sürüklemeDurumu = false;
            tıklananBtn.Cursor = Cursors.Default;
            if (ilkTopKonum < btnAltDuvar.Top && tıklananBtn.Top > btnAltDuvar.Bottom)
            {
                lblKullanıcıSayı.Text = (int.Parse(lblKullanıcıSayı.Text) + int.Parse(tıklananBtn.Text)).ToString();
                hamle--;
            }
            else if (ilkTopKonum > btnAltDuvar.Bottom && tıklananBtn.Top < btnAltDuvar.Top)
            {
                lblKullanıcıSayı.Text = (int.Parse(lblKullanıcıSayı.Text) - int.Parse(tıklananBtn.Text)).ToString();
                hamle--;
            }
            else if (ilkTopKonum > btnUstDuvar.Bottom && tıklananBtn.Bottom <  btnUstDuvar.Top)
            {
                lblKullanıcıSayı.Text = (int.Parse(lblKullanıcıSayı.Text) - int.Parse(tıklananBtn.Text)).ToString();
                hamle--;
            }
            else if (ilkTopKonum < btnUstDuvar.Top && tıklananBtn.Bottom > btnUstDuvar.Bottom)
            {
                lblKullanıcıSayı.Text = (int.Parse(lblKullanıcıSayı.Text) + int.Parse(tıklananBtn.Text)).ToString();
                hamle--;
            }

            else
            {
                tıklananBtn.Location = tıklananBtnPoint;
            }
            lblHamle.Text = hamle.ToString();
            if (lblKullanıcıSayı.Text == lblpcSayı.Text)
            {
                MessageBox.Show("Tebrikler Kazandınız");
            }
            else if (hamle == 0)
            {
                MessageBox.Show("KAYBETTİNİZ.");
                for (int i = 1; i < 15; i++)
                {
                    ((Button)this.Controls["button" + i]).Enabled = false;
                }
            }
        }
        int[] dizi = new int[20];
        int[] topDizi = new int[3];
        Random rnd = new Random();
        public void benzersizSayıUret()
        {
            int sayı;
            for (int i = 0; i < 14; i++)
            {
                do
                {
                    sayı = rnd.Next(1, 100);
                } while (Array.IndexOf(dizi, sayı) > -1);
                dizi[i] = sayı;
                ((Button)this.Controls["button" + (i + 1)]).Text = dizi[i].ToString();
            }
            topDizi[0] = 40;
            topDizi[1] = 40;
            topDizi[2] = 40;
            for (int i = 0; i < 3; i++)
            {
                do
                {
                    sayı = rnd.Next(0, 14);
                } while (Array.IndexOf(topDizi, sayı) > -1);
                topDizi[i] = sayı;
            }

        }
        int işlem1, işlem2, sonuç;
        private void Form1_Load(object sender, EventArgs e)
        {
            benzersizSayıUret();
            
            işlem1 = rnd.Next(0, 2);
            işlem2 = rnd.Next(0, 2);
            sonuç = dizi[topDizi[0]];
            if (işlem1==0)
            {
                sonuç += dizi[topDizi[1]];
            }
            else
            {
                sonuç -= dizi[topDizi[1]];
            }

            if (işlem2 == 0)
            {
                sonuç += dizi[topDizi[2]];
            }
            else
            {
                sonuç -= dizi[topDizi[2]];
            }
            int pcSayı = sonuç;
            lblpcSayı.Text = pcSayı.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                for (int i = 0; i < 3; i++)
                {
                    ((Button)this.Controls["button" + (topDizi[i] + 1)]).BackColor = Color.Yellow;
                }
                
                
                lblDogruIslem.Text = dizi[topDizi[0]].ToString();
                if (işlem1 == 0)
                {
                    lblDogruIslem.Text += "+";
                    lblDogruIslem.Text += dizi[topDizi[1]].ToString();
                }
                else
                {
                    lblDogruIslem.Text += "-";
                    lblDogruIslem.Text += dizi[topDizi[1]].ToString();
                }

                if (işlem2 == 0)
                {
                    lblDogruIslem.Text += "+";
                    lblDogruIslem.Text += dizi[topDizi[2]].ToString();
                }
                else
                {
                    lblDogruIslem.Text += "-";
                    lblDogruIslem.Text += dizi[topDizi[2]].ToString();
                }
                //lblDogruIslem.Text = dizi[topDizi[0]].ToString()+ dizi[topDizi[1]].ToString()+dizi[topDizi[2]].ToString(); 
            }
        }


    }
}
