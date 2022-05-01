using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();
        ArrayList buttonDizi = new ArrayList();
        int[] sayiListe = new int[100];
        int[] btnText = new int[100];
        private void Form1_Load(object sender, EventArgs e)
        {
            int rastgele;
            for (int i = 0; i < 100; i++)
            {
                rastgele = r.Next(1, 100);
                for (int j = 0; j < i; j++)
                {
                    if (sayiListe[j] == rastgele)
                    {
                        i--;
                        break;
                    }
                    else
                    {
                        sayiListe[i] = rastgele;
                    }
                }
            }
            int x = 10, y = 10, degisken = 0;
            for (int g = 0; g < 100; g++)
            {
                Button btn = new Button();
                btn.Text = (sayiListe[g] + 1).ToString();
                btn.Name = g.ToString();
                buttonDizi.Add(btn);
                btn.BackColor = Color.Black;
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Size = new Size(50, 50);
                btn.Location = new Point(x, y);
                Controls.Add(btn);
                degisken += 1;
                x += 50;
                if (degisken == 10)
                {
                    degisken = 0;
                    x = 10;
                    y += 50;
                }
                btn.Click += Btn_Click;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button x = (Button)sender;
            if (x.Text == 1.ToString())
            {
                timer1.Start();
                x.Enabled = false;
            }
            for (int i = 2; i < 100; i++)
            {
                if (x.Text == i.ToString())
                {
                    x.Enabled = false;
                    i++;
                }
                break;
            }
        }

        int salise = 0, saniye = 0, dakika = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Salise.Text = salise.ToString();
            salise++;
            if (salise == 60)
            {
                salise = 0;
                saniye++;
                lbl_Saniye.Text = saniye.ToString();
                if (saniye == 60)
                {
                    dakika++;
                    lbl_Dakika.Text = dakika.ToString();
                }
            }
        }
    }
}
