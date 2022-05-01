namespace E_Okul
{
    partial class Form1
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
            this.button_Gir = new System.Windows.Forms.Button();
            this.button_Kayit = new System.Windows.Forms.Button();
            this.button_Cik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Gir
            // 
            this.button_Gir.Location = new System.Drawing.Point(18, 12);
            this.button_Gir.Name = "button_Gir";
            this.button_Gir.Size = new System.Drawing.Size(81, 29);
            this.button_Gir.TabIndex = 0;
            this.button_Gir.Text = "Giriş";
            this.button_Gir.UseVisualStyleBackColor = true;
            this.button_Gir.Click += new System.EventHandler(this.button_Gir_Click);
            // 
            // button_Kayit
            // 
            this.button_Kayit.Location = new System.Drawing.Point(18, 47);
            this.button_Kayit.Name = "button_Kayit";
            this.button_Kayit.Size = new System.Drawing.Size(81, 29);
            this.button_Kayit.TabIndex = 1;
            this.button_Kayit.Text = "Kayıt Ol";
            this.button_Kayit.UseVisualStyleBackColor = true;
            this.button_Kayit.Click += new System.EventHandler(this.button_Kayit_Click);
            // 
            // button_Cik
            // 
            this.button_Cik.Location = new System.Drawing.Point(18, 82);
            this.button_Cik.Name = "button_Cik";
            this.button_Cik.Size = new System.Drawing.Size(81, 29);
            this.button_Cik.TabIndex = 2;
            this.button_Cik.Text = "Çıkış";
            this.button_Cik.UseVisualStyleBackColor = true;
            this.button_Cik.Click += new System.EventHandler(this.button_Cik_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 123);
            this.ControlBox = false;
            this.Controls.Add(this.button_Cik);
            this.Controls.Add(this.button_Kayit);
            this.Controls.Add(this.button_Gir);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Gir;
        private System.Windows.Forms.Button button_Kayit;
        private System.Windows.Forms.Button button_Cik;
    }
}

