namespace OkulStokProgramı
{
    partial class Goruntule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Goruntule));
            this.Btn_Font = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Geri = new System.Windows.Forms.ToolStripButton();
            this.İleri = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Font
            // 
            this.Btn_Font.Font = new System.Drawing.Font("Korolev Heavy", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Font.Location = new System.Drawing.Point(25, -110);
            this.Btn_Font.Name = "Btn_Font";
            this.Btn_Font.Size = new System.Drawing.Size(132, 65);
            this.Btn_Font.TabIndex = 4;
            this.Btn_Font.Text = "EKLE";
            this.Btn_Font.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Geri,
            this.İleri});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Geri
            // 
            this.Geri.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Geri.Image = ((System.Drawing.Image)(resources.GetObject("Geri.Image")));
            this.Geri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Geri.Name = "Geri";
            this.Geri.Size = new System.Drawing.Size(23, 22);
            this.Geri.Text = "Geri";
            this.Geri.Click += new System.EventHandler(this.Geri_Click);
            // 
            // İleri
            // 
            this.İleri.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.İleri.Image = ((System.Drawing.Image)(resources.GetObject("İleri.Image")));
            this.İleri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.İleri.Name = "İleri";
            this.İleri.Size = new System.Drawing.Size(23, 22);
            this.İleri.Text = "İleri";
            // 
            // Goruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Btn_Font);
            this.Name = "Goruntule";
            this.Text = "Görüntüle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Goruntule_FormClosing);
            this.Load += new System.EventHandler(this.Görüntüle_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Font;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Geri;
        private System.Windows.Forms.ToolStripButton İleri;
    }
}