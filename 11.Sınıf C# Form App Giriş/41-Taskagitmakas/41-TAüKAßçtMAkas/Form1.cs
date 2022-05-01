using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _41_TAşKAğıtMAkas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int oyuncu, pc;
        int o = 0, p = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            Button btn=(Button)sender;
            oyuncu =int.Parse(btn.Name.Substring(6));
            pc = rnd.Next(1, 4);
            button4.BackgroundImage = ımageList1.Images[pc];
            button4.Text = pc.ToString();
            if (oyuncu==1 && pc==3 || oyuncu==2 && pc==1 || oyuncu==3 && pc==2)
            {
                textBox1.Text = (int.Parse(textBox1.Text)+1).ToString();

                MessageBox.Show("Oyuncu Kazandı");

            }
            else if (oyuncu==pc)
            {
                MessageBox.Show("Berabere");
            }
            else
	{
        textBox2.Text = (int.Parse(textBox2.Text) + 1).ToString();
        MessageBox.Show("Pc kazandı ");
	}

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BackgroundImage = ımageList1.Images[1];
            button2.BackgroundImage = ımageList1.Images[2];
            button3.BackgroundImage = ımageList1.Images[3];
            button4.BackgroundImage = ımageList1.Images[0];
        }
    }
}
