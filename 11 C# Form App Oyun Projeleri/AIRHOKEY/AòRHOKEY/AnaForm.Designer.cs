namespace AİRHOKEY
{
	partial class AnaForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.BtnTekrarBaslat = new System.Windows.Forms.Button();
			this.picTop = new System.Windows.Forms.PictureBox();
			this.lblSure = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblPlayer2Skor = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblPlayer1Skor = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.lblUstDuvar = new System.Windows.Forms.Label();
			this.picPlayer2 = new System.Windows.Forms.PictureBox();
			this.picPlayer1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.timerZaman = new System.Windows.Forms.Timer(this.components);
			this.timerTopHizi = new System.Windows.Forms.Timer(this.components);
			this.timerPlayer2Hizi = new System.Windows.Forms.Timer(this.components);
			this.lblSagDuvar = new System.Windows.Forms.Label();
			this.lblSolDuvar = new System.Windows.Forms.Label();
			this.lblAltDuvar = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picTop)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).BeginInit();
			this.SuspendLayout();
			// 
			// BtnTekrarBaslat
			// 
			this.BtnTekrarBaslat.BackColor = System.Drawing.Color.Black;
			this.BtnTekrarBaslat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.BtnTekrarBaslat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.BtnTekrarBaslat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnTekrarBaslat.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnTekrarBaslat.ForeColor = System.Drawing.Color.White;
			this.BtnTekrarBaslat.Location = new System.Drawing.Point(522, 3);
			this.BtnTekrarBaslat.Name = "BtnTekrarBaslat";
			this.BtnTekrarBaslat.Size = new System.Drawing.Size(98, 33);
			this.BtnTekrarBaslat.TabIndex = 50;
			this.BtnTekrarBaslat.Text = "Başlat";
			this.BtnTekrarBaslat.UseVisualStyleBackColor = false;
			this.BtnTekrarBaslat.Click += new System.EventHandler(this.BtnTekrarBaslat_Click);
			// 
			// picTop
			// 
			this.picTop.BackColor = System.Drawing.Color.Goldenrod;
			this.picTop.Enabled = false;
			this.picTop.Location = new System.Drawing.Point(342, 220);
			this.picTop.Name = "picTop";
			this.picTop.Size = new System.Drawing.Size(25, 25);
			this.picTop.TabIndex = 49;
			this.picTop.TabStop = false;
			// 
			// lblSure
			// 
			this.lblSure.AutoSize = true;
			this.lblSure.BackColor = System.Drawing.Color.Black;
			this.lblSure.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblSure.ForeColor = System.Drawing.Color.White;
			this.lblSure.Location = new System.Drawing.Point(89, 15);
			this.lblSure.Name = "lblSure";
			this.lblSure.Size = new System.Drawing.Size(53, 19);
			this.lblSure.TabIndex = 48;
			this.lblSure.Text = "00 : 00";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Black;
			this.label6.Font = new System.Drawing.Font("Bahamas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(12, 11);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 25);
			this.label6.TabIndex = 47;
			this.label6.Text = "Süre : ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Black;
			this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(318, 11);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(13, 19);
			this.label5.TabIndex = 46;
			this.label5.Text = ":";
			// 
			// lblPlayer2Skor
			// 
			this.lblPlayer2Skor.AutoSize = true;
			this.lblPlayer2Skor.BackColor = System.Drawing.Color.Black;
			this.lblPlayer2Skor.Font = new System.Drawing.Font("Bahamas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblPlayer2Skor.ForeColor = System.Drawing.Color.White;
			this.lblPlayer2Skor.Location = new System.Drawing.Point(337, 11);
			this.lblPlayer2Skor.Name = "lblPlayer2Skor";
			this.lblPlayer2Skor.Size = new System.Drawing.Size(24, 25);
			this.lblPlayer2Skor.TabIndex = 45;
			this.lblPlayer2Skor.Text = "0";
			this.lblPlayer2Skor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Black;
			this.label4.Font = new System.Drawing.Font("Bahamas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(367, 10);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 25);
			this.label4.TabIndex = 44;
			this.label4.Text = "Player2";
			// 
			// lblPlayer1Skor
			// 
			this.lblPlayer1Skor.AutoSize = true;
			this.lblPlayer1Skor.BackColor = System.Drawing.Color.Black;
			this.lblPlayer1Skor.Font = new System.Drawing.Font("Bahamas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblPlayer1Skor.ForeColor = System.Drawing.Color.White;
			this.lblPlayer1Skor.Location = new System.Drawing.Point(288, 8);
			this.lblPlayer1Skor.Name = "lblPlayer1Skor";
			this.lblPlayer1Skor.Size = new System.Drawing.Size(24, 25);
			this.lblPlayer1Skor.TabIndex = 43;
			this.lblPlayer1Skor.Text = "0";
			this.lblPlayer1Skor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Black;
			this.label1.Font = new System.Drawing.Font("Bahamas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(197, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 25);
			this.label1.TabIndex = 42;
			this.label1.Text = "Player1";
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Red;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnClose.Location = new System.Drawing.Point(688, 8);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(26, 22);
			this.btnClose.TabIndex = 41;
			this.btnClose.Text = "X";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
			// 
			// lblUstDuvar
			// 
			this.lblUstDuvar.BackColor = System.Drawing.Color.White;
			this.lblUstDuvar.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblUstDuvar.Enabled = false;
			this.lblUstDuvar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblUstDuvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.lblUstDuvar.Location = new System.Drawing.Point(0, 0);
			this.lblUstDuvar.Name = "lblUstDuvar";
			this.lblUstDuvar.Size = new System.Drawing.Size(724, 40);
			this.lblUstDuvar.TabIndex = 39;
			this.lblUstDuvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picPlayer2
			// 
			this.picPlayer2.BackColor = System.Drawing.Color.Pink;
			this.picPlayer2.Enabled = false;
			this.picPlayer2.Location = new System.Drawing.Point(661, 212);
			this.picPlayer2.Name = "picPlayer2";
			this.picPlayer2.Size = new System.Drawing.Size(50, 42);
			this.picPlayer2.TabIndex = 38;
			this.picPlayer2.TabStop = false;
			// 
			// picPlayer1
			// 
			this.picPlayer1.BackColor = System.Drawing.Color.DodgerBlue;
			this.picPlayer1.Enabled = false;
			this.picPlayer1.Location = new System.Drawing.Point(11, 212);
			this.picPlayer1.Name = "picPlayer1";
			this.picPlayer1.Size = new System.Drawing.Size(50, 50);
			this.picPlayer1.TabIndex = 37;
			this.picPlayer1.TabStop = false;
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(351, 31);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(10, 429);
			this.button1.TabIndex = 51;
			this.button1.UseVisualStyleBackColor = true;
			// 
			// timerZaman
			// 
			this.timerZaman.Interval = 1000;
			this.timerZaman.Tick += new System.EventHandler(this.timerZaman_Tick);
			// 
			// timerTopHizi
			// 
			this.timerTopHizi.Interval = 1;
			this.timerTopHizi.Tick += new System.EventHandler(this.timerTopHizi_Tick);
			// 
			// timerPlayer2Hizi
			// 
			this.timerPlayer2Hizi.Interval = 1;
			this.timerPlayer2Hizi.Tick += new System.EventHandler(this.timerPlayer2Hizi_Tick);
			// 
			// lblSagDuvar
			// 
			this.lblSagDuvar.BackColor = System.Drawing.Color.Turquoise;
			this.lblSagDuvar.Dock = System.Windows.Forms.DockStyle.Right;
			this.lblSagDuvar.Font = new System.Drawing.Font("Calibri", 9F);
			this.lblSagDuvar.Location = new System.Drawing.Point(714, 40);
			this.lblSagDuvar.Name = "lblSagDuvar";
			this.lblSagDuvar.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblSagDuvar.Size = new System.Drawing.Size(10, 421);
			this.lblSagDuvar.TabIndex = 20;
			// 
			// lblSolDuvar
			// 
			this.lblSolDuvar.BackColor = System.Drawing.Color.Turquoise;
			this.lblSolDuvar.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblSolDuvar.Location = new System.Drawing.Point(0, 40);
			this.lblSolDuvar.Name = "lblSolDuvar";
			this.lblSolDuvar.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblSolDuvar.Size = new System.Drawing.Size(10, 421);
			this.lblSolDuvar.TabIndex = 56;
			// 
			// lblAltDuvar
			// 
			this.lblAltDuvar.BackColor = System.Drawing.Color.Turquoise;
			this.lblAltDuvar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblAltDuvar.Font = new System.Drawing.Font("Calibri", 9F);
			this.lblAltDuvar.Location = new System.Drawing.Point(10, 460);
			this.lblAltDuvar.Name = "lblAltDuvar";
			this.lblAltDuvar.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblAltDuvar.Size = new System.Drawing.Size(704, 1);
			this.lblAltDuvar.TabIndex = 21;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Red;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(-67, 291);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 108);
			this.label2.TabIndex = 57;
			this.label2.Text = "b";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Red;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(-67, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 108);
			this.label3.TabIndex = 58;
			this.label3.Text = "b";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// AnaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Turquoise;
			this.ClientSize = new System.Drawing.Size(724, 461);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblAltDuvar);
			this.Controls.Add(this.lblSolDuvar);
			this.Controls.Add(this.lblSagDuvar);
			this.Controls.Add(this.BtnTekrarBaslat);
			this.Controls.Add(this.picTop);
			this.Controls.Add(this.lblSure);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblPlayer2Skor);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblPlayer1Skor);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lblUstDuvar);
			this.Controls.Add(this.picPlayer2);
			this.Controls.Add(this.picPlayer1);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AnaForm";
			this.Text = "AnaForm";
			this.Load += new System.EventHandler(this.AnaForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnaForm_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.picTop)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button BtnTekrarBaslat;
		private System.Windows.Forms.PictureBox picTop;
		private System.Windows.Forms.Label lblSure;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblPlayer2Skor;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblPlayer1Skor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label lblUstDuvar;
		private System.Windows.Forms.PictureBox picPlayer2;
		private System.Windows.Forms.PictureBox picPlayer1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Timer timerZaman;
		private System.Windows.Forms.Timer timerTopHizi;
		private System.Windows.Forms.Timer timerPlayer2Hizi;
		private System.Windows.Forms.Label lblSagDuvar;
		private System.Windows.Forms.Label lblSolDuvar;
		private System.Windows.Forms.Label lblAltDuvar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}