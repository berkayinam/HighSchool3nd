namespace OkulStokProgramı
{
    partial class TreeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeView));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.Btn_Qr_Yazdır = new System.Windows.Forms.Button();
            this.Btn_Excel = new System.Windows.Forms.Button();
            this.Lbl_Adet = new System.Windows.Forms.Label();
            this.Pic_Qr = new System.Windows.Forms.PictureBox();
            this.List_Malzeme = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Qr)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(228, 567);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.progressBar);
            this.splitContainer1.Panel2.Controls.Add(this.Btn_Qr_Yazdır);
            this.splitContainer1.Panel2.Controls.Add(this.Btn_Excel);
            this.splitContainer1.Panel2.Controls.Add(this.Lbl_Adet);
            this.splitContainer1.Panel2.Controls.Add(this.Pic_Qr);
            this.splitContainer1.Panel2.Controls.Add(this.List_Malzeme);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(684, 567);
            this.splitContainer1.SplitterDistance = 228;
            this.splitContainer1.TabIndex = 1;
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.LimeGreen;
            this.progressBar.Location = new System.Drawing.Point(17, 536);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(420, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 32;
            // 
            // Btn_Qr_Yazdır
            // 
            this.Btn_Qr_Yazdır.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Qr_Yazdır.Location = new System.Drawing.Point(201, 397);
            this.Btn_Qr_Yazdır.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Qr_Yazdır.Name = "Btn_Qr_Yazdır";
            this.Btn_Qr_Yazdır.Size = new System.Drawing.Size(236, 128);
            this.Btn_Qr_Yazdır.TabIndex = 31;
            this.Btn_Qr_Yazdır.Text = "QR YAZDIR";
            this.Btn_Qr_Yazdır.UseVisualStyleBackColor = true;
            this.Btn_Qr_Yazdır.Click += new System.EventHandler(this.Btn_Qr_Yazdır_Click);
            // 
            // Btn_Excel
            // 
            this.Btn_Excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Excel.Location = new System.Drawing.Point(201, 257);
            this.Btn_Excel.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Excel.Name = "Btn_Excel";
            this.Btn_Excel.Size = new System.Drawing.Size(235, 132);
            this.Btn_Excel.TabIndex = 30;
            this.Btn_Excel.Text = "EXCEL YAZDIR";
            this.Btn_Excel.UseVisualStyleBackColor = true;
            this.Btn_Excel.Click += new System.EventHandler(this.Btn_Excel_Click);
            // 
            // Lbl_Adet
            // 
            this.Lbl_Adet.AutoSize = true;
            this.Lbl_Adet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_Adet.Location = new System.Drawing.Point(203, 210);
            this.Lbl_Adet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Adet.Name = "Lbl_Adet";
            this.Lbl_Adet.Size = new System.Drawing.Size(105, 32);
            this.Lbl_Adet.TabIndex = 29;
            this.Lbl_Adet.Text = "Adet: 0";
            // 
            // Pic_Qr
            // 
            this.Pic_Qr.Location = new System.Drawing.Point(201, 13);
            this.Pic_Qr.Margin = new System.Windows.Forms.Padding(4);
            this.Pic_Qr.Name = "Pic_Qr";
            this.Pic_Qr.Size = new System.Drawing.Size(236, 193);
            this.Pic_Qr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Qr.TabIndex = 28;
            this.Pic_Qr.TabStop = false;
            // 
            // List_Malzeme
            // 
            this.List_Malzeme.FormattingEnabled = true;
            this.List_Malzeme.ItemHeight = 16;
            this.List_Malzeme.Location = new System.Drawing.Point(17, 13);
            this.List_Malzeme.Margin = new System.Windows.Forms.Padding(4);
            this.List_Malzeme.Name = "List_Malzeme";
            this.List_Malzeme.Size = new System.Drawing.Size(176, 516);
            this.List_Malzeme.TabIndex = 27;
            this.List_Malzeme.SelectedIndexChanged += new System.EventHandler(this.List_Malzeme_SelectedIndexChanged);
            // 
            // TreeView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(684, 567);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TreeView";
            this.Text = "Stok Listesi";
            this.Load += new System.EventHandler(this.TreeView_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Qr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Btn_Qr_Yazdır;
        private System.Windows.Forms.Button Btn_Excel;
        private System.Windows.Forms.Label Lbl_Adet;
        private System.Windows.Forms.PictureBox Pic_Qr;
        private System.Windows.Forms.ListBox List_Malzeme;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}