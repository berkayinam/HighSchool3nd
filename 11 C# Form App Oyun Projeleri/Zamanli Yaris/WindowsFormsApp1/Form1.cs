using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int saniye = 0, salise = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            button_A.Location = new Point(button_A.Location.X + rnd.Next(1, 11), button_A.Location.Y);
            button_B.Location = new Point(button_B.Location.X + rnd.Next(1, 11), button_B.Location.Y);
            if (button_A.Location.X + button_A.Width >= button_End.Location.X)
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("'A' arabası kazandı..!\n " + (int.Parse(label1.Text)) + "." + (int.Parse(label2.Text)) + " saniye..!");
            }
            else if (button_B.Location.X + button_B.Width >= button_End.Location.X)
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("'B' arabası kazandı..!\n " + (int.Parse(label1.Text)) + "." + (int.Parse(label2.Text)) + " saniye..!");
            }
        }

        private void button_Baslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            label1.Text = saniye.ToString();
            label2.Text = salise.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "0";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            salise++;
            label2.Text = salise.ToString();
            if (int.Parse(label2.Text) == 60)
            {
                saniye++;
                label1.Text = saniye.ToString();               
                salise = 0;               
            }
        }
    }
}
