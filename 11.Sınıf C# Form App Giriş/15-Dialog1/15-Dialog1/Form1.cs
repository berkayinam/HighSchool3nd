using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_Dialog1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult cvp;
            cvp=MessageBox.Show("Program Kapatılsın mı?","Program Kapatma Ekranı",MessageBoxButtons.YesNo,MessageBoxIcon.Hand);
            if (cvp==DialogResult.Yes)
            {
                Application.Exit(); 
            }
          
        }
    }
}
