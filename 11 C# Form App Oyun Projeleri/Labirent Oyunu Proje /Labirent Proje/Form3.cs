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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            Cursor.Position = PointToScreen(Form2.baslangic);
        }
        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (Cursor.Position != Form2.baslangic)
            {
                timer1.Start();
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
        private void yanma2(object sender, EventArgs e)
        {
            yan();
        }
        private void yan()
        {
            timer1.Stop();
            dr = MessageBox.Show("YANDINIZ!!\nYeniden Başlamak İstiyorsanız Evet,Oyundan Çıkmak İstiyorsanız Hayır Butonuna Basınız.", "OYUN BİTTİ", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            dialogkont();
        }

        private void dialogkont()
        {          
            if (dr == DialogResult.Yes)
            {
                Cursor.Position = PointToScreen(Form2.baslangic);
                saniye = 30;
                lbl_sure.Text = saniye.ToString();
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
                Form4 frm4 = new Form4();
                frm4.Show();
                this.Hide();
            }
            else
            {
                Application.Exit();
            }
        }
        private void label2_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            dr = MessageBox.Show("YANDINIZ!!\nYeniden Başlamak İstiyorsanız Evet,Oyundan Çıkmak İstiyorsanız Hayır Butonuna Basınız.", "OYUN BİTTİ", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            dialogkont();
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            yan();
        }
    }
}
