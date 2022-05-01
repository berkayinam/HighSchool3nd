using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_Dialog3_Openfiledialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog DosyaPenceresi = new OpenFileDialog();
            DosyaPenceresi.Title = "Resim Dosyası Seçiniz";
            DosyaPenceresi.Multiselect = true;
            if (DosyaPenceresi.ShowDialog()==DialogResult.OK)
            {              
                for (int i = 0; i < DosyaPenceresi.FileNames.Length; i++)
                {
                    listBox1.Items.Add( DosyaPenceresi.FileNames[i]);
                    listBox2.Items.Add(DosyaPenceresi.SafeFileNames[i]);
                } 
            }
            
        }
    }
}
