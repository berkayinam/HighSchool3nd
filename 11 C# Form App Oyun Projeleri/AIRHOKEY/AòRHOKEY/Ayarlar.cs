using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AİRHOKEY
{
	public partial class Ayarlar : Form
	{
		public Ayarlar()
		{
			InitializeComponent();
		}

		private void Ayarlar_Load(object sender, EventArgs e)
		{
			numericUpDown1.Value = Properties.Settings.Default.TopHizi;
			numericUpDown2.Value = Properties.Settings.Default.Player2TimerHizi;
			numericUpDown3.Value = Properties.Settings.Default.TopTimerHizi;
			numericUpDown4.Value = Properties.Settings.Default.Player2Hizi;
			numericUpDown5.Value = Properties.Settings.Default.Player1Hizi;
		}

		private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			var btn = (NumericUpDown)sender;
			if (btn.Value > 0)
			{
				switch (btn.Name)
				{
					case "numericUpDown1":
						Properties.Settings.Default.TopHizi = (int)numericUpDown1.Value;
						break;
					case "numericUpDown2":
						Properties.Settings.Default.Player2TimerHizi = (int)numericUpDown2.Value;
						break;
					case "numericUpDown3":
						Properties.Settings.Default.TopTimerHizi = (int)numericUpDown3.Value;
						break;
					case "numericUpDown4":
						Properties.Settings.Default.Player2Hizi = (int)numericUpDown4.Value;
						break;
					case "numericUpDown5":
						Properties.Settings.Default.Player1Hizi = (int)numericUpDown5.Value;
						break;
				}
			}
			else
			{
				btn.Value = 1;
			}
			Properties.Settings.Default.Save();
		}

		private void Varsayilan_Click(object sender, EventArgs e)
		{
			numericUpDown1.Value = 6;
			numericUpDown2.Value = 1;
			numericUpDown3.Value = 1;
			numericUpDown4.Value = 2;
			numericUpDown5.Value = 2;
			Properties.Settings.Default.TopHizi = 6;
			Properties.Settings.Default.Player2TimerHizi = 1;
			Properties.Settings.Default.TopTimerHizi = 1;
			Properties.Settings.Default.Player2Hizi = 2;
			Properties.Settings.Default.Player1Hizi = 2;
			Properties.Settings.Default.Save();
		}

		private void Btn_basla_Click(object sender, EventArgs e)
		{
			AnaForm frm2 = new AnaForm();
			this.Hide();
			frm2.Show();
		}
	}
}
