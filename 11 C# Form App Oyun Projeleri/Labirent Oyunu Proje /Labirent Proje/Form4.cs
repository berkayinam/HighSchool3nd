using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirent_Proje
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        Point baslangic;
        private void Form4_Load(object sender, EventArgs e)
        {
            baslangic = new Point(lbl_basla.Location.X+lbl_basla.Width/2 , lbl_basla.Location.Y+lbl_basla.Height/2-5 );
            Cursor.Position = PointToScreen(baslangic);
        }
        Random rnd;
        int rSayi,sayac=0;
        Button surprizengel;
        private void Form4_MouseMove(object sender, MouseEventArgs e)
        {           
            if (Cursor.Position!=baslangic)
            {
                timer1.Start();
            }
            if (Cursor.Position.X>395)
            {
                sayac++;
                if (sayac == 1)
                {
                    rnd = new Random();
                    rSayi = rnd.Next(1, 3);
                    surprizengel = new Button();
                    surprizengel.Size = new Size(30, 50);
                    if (rSayi == 1)
                    {
                        surprizengel.Location = new Point(460, 400);
                    }
                    else if (rSayi == 2)
                    {
                        surprizengel.Location = new Point(410, 215);
                    }
                    surprizengel.BackColor = Color.Black;
                    surprizengel.FlatStyle = FlatStyle.Flat;
                    Controls.Add(surprizengel);
                    surprizengel.MouseEnter += new System.EventHandler(this.yanma3);
                }
            }
        }
        DialogResult dr;
        int saniye = 30;
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye--;
            lbl_sure.Text = saniye.ToString();
            if (saniye == 0)
            {
                timer1.Stop();
                dr = MessageBox.Show("SÜRE BİTTİ,YANDINIZ!!\nYeniden Başlamak İstiyorsanız Evet,Oyundan Çıkmak İstiyorsanız Hayır Butonuna Basınız.", "OYUN BİTTİ", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                dialogkont();
            }
        }
        private void lbl_bitis_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            dr = MessageBox.Show("BÖLÜMÜ GEÇTİNİZ!\nDiğer Bölüme Geçmek İstiyorsanız Evet,Oyundan Çıkmak İstiyorsanız Hayır Butonuna Basınız.", "OYUN BİTTİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                Form5 frm5 = new Form5();
                frm5.Show();
                this.Hide();
            }
            else
            {
                Application.Exit();
            }
        }

        public void yanma3(object sender, EventArgs e)
        {
            yan();            
        }
        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            yan();
        }
        private void yan()
        {
            timer1.Stop();
            dr = MessageBox.Show("YANDINIZ!!\nYeniden Başlamak İstiyorsanız Evet,Oyundan Çıkmak İstiyorsanız Hayır Butonuna Basınız.", "OYUN BİTTİ", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (dr == DialogResult.Yes)
            {
                Cursor.Position = PointToScreen(baslangic);
                saniye = 30;
                lbl_sure.Text = saniye.ToString();
                Controls.Remove(surprizengel);
                sayac = 0;
            }
            else if (dr == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void dialogkont()
        {
            if (dr == DialogResult.Yes)
            {
                Cursor.Position = PointToScreen(baslangic);
                saniye = 30;
                lbl_sure.Text = saniye.ToString();
                Controls.Remove(surprizengel);
                sayac = 0;
            }
            else if (dr == DialogResult.No)
            {
                Application.Exit();
            }
        }
    }
}
