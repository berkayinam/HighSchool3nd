namespace _03_MatIslem
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
            this.lblSayı1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSayı2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSayı1
            // 
            this.lblSayı1.AutoSize = true;
            this.lblSayı1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayı1.Location = new System.Drawing.Point(62, 36);
            this.lblSayı1.Name = "lblSayı1";
            this.lblSayı1.Size = new System.Drawing.Size(29, 31);
            this.lblSayı1.TabIndex = 0;
            this.lblSayı1.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(135, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            // 
            // lblSayı2
            // 
            this.lblSayı2.AutoSize = true;
            this.lblSayı2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayı2.Location = new System.Drawing.Point(214, 36);
            this.lblSayı2.Name = "lblSayı2";
            this.lblSayı2.Size = new System.Drawing.Size(29, 31);
            this.lblSayı2.TabIndex = 2;
            this.lblSayı2.Text = "?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(276, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "=";
            // 
            // txtSonuc
            // 
            this.txtSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSonuc.Location = new System.Drawing.Point(321, 33);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(79, 38);
            this.txtSonuc.TabIndex = 4;
            this.txtSonuc.TextChanged += new System.EventHandler(this.txtSonuc_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tekrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 140);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSayı2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSayı1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayı1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSayı2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Button button1;
    }
}

