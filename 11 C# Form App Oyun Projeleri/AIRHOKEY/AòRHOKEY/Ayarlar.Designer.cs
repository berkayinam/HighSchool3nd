namespace AİRHOKEY
{
	partial class Ayarlar
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.Btn_basla = new System.Windows.Forms.Button();
			this.Settings = new System.Windows.Forms.GroupBox();
			this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
			this.Oyuncu1hizi = new System.Windows.Forms.Label();
			this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
			this.Oyuncu2hizi = new System.Windows.Forms.Label();
			this.Varsayilan = new System.Windows.Forms.Button();
			this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.Oyuncu2timerhizi = new System.Windows.Forms.Label();
			this.Oyuncutimerhizi = new System.Windows.Forms.Label();
			this.TopHizi = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.Settings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// Btn_basla
			// 
			this.Btn_basla.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Btn_basla.Location = new System.Drawing.Point(32, 190);
			this.Btn_basla.Name = "Btn_basla";
			this.Btn_basla.Size = new System.Drawing.Size(183, 81);
			this.Btn_basla.TabIndex = 9;
			this.Btn_basla.Text = "BAŞLA";
			this.Btn_basla.UseVisualStyleBackColor = true;
			this.Btn_basla.Click += new System.EventHandler(this.Btn_basla_Click);
			// 
			// Settings
			// 
			this.Settings.Controls.Add(this.numericUpDown5);
			this.Settings.Controls.Add(this.Oyuncu1hizi);
			this.Settings.Controls.Add(this.numericUpDown4);
			this.Settings.Controls.Add(this.Oyuncu2hizi);
			this.Settings.Controls.Add(this.Varsayilan);
			this.Settings.Controls.Add(this.numericUpDown3);
			this.Settings.Controls.Add(this.numericUpDown2);
			this.Settings.Controls.Add(this.Oyuncu2timerhizi);
			this.Settings.Controls.Add(this.Oyuncutimerhizi);
			this.Settings.Controls.Add(this.TopHizi);
			this.Settings.Controls.Add(this.numericUpDown1);
			this.Settings.Location = new System.Drawing.Point(12, 12);
			this.Settings.Name = "Settings";
			this.Settings.Size = new System.Drawing.Size(237, 172);
			this.Settings.TabIndex = 8;
			this.Settings.TabStop = false;
			this.Settings.Text = "Gelişmiş Ayarlar";
			// 
			// numericUpDown5
			// 
			this.numericUpDown5.Location = new System.Drawing.Point(119, 111);
			this.numericUpDown5.Name = "numericUpDown5";
			this.numericUpDown5.Size = new System.Drawing.Size(107, 20);
			this.numericUpDown5.TabIndex = 13;
			this.numericUpDown5.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// Oyuncu1hizi
			// 
			this.Oyuncu1hizi.AutoSize = true;
			this.Oyuncu1hizi.Location = new System.Drawing.Point(6, 118);
			this.Oyuncu1hizi.Name = "Oyuncu1hizi";
			this.Oyuncu1hizi.Size = new System.Drawing.Size(70, 13);
			this.Oyuncu1hizi.TabIndex = 12;
			this.Oyuncu1hizi.Text = "Oyuncu1 Hızı";
			// 
			// numericUpDown4
			// 
			this.numericUpDown4.Location = new System.Drawing.Point(119, 88);
			this.numericUpDown4.Name = "numericUpDown4";
			this.numericUpDown4.Size = new System.Drawing.Size(107, 20);
			this.numericUpDown4.TabIndex = 11;
			this.numericUpDown4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// Oyuncu2hizi
			// 
			this.Oyuncu2hizi.AutoSize = true;
			this.Oyuncu2hizi.Location = new System.Drawing.Point(6, 95);
			this.Oyuncu2hizi.Name = "Oyuncu2hizi";
			this.Oyuncu2hizi.Size = new System.Drawing.Size(70, 13);
			this.Oyuncu2hizi.TabIndex = 10;
			this.Oyuncu2hizi.Text = "Oyuncu2 Hızı";
			// 
			// Varsayilan
			// 
			this.Varsayilan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Varsayilan.Location = new System.Drawing.Point(6, 143);
			this.Varsayilan.Name = "Varsayilan";
			this.Varsayilan.Size = new System.Drawing.Size(220, 23);
			this.Varsayilan.TabIndex = 9;
			this.Varsayilan.Text = "Varsayılan Ayarlara Dön";
			this.Varsayilan.UseVisualStyleBackColor = true;
			this.Varsayilan.Click += new System.EventHandler(this.Varsayilan_Click);
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.Location = new System.Drawing.Point(119, 65);
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(107, 20);
			this.numericUpDown3.TabIndex = 8;
			this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(119, 42);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(107, 20);
			this.numericUpDown2.TabIndex = 7;
			this.numericUpDown2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// Oyuncu2timerhizi
			// 
			this.Oyuncu2timerhizi.AutoSize = true;
			this.Oyuncu2timerhizi.Location = new System.Drawing.Point(6, 49);
			this.Oyuncu2timerhizi.Name = "Oyuncu2timerhizi";
			this.Oyuncu2timerhizi.Size = new System.Drawing.Size(99, 13);
			this.Oyuncu2timerhizi.TabIndex = 6;
			this.Oyuncu2timerhizi.Text = "Oyuncu2 Timer Hızı";
			// 
			// Oyuncutimerhizi
			// 
			this.Oyuncutimerhizi.AutoSize = true;
			this.Oyuncutimerhizi.Location = new System.Drawing.Point(6, 72);
			this.Oyuncutimerhizi.Name = "Oyuncutimerhizi";
			this.Oyuncutimerhizi.Size = new System.Drawing.Size(81, 13);
			this.Oyuncutimerhizi.TabIndex = 5;
			this.Oyuncutimerhizi.Text = "Oyun Timer Hızı";
			// 
			// TopHizi
			// 
			this.TopHizi.AutoSize = true;
			this.TopHizi.Location = new System.Drawing.Point(6, 26);
			this.TopHizi.Name = "TopHizi";
			this.TopHizi.Size = new System.Drawing.Size(46, 13);
			this.TopHizi.TabIndex = 4;
			this.TopHizi.Text = "Top Hızı";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(119, 19);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(107, 20);
			this.numericUpDown1.TabIndex = 0;
			this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
			// 
			// Ayarlar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(259, 288);
			this.Controls.Add(this.Btn_basla);
			this.Controls.Add(this.Settings);
			this.Name = "Ayarlar";
			this.Text = "AYARLAR";
			this.Load += new System.EventHandler(this.Ayarlar_Load);
			this.Settings.ResumeLayout(false);
			this.Settings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Btn_basla;
		private System.Windows.Forms.GroupBox Settings;
		private System.Windows.Forms.NumericUpDown numericUpDown5;
		private System.Windows.Forms.Label Oyuncu1hizi;
		private System.Windows.Forms.NumericUpDown numericUpDown4;
		private System.Windows.Forms.Label Oyuncu2hizi;
		private System.Windows.Forms.Button Varsayilan;
		private System.Windows.Forms.NumericUpDown numericUpDown3;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.Label Oyuncu2timerhizi;
		private System.Windows.Forms.Label Oyuncutimerhizi;
		private System.Windows.Forms.Label TopHizi;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
	}
}

