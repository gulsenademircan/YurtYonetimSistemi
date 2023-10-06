namespace YurtYönetimSistemi
{
    partial class YazdirForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YazdirForm));
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblIzinBitis = new System.Windows.Forms.Label();
            this.lblIzinBaslangic = new System.Windows.Forms.Label();
            this.lblIzinSebep = new System.Windows.Forms.Label();
            this.lblOdaNo = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button1 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(205, 9);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(34, 13);
            this.lblAdSoyad.TabIndex = 10;
            this.lblAdSoyad.Text = "label";
            this.lblAdSoyad.Visible = false;
            // 
            // lblIzinBitis
            // 
            this.lblIzinBitis.AutoSize = true;
            this.lblIzinBitis.Location = new System.Drawing.Point(315, 9);
            this.lblIzinBitis.Name = "lblIzinBitis";
            this.lblIzinBitis.Size = new System.Drawing.Size(29, 13);
            this.lblIzinBitis.TabIndex = 7;
            this.lblIzinBitis.Text = "label";
            this.lblIzinBitis.Visible = false;
            // 
            // lblIzinBaslangic
            // 
            this.lblIzinBaslangic.AutoSize = true;
            this.lblIzinBaslangic.Location = new System.Drawing.Point(280, 9);
            this.lblIzinBaslangic.Name = "lblIzinBaslangic";
            this.lblIzinBaslangic.Size = new System.Drawing.Size(29, 13);
            this.lblIzinBaslangic.TabIndex = 5;
            this.lblIzinBaslangic.Text = "label";
            this.lblIzinBaslangic.Visible = false;
            // 
            // lblIzinSebep
            // 
            this.lblIzinSebep.AutoSize = true;
            this.lblIzinSebep.Location = new System.Drawing.Point(245, 9);
            this.lblIzinSebep.Name = "lblIzinSebep";
            this.lblIzinSebep.Size = new System.Drawing.Size(29, 13);
            this.lblIzinSebep.TabIndex = 3;
            this.lblIzinSebep.Text = "label";
            this.lblIzinSebep.Visible = false;
            // 
            // lblOdaNo
            // 
            this.lblOdaNo.AutoSize = true;
            this.lblOdaNo.Location = new System.Drawing.Point(170, 9);
            this.lblOdaNo.Name = "lblOdaNo";
            this.lblOdaNo.Size = new System.Drawing.Size(29, 13);
            this.lblOdaNo.TabIndex = 1;
            this.lblOdaNo.Text = "label";
            this.lblOdaNo.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(248, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "YAZDIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(45, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Seçilen öğrencinin izin belgesini yazdır ?";
            // 
            // deneme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(355, 103);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.lblOdaNo);
            this.Controls.Add(this.lblIzinSebep);
            this.Controls.Add(this.lblIzinBitis);
            this.Controls.Add(this.lblIzinBaslangic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "deneme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yazdır";
            this.Load += new System.EventHandler(this.deneme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblIzinBitis;
        private System.Windows.Forms.Label lblIzinBaslangic;
        private System.Windows.Forms.Label lblIzinSebep;
        private System.Windows.Forms.Label lblOdaNo;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label1;
    }
}