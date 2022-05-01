namespace E_Okul
{
    partial class Menu
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
            this.button_dersEkle = new System.Windows.Forms.Button();
            this.button_notEkle = new System.Windows.Forms.Button();
            this.button_Guncl = new System.Windows.Forms.Button();
            this.button_Devam = new System.Windows.Forms.Button();
            this.button_Karne = new System.Windows.Forms.Button();
            this.button_Cik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_dersEkle
            // 
            this.button_dersEkle.Location = new System.Drawing.Point(13, 13);
            this.button_dersEkle.Name = "button_dersEkle";
            this.button_dersEkle.Size = new System.Drawing.Size(86, 37);
            this.button_dersEkle.TabIndex = 0;
            this.button_dersEkle.Text = "Ders Ekle";
            this.button_dersEkle.UseVisualStyleBackColor = true;
            this.button_dersEkle.Click += new System.EventHandler(this.button_dersEkle_Click);
            // 
            // button_notEkle
            // 
            this.button_notEkle.Location = new System.Drawing.Point(13, 56);
            this.button_notEkle.Name = "button_notEkle";
            this.button_notEkle.Size = new System.Drawing.Size(86, 37);
            this.button_notEkle.TabIndex = 1;
            this.button_notEkle.Text = "Not Ekle";
            this.button_notEkle.UseVisualStyleBackColor = true;
            this.button_notEkle.Click += new System.EventHandler(this.button_notEkle_Click);
            // 
            // button_Guncl
            // 
            this.button_Guncl.Location = new System.Drawing.Point(13, 99);
            this.button_Guncl.Name = "button_Guncl";
            this.button_Guncl.Size = new System.Drawing.Size(86, 37);
            this.button_Guncl.TabIndex = 2;
            this.button_Guncl.Text = "Bilgileri Güncelle";
            this.button_Guncl.UseVisualStyleBackColor = true;
            this.button_Guncl.Click += new System.EventHandler(this.button_Guncl_Click);
            // 
            // button_Devam
            // 
            this.button_Devam.Location = new System.Drawing.Point(13, 142);
            this.button_Devam.Name = "button_Devam";
            this.button_Devam.Size = new System.Drawing.Size(86, 37);
            this.button_Devam.TabIndex = 3;
            this.button_Devam.Text = "Devamsızlık Ekle";
            this.button_Devam.UseVisualStyleBackColor = true;
            this.button_Devam.Click += new System.EventHandler(this.button_Devam_Click);
            // 
            // button_Karne
            // 
            this.button_Karne.Location = new System.Drawing.Point(13, 185);
            this.button_Karne.Name = "button_Karne";
            this.button_Karne.Size = new System.Drawing.Size(86, 37);
            this.button_Karne.TabIndex = 4;
            this.button_Karne.Text = "Karneyi Göster";
            this.button_Karne.UseVisualStyleBackColor = true;
            this.button_Karne.Click += new System.EventHandler(this.button_Karne_Click);
            // 
            // button_Cik
            // 
            this.button_Cik.Location = new System.Drawing.Point(12, 228);
            this.button_Cik.Name = "button_Cik";
            this.button_Cik.Size = new System.Drawing.Size(86, 37);
            this.button_Cik.TabIndex = 5;
            this.button_Cik.Text = "Çıkış";
            this.button_Cik.UseVisualStyleBackColor = true;
            this.button_Cik.Click += new System.EventHandler(this.button_Cik_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 275);
            this.ControlBox = false;
            this.Controls.Add(this.button_Cik);
            this.Controls.Add(this.button_Karne);
            this.Controls.Add(this.button_Devam);
            this.Controls.Add(this.button_Guncl);
            this.Controls.Add(this.button_notEkle);
            this.Controls.Add(this.button_dersEkle);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_dersEkle;
        private System.Windows.Forms.Button button_notEkle;
        private System.Windows.Forms.Button button_Guncl;
        private System.Windows.Forms.Button button_Devam;
        private System.Windows.Forms.Button button_Karne;
        private System.Windows.Forms.Button button_Cik;
    }
}