namespace YurtYönetimSistemi
{
    partial class OdemeKayitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdemeKayitForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.borcIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odemeTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odenenTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet18 = new YurtYönetimSistemi.YurtOtomasyonuDataSet18();
            this.odemeTableAdapter = new YurtYönetimSistemi.YurtOtomasyonuDataSet18TableAdapters.OdemeTableAdapter();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnAra = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odemeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet18)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(135, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğrenci Soyadı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Adı :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.borcIdDataGridViewTextBoxColumn,
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.odemeTarihiDataGridViewTextBoxColumn,
            this.odenenTutarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.odemeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 337);
            this.dataGridView1.TabIndex = 1;
            // 
            // borcIdDataGridViewTextBoxColumn
            // 
            this.borcIdDataGridViewTextBoxColumn.DataPropertyName = "BorcId";
            this.borcIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.borcIdDataGridViewTextBoxColumn.Name = "borcIdDataGridViewTextBoxColumn";
            // 
            // ogrAdDataGridViewTextBoxColumn
            // 
            this.ogrAdDataGridViewTextBoxColumn.DataPropertyName = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.HeaderText = "Öğrenci Adı";
            this.ogrAdDataGridViewTextBoxColumn.Name = "ogrAdDataGridViewTextBoxColumn";
            // 
            // ogrSoyadDataGridViewTextBoxColumn
            // 
            this.ogrSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.HeaderText = "Öğrenci Soyadı";
            this.ogrSoyadDataGridViewTextBoxColumn.Name = "ogrSoyadDataGridViewTextBoxColumn";
            // 
            // odemeTarihiDataGridViewTextBoxColumn
            // 
            this.odemeTarihiDataGridViewTextBoxColumn.DataPropertyName = "OdemeTarihi";
            this.odemeTarihiDataGridViewTextBoxColumn.HeaderText = "Ödeme Yapılan Tarih";
            this.odemeTarihiDataGridViewTextBoxColumn.Name = "odemeTarihiDataGridViewTextBoxColumn";
            // 
            // odenenTutarDataGridViewTextBoxColumn
            // 
            this.odenenTutarDataGridViewTextBoxColumn.DataPropertyName = "OdenenTutar";
            this.odenenTutarDataGridViewTextBoxColumn.HeaderText = "Ödenen Tutar";
            this.odenenTutarDataGridViewTextBoxColumn.Name = "odenenTutarDataGridViewTextBoxColumn";
            // 
            // odemeBindingSource
            // 
            this.odemeBindingSource.DataMember = "Odeme";
            this.odemeBindingSource.DataSource = this.yurtOtomasyonuDataSet18;
            // 
            // yurtOtomasyonuDataSet18
            // 
            this.yurtOtomasyonuDataSet18.DataSetName = "YurtOtomasyonuDataSet18";
            this.yurtOtomasyonuDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odemeTableAdapter
            // 
            this.odemeTableAdapter.ClearBeforeFill = true;
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYazdir.ImageKey = "icons8-printer-25.png";
            this.btnYazdir.ImageList = this.ımageList1;
            this.btnYazdir.Location = new System.Drawing.Point(495, 102);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(80, 34);
            this.btnYazdir.TabIndex = 2;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYazdir.UseVisualStyleBackColor = false;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icons8-search-25.png");
            this.ımageList1.Images.SetKeyName(1, "icons8-delete-25 (3).png");
            this.ımageList1.Images.SetKeyName(2, "icons8-pay-25 (1).png");
            this.ımageList1.Images.SetKeyName(3, "icons8-printer-25.png");
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAra.ImageKey = "icons8-search-25.png";
            this.btnAra.ImageList = this.ımageList1;
            this.btnAra.Location = new System.Drawing.Point(495, 33);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(80, 34);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "Ara";
            this.btnAra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // OdemeKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(608, 523);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OdemeKayitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Kayıtları";
            this.Load += new System.EventHandler(this.OdemeKayitForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odemeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet18)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet18 yurtOtomasyonuDataSet18;
        private System.Windows.Forms.BindingSource odemeBindingSource;
        private YurtOtomasyonuDataSet18TableAdapters.OdemeTableAdapter odemeTableAdapter;
        private System.Windows.Forms.Button btnYazdir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn borcIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemeTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odenenTutarDataGridViewTextBoxColumn;
    }
}