namespace YurtYönetimSistemi
{
    partial class OgrenciListesiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciListesiForm));
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet = new YurtYönetimSistemi.YurtOtomasyonuDataSet();
            this.ogrenciTableAdapter = new YurtYönetimSistemi.YurtOtomasyonuDataSetTableAdapters.OgrenciTableAdapter();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ogrenciBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet3 = new YurtYönetimSistemi.YurtOtomasyonuDataSet3();
            this.ogrenciTableAdapter1 = new YurtYönetimSistemi.YurtOtomasyonuDataSet3TableAdapters.OgrenciTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrDogumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrBolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrOdaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrYillikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrVeliTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrVeliAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrResimDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.ogrSaglikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrKanGrubuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet7 = new YurtYönetimSistemi.YurtOtomasyonuDataSet7();
            this.ogrenciTableAdapter2 = new YurtYönetimSistemi.YurtOtomasyonuDataSet7TableAdapters.OgrenciTableAdapter();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.radioSoyad = new System.Windows.Forms.RadioButton();
            this.btnAra = new System.Windows.Forms.Button();
            this.radioAd = new System.Windows.Forms.RadioButton();
            this.radioAra = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet7)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "Ogrenci";
            this.ogrenciBindingSource.DataSource = this.yurtOtomasyonuDataSet;
            // 
            // yurtOtomasyonuDataSet
            // 
            this.yurtOtomasyonuDataSet.DataSetName = "YurtOtomasyonuDataSet";
            this.yurtOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
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
            // ogrenciBindingSource1
            // 
            this.ogrenciBindingSource1.DataMember = "Ogrenci";
            this.ogrenciBindingSource1.DataSource = this.yurtOtomasyonuDataSet3;
            // 
            // yurtOtomasyonuDataSet3
            // 
            this.yurtOtomasyonuDataSet3.DataSetName = "YurtOtomasyonuDataSet3";
            this.yurtOtomasyonuDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciTableAdapter1
            // 
            this.ogrenciTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogridDataGridViewTextBoxColumn,
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.ogrTCDataGridViewTextBoxColumn,
            this.ogrTelefonDataGridViewTextBoxColumn,
            this.ogrDogumDataGridViewTextBoxColumn,
            this.ogrBolumDataGridViewTextBoxColumn,
            this.ogrMailDataGridViewTextBoxColumn,
            this.ogrOdaNoDataGridViewTextBoxColumn,
            this.ogrYillikDataGridViewTextBoxColumn,
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn,
            this.ogrVeliTelefonDataGridViewTextBoxColumn,
            this.ogrVeliAdresDataGridViewTextBoxColumn,
            this.ogrResimDataGridViewImageColumn,
            this.ogrSaglikDataGridViewTextBoxColumn,
            this.ogrKanGrubuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrenciBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(31, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(737, 301);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // ogridDataGridViewTextBoxColumn
            // 
            this.ogridDataGridViewTextBoxColumn.DataPropertyName = "Ogrid";
            this.ogridDataGridViewTextBoxColumn.HeaderText = "Öğrenci Id";
            this.ogridDataGridViewTextBoxColumn.Name = "ogridDataGridViewTextBoxColumn";
            this.ogridDataGridViewTextBoxColumn.ReadOnly = true;
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
            // ogrTCDataGridViewTextBoxColumn
            // 
            this.ogrTCDataGridViewTextBoxColumn.DataPropertyName = "OgrTC";
            this.ogrTCDataGridViewTextBoxColumn.HeaderText = "TC";
            this.ogrTCDataGridViewTextBoxColumn.Name = "ogrTCDataGridViewTextBoxColumn";
            // 
            // ogrTelefonDataGridViewTextBoxColumn
            // 
            this.ogrTelefonDataGridViewTextBoxColumn.DataPropertyName = "OgrTelefon";
            this.ogrTelefonDataGridViewTextBoxColumn.HeaderText = "Telefon Numarası";
            this.ogrTelefonDataGridViewTextBoxColumn.Name = "ogrTelefonDataGridViewTextBoxColumn";
            // 
            // ogrDogumDataGridViewTextBoxColumn
            // 
            this.ogrDogumDataGridViewTextBoxColumn.DataPropertyName = "OgrDogum";
            this.ogrDogumDataGridViewTextBoxColumn.HeaderText = "Doğum Tarihi";
            this.ogrDogumDataGridViewTextBoxColumn.Name = "ogrDogumDataGridViewTextBoxColumn";
            // 
            // ogrBolumDataGridViewTextBoxColumn
            // 
            this.ogrBolumDataGridViewTextBoxColumn.DataPropertyName = "OgrBolum";
            this.ogrBolumDataGridViewTextBoxColumn.HeaderText = "Fakülte";
            this.ogrBolumDataGridViewTextBoxColumn.Name = "ogrBolumDataGridViewTextBoxColumn";
            // 
            // ogrMailDataGridViewTextBoxColumn
            // 
            this.ogrMailDataGridViewTextBoxColumn.DataPropertyName = "OgrMail";
            this.ogrMailDataGridViewTextBoxColumn.HeaderText = "Mail Adresi";
            this.ogrMailDataGridViewTextBoxColumn.Name = "ogrMailDataGridViewTextBoxColumn";
            // 
            // ogrOdaNoDataGridViewTextBoxColumn
            // 
            this.ogrOdaNoDataGridViewTextBoxColumn.DataPropertyName = "OgrOdaNo";
            this.ogrOdaNoDataGridViewTextBoxColumn.HeaderText = "Oda Numarası";
            this.ogrOdaNoDataGridViewTextBoxColumn.Name = "ogrOdaNoDataGridViewTextBoxColumn";
            // 
            // ogrYillikDataGridViewTextBoxColumn
            // 
            this.ogrYillikDataGridViewTextBoxColumn.DataPropertyName = "OgrYillik";
            this.ogrYillikDataGridViewTextBoxColumn.HeaderText = "Yıllık Ücret";
            this.ogrYillikDataGridViewTextBoxColumn.Name = "ogrYillikDataGridViewTextBoxColumn";
            // 
            // ogrVeliAdSoyadDataGridViewTextBoxColumn
            // 
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrVeliAdSoyad";
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn.HeaderText = "Veli Adı ve Soyadı";
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn.Name = "ogrVeliAdSoyadDataGridViewTextBoxColumn";
            // 
            // ogrVeliTelefonDataGridViewTextBoxColumn
            // 
            this.ogrVeliTelefonDataGridViewTextBoxColumn.DataPropertyName = "OgrVeliTelefon";
            this.ogrVeliTelefonDataGridViewTextBoxColumn.HeaderText = "Veli Telefon Numarası";
            this.ogrVeliTelefonDataGridViewTextBoxColumn.Name = "ogrVeliTelefonDataGridViewTextBoxColumn";
            // 
            // ogrVeliAdresDataGridViewTextBoxColumn
            // 
            this.ogrVeliAdresDataGridViewTextBoxColumn.DataPropertyName = "OgrVeliAdres";
            this.ogrVeliAdresDataGridViewTextBoxColumn.HeaderText = "Veli Adresi";
            this.ogrVeliAdresDataGridViewTextBoxColumn.Name = "ogrVeliAdresDataGridViewTextBoxColumn";
            // 
            // ogrResimDataGridViewImageColumn
            // 
            this.ogrResimDataGridViewImageColumn.DataPropertyName = "OgrResim";
            this.ogrResimDataGridViewImageColumn.HeaderText = "Öğrenci Resmi";
            this.ogrResimDataGridViewImageColumn.Name = "ogrResimDataGridViewImageColumn";
            // 
            // ogrSaglikDataGridViewTextBoxColumn
            // 
            this.ogrSaglikDataGridViewTextBoxColumn.DataPropertyName = "OgrSaglik";
            this.ogrSaglikDataGridViewTextBoxColumn.HeaderText = "Sağlık Bilgileri";
            this.ogrSaglikDataGridViewTextBoxColumn.Name = "ogrSaglikDataGridViewTextBoxColumn";
            // 
            // ogrKanGrubuDataGridViewTextBoxColumn
            // 
            this.ogrKanGrubuDataGridViewTextBoxColumn.DataPropertyName = "OgrKanGrubu";
            this.ogrKanGrubuDataGridViewTextBoxColumn.HeaderText = "Kan Grubu";
            this.ogrKanGrubuDataGridViewTextBoxColumn.Name = "ogrKanGrubuDataGridViewTextBoxColumn";
            // 
            // ogrenciBindingSource2
            // 
            this.ogrenciBindingSource2.DataMember = "Ogrenci";
            this.ogrenciBindingSource2.DataSource = this.yurtOtomasyonuDataSet7;
            // 
            // yurtOtomasyonuDataSet7
            // 
            this.yurtOtomasyonuDataSet7.DataSetName = "YurtOtomasyonuDataSet7";
            this.yurtOtomasyonuDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciTableAdapter2
            // 
            this.ogrenciTableAdapter2.ClearBeforeFill = true;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtAd.Location = new System.Drawing.Point(285, 102);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(193, 22);
            this.txtAd.TabIndex = 5;
            // 
            // radioSoyad
            // 
            this.radioSoyad.AutoSize = true;
            this.radioSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.radioSoyad.Location = new System.Drawing.Point(321, 50);
            this.radioSoyad.Name = "radioSoyad";
            this.radioSoyad.Size = new System.Drawing.Size(130, 20);
            this.radioSoyad.TabIndex = 3;
            this.radioSoyad.TabStop = true;
            this.radioSoyad.Text = "Soyada Göre Ara";
            this.radioSoyad.UseVisualStyleBackColor = true;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAra.ImageKey = "icons8-search-48.png";
            this.btnAra.ImageList = this.ımageList1;
            this.btnAra.Location = new System.Drawing.Point(343, 130);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(89, 33);
            this.btnAra.TabIndex = 6;
            this.btnAra.Text = "ARA";
            this.btnAra.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioAd
            // 
            this.radioAd.AutoSize = true;
            this.radioAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.radioAd.Location = new System.Drawing.Point(321, 24);
            this.radioAd.Name = "radioAd";
            this.radioAd.Size = new System.Drawing.Size(111, 20);
            this.radioAd.TabIndex = 2;
            this.radioAd.TabStop = true;
            this.radioAd.Text = "İsme Göre Ara";
            this.radioAd.UseVisualStyleBackColor = true;
            this.radioAd.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioAra
            // 
            this.radioAra.AutoSize = true;
            this.radioAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.radioAra.Location = new System.Drawing.Point(321, 76);
            this.radioAra.Name = "radioAra";
            this.radioAra.Size = new System.Drawing.Size(123, 20);
            this.radioAra.TabIndex = 4;
            this.radioAra.TabStop = true;
            this.radioAra.Text = "Odaya Göre Ara";
            this.radioAra.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAra);
            this.groupBox1.Controls.Add(this.radioAd);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.radioAra);
            this.groupBox1.Controls.Add(this.radioSoyad);
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 191);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Arama Ve Filtreleme";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // OgrenciListesiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OgrenciListesiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Listesi";
            this.Load += new System.EventHandler(this.OgrenciListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet7)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private YurtOtomasyonuDataSet yurtOtomasyonuDataSet;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private YurtOtomasyonuDataSetTableAdapters.OgrenciTableAdapter ogrenciTableAdapter;
        private System.Windows.Forms.ImageList ımageList1;
        private YurtOtomasyonuDataSet3 yurtOtomasyonuDataSet3;
        private System.Windows.Forms.BindingSource ogrenciBindingSource1;
        private YurtOtomasyonuDataSet3TableAdapters.OgrenciTableAdapter ogrenciTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet7 yurtOtomasyonuDataSet7;
        private System.Windows.Forms.BindingSource ogrenciBindingSource2;
        private YurtOtomasyonuDataSet7TableAdapters.OgrenciTableAdapter ogrenciTableAdapter2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.RadioButton radioSoyad;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.RadioButton radioAd;
        private System.Windows.Forms.RadioButton radioAra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrDogumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrBolumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrOdaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrYillikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrVeliAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrVeliTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrVeliAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn ogrResimDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSaglikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrKanGrubuDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}