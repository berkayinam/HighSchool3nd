namespace WindowsFormsApp9
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Saniye = new System.Windows.Forms.Label();
            this.lbl_Salise = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_Dakika = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(536, -29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 565);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = " ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lbl_Saniye
            // 
            this.lbl_Saniye.AutoSize = true;
            this.lbl_Saniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Saniye.ForeColor = System.Drawing.Color.Black;
            this.lbl_Saniye.Location = new System.Drawing.Point(650, 90);
            this.lbl_Saniye.Name = "lbl_Saniye";
            this.lbl_Saniye.Size = new System.Drawing.Size(36, 39);
            this.lbl_Saniye.TabIndex = 1;
            this.lbl_Saniye.Text = "0";
            // 
            // lbl_Salise
            // 
            this.lbl_Salise.AutoSize = true;
            this.lbl_Salise.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Salise.ForeColor = System.Drawing.Color.Black;
            this.lbl_Salise.Location = new System.Drawing.Point(736, 90);
            this.lbl_Salise.Name = "lbl_Salise";
            this.lbl_Salise.Size = new System.Drawing.Size(36, 39);
            this.lbl_Salise.TabIndex = 2;
            this.lbl_Salise.Text = "0";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(698, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = ".";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_Dakika
            // 
            this.lbl_Dakika.AutoSize = true;
            this.lbl_Dakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Dakika.ForeColor = System.Drawing.Color.Black;
            this.lbl_Dakika.Location = new System.Drawing.Point(566, 90);
            this.lbl_Dakika.Name = "lbl_Dakika";
            this.lbl_Dakika.Size = new System.Drawing.Size(36, 39);
            this.lbl_Dakika.TabIndex = 5;
            this.lbl_Dakika.Text = "0";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(614, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 522);
            this.Controls.Add(this.lbl_Dakika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Salise);
            this.Controls.Add(this.lbl_Saniye);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Sayı Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_Saniye;
        private System.Windows.Forms.Label lbl_Salise;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_Dakika;
        private System.Windows.Forms.Label label2;
    }
}

