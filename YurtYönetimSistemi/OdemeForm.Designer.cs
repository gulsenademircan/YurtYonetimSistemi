namespace YurtYönetimSistemi
{
    partial class OdemeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdemeForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnArama = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mskTarih = new System.Windows.Forms.MaskedTextBox();
            this.txtOdeme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKalan = new System.Windows.Forms.TextBox();
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnOdeme = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.borclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.borclarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.borclarBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.borclarBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet17 = new YurtYönetimSistemi.YurtOtomasyonuDataSet17();
            this.borclarTableAdapter3 = new YurtYönetimSistemi.YurtOtomasyonuDataSet17TableAdapters.BorclarTableAdapter();
            this.borcIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrKalanBorcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odemeTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odemeTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet17)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(495, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama Ve Filtreleme";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(123, 104);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(141, 22);
            this.txtSoyad.TabIndex = 5;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(123, 67);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(141, 22);
            this.txtAd.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(123, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(141, 22);
            this.txtId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Öğrenci Soyadı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğrenci Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borç Id :";
            // 
            // btnArama
            // 
            this.btnArama.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnArama.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnArama.ImageKey = "icons8-search-25.png";
            this.btnArama.ImageList = this.ımageList1;
            this.btnArama.Location = new System.Drawing.Point(813, 88);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(75, 32);
            this.btnArama.TabIndex = 6;
            this.btnArama.Text = "Ara";
            this.btnArama.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnArama.UseVisualStyleBackColor = false;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icons8-search-25.png");
            this.ımageList1.Images.SetKeyName(1, "icons8-delete-25 (3).png");
            this.ımageList1.Images.SetKeyName(2, "icons8-pay-25 (1).png");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mskTarih);
            this.groupBox2.Controls.Add(this.txtOdeme);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(495, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 127);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ödeme İşlemi";
            // 
            // mskTarih
            // 
            this.mskTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.mskTarih.Location = new System.Drawing.Point(158, 34);
            this.mskTarih.Mask = "00/00/0000";
            this.mskTarih.Name = "mskTarih";
            this.mskTarih.Size = new System.Drawing.Size(125, 22);
            this.mskTarih.TabIndex = 13;
            this.mskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtOdeme
            // 
            this.txtOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtOdeme.Location = new System.Drawing.Point(158, 68);
            this.txtOdeme.Name = "txtOdeme";
            this.txtOdeme.Size = new System.Drawing.Size(125, 22);
            this.txtOdeme.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(57, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ödeme Tutarı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(11, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ödeme Yapılan Tarih :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(564, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Kalan Borç :";
            // 
            // txtKalan
            // 
            this.txtKalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtKalan.Location = new System.Drawing.Point(648, 374);
            this.txtKalan.Name = "txtKalan";
            this.txtKalan.ReadOnly = true;
            this.txtKalan.Size = new System.Drawing.Size(100, 22);
            this.txtKalan.TabIndex = 12;
            // 
            // btnOdeme
            // 
            this.btnOdeme.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdeme.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOdeme.ImageKey = "icons8-pay-25 (1).png";
            this.btnOdeme.ImageList = this.ımageList1;
            this.btnOdeme.Location = new System.Drawing.Point(813, 196);
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.Size = new System.Drawing.Size(75, 32);
            this.btnOdeme.TabIndex = 7;
            this.btnOdeme.Text = "Öde";
            this.btnOdeme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOdeme.UseVisualStyleBackColor = false;
            this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTemizle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTemizle.ImageKey = "icons8-delete-25 (3).png";
            this.btnTemizle.ImageList = this.ımageList1;
            this.btnTemizle.Location = new System.Drawing.Point(813, 300);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(81, 39);
            this.btnTemizle.TabIndex = 14;
            this.btnTemizle.Text = "Sayfayı Temizle";
            this.btnTemizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.borcIdDataGridViewTextBoxColumn,
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.ogrKalanBorcDataGridViewTextBoxColumn,
            this.odemeTarihDataGridViewTextBoxColumn,
            this.odemeTutarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.borclarBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(459, 290);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // borclarBindingSource3
            // 
            this.borclarBindingSource3.DataMember = "Borclar";
            this.borclarBindingSource3.DataSource = this.yurtOtomasyonuDataSet17;
            // 
            // yurtOtomasyonuDataSet17
            // 
            this.yurtOtomasyonuDataSet17.DataSetName = "YurtOtomasyonuDataSet17";
            this.yurtOtomasyonuDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // borclarTableAdapter3
            // 
            this.borclarTableAdapter3.ClearBeforeFill = true;
            // 
            // borcIdDataGridViewTextBoxColumn
            // 
            this.borcIdDataGridViewTextBoxColumn.DataPropertyName = "BorcId";
            this.borcIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.borcIdDataGridViewTextBoxColumn.Name = "borcIdDataGridViewTextBoxColumn";
            this.borcIdDataGridViewTextBoxColumn.ReadOnly = true;
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
            // ogrKalanBorcDataGridViewTextBoxColumn
            // 
            this.ogrKalanBorcDataGridViewTextBoxColumn.DataPropertyName = "OgrKalanBorc";
            this.ogrKalanBorcDataGridViewTextBoxColumn.HeaderText = "Kalan Borç";
            this.ogrKalanBorcDataGridViewTextBoxColumn.Name = "ogrKalanBorcDataGridViewTextBoxColumn";
            // 
            // odemeTarihDataGridViewTextBoxColumn
            // 
            this.odemeTarihDataGridViewTextBoxColumn.DataPropertyName = "OdemeTarih";
            this.odemeTarihDataGridViewTextBoxColumn.HeaderText = "Ödeme Tarihi";
            this.odemeTarihDataGridViewTextBoxColumn.Name = "odemeTarihDataGridViewTextBoxColumn";
            // 
            // odemeTutarDataGridViewTextBoxColumn
            // 
            this.odemeTutarDataGridViewTextBoxColumn.DataPropertyName = "OdemeTutar";
            this.odemeTutarDataGridViewTextBoxColumn.HeaderText = "Ödenen Tutar";
            this.odemeTutarDataGridViewTextBoxColumn.Name = "odemeTutarDataGridViewTextBoxColumn";
            // 
            // OdemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 522);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnOdeme);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.txtKalan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OdemeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Kayıt";
            this.Load += new System.EventHandler(this.OdemeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet17)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtKalan;
        private System.Windows.Forms.TextBox txtOdeme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskTarih;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private System.Windows.Forms.Button btnOdeme;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.BindingSource borclarBindingSource;
        private System.Windows.Forms.BindingSource borclarBindingSource1;
        private System.Windows.Forms.BindingSource borclarBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet17 yurtOtomasyonuDataSet17;
        private System.Windows.Forms.BindingSource borclarBindingSource3;
        private YurtOtomasyonuDataSet17TableAdapters.BorclarTableAdapter borclarTableAdapter3;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn borcIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrKalanBorcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemeTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemeTutarDataGridViewTextBoxColumn;
    }
}