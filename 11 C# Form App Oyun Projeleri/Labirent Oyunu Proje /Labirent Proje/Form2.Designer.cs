namespace Labirent_Proje
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_basla = new System.Windows.Forms.Label();
            this.lbl_bitis = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_sure = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 500);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseEnter += new System.EventHandler(this.yanma);
            this.button1.MouseLeave += new System.EventHandler(this.yanma);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(450, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(350, 500);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseEnter += new System.EventHandler(this.yanma);
            // 
            // lbl_basla
            // 
            this.lbl_basla.BackColor = System.Drawing.Color.Yellow;
            this.lbl_basla.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_basla.Location = new System.Drawing.Point(350, 426);
            this.lbl_basla.Name = "lbl_basla";
            this.lbl_basla.Size = new System.Drawing.Size(100, 35);
            this.lbl_basla.TabIndex = 2;
            this.lbl_basla.Text = "BAŞLA";
            this.lbl_basla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_basla.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            // 
            // lbl_bitis
            // 
            this.lbl_bitis.BackColor = System.Drawing.Color.Yellow;
            this.lbl_bitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bitis.Location = new System.Drawing.Point(350, 5);
            this.lbl_bitis.Name = "lbl_bitis";
            this.lbl_bitis.Size = new System.Drawing.Size(100, 35);
            this.lbl_bitis.TabIndex = 3;
            this.lbl_bitis.Text = "BİTİŞ";
            this.lbl_bitis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_bitis.MouseEnter += new System.EventHandler(this.lbl_bitis_MouseEnter);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Lithos Pro Regular", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "SÜRE:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_sure
            // 
            this.lbl_sure.BackColor = System.Drawing.Color.Black;
            this.lbl_sure.Font = new System.Drawing.Font("Lithos Pro Regular", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sure.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_sure.Location = new System.Drawing.Point(80, 9);
            this.lbl_sure.Name = "lbl_sure";
            this.lbl_sure.Size = new System.Drawing.Size(74, 35);
            this.lbl_sure.TabIndex = 5;
            this.lbl_sure.Text = "30";
            this.lbl_sure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(350, -30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 35);
            this.label2.TabIndex = 6;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_sure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_bitis);
            this.Controls.Add(this.lbl_basla);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_basla;
        private System.Windows.Forms.Label lbl_bitis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_sure;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}