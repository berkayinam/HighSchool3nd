namespace _07_ArabaYarısı
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbxFiat = new System.Windows.Forms.PictureBox();
            this.pbxPorsche = new System.Windows.Forms.PictureBox();
            this.btnIlerle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFiat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPorsche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(49, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(637, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "=================================================================================" +
    "========================";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(49, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(637, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "=================================================================================" +
    "========================";
            // 
            // pbxFiat
            // 
            this.pbxFiat.Image = ((System.Drawing.Image)(resources.GetObject("pbxFiat.Image")));
            this.pbxFiat.Location = new System.Drawing.Point(12, 68);
            this.pbxFiat.Name = "pbxFiat";
            this.pbxFiat.Size = new System.Drawing.Size(60, 66);
            this.pbxFiat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFiat.TabIndex = 2;
            this.pbxFiat.TabStop = false;
            // 
            // pbxPorsche
            // 
            this.pbxPorsche.Image = ((System.Drawing.Image)(resources.GetObject("pbxPorsche.Image")));
            this.pbxPorsche.Location = new System.Drawing.Point(12, 140);
            this.pbxPorsche.Name = "pbxPorsche";
            this.pbxPorsche.Size = new System.Drawing.Size(60, 66);
            this.pbxPorsche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPorsche.TabIndex = 3;
            this.pbxPorsche.TabStop = false;
            // 
            // btnIlerle
            // 
            this.btnIlerle.Location = new System.Drawing.Point(71, 271);
            this.btnIlerle.Name = "btnIlerle";
            this.btnIlerle.Size = new System.Drawing.Size(75, 23);
            this.btnIlerle.TabIndex = 4;
            this.btnIlerle.Text = "ilerlet";
            this.btnIlerle.UseVisualStyleBackColor = true;
            this.btnIlerle.Click += new System.EventHandler(this.btnIlerle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(680, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yenileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(835, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.yenileToolStripMenuItem.Text = "Yenile";
            this.yenileToolStripMenuItem.Click += new System.EventHandler(this.yenileToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnIlerle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 356);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIlerle);
            this.Controls.Add(this.pbxPorsche);
            this.Controls.Add(this.pbxFiat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxFiat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPorsche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbxFiat;
        private System.Windows.Forms.PictureBox pbxPorsche;
        private System.Windows.Forms.Button btnIlerle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
    }
}

