using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_MatIslem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayı1, sayı2;
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            sayı1 = rnd.Next(0, 11);
            sayı2 = rnd.Next(0, 11);
            lblSayı1.Text = sayı1.ToString() ;
            lblSayı2.Text = sayı2.ToString();
        }

        private void txtSonuc_TextChanged(object sender, EventArgs e)
        {
            int doğrusonuc = sayı1 * sayı2;
            string kullanıcıcevabı=txtSonuc.Text;
            if (doğrusonuc.ToString()==kullanıcıcevabı)
            {
                txtSonuc.ForeColor = Color.Green;
            }
            else
            {
                txtSonuc.ForeColor = Color.Red;
            }
            
        }     
        
        
    }
}
