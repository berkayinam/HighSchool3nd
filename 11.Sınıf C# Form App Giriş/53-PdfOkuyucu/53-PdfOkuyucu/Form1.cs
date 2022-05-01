using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _53_PdfOkuyucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aÇToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "PDF Dosyaları |*.pdf";
            dosya.ShowDialog();
            if (dosya.FileName != "")
            {
                axAcroPDF1.LoadFile(dosya.FileName);
            }
        }

        private void kAPATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axAcroPDF1.Dispose();
            this.Close();
        }
    }
}
