using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puzzle2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PictureBox pb;
        int sira = 1;


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            degistir(sender);

        }
        private void degistir(object sender)
        {
            if (sira == 1)
            {
                pb = ((PictureBox)sender);
                sira++;
            }
            else
            {
                Image im = ((PictureBox)sender).Image;

                ((PictureBox)sender).Image = pb.Image;
                pb.Image = im;
                sira = 1;

                int m = Int16.Parse(((PictureBox)sender).Tag.ToString());
                int n= Convert.ToInt16((pb.Tag.ToString()));

                object gcc = ( sirasiz[n]);
                sirasiz[n] = sirasiz[m];
                sirasiz[m] = gcc;

                kontrol();
            }
        }

        private void kontrol()
        {
            bool b = true;
            for (int i = 0; i < sirasiz.Count; i++)
            {
                if (sirasiz[i] != sirali[i])
                {
                    b = false;
                    break;
                }
            }
            if (b)
            {
                MessageBox.Show("Tebrikler");
            }
        }

        ArrayList pics = new ArrayList();
        ArrayList sirali = new ArrayList()
        {
            0,1,2,3,4,5,6,7,8
        };

        ArrayList sirasiz = new ArrayList();
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                pics.Add(item);

            }
            int x = 100;
            int y = 100;
            int s;
            bool b = false;
            Random r = new Random();


            for (int sa = 0; sa < 3; sa++)
            {
                for (int su = 0; su < 3; su++)
                {
                    s = r.Next(0, 9);
                    b = false;
                    do
                    {
                        if (sirasiz.IndexOf(s) == -1)
                        {
                            sirasiz.Add(s);

                            ((PictureBox)pics[s]).Location = new Point(x + su * 75, y + sa * 75);

                            b = false;
                        }
                        else
                        {
                            s = r.Next(0, 9);
                            b = true;
                        }
                    } while (b);
                }
            }
        }
    }
}
