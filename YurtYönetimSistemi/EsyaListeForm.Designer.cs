namespace YurtYönetimSistemi
{
    partial class EsyaListeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EsyaListeForm));
            this.esyaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet11 = new YurtYönetimSistemi.YurtOtomasyonuDataSet11();
            this.esyaTableAdapter = new YurtYönetimSistemi.YurtOtomasyonuDataSet11TableAdapters.EsyaTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rdBulunan = new System.Windows.Forms.RadioButton();
            this.rdKayip = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.esyaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet12 = new YurtYönetimSistemi.YurtOtomasyonuDataSet12();
            this.esyaTableAdapter1 = new YurtYönetimSistemi.YurtOtomasyonuDataSet12TableAdapters.EsyaTableAdapter();
            this.esyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esyaYerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esyaTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esyaSahipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esyaNumaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.esyaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet11)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esyaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // esyaBindingSource
            // 
            this.esyaBindingSource.DataMember = "Esya";
            this.esyaBindingSource.DataSource = this.yurtOtomasyonuDataSet11;
            this.esyaBindingSource.CurrentChanged += new System.EventHandler(this.esyaBindingSource_CurrentChanged);
            // 
            // yurtOtomasyonuDataSet11
            // 
            this.yurtOtomasyonuDataSet11.DataSetName = "YurtOtomasyonuDataSet11";
            this.yurtOtomasyonuDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // esyaTableAdapter
            // 
            this.esyaTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.rdBulunan);
            this.groupBox1.Controls.Add(this.rdKayip);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 190);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FİLTRELEME VE ARAMA";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 4;
            // 
            // rdBulunan
            // 
            this.rdBulunan.AutoSize = true;
            this.rdBulunan.Location = new System.Drawing.Point(12, 67);
            this.rdBulunan.Name = "rdBulunan";
            this.rdBulunan.Size = new System.Drawing.Size(64, 17);
            this.rdBulunan.TabIndex = 3;
            this.rdBulunan.TabStop = true;
            this.rdBulunan.Text = "Bulunan";
            this.rdBulunan.UseVisualStyleBackColor = true;
            this.rdBulunan.CheckedChanged += new System.EventHandler(this.rdBulunan_CheckedChanged);
            // 
            // rdKayip
            // 
            this.rdKayip.AutoSize = true;
            this.rdKayip.Location = new System.Drawing.Point(12, 90);
            this.rdKayip.Name = "rdKayip";
            this.rdKayip.Size = new System.Drawing.Size(51, 17);
            this.rdKayip.TabIndex = 2;
            this.rdKayip.TabStop = true;
            this.rdKayip.Text = "Kayıp";
            this.rdKayip.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.ImageKey = "icons8-search-25.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(150, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "ARA";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icons8-search-25 (1).png");
            this.ımageList1.Images.SetKeyName(1, "icons8-update-25.png");
            this.ımageList1.Images.SetKeyName(2, "icons8-delete-25 (3).png");
            this.ımageList1.Images.SetKeyName(3, "icons8-search-25.png");
            this.ımageList1.Images.SetKeyName(4, "icons8-save-25.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eşya Tanımı :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.esyaDataGridViewTextBoxColumn,
            this.esyaYerDataGridViewTextBoxColumn,
            this.esyaTarihDataGridViewTextBoxColumn,
            this.detayDataGridViewTextBoxColumn,
            this.esyaSahipDataGridViewTextBoxColumn,
            this.esyaNumaraDataGridViewTextBoxColumn,
            this.durumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.esyaBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(26, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(440, 221);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // esyaBindingSource1
            // 
            this.esyaBindingSource1.DataMember = "Esya";
            this.esyaBindingSource1.DataSource = this.yurtOtomasyonuDataSet12;
            // 
            // yurtOtomasyonuDataSet12
            // 
            this.yurtOtomasyonuDataSet12.DataSetName = "YurtOtomasyonuDataSet12";
            this.yurtOtomasyonuDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // esyaTableAdapter1
            // 
            this.esyaTableAdapter1.ClearBeforeFill = true;
            // 
            // esyaDataGridViewTextBoxColumn
            // 
            this.esyaDataGridViewTextBoxColumn.DataPropertyName = "Esya";
            this.esyaDataGridViewTextBoxColumn.HeaderText = "Eşya";
            this.esyaDataGridViewTextBoxColumn.Name = "esyaDataGridViewTextBoxColumn";
            // 
            // esyaYerDataGridViewTextBoxColumn
            // 
            this.esyaYerDataGridViewTextBoxColumn.DataPropertyName = "EsyaYer";
            this.esyaYerDataGridViewTextBoxColumn.HeaderText = "Eşya Yeri";
            this.esyaYerDataGridViewTextBoxColumn.Name = "esyaYerDataGridViewTextBoxColumn";
            // 
            // esyaTarihDataGridViewTextBoxColumn
            // 
            this.esyaTarihDataGridViewTextBoxColumn.DataPropertyName = "EsyaTarih";
            this.esyaTarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.esyaTarihDataGridViewTextBoxColumn.Name = "esyaTarihDataGridViewTextBoxColumn";
            // 
            // detayDataGridViewTextBoxColumn
            // 
            this.detayDataGridViewTextBoxColumn.DataPropertyName = "Detay";
            this.detayDataGridViewTextBoxColumn.HeaderText = "Detay";
            this.detayDataGridViewTextBoxColumn.Name = "detayDataGridViewTextBoxColumn";
            // 
            // esyaSahipDataGridViewTextBoxColumn
            // 
            this.esyaSahipDataGridViewTextBoxColumn.DataPropertyName = "EsyaSahip";
            this.esyaSahipDataGridViewTextBoxColumn.HeaderText = "İletişim Kurulacak Kişi";
            this.esyaSahipDataGridViewTextBoxColumn.Name = "esyaSahipDataGridViewTextBoxColumn";
            // 
            // esyaNumaraDataGridViewTextBoxColumn
            // 
            this.esyaNumaraDataGridViewTextBoxColumn.DataPropertyName = "EsyaNumara";
            this.esyaNumaraDataGridViewTextBoxColumn.HeaderText = "Kişi Telefon Numarası";
            this.esyaNumaraDataGridViewTextBoxColumn.Name = "esyaNumaraDataGridViewTextBoxColumn";
            // 
            // durumDataGridViewTextBoxColumn
            // 
            this.durumDataGridViewTextBoxColumn.DataPropertyName = "Durum";
            this.durumDataGridViewTextBoxColumn.HeaderText = "Durum";
            this.durumDataGridViewTextBoxColumn.Name = "durumDataGridViewTextBoxColumn";
            // 
            // EsyaListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EsyaListeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıp Eşya Listesi";
            this.Load += new System.EventHandler(this.EsyaListeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.esyaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet11)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esyaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private YurtOtomasyonuDataSet11 yurtOtomasyonuDataSet11;
        private System.Windows.Forms.BindingSource esyaBindingSource;
        private YurtOtomasyonuDataSet11TableAdapters.EsyaTableAdapter esyaTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rdBulunan;
        private System.Windows.Forms.RadioButton rdKayip;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private YurtOtomasyonuDataSet12 yurtOtomasyonuDataSet12;
        private System.Windows.Forms.BindingSource esyaBindingSource1;
        private YurtOtomasyonuDataSet12TableAdapters.EsyaTableAdapter esyaTableAdapter1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esyaYerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esyaTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esyaSahipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esyaNumaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
    }
}