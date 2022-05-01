using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_butonGösterGizle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            if (btnGoster.Text=="Gizle")
            {
                for (int i = 1; i <= 10; i++)
                {
                    this.Controls["button" + i].Visible = false;                    
                }
                btnGoster.Text = "Göster";
            }
            else if (btnGoster.Text=="Göster")
            {
                for (int i = 1; i <= 10; i++)
                {
                    this.Controls["button" + i].Visible = true;                    
                }
                btnGoster.Text = "Gizle";
            }

            
               
           
            
        }
    }
}
