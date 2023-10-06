namespace YurtYönetimSistemi
{
    partial class HarcamaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HarcamaForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskTarih = new System.Windows.Forms.MaskedTextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtKisi = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.harcamalarTableAdapter = new YurtYönetimSistemi.YurtOtomasyonuDataSet19TableAdapters.HarcamalarTableAdapter();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.yurtOtomasyonuDataSet20 = new YurtYönetimSistemi.YurtOtomasyonuDataSet20();
            this.harcamalarTableAdapter1 = new YurtYönetimSistemi.YurtOtomasyonuDataSet20TableAdapters.HarcamalarTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.harcamaTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harcamaTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harcamaKisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harcamaDetayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harcamaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harcamalarBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet21 = new YurtYönetimSistemi.YurtOtomasyonuDataSet21();
            this.harcamalarTableAdapter2 = new YurtYönetimSistemi.YurtOtomasyonuDataSet21TableAdapters.HarcamalarTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.harcamalarBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet21)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskTarih);
            this.groupBox1.Controls.Add(this.txtAciklama);
            this.groupBox1.Controls.Add(this.txtKisi);
            this.groupBox1.Controls.Add(this.txtTutar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Harcama Detayları";
            // 
            // mskTarih
            // 
            this.mskTarih.Location = new System.Drawing.Point(167, 28);
            this.mskTarih.Mask = "00/00/0000";
            this.mskTarih.Name = "mskTarih";
            this.mskTarih.Size = new System.Drawing.Size(101, 20);
            this.mskTarih.TabIndex = 8;
            this.mskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(167, 133);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(186, 20);
            this.txtAciklama.TabIndex = 7;
            // 
            // txtKisi
            // 
            this.txtKisi.Location = new System.Drawing.Point(167, 99);
            this.txtKisi.Name = "txtKisi";
            this.txtKisi.Size = new System.Drawing.Size(186, 20);
            this.txtKisi.TabIndex = 6;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(167, 62);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(101, 20);
            this.txtTutar.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Açıklama :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ödeme Yapılan Kişi / Şirket :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tutar :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarih :";
            // 
            // harcamalarTableAdapter
            // 
            this.harcamalarTableAdapter.ClearBeforeFill = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTemizle.ImageKey = "icons8-delete-document-25.png";
            this.btnTemizle.ImageList = this.ımageList1;
            this.btnTemizle.Location = new System.Drawing.Point(484, 329);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(84, 36);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Sayfayı Temizle";
            this.btnTemizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icons8-save-25.png");
            this.ımageList1.Images.SetKeyName(1, "icons8-update-25.png");
            this.ımageList1.Images.SetKeyName(2, "icons8-delete-25 (3).png");
            this.ımageList1.Images.SetKeyName(3, "icons8-delete-25 (3).png");
            this.ımageList1.Images.SetKeyName(4, "icons8-delete-document-25.png");
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKaydet.ImageKey = "icons8-save-25.png";
            this.btnKaydet.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(484, 91);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(84, 33);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSil.ImageKey = "icons8-delete-25 (3).png";
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(484, 244);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(84, 33);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGüncelle.ImageKey = "icons8-update-25.png";
            this.btnGüncelle.ImageList = this.ımageList1;
            this.btnGüncelle.Location = new System.Drawing.Point(484, 165);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(84, 35);
            this.btnGüncelle.TabIndex = 6;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(513, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // yurtOtomasyonuDataSet20
            // 
            this.yurtOtomasyonuDataSet20.DataSetName = "YurtOtomasyonuDataSet20";
            this.yurtOtomasyonuDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // harcamalarTableAdapter1
            // 
            this.harcamalarTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.harcamaTarihDataGridViewTextBoxColumn,
            this.harcamaTutarDataGridViewTextBoxColumn,
            this.harcamaKisiDataGridViewTextBoxColumn,
            this.harcamaDetayDataGridViewTextBoxColumn,
            this.harcamaIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.harcamalarBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 283);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // harcamaTarihDataGridViewTextBoxColumn
            // 
            this.harcamaTarihDataGridViewTextBoxColumn.DataPropertyName = "HarcamaTarih";
            this.harcamaTarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.harcamaTarihDataGridViewTextBoxColumn.Name = "harcamaTarihDataGridViewTextBoxColumn";
            // 
            // harcamaTutarDataGridViewTextBoxColumn
            // 
            this.harcamaTutarDataGridViewTextBoxColumn.DataPropertyName = "HarcamaTutar";
            this.harcamaTutarDataGridViewTextBoxColumn.HeaderText = "Tutar";
            this.harcamaTutarDataGridViewTextBoxColumn.Name = "harcamaTutarDataGridViewTextBoxColumn";
            // 
            // harcamaKisiDataGridViewTextBoxColumn
            // 
            this.harcamaKisiDataGridViewTextBoxColumn.DataPropertyName = "HarcamaKisi";
            this.harcamaKisiDataGridViewTextBoxColumn.HeaderText = "Ödeme Yapılan Kişi / Kurum";
            this.harcamaKisiDataGridViewTextBoxColumn.Name = "harcamaKisiDataGridViewTextBoxColumn";
            // 
            // harcamaDetayDataGridViewTextBoxColumn
            // 
            this.harcamaDetayDataGridViewTextBoxColumn.DataPropertyName = "HarcamaDetay";
            this.harcamaDetayDataGridViewTextBoxColumn.HeaderText = "Açıklama";
            this.harcamaDetayDataGridViewTextBoxColumn.Name = "harcamaDetayDataGridViewTextBoxColumn";
            // 
            // harcamaIdDataGridViewTextBoxColumn
            // 
            this.harcamaIdDataGridViewTextBoxColumn.DataPropertyName = "HarcamaId";
            this.harcamaIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.harcamaIdDataGridViewTextBoxColumn.Name = "harcamaIdDataGridViewTextBoxColumn";
            this.harcamaIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // harcamalarBindingSource2
            // 
            this.harcamalarBindingSource2.DataMember = "Harcamalar";
            this.harcamalarBindingSource2.DataSource = this.yurtOtomasyonuDataSet21;
            // 
            // yurtOtomasyonuDataSet21
            // 
            this.yurtOtomasyonuDataSet21.DataSetName = "YurtOtomasyonuDataSet21";
            this.yurtOtomasyonuDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // harcamalarTableAdapter2
            // 
            this.harcamalarTableAdapter2.ClearBeforeFill = true;
            // 
            // HarcamaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(580, 501);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HarcamaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gider Ekle";
            this.Load += new System.EventHandler(this.HarcamaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.harcamalarBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskTarih;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtKisi;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private YurtOtomasyonuDataSet19TableAdapters.HarcamalarTableAdapter harcamalarTableAdapter;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label label5;
        private YurtOtomasyonuDataSet20 yurtOtomasyonuDataSet20;
        private YurtOtomasyonuDataSet20TableAdapters.HarcamalarTableAdapter harcamalarTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet21 yurtOtomasyonuDataSet21;
        private System.Windows.Forms.BindingSource harcamalarBindingSource2;
        private YurtOtomasyonuDataSet21TableAdapters.HarcamalarTableAdapter harcamalarTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn harcamaTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn harcamaTutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn harcamaKisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn harcamaDetayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn harcamaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ImageList ımageList1;
    }
}