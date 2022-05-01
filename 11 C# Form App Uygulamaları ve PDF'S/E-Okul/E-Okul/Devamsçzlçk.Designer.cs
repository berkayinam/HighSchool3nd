namespace E_Okul
{
    partial class Devamsızlık
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
            this.button_Ekle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox_Ad = new System.Windows.Forms.TextBox();
            this.textBox_Snf = new System.Windows.Forms.TextBox();
            this.textBox_Sube = new System.Windows.Forms.TextBox();
            this.textBox_Devam = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Ekle
            // 
            this.button_Ekle.Location = new System.Drawing.Point(203, 159);
            this.button_Ekle.Name = "button_Ekle";
            this.button_Ekle.Size = new System.Drawing.Size(86, 36);
            this.button_Ekle.TabIndex = 1;
            this.button_Ekle.Text = "Ekle";
            this.button_Ekle.UseVisualStyleBackColor = true;
            this.button_Ekle.Click += new System.EventHandler(this.button_Ekle_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(184, 186);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox_Ad
            // 
            this.textBox_Ad.Enabled = false;
            this.textBox_Ad.Location = new System.Drawing.Point(203, 24);
            this.textBox_Ad.Name = "textBox_Ad";
            this.textBox_Ad.Size = new System.Drawing.Size(100, 20);
            this.textBox_Ad.TabIndex = 3;
            // 
            // textBox_Snf
            // 
            this.textBox_Snf.Enabled = false;
            this.textBox_Snf.Location = new System.Drawing.Point(203, 50);
            this.textBox_Snf.Name = "textBox_Snf";
            this.textBox_Snf.Size = new System.Drawing.Size(100, 20);
            this.textBox_Snf.TabIndex = 5;
            // 
            // textBox_Sube
            // 
            this.textBox_Sube.Enabled = false;
            this.textBox_Sube.Location = new System.Drawing.Point(203, 76);
            this.textBox_Sube.Name = "textBox_Sube";
            this.textBox_Sube.Size = new System.Drawing.Size(100, 20);
            this.textBox_Sube.TabIndex = 6;
            this.textBox_Sube.TextChanged += new System.EventHandler(this.textBox_Sube_TextChanged);
            // 
            // textBox_Devam
            // 
            this.textBox_Devam.Location = new System.Drawing.Point(203, 133);
            this.textBox_Devam.Name = "textBox_Devam";
            this.textBox_Devam.Size = new System.Drawing.Size(100, 20);
            this.textBox_Devam.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Devamsızlık
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 209);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Devam);
            this.Controls.Add(this.textBox_Sube);
            this.Controls.Add(this.textBox_Snf);
            this.Controls.Add(this.textBox_Ad);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_Ekle);
            this.Name = "Devamsızlık";
            this.Text = "Devamsızlık";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Devamsızlık_FormClosing);
            this.Load += new System.EventHandler(this.Devamsızlık_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Ekle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox_Ad;
        private System.Windows.Forms.TextBox textBox_Snf;
        private System.Windows.Forms.TextBox textBox_Sube;
        private System.Windows.Forms.TextBox textBox_Devam;
        private System.Windows.Forms.Button button1;
    }
}