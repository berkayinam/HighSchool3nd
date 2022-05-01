using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AİRHOKEY
{
	public partial class AnaForm : Form
	{

		Random Random = null;
		Boolean Player1Yukari, Player1Asagi = false;
		Boolean OyunaDevammi = false;
		Boolean TopSolamiGidiyor = true;
		int sayac = 0;
		int topGucu;
		public AnaForm()
		{
			InitializeComponent();
			this.KeyPreview = true;
			Random = new Random();
		}
		int Player1Hizi;
		int Player2Hizi;
		int TopHizi;

		public void TopuYuvarla(PictureBox pic)
		{
			GraphicsPath gp = new GraphicsPath();
			gp.AddEllipse(0, 0, pic.Width - 2, pic.Height - 2);
			Region rg = new Region(gp);
			pic.Region = rg;
		}

		public void UygulamaAyarlari()
		{
			Player1Hizi =
				Properties.Settings.Default.Player1Hizi;
			Player2Hizi = Properties.Settings.Default.Player2Hizi;
			TopHizi = Properties.Settings.Default.TopHizi;
			timerTopHizi.Interval = Properties.Settings.Default.TopTimerHizi;
			timerPlayer2Hizi.Interval = Properties.Settings.Default.Player2TimerHizi;
		}

		Point ilkKonum;
		Point ilkKonum2;
		Point topKonum;

		private void AnaForm_Load(object sender, EventArgs e)
		{
			topKonum = picTop.Location;
			ilkKonum2 = picPlayer2.Location;
			ilkKonum = picPlayer1.Location;
			TopuYuvarla(picTop);
			UygulamaAyarlari();
			picTop.Location = topKonum;
			GraphicsPath gl = new GraphicsPath();
			gl.AddEllipse(0, 0, picPlayer1.Width - 2, picPlayer1.Height - 2);
			Region rl = new Region(gl);
			picPlayer1.Region = rl;
			GraphicsPath gr = new GraphicsPath();
			gr.AddEllipse(0, 0, picPlayer2.Width - 7, picPlayer2.Height - 7);
			Region rr = new Region(gr);
			picPlayer2.Region = rr;

		}

		private void AnaForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.A)
			{
				if (picPlayer1.Left > lblSolDuvar.Right)
				{
					picPlayer1.Left -= 10;
				}
			}
			if (e.KeyCode == Keys.W)
			{
				if (picPlayer1.Top > lblUstDuvar.Bottom)
				{
					picPlayer1.Top -= 10;
				}

			}
			if (e.KeyCode == Keys.D)
			{
				if (picPlayer1.Location.X + picPlayer1.Width < button1.Location.X)
				{
					picPlayer1.Left += 10;
				}
			}

			if (e.KeyCode == Keys.S)
			{
				if (picPlayer1.Bottom < this.Height)
				{
					picPlayer1.Top += 10;
				}
			}
		}
		private void timerPlayer2Hizi_Tick(object sender, EventArgs e)
		{
			if (OyunaDevammi)
			{
				if (picPlayer2.Location.Y < picTop.Location.Y)
				{
					picPlayer2.Top += Player2Hizi;
				}
				else picPlayer2.Top -= Player2Hizi;
			}
		}

		private void timerTopHizi_Tick(object sender, EventArgs e)
		{
			UygulamaAyarlari();

			if (OyunaDevammi)
			{
				if (Player1Yukari && !UstDuvarCarpisma(picPlayer1))
				{
					picPlayer1.Top -= Player1Hizi;
				}
				if (Player1Asagi && !AltDuvarCarpisma(picPlayer1))
				{
					picPlayer1.Top += Player1Hizi;
				}

				if (topGucu != 0)
				{
					picTop.Top -= topGucu;
				}

				if (picTop.Location.Y <= lblUstDuvar.Height)
				{
					topGucu = TopYonunuAyarla(topGucu, true);
				}

				if (picTop.Location.Y + picTop.Height >= lblAltDuvar.Location.Y)
				{
					topGucu = TopYonunuAyarla(topGucu, false);
				}
				//HOCAM BUNU YAPAMADIM KALELER OLMADI 

				//if (picTop.Location.X <= label2.Height)
				//{
				//	topGucu = TopYonunuAyarla(topGucu, true);
				//}
				//if (picTop.Location.X <= label3.Height)
				//{
				//	topGucu = TopYonunuAyarla(topGucu, true);
				//}


				if (TopSolamiGidiyor)
				{
					if (SolDuvarCarpisma(picTop))
					{
						SkorEkle('2');
						picTop.Location = topKonum;
						picPlayer1.Location = ilkKonum;
						topGucu = 0;
					}

					if (!Player1VeTopCarpisma(picTop))
					{
						picTop.Left -= TopHizi;
					}
					else TopSolamiGidiyor = false;
				}
				else
				{
					if (SagDuvarCarpisma(picTop))
					{
						SkorEkle('1');
						picTop.Location = topKonum;
						picPlayer1.Location = ilkKonum;
						topGucu = 0;
					}

					if (!Player2VeTopCarpisma(picTop))
					{
						picTop.Left += TopHizi;
					}
					else TopSolamiGidiyor = true;
				}
			}
		}

		private void timerZaman_Tick(object sender, EventArgs e)
		{
			if (picPlayer1.Bounds.IntersectsWith(button1.Bounds))
			{
				picPlayer1.Left -= 25;
			}
			else if (picPlayer1.Bounds.IntersectsWith(lblUstDuvar.Bounds))
			{
				picPlayer1.Top += 25;
			}
			else if (picPlayer1.Bounds.IntersectsWith(lblAltDuvar.Bounds))
			{
				picPlayer1.Top -= 25;
			}

			if (OyunaDevammi)
			{
				sayac++;
				TimeSpan zaman = TimeSpan.FromSeconds(sayac);
				lblSure.Text = zaman.ToString(@"mm\:ss");
			}
		}
		//Player üst duvara çarptıysa
		public bool UstDuvarCarpisma(PictureBox obje)
		{
			if (obje.Location.Y <= lblUstDuvar.Height)
			{
				return true;
			}
			return false;
		}

		//Player alt duvara çarptıysa
		public bool AltDuvarCarpisma(PictureBox obje)
		{
			if (obje.Location.Y + obje.Height >= lblAltDuvar.Location.Y)
			{
				return true;
			}
			return false;
		}

		//Top sol duvara çarptıysa
		public bool SolDuvarCarpisma(PictureBox obje)
		{
			if (obje.Location.X <= lblSolDuvar.Width)
			{
				return true;
			}
			return false;
		}

		//Top sağ duvara çarptıysa
		public bool SagDuvarCarpisma(PictureBox obj)
		{
			if (obj.Location.X + obj.Width >= this.Width - lblSagDuvar.Width)
			{
				return true;
			}
			return false;
		}

		//Top player1 'e çarptıysa
		public bool Player1VeTopCarpisma(PictureBox tar)
		{
			//top ile player1 in çarpışıp çarpışmadığını kontrol eder
			//topun gücü, player1'in çarptığı bölgesine göre değişir.
			if (tar.Bounds.IntersectsWith(picPlayer1.Bounds))
			{
				PictureBox temp1 = new PictureBox
				{
					Bounds = picPlayer1.Bounds
				};

				temp1.SetBounds(temp1.Location.X + temp1.Width, temp1.Location.Y, 1, 14);
				if (tar.Bounds.IntersectsWith(temp1.Bounds))
				{
					topGucu = 3;
					return true;
				}
				temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 14, 1, 14);
				if (tar.Bounds.IntersectsWith(temp1.Bounds))
				{
					topGucu = 2;
					return true;
				}
				temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 14, 1, 14);
				if (tar.Bounds.IntersectsWith(temp1.Bounds))
				{
					topGucu = 1;
					return true;
				}
				temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 14, 1, 14);
				if (tar.Bounds.IntersectsWith(temp1.Bounds))
				{
					topGucu = 0;
					return true;
				}
				temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 14, 1, 14);
				if (tar.Bounds.IntersectsWith(temp1.Bounds))
				{
					topGucu = -1;
					return true;
				}
				temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 14, 1, 14);
				if (tar.Bounds.IntersectsWith(temp1.Bounds))
				{
					topGucu = -2;
					return true;
				}
				temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 14, 1, 14);
				if (tar.Bounds.IntersectsWith(temp1.Bounds))
				{
					topGucu = -3;
					return true;
				}
			}
			return false;
		}

		//Top player2 'e çarptıysa
		public bool Player2VeTopCarpisma(PictureBox tar)
		{
			PictureBox temp1 = new PictureBox
			{
				Bounds = picPlayer2.Bounds
			};

			temp1.SetBounds(temp1.Location.X - 1, temp1.Location.Y, 1, 10);
			if (tar.Bounds.IntersectsWith(temp1.Bounds))
			{
				topGucu = 3;
				return true;
			}
			temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 10, 1, 15);
			if (tar.Bounds.IntersectsWith(temp1.Bounds))
			{
				topGucu = 2;
				return true;
			}
			temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 15, 1, 15);
			if (tar.Bounds.IntersectsWith(temp1.Bounds))
			{
				topGucu = 1;
				return true;
			}
			temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 15, 1, 15);
			if (tar.Bounds.IntersectsWith(temp1.Bounds))
			{
				topGucu = 0;
				return true;
			}
			temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 15, 1, 15);
			if (tar.Bounds.IntersectsWith(temp1.Bounds))
			{
				topGucu = -1;
				return true;
			}
			temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 15, 1, 15);
			if (tar.Bounds.IntersectsWith(temp1.Bounds))
			{
				topGucu = -2;
				return true;
			}
			temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 15, 1, 15);
			if (tar.Bounds.IntersectsWith(temp1.Bounds))
			{
				topGucu = -3;
				return true;
			}
			return false;
		}

		//topun üst yada alt duvara çarpmasına göre x değerini tersine çevir.(Eksiyse artıya)
		public int TopYonunuAyarla(int x, bool Negative = false)
		{
			if (Negative)
			{
				if (x > 0)
				{
					x = ~x + 1;
				}
			}
			else x = x - (x * 2);
			return x;
		}

		public void SkorEkle(char skoruKimAldi)
		{
			if (skoruKimAldi == '1')
				lblPlayer1Skor.Text = (Convert.ToInt32(lblPlayer1Skor.Text) + 1).ToString();
			else if (skoruKimAldi == '2')
				lblPlayer2Skor.Text = (Convert.ToInt32(lblPlayer2Skor.Text) + 1).ToString();
			if (lblPlayer1Skor.Text == "5")
			{
				Sifirla();
				MessageBox.Show("Siz kazandınız!");
			}
			else if (lblPlayer2Skor.Text == "5")
			{
				Sifirla();
				MessageBox.Show("Bilgisayar kazandı!");
			}
		}

		private void Sifirla()
		{
			OyunaDevammi = false;
			timerPlayer2Hizi.Stop();
			timerZaman.Stop();
			timerTopHizi.Stop();
			lblSure.Text = "00 : 00";
			lblPlayer1Skor.Text = "0";
			lblPlayer2Skor.Text = "0";
			picPlayer1.Location = new Point(4, 190);
			picPlayer2.Location = new Point(697, 190);
			sayac = 0;
			Player1Yukari = false;
			Player1Asagi = false;
			BtnTekrarBaslat.Visible = true;
		}

		private void BtnTekrarBaslat_Click(object sender, EventArgs e)
		{
			BtnTekrarBaslat.Visible = false;
			OyunaDevammi = true;
			timerPlayer2Hizi.Start();
			timerZaman.Start();
			timerTopHizi.Start();
		}

		private void btnClose_Click_1(object sender, EventArgs e)
		{
			Application.Exit();
		}

	}
}
