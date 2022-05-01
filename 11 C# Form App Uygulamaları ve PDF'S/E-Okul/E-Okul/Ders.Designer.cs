namespace E_Okul
{
    partial class Ders
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Ders = new System.Windows.Forms.TextBox();
            this.button_Ekle = new System.Windows.Forms.Button();
            this.button_Cik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders Adı:";
            // 
            // textBox_Ders
            // 
            this.textBox_Ders.Location = new System.Drawing.Point(69, 10);
            this.textBox_Ders.Name = "textBox_Ders";
            this.textBox_Ders.Size = new System.Drawing.Size(100, 20);
            this.textBox_Ders.TabIndex = 1;
            // 
            // button_Ekle
            // 
            this.button_Ekle.Location = new System.Drawing.Point(94, 36);
            this.button_Ekle.Name = "button_Ekle";
            this.button_Ekle.Size = new System.Drawing.Size(75, 29);
            this.button_Ekle.TabIndex = 2;
            this.button_Ekle.Text = "Ekle";
            this.button_Ekle.UseVisualStyleBackColor = true;
            this.button_Ekle.Click += new System.EventHandler(this.button_Ekle_Click);
            // 
            // button_Cik
            // 
            this.button_Cik.Location = new System.Drawing.Point(13, 36);
            this.button_Cik.Name = "button_Cik";
            this.button_Cik.Size = new System.Drawing.Size(75, 29);
            this.button_Cik.TabIndex = 3;
            this.button_Cik.Text = "İptal";
            this.button_Cik.UseVisualStyleBackColor = true;
            this.button_Cik.Click += new System.EventHandler(this.button_Cik_Click);
            // 
            // Ders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 74);
            this.ControlBox = false;
            this.Controls.Add(this.button_Cik);
            this.Controls.Add(this.button_Ekle);
            this.Controls.Add(this.textBox_Ders);
            this.Controls.Add(this.label1);
            this.Name = "Ders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ders_FormClosing);
            this.Load += new System.EventHandler(this.Ders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Ders;
        private System.Windows.Forms.Button button_Ekle;
        private System.Windows.Forms.Button button_Cik;
    }
}