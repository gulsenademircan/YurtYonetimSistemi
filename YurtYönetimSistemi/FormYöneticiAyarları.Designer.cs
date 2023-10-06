namespace YurtYönetimSistemi
{
    partial class FormYöneticiAyarları
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYöneticiAyarları));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonGüncelle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.textParola = new System.Windows.Forms.TextBox();
            this.textKullaniciAd = new System.Windows.Forms.TextBox();
            this.textid = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yoneticiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet4 = new YurtYönetimSistemi.YurtOtomasyonuDataSet4();
            this.adminTableAdapter = new YurtYönetimSistemi.YurtOtomasyonuDataSet4TableAdapters.AdminTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(85, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(34, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(61, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parola : ";
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonKaydet.ImageKey = "icons8-save-25.png";
            this.buttonKaydet.ImageList = this.ımageList1;
            this.buttonKaydet.Location = new System.Drawing.Point(380, 60);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(86, 34);
            this.buttonKaydet.TabIndex = 3;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonKaydet.UseVisualStyleBackColor = false;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icons8-delete-30 (2).png");
            this.ımageList1.Images.SetKeyName(1, "icons8-update-30 (1).png");
            this.ımageList1.Images.SetKeyName(2, "icons8-trash-32.png");
            this.ımageList1.Images.SetKeyName(3, "icons8-save-30.png");
            this.ımageList1.Images.SetKeyName(4, "icons8-plus-30 (1).png");
            this.ımageList1.Images.SetKeyName(5, "icons8-plus-30.png");
            this.ımageList1.Images.SetKeyName(6, "icons8-delete-25 (3).png");
            this.ımageList1.Images.SetKeyName(7, "icons8-save-25.png");
            this.ımageList1.Images.SetKeyName(8, "icons8-update-25.png");
            this.ımageList1.Images.SetKeyName(9, "icons8-delete-document-25.png");
            // 
            // buttonGüncelle
            // 
            this.buttonGüncelle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonGüncelle.ImageKey = "icons8-update-25.png";
            this.buttonGüncelle.ImageList = this.ımageList1;
            this.buttonGüncelle.Location = new System.Drawing.Point(380, 131);
            this.buttonGüncelle.Name = "buttonGüncelle";
            this.buttonGüncelle.Size = new System.Drawing.Size(86, 34);
            this.buttonGüncelle.TabIndex = 4;
            this.buttonGüncelle.Text = "Güncelle";
            this.buttonGüncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGüncelle.UseVisualStyleBackColor = false;
            this.buttonGüncelle.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonSil.ImageKey = "icons8-delete-25 (3).png";
            this.buttonSil.ImageList = this.ımageList1;
            this.buttonSil.Location = new System.Drawing.Point(380, 204);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(86, 34);
            this.buttonSil.TabIndex = 5;
            this.buttonSil.Text = "Sil";
            this.buttonSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // textParola
            // 
            this.textParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textParola.Location = new System.Drawing.Point(113, 86);
            this.textParola.Name = "textParola";
            this.textParola.Size = new System.Drawing.Size(145, 20);
            this.textParola.TabIndex = 5;
            // 
            // textKullaniciAd
            // 
            this.textKullaniciAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textKullaniciAd.Location = new System.Drawing.Point(113, 55);
            this.textKullaniciAd.Name = "textKullaniciAd";
            this.textKullaniciAd.Size = new System.Drawing.Size(145, 20);
            this.textKullaniciAd.TabIndex = 4;
            // 
            // textid
            // 
            this.textid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textid.Location = new System.Drawing.Point(113, 25);
            this.textid.Name = "textid";
            this.textid.ReadOnly = true;
            this.textid.Size = new System.Drawing.Size(145, 20);
            this.textid.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yoneticiidDataGridViewTextBoxColumn,
            this.yoneticiAdDataGridViewTextBoxColumn,
            this.yoneticiSifreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.adminBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(342, 231);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // yoneticiidDataGridViewTextBoxColumn
            // 
            this.yoneticiidDataGridViewTextBoxColumn.DataPropertyName = "Yoneticiid";
            this.yoneticiidDataGridViewTextBoxColumn.HeaderText = "Id";
            this.yoneticiidDataGridViewTextBoxColumn.Name = "yoneticiidDataGridViewTextBoxColumn";
            this.yoneticiidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yoneticiAdDataGridViewTextBoxColumn
            // 
            this.yoneticiAdDataGridViewTextBoxColumn.DataPropertyName = "YoneticiAd";
            this.yoneticiAdDataGridViewTextBoxColumn.HeaderText = "Kullanıcı Adı";
            this.yoneticiAdDataGridViewTextBoxColumn.Name = "yoneticiAdDataGridViewTextBoxColumn";
            // 
            // yoneticiSifreDataGridViewTextBoxColumn
            // 
            this.yoneticiSifreDataGridViewTextBoxColumn.DataPropertyName = "YoneticiSifre";
            this.yoneticiSifreDataGridViewTextBoxColumn.HeaderText = "Şifre";
            this.yoneticiSifreDataGridViewTextBoxColumn.Name = "yoneticiSifreDataGridViewTextBoxColumn";
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "Admin";
            this.adminBindingSource.DataSource = this.yurtOtomasyonuDataSet4;
            // 
            // yurtOtomasyonuDataSet4
            // 
            this.yurtOtomasyonuDataSet4.DataSetName = "YurtOtomasyonuDataSet4";
            this.yurtOtomasyonuDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textParola);
            this.groupBox1.Controls.Add(this.textid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textKullaniciAd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 130);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yönetici Bilgileri";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button1.ImageKey = "icons8-delete-document-25.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(380, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sayfayı Temizle";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormYöneticiAyarları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(486, 431);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonGüncelle);
            this.Controls.Add(this.buttonKaydet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormYöneticiAyarları";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Ayarları";
            this.Load += new System.EventHandler(this.FormYöneticiAyarları_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Button buttonGüncelle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.TextBox textParola;
        private System.Windows.Forms.TextBox textKullaniciAd;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet4 yurtOtomasyonuDataSet4;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private YurtOtomasyonuDataSet4TableAdapters.AdminTableAdapter adminTableAdapter;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiSifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}