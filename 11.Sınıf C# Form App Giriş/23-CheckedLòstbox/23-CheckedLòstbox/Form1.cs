using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_CheckedLİstbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("Phyton");
            label2.Text = checkedListBox1.Items.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //checkedListBox1.SetItemChecked(0, true);
            label2.Text = checkedListBox1.Items.Count.ToString();
            for (int i = 0; i <checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = checkedListBox1.Items.Count.ToString();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i,false);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                listBox1.Items.Add(checkedListBox1.CheckedItems[i]);  
            }
            
            int s = checkedListBox1.Items.Count - 1;

            do
            {
                if (checkedListBox1.GetItemChecked(s))
                    checkedListBox1.Items.RemoveAt(s);
                MessageBox.Show("vgdf");
                s--;
            } while (s >= 0);
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(checkedListBox1.CheckedItems.Count.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(checkedListBox1.GetItemChecked(int.Parse(textBox1.Text)).ToString());
        }
    }
}
