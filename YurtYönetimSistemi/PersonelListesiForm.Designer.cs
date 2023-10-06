namespace YurtYönetimSistemi
{
    partial class PersonelListesiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelListesiForm));
            this.yurtOtomasyonuDataSet8 = new YurtYönetimSistemi.YurtOtomasyonuDataSet8();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelTableAdapter = new YurtYönetimSistemi.YurtOtomasyonuDataSet8TableAdapters.PersonelTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDepartmanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelResimDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.personelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet9 = new YurtYönetimSistemi.YurtOtomasyonuDataSet9();
            this.personelTableAdapter1 = new YurtYönetimSistemi.YurtOtomasyonuDataSet9TableAdapters.PersonelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // yurtOtomasyonuDataSet8
            // 
            this.yurtOtomasyonuDataSet8.DataSetName = "YurtOtomasyonuDataSet8";
            this.yurtOtomasyonuDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "Personel";
            this.personelBindingSource.DataSource = this.yurtOtomasyonuDataSet8;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelidDataGridViewTextBoxColumn,
            this.personelAdSoyadDataGridViewTextBoxColumn,
            this.personelDepartmanDataGridViewTextBoxColumn,
            this.personelTarihDataGridViewTextBoxColumn,
            this.personelTelefonDataGridViewTextBoxColumn,
            this.personelAdresDataGridViewTextBoxColumn,
            this.personelResimDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.personelBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(32, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 437);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // personelidDataGridViewTextBoxColumn
            // 
            this.personelidDataGridViewTextBoxColumn.DataPropertyName = "Personelid";
            this.personelidDataGridViewTextBoxColumn.HeaderText = "Personel Id";
            this.personelidDataGridViewTextBoxColumn.Name = "personelidDataGridViewTextBoxColumn";
            this.personelidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelAdSoyadDataGridViewTextBoxColumn
            // 
            this.personelAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "PersonelAdSoyad";
            this.personelAdSoyadDataGridViewTextBoxColumn.HeaderText = "Adı ve Soyadı";
            this.personelAdSoyadDataGridViewTextBoxColumn.Name = "personelAdSoyadDataGridViewTextBoxColumn";
            // 
            // personelDepartmanDataGridViewTextBoxColumn
            // 
            this.personelDepartmanDataGridViewTextBoxColumn.DataPropertyName = "PersonelDepartman";
            this.personelDepartmanDataGridViewTextBoxColumn.HeaderText = "Departmanı";
            this.personelDepartmanDataGridViewTextBoxColumn.Name = "personelDepartmanDataGridViewTextBoxColumn";
            // 
            // personelTarihDataGridViewTextBoxColumn
            // 
            this.personelTarihDataGridViewTextBoxColumn.DataPropertyName = "PersonelTarih";
            this.personelTarihDataGridViewTextBoxColumn.HeaderText = "İşe Giriş Tarihi";
            this.personelTarihDataGridViewTextBoxColumn.Name = "personelTarihDataGridViewTextBoxColumn";
            // 
            // personelTelefonDataGridViewTextBoxColumn
            // 
            this.personelTelefonDataGridViewTextBoxColumn.DataPropertyName = "PersonelTelefon";
            this.personelTelefonDataGridViewTextBoxColumn.HeaderText = "Telefon Numarası";
            this.personelTelefonDataGridViewTextBoxColumn.Name = "personelTelefonDataGridViewTextBoxColumn";
            // 
            // personelAdresDataGridViewTextBoxColumn
            // 
            this.personelAdresDataGridViewTextBoxColumn.DataPropertyName = "PersonelAdres";
            this.personelAdresDataGridViewTextBoxColumn.HeaderText = "Adresi";
            this.personelAdresDataGridViewTextBoxColumn.Name = "personelAdresDataGridViewTextBoxColumn";
            // 
            // personelResimDataGridViewImageColumn
            // 
            this.personelResimDataGridViewImageColumn.DataPropertyName = "PersonelResim";
            this.personelResimDataGridViewImageColumn.HeaderText = "Resmi";
            this.personelResimDataGridViewImageColumn.Name = "personelResimDataGridViewImageColumn";
            // 
            // personelBindingSource1
            // 
            this.personelBindingSource1.DataMember = "Personel";
            this.personelBindingSource1.DataSource = this.yurtOtomasyonuDataSet9;
            // 
            // yurtOtomasyonuDataSet9
            // 
            this.yurtOtomasyonuDataSet9.DataSetName = "YurtOtomasyonuDataSet9";
            this.yurtOtomasyonuDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelTableAdapter1
            // 
            this.personelTableAdapter1.ClearBeforeFill = true;
            // 
            // PersonelListesiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(708, 493);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonelListesiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Listesi";
            this.Load += new System.EventHandler(this.PersonelListesiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private YurtOtomasyonuDataSet8 yurtOtomasyonuDataSet8;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private YurtOtomasyonuDataSet8TableAdapters.PersonelTableAdapter personelTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet9 yurtOtomasyonuDataSet9;
        private System.Windows.Forms.BindingSource personelBindingSource1;
        private YurtOtomasyonuDataSet9TableAdapters.PersonelTableAdapter personelTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDepartmanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn personelResimDataGridViewImageColumn;
    }
}