namespace WindowsFormsApp1
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
            this.button_Baslat = new System.Windows.Forms.Button();
            this.button_A = new System.Windows.Forms.Button();
            this.button_B = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button_End = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Baslat
            // 
            this.button_Baslat.BackColor = System.Drawing.Color.ForestGreen;
            this.button_Baslat.Location = new System.Drawing.Point(12, 36);
            this.button_Baslat.Name = "button_Baslat";
            this.button_Baslat.Size = new System.Drawing.Size(111, 40);
            this.button_Baslat.TabIndex = 0;
            this.button_Baslat.Text = "Başlat";
            this.button_Baslat.UseVisualStyleBackColor = false;
            this.button_Baslat.Click += new System.EventHandler(this.button_Baslat_Click);
            // 
            // button_A
            // 
            this.button_A.Location = new System.Drawing.Point(12, 150);
            this.button_A.Name = "button_A";
            this.button_A.Size = new System.Drawing.Size(137, 63);
            this.button_A.TabIndex = 1;
            this.button_A.Text = "A";
            this.button_A.UseVisualStyleBackColor = true;
            // 
            // button_B
            // 
            this.button_B.Location = new System.Drawing.Point(12, 278);
            this.button_B.Name = "button_B";
            this.button_B.Size = new System.Drawing.Size(137, 63);
            this.button_B.TabIndex = 2;
            this.button_B.Text = "B";
            this.button_B.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(0, 115);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(1031, 15);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button_End
            // 
            this.button_End.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_End.Location = new System.Drawing.Point(1012, 115);
            this.button_End.Name = "button_End";
            this.button_End.Size = new System.Drawing.Size(19, 269);
            this.button_End.TabIndex = 6;
            this.button_End.Text = "F I N I S H";
            this.button_End.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(847, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "0";
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(900, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 35);
            this.label2.TabIndex = 8;
            this.label2.Text = "0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(0, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1031, 15);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(0, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1031, 15);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(879, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 425);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_End);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button_B);
            this.Controls.Add(this.button_A);
            this.Controls.Add(this.button_Baslat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Baslat;
        private System.Windows.Forms.Button button_A;
        private System.Windows.Forms.Button button_B;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button_End;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
    }
}

