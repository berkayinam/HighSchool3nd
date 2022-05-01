using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_Dilog2_color
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //if (colorDialog1.ShowDialog()==DialogResult.OK)
            //{
            //    button1.BackColor = colorDialog1.Color;
            //}
            //DialogResult cvp;
            //cvp = colorDialog1.ShowDialog();
            //if (cvp==DialogResult.OK)
            //{
            //    button1.BackColor = colorDialog1.Color;
            //}

            //kodla colordialog oluşturuyoruz.
            ColorDialog RenkPenceresi = new ColorDialog();
            RenkPenceresi.ShowDialog();
           
        }
    }
}
