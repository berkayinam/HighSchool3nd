using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulStokProgramı
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void Giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ekle_Giris f1 = new Ekle_Giris();
            if (Application.OpenForms[f1.Name] == null)
            {
                f1.MdiParent = this;
                f1.Show();
            }
            else
            {
                f1.BringToFront();
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeView f2 = new TreeView();
            if (Application.OpenForms[f2.Name] == null)
            {
                f2.MdiParent = this;
                f2.Show();
            }
            else
            {
                f2.BringToFront();
            }
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Güncelle f3 = new Güncelle();
            if (Application.OpenForms[f3.Name] == null)
            {
                f3.MdiParent = this;
                f3.Show();
            }
            else
            {
                f3.BringToFront();
            }
        }

        private void ekleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ana_Yer_ve_Yer_Kayıt f4 = new Ana_Yer_ve_Yer_Kayıt();
            if (Application.OpenForms[f4.Name] == null)
            {
                f4.MdiParent = this;
                f4.Show();
            }
            else
            {
                f4.BringToFront();
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sil f5 = new Sil();
            if (Application.OpenForms[f5.Name] == null)
            {
                f5.MdiParent = this;
                f5.Show();
            }
            else
            {
                f5.BringToFront();
            }
        }
    }
}
