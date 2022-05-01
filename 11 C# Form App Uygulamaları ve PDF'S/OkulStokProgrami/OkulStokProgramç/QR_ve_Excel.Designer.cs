namespace OkulStokProgramı
{
    partial class QR_ve_Excel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QR_ve_Excel));
            this.Lbl_Yer = new System.Windows.Forms.Label();
            this.List_Malzeme = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Geri = new System.Windows.Forms.ToolStripButton();
            this.İleri = new System.Windows.Forms.ToolStripButton();
            this.Pic_Qr = new System.Windows.Forms.PictureBox();
            this.Lbl_Adet = new System.Windows.Forms.Label();
            this.Btn_Excel = new System.Windows.Forms.Button();
            this.Btn_Qr_Yazdır = new System.Windows.Forms.Button();
            this.Btn_Qr_Kaydet = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Qr)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Yer
            // 
            this.Lbl_Yer.AutoSize = true;
            this.Lbl_Yer.Font = new System.Drawing.Font("Korolev Heavy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_Yer.Location = new System.Drawing.Point(12, 25);
            this.Lbl_Yer.Name = "Lbl_Yer";
            this.Lbl_Yer.Size = new System.Drawing.Size(50, 34);
            this.Lbl_Yer.TabIndex = 18;
            this.Lbl_Yer.Text = "Yer";
            // 
            // List_Malzeme
            // 
            this.List_Malzeme.FormattingEnabled = true;
            this.List_Malzeme.Location = new System.Drawing.Point(18, 63);
            this.List_Malzeme.Name = "List_Malzeme";
            this.List_Malzeme.Size = new System.Drawing.Size(214, 394);
            this.List_Malzeme.TabIndex = 19;
            this.List_Malzeme.SelectedIndexChanged += new System.EventHandler(this.List_Malzeme_SelectedIndexChanged);
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
            this.toolStrip1.Size = new System.Drawing.Size(427, 25);
            this.toolStrip1.TabIndex = 20;
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
            // Pic_Qr
            // 
            this.Pic_Qr.Location = new System.Drawing.Point(238, 63);
            this.Pic_Qr.Name = "Pic_Qr";
            this.Pic_Qr.Size = new System.Drawing.Size(177, 157);
            this.Pic_Qr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Qr.TabIndex = 21;
            this.Pic_Qr.TabStop = false;
            // 
            // Lbl_Adet
            // 
            this.Lbl_Adet.AutoSize = true;
            this.Lbl_Adet.Font = new System.Drawing.Font("Korolev Heavy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_Adet.Location = new System.Drawing.Point(247, 228);
            this.Lbl_Adet.Name = "Lbl_Adet";
            this.Lbl_Adet.Size = new System.Drawing.Size(94, 34);
            this.Lbl_Adet.TabIndex = 22;
            this.Lbl_Adet.Text = "Adet: 0";
            // 
            // Btn_Excel
            // 
            this.Btn_Excel.Font = new System.Drawing.Font("Korolev Heavy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Excel.Location = new System.Drawing.Point(244, 331);
            this.Btn_Excel.Name = "Btn_Excel";
            this.Btn_Excel.Size = new System.Drawing.Size(171, 60);
            this.Btn_Excel.TabIndex = 23;
            this.Btn_Excel.Text = "EXCEL";
            this.Btn_Excel.UseVisualStyleBackColor = true;
            // 
            // Btn_Qr_Yazdır
            // 
            this.Btn_Qr_Yazdır.Font = new System.Drawing.Font("Korolev Heavy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Qr_Yazdır.Location = new System.Drawing.Point(244, 397);
            this.Btn_Qr_Yazdır.Name = "Btn_Qr_Yazdır";
            this.Btn_Qr_Yazdır.Size = new System.Drawing.Size(171, 60);
            this.Btn_Qr_Yazdır.TabIndex = 24;
            this.Btn_Qr_Yazdır.Text = "QR (BARKOD) YAZDIR";
            this.Btn_Qr_Yazdır.UseVisualStyleBackColor = true;
            // 
            // Btn_Qr_Kaydet
            // 
            this.Btn_Qr_Kaydet.Enabled = false;
            this.Btn_Qr_Kaydet.Font = new System.Drawing.Font("Korolev Heavy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Qr_Kaydet.Location = new System.Drawing.Point(244, 265);
            this.Btn_Qr_Kaydet.Name = "Btn_Qr_Kaydet";
            this.Btn_Qr_Kaydet.Size = new System.Drawing.Size(171, 60);
            this.Btn_Qr_Kaydet.TabIndex = 25;
            this.Btn_Qr_Kaydet.Text = "QR (BARKOD) KAYDET";
            this.Btn_Qr_Kaydet.UseVisualStyleBackColor = true;
            this.Btn_Qr_Kaydet.Click += new System.EventHandler(this.Btn_Qr_Kaydet_Click);
            // 
            // QR_ve_Excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 477);
            this.Controls.Add(this.Btn_Qr_Kaydet);
            this.Controls.Add(this.Btn_Qr_Yazdır);
            this.Controls.Add(this.Btn_Excel);
            this.Controls.Add(this.Lbl_Adet);
            this.Controls.Add(this.Pic_Qr);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.List_Malzeme);
            this.Controls.Add(this.Lbl_Yer);
            this.Name = "QR_ve_Excel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR_ve_Excel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QR_ve_Excel_FormClosing);
            this.Load += new System.EventHandler(this.QR_ve_Excel_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Qr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Yer;
        private System.Windows.Forms.ListBox List_Malzeme;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Geri;
        private System.Windows.Forms.ToolStripButton İleri;
        private System.Windows.Forms.PictureBox Pic_Qr;
        private System.Windows.Forms.Label Lbl_Adet;
        private System.Windows.Forms.Button Btn_Excel;
        private System.Windows.Forms.Button Btn_Qr_Yazdır;
        private System.Windows.Forms.Button Btn_Qr_Kaydet;
    }
}