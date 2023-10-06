namespace YurtYönetimSistemi
{
    partial class IzinBulForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzinBulForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrenciAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ızinBaslangicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ızınBitisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ızinSebebiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kisiAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yakinlikDerecesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kisiTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kisiAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ızinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet10 = new YurtYönetimSistemi.YurtOtomasyonuDataSet10();
            this.izinTableAdapter = new YurtYönetimSistemi.YurtOtomasyonuDataSet10TableAdapters.IzinTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtAd = new System.Windows.Forms.TextBox();
            this.radioAd = new System.Windows.Forms.RadioButton();
            this.radioAra = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ızinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet10)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciAdiDataGridViewTextBoxColumn,
            this.odaNoDataGridViewTextBoxColumn,
            this.ogrenciTelefonDataGridViewTextBoxColumn,
            this.ızinBaslangicDataGridViewTextBoxColumn,
            this.ızınBitisDataGridViewTextBoxColumn,
            this.ızinSebebiDataGridViewTextBoxColumn,
            this.kisiAdiDataGridViewTextBoxColumn,
            this.yakinlikDerecesiDataGridViewTextBoxColumn,
            this.kisiTelefonDataGridViewTextBoxColumn,
            this.kisiAdresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ızinBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(533, 408);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ogrenciAdiDataGridViewTextBoxColumn
            // 
            this.ogrenciAdiDataGridViewTextBoxColumn.DataPropertyName = "OgrenciAdi";
            this.ogrenciAdiDataGridViewTextBoxColumn.HeaderText = "Öğrenci Adı";
            this.ogrenciAdiDataGridViewTextBoxColumn.Name = "ogrenciAdiDataGridViewTextBoxColumn";
            // 
            // odaNoDataGridViewTextBoxColumn
            // 
            this.odaNoDataGridViewTextBoxColumn.DataPropertyName = "OdaNo";
            this.odaNoDataGridViewTextBoxColumn.HeaderText = "Oda Numarası";
            this.odaNoDataGridViewTextBoxColumn.Name = "odaNoDataGridViewTextBoxColumn";
            // 
            // ogrenciTelefonDataGridViewTextBoxColumn
            // 
            this.ogrenciTelefonDataGridViewTextBoxColumn.DataPropertyName = "OgrenciTelefon";
            this.ogrenciTelefonDataGridViewTextBoxColumn.HeaderText = "Telefon Numarası";
            this.ogrenciTelefonDataGridViewTextBoxColumn.Name = "ogrenciTelefonDataGridViewTextBoxColumn";
            // 
            // ızinBaslangicDataGridViewTextBoxColumn
            // 
            this.ızinBaslangicDataGridViewTextBoxColumn.DataPropertyName = "IzinBaslangic";
            this.ızinBaslangicDataGridViewTextBoxColumn.HeaderText = "İzin Başlangıç Tarihi";
            this.ızinBaslangicDataGridViewTextBoxColumn.Name = "ızinBaslangicDataGridViewTextBoxColumn";
            // 
            // ızınBitisDataGridViewTextBoxColumn
            // 
            this.ızınBitisDataGridViewTextBoxColumn.DataPropertyName = "IzınBitis";
            this.ızınBitisDataGridViewTextBoxColumn.HeaderText = "İzin Bitiş Tarihi";
            this.ızınBitisDataGridViewTextBoxColumn.Name = "ızınBitisDataGridViewTextBoxColumn";
            // 
            // ızinSebebiDataGridViewTextBoxColumn
            // 
            this.ızinSebebiDataGridViewTextBoxColumn.DataPropertyName = "IzinSebebi";
            this.ızinSebebiDataGridViewTextBoxColumn.HeaderText = "IzinSebebi";
            this.ızinSebebiDataGridViewTextBoxColumn.Name = "ızinSebebiDataGridViewTextBoxColumn";
            // 
            // kisiAdiDataGridViewTextBoxColumn
            // 
            this.kisiAdiDataGridViewTextBoxColumn.DataPropertyName = "KisiAdi";
            this.kisiAdiDataGridViewTextBoxColumn.HeaderText = "KisiAdi";
            this.kisiAdiDataGridViewTextBoxColumn.Name = "kisiAdiDataGridViewTextBoxColumn";
            // 
            // yakinlikDerecesiDataGridViewTextBoxColumn
            // 
            this.yakinlikDerecesiDataGridViewTextBoxColumn.DataPropertyName = "YakinlikDerecesi";
            this.yakinlikDerecesiDataGridViewTextBoxColumn.HeaderText = "YakinlikDerecesi";
            this.yakinlikDerecesiDataGridViewTextBoxColumn.Name = "yakinlikDerecesiDataGridViewTextBoxColumn";
            // 
            // kisiTelefonDataGridViewTextBoxColumn
            // 
            this.kisiTelefonDataGridViewTextBoxColumn.DataPropertyName = "KisiTelefon";
            this.kisiTelefonDataGridViewTextBoxColumn.HeaderText = "KisiTelefon";
            this.kisiTelefonDataGridViewTextBoxColumn.Name = "kisiTelefonDataGridViewTextBoxColumn";
            // 
            // kisiAdresDataGridViewTextBoxColumn
            // 
            this.kisiAdresDataGridViewTextBoxColumn.DataPropertyName = "KisiAdres";
            this.kisiAdresDataGridViewTextBoxColumn.HeaderText = "KisiAdres";
            this.kisiAdresDataGridViewTextBoxColumn.Name = "kisiAdresDataGridViewTextBoxColumn";
            // 
            // ızinBindingSource
            // 
            this.ızinBindingSource.DataMember = "Izin";
            this.ızinBindingSource.DataSource = this.yurtOtomasyonuDataSet10;
            // 
            // yurtOtomasyonuDataSet10
            // 
            this.yurtOtomasyonuDataSet10.DataSetName = "YurtOtomasyonuDataSet10";
            this.yurtOtomasyonuDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // izinTableAdapter
            // 
            this.izinTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.btnAra);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.radioAd);
            this.groupBox1.Controls.Add(this.radioAra);
            this.groupBox1.Location = new System.Drawing.Point(22, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 174);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İzin Arama";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAra.ImageKey = "icons8-search-48.png";
            this.btnAra.ImageList = this.ımageList1;
            this.btnAra.Location = new System.Drawing.Point(208, 112);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(89, 33);
            this.btnAra.TabIndex = 9;
            this.btnAra.Text = "ARA";
            this.btnAra.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icons8-search-client-48.png");
            this.ımageList1.Images.SetKeyName(1, "icons8-search-48.png");
            this.ımageList1.Images.SetKeyName(2, "icons8-available-updates-30.png");
            this.ımageList1.Images.SetKeyName(3, "icons8-delete-30 (1).png");
            this.ımageList1.Images.SetKeyName(4, "icons8-delete-30.png");
            this.ımageList1.Images.SetKeyName(5, "icons8-search-30 (1).png");
            this.ımageList1.Images.SetKeyName(6, "icons8-search-25 (1).png");
            this.ımageList1.Images.SetKeyName(7, "icons8-search-25.png");
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtAd.Location = new System.Drawing.Point(159, 84);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(193, 22);
            this.txtAd.TabIndex = 8;
            // 
            // radioAd
            // 
            this.radioAd.AutoSize = true;
            this.radioAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.radioAd.Location = new System.Drawing.Point(204, 32);
            this.radioAd.Name = "radioAd";
            this.radioAd.Size = new System.Drawing.Size(93, 20);
            this.radioAd.TabIndex = 5;
            this.radioAd.TabStop = true;
            this.radioAd.Text = "İsme Göre ;";
            this.radioAd.UseVisualStyleBackColor = true;
            this.radioAd.CheckedChanged += new System.EventHandler(this.radioAd_CheckedChanged);
            // 
            // radioAra
            // 
            this.radioAra.AutoSize = true;
            this.radioAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.radioAra.Location = new System.Drawing.Point(204, 58);
            this.radioAra.Name = "radioAra";
            this.radioAra.Size = new System.Drawing.Size(105, 20);
            this.radioAra.TabIndex = 7;
            this.radioAra.TabStop = true;
            this.radioAra.Text = "Odaya Göre ;";
            this.radioAra.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(19, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "** İzin belgesini yazdırmak için gerekli öğrencinin üzerine tıklayınız... ";
            // 
            // IzinBulForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(573, 675);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IzinBulForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IzinBulForm";
            this.Load += new System.EventHandler(this.IzinBulForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ızinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet10)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet10 yurtOtomasyonuDataSet10;
        private System.Windows.Forms.BindingSource ızinBindingSource;
        private YurtOtomasyonuDataSet10TableAdapters.IzinTableAdapter izinTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioAd;
        private System.Windows.Forms.RadioButton radioAra;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ızinBaslangicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ızınBitisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ızinSebebiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kisiAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yakinlikDerecesiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kisiTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kisiAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}