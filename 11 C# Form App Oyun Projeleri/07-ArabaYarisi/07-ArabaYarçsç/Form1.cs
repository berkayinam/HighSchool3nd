using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_ArabaYarısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void btnIlerle_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbxFiat.Location.X>620)
            {
                timer1.Stop();
                MessageBox.Show("Fiat Kazandı!!!");
            }
            if (pbxPorsche.Location.X>620)
            {
                timer1.Stop();
                MessageBox.Show("Porsche Kazandı!!!");
            }
            pbxFiat.Location = new Point(pbxFiat.Location.X + rnd.Next(0, 55), pbxFiat.Location.Y);
            pbxPorsche.Location = new Point(pbxPorsche.Location.X + rnd.Next(0, 55), pbxPorsche.Location.Y);
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
