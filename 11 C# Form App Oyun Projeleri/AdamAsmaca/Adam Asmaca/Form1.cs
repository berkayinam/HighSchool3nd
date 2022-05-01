using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adam_Asmaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string kelime = "";
        TextBox[] txtler;
        int bosluk = 0;

        private void button2_Click_1(object sender, EventArgs e)
        {
            kelime = textBox1.Text;
            txtler = new TextBox[kelime.Length];

            for (int i = 0; i < kelime.Length; i++)
            {
                TextBox tx = new TextBox();
                tx.Name = "tx" + (i + 1).ToString();
                tx.Size = new Size(30, 30);
                tx.Enabled = false;
                tx.Location = new Point(150 + bosluk + i * 30, 50);
                bosluk += 20;
                txtler[i] = tx;
                Controls.Add(tx);
            }

            textBox1.Text = "";
            textBox1.Enabled = false;
            button2.Enabled = false;
        }

        // pictureboxlar için dizi oluşturup resimleri ordan çekiyoruz
        PictureBox[] pbx = new PictureBox[7];
        private void Form1_Load_1(object sender, EventArgs e)
        {
            pbx[0] = pictureBox1;
            pbx[1] = pictureBox2;
            pbx[2] = pictureBox3;
            pbx[3] = pictureBox4;
            pbx[4] = pictureBox5;
            pbx[5] = pictureBox6;
            pbx[6] = pictureBox7;

            //form yüklenirken bütün resimleri görünmez yapıyoruz
            foreach (PictureBox item in pbx)
            {
                item.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool b = true;
            bool hata = true;
            char harf = textBox2.Text[0];

            //kelimenin içinde harf arama işlemi
            for (int i = 0; i < kelime.Length; i++)
            {
                ///harf bulunduysa
                if (kelime[i] == harf)
                {
                    hata = false;
                    txtler[i].Text = harf.ToString();
                }
            }

            //hata yaptıysa olcaklar
            if (hata)
            {
                for (int i = 0; i < pbx.Length; i++)
                {
                    if (pbx[i].Visible == false)
                    {
                        pbx[i].Visible = true;
                        break;
                    }
                }
                if (pbx[6].Visible == true)
                {
                    MessageBox.Show("KAYBETTİNİZ");
                }
            }

            for (int i = 0; i < txtler.Length; i++)
            {
                if (txtler[i].Text == "")
                {
                    b = false;
                }
            }
            if (b)
            {
                MessageBox.Show("kazandınız");
                textBox2.Enabled = false;
            }
            textBox2.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bosluk = 0;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            button1.Enabled = true;
            foreach (TextBox item in txtler)
            {
                Controls.Remove(item);
            }
            foreach (PictureBox item in pbx)
            {
                item.Visible = false;
            }
        }
    }
}