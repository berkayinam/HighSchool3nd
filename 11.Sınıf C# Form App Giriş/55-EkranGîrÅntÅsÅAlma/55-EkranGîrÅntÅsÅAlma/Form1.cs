using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _55_EkranGörüntüsüAlma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Ekrangörüntüsüal()
        {
            Bitmap foto = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics grafik = Graphics.FromImage(foto);
            grafik.CopyFromScreen(0, 0, 0, 0, new Size(foto.Width, foto.Height));
            pictureBox1.Image = foto;
        }
        private void görüntüAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ekrangörüntüsüal();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Text = "Sol Tuşa Basıldı.";
            }
            else if (e.Button == MouseButtons.Right)
            {
                this.Text = "Sağ Tuşa Basıldı.";
                Ekrangörüntüsüal();
            }
        }
    }
}
