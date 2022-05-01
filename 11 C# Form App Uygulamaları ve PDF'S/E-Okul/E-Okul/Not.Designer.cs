namespace E_Okul
{
    partial class Not
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
            this.listBox_Dersler = new System.Windows.Forms.ListBox();
            this.textBox_Not1 = new System.Windows.Forms.TextBox();
            this.textBox_Not2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Ekle = new System.Windows.Forms.Button();
            this.button_Cik = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Kredi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox_Dersler
            // 
            this.listBox_Dersler.FormattingEnabled = true;
            this.listBox_Dersler.Location = new System.Drawing.Point(13, 13);
            this.listBox_Dersler.Name = "listBox_Dersler";
            this.listBox_Dersler.Size = new System.Drawing.Size(140, 173);
            this.listBox_Dersler.TabIndex = 0;
            this.listBox_Dersler.SelectedIndexChanged += new System.EventHandler(this.listBox_Dersler_SelectedIndexChanged);
            // 
            // textBox_Not1
            // 
            this.textBox_Not1.Location = new System.Drawing.Point(158, 32);
            this.textBox_Not1.MaxLength = 3;
            this.textBox_Not1.Name = "textBox_Not1";
            this.textBox_Not1.Size = new System.Drawing.Size(47, 20);
            this.textBox_Not1.TabIndex = 1;
            // 
            // textBox_Not2
            // 
            this.textBox_Not2.Location = new System.Drawing.Point(226, 32);
            this.textBox_Not2.MaxLength = 3;
            this.textBox_Not2.Name = "textBox_Not2";
            this.textBox_Not2.Size = new System.Drawing.Size(49, 20);
            this.textBox_Not2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sınav 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sınav 2:";
            // 
            // button_Ekle
            // 
            this.button_Ekle.Location = new System.Drawing.Point(263, 60);
            this.button_Ekle.Name = "button_Ekle";
            this.button_Ekle.Size = new System.Drawing.Size(66, 42);
            this.button_Ekle.TabIndex = 5;
            this.button_Ekle.Text = "Ekle";
            this.button_Ekle.UseVisualStyleBackColor = true;
            this.button_Ekle.Click += new System.EventHandler(this.button_Ekle_Click);
            // 
            // button_Cik
            // 
            this.button_Cik.Location = new System.Drawing.Point(162, 60);
            this.button_Cik.Name = "button_Cik";
            this.button_Cik.Size = new System.Drawing.Size(71, 42);
            this.button_Cik.TabIndex = 6;
            this.button_Cik.Text = "Çık";
            this.button_Cik.UseVisualStyleBackColor = true;
            this.button_Cik.Click += new System.EventHandler(this.button_Cik_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kredi:";
            // 
            // textBox_Kredi
            // 
            this.textBox_Kredi.Location = new System.Drawing.Point(292, 32);
            this.textBox_Kredi.MaxLength = 3;
            this.textBox_Kredi.Name = "textBox_Kredi";
            this.textBox_Kredi.Size = new System.Drawing.Size(49, 20);
            this.textBox_Kredi.TabIndex = 7;
            // 
            // Not
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 195);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Kredi);
            this.Controls.Add(this.button_Cik);
            this.Controls.Add(this.button_Ekle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Not2);
            this.Controls.Add(this.textBox_Not1);
            this.Controls.Add(this.listBox_Dersler);
            this.Name = "Not";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Not";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Not_FormClosing);
            this.Load += new System.EventHandler(this.Not_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Dersler;
        private System.Windows.Forms.TextBox textBox_Not1;
        private System.Windows.Forms.TextBox textBox_Not2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Ekle;
        private System.Windows.Forms.Button button_Cik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Kredi;
    }
}