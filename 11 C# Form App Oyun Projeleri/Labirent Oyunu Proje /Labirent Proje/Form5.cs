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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        Point baslangic;
        private void Form5_Load(object sender, EventArgs e)
        {
            baslangic = new Point(lbl_basla.Location.X + lbl_basla.Width / 2, lbl_basla.Location.Y + lbl_basla.Height / 2 - 5);
            Cursor.Position = PointToScreen(baslangic);
        }
        Button surprizengel;
        private void Form5_MouseMove(object sender, MouseEventArgs e)
        {
            if (Cursor.Position != baslangic)
            {
                timer1.Start();
            }
        }
        private void engelolustur(int g1, int g2, int g3, int g4)
        {
            surprizengel = new Button();
            surprizengel.Size = new Size(g3, g4);
            surprizengel.Location = new Point(g1, g2);
            surprizengel.BackColor = Color.Black;
            surprizengel.FlatStyle = FlatStyle.Flat;
            Controls.Add(surprizengel);
            surprizengel.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
        }
        DialogResult dr;
        int saniye = 30;       
        private void Form5_MouseDown(object sender, MouseEventArgs e)
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
                lbl_bitis.Enabled = true;
            }
            else if (dr == DialogResult.No)
            {
                Application.Exit();
            }
        }

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
        private void dialogkont()
        {
            if (dr == DialogResult.Yes)
            {
                Cursor.Position = PointToScreen(baslangic);
                saniye = 30;
                lbl_sure.Text = saniye.ToString();
                Controls.Remove(surprizengel);
                lbl_bitis.Enabled = true;
            }
            else if (dr == DialogResult.No)
            {
                Application.Exit();
            }
        }
        private void lbl_bitis_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            dr = MessageBox.Show("BÖLÜMÜ GEÇTİNİZ!\nDiğer Bölüme Geçmek İstiyorsanız Evet,Oyundan Çıkmak İstiyorsanız Hayır Butonuna Basınız.", "OYUN BİTTİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                Form6 frm6 = new Form6();
                frm6.Show();
                this.Hide();
                
            }
            else
            {
                Application.Exit();
            }
        }
        private void label2_MouseEnter(object sender, EventArgs e)
        {
            yan();
        }

     
    }
}
