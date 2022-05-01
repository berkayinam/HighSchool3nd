using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _47_piyano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.A)//DO
            {                
                Console.Beep(261,250);
            }
            if (e.KeyCode == Keys.S)//RE
            {
                
                Console.Beep(293,250);
            }
            if (e.KeyCode == Keys.D)//Mİ
            {
               
                Console.Beep(329,250);
            }
            if (e.KeyCode == Keys.F)//FA
            {
               
                Console.Beep(349,250);
            }
            if (e.KeyCode == Keys.G)//SOL
            {
               
                Console.Beep(392,250);
            }
            if (e.KeyCode == Keys.H)//LA
            {
               
                Console.Beep(440,250);
            }
            if (e.KeyCode == Keys.J)//Sİ
            {
               
                Console.Beep(493,250);
            }
            if (e.KeyCode == Keys.K)//DO
            {

                Console.Beep(554,250);
            }
            
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button tus = (Button)sender;
            switch (tus.Text)
            {
                case "DO" :
                    Console.Beep(261, 250);
                    break;
                case "RE":
                    Console.Beep(293, 250);
                    break;
                case "Mİ":
                    Console.Beep(329, 250);
                    break;
                case "FA":
                    Console.Beep(346, 250);
                    break;
                case "SOL":
                    Console.Beep(392, 250);
                    break;
                case "LA":
                    Console.Beep(440, 250);
                    break;
                case "Sİ":
                    Console.Beep(493, 250);
                    break;
                case "DO-":
                    Console.Beep(554, 250);
                    break;
                
            }
        }
    }
}
