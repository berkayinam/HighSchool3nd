using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _52_dosyakopyalama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string kaynakDosya = "", kaynakDosyaIsmi = "", hedefKlasor = "";

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                hedefKlasor = folderBrowserDialog1.SelectedPath.ToString();
                textBox2.Text = hedefKlasor;
            }
            else
            {
                MessageBox.Show("Dosyanın Kopyalanacağı Klasörü Seçmediniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (hedefKlasor != "" && kaynakDosya != "")
            {
                if (File.Exists(hedefKlasor + "\\" + kaynakDosyaIsmi))
                {
                    MessageBox.Show("Belirtilen klasörde " + kaynakDosyaIsmi + " isimli dosya zaten mevcut...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    File.Copy(kaynakDosya, hedefKlasor + "\\" + kaynakDosyaIsmi);
                    MessageBox.Show("Dosya Kopyalama İşlemi Başarılı", "Dosya Kopyalandı...");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Kopyalanacak Dosyayı Seçiniz...";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                kaynakDosyaIsmi = openFileDialog1.SafeFileName.ToString();
                kaynakDosya = openFileDialog1.FileName.ToString();
                textBox1.Text = kaynakDosya;
            }
            else
            {
                MessageBox.Show("Dosya Seçmediniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }
    }
}
