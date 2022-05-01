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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }       
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public static Point baslangic;
        private void Form2_Load(object sender, EventArgs e)
        {
            baslangic =new Point(lbl_basla.Location.X+49,lbl_basla.Location.Y+15);
            Cursor.Position = PointToScreen(baslangic);           
        }  
        public void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (Cursor.Position!=baslangic)
            {
                timer1.Start();
            }            
        }
        public static int saniye = 30;
        public void timer1_Tick(object sender, EventArgs e)
        {
            saniye--; 
            lbl_sure.Text = saniye.ToString();                       
            if (saniye==0)
            {
                surebitti();
            }
        }        
        public void yanma(object sender,EventArgs e)
        {
            yan();            
        }

        private void yan()
        {
            timer1.Stop();
            DialogResult dr = MessageBox.Show("YANDINIZ!!\nYeniden Başlamak İstiyorsanız Evet,Oyundan Çıkmak İstiyorsanız Hayır Butonuna Basınız.", "OYUN BİTTİ", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (dr == DialogResult.Yes)
            {
                sifirla();
            }
            else if (dr == DialogResult.No)
            {
                Application.Exit();
            }
        }
        DialogResult dr;
        public   void dialogkontrol()
        {
            if (dr == DialogResult.Yes)
            {
                sifirla();
            }
            else if (dr==DialogResult.No)
            {
                Application.Exit();
            }
        }
        public   void sifirla()
        {
            Cursor.Position = PointToScreen(baslangic);
            saniye = 30;            
            lbl_sure.Text = saniye.ToString();
        }
        public void lbl_bitis_MouseEnter(object sender, EventArgs e)
        {
            oyunbitti();
        }
        public void oyunbitti()
        {
            timer1.Stop();
            dr = MessageBox.Show("BÖLÜMÜ GEÇTİNİZ!\nDiğer Bölüme Geçmek İstiyorsanız Evet,Oyundan Çıkmak İstiyorsanız Hayır Butonuna Basınız.", "OYUN BİTTİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                Form3 frm3 = new Form3();
                frm3.Show();
                this.Hide();
            }
            else
            {
                Application.Exit();
            }
        }
        public void  surebitti()
        {
            timer1.Stop();
            DialogResult dr = MessageBox.Show("SÜRE BİTTİ,YANDINIZ!!\nYeniden Başlamak İstiyorsanız Evet,Oyundan Çıkmak İstiyorsanız Hayır Butonuna Basınız.", "OYUN BİTTİ", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            dialogkontrol();          
        }
        private void label2_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            DialogResult dr = MessageBox.Show("YANDINIZ!!\nYeniden Başlamak İstiyorsanız Evet,Oyundan Çıkmak İstiyorsanız Hayır Butonuna Basınız.", "OYUN BİTTİ", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            dialogkontrol();            
        }
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            yan();
        }
    }
    
}
