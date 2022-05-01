using Labirent_Proje.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace Labirent_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }        
        Button btn;
        Label lbl;
        private void button4_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button4.Visible = false;
            lbl = new Label();
            lbl.Size = new Size(350, 150);
            lbl.Location = new Point(this.Width/2-lbl.Width/2,this.Height/2-lbl.Height/2-50);
            lbl.Text = "          OYUNUN AMACI         \nBu oyunda oyuncu fareyi kontrol etmeye çalışır.Buradaki amaç fareyi sürükleyerek engellere çarpmadan bitiş çizgisine ulaştırmaktır.";
            lbl.Font = new Font("Orator Std", 10, FontStyle.Bold);
            Controls.Add(lbl);
            btn = new Button();
            btn.Size = new Size(200, 60);
            btn.Location = new Point(this.Width/2-125  , this.Height/2+50 );
            ResourceManager rm = Resources.ResourceManager;
            btn.BackgroundImage = (Bitmap)rm.GetObject(6.ToString());
            btn.FlatStyle = FlatStyle.Flat;
            Controls.Add(btn);
            btn.Click += Btn_Click;
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Controls.Remove(btn);
            Controls.Remove(lbl);
            button1.Visible = true;
            button2.Visible = true;
            button4.Visible = true;
        }
        SoundPlayer sp;
        private void Form1_Load(object sender, EventArgs e)
        {
            sp = new SoundPlayer();
            string path = Application.StartupPath + "\\m1.wav";
            sp.SoundLocation = path;
            sp.Play();
        }
        int d = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            d++;
            if (d==1)
            {
                sp.Stop();
            }
            else if (d==2)
            {
                sp.Play();
                d = 0;
            }
        }
    }
}
