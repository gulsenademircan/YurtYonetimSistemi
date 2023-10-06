namespace YurtYönetimSistemi
{
    partial class PersonelIslemleriForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelIslemleriForm));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonResimsec = new System.Windows.Forms.Button();
            this.RchAdres = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MskisGiris = new System.Windows.Forms.MaskedTextBox();
            this.textGorev = new System.Windows.Forms.TextBox();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textAd = new System.Windows.Forms.TextBox();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAra = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(508, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // buttonResimsec
            // 
            this.buttonResimsec.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonResimsec.Location = new System.Drawing.Point(557, 273);
            this.buttonResimsec.Name = "buttonResimsec";
            this.buttonResimsec.Size = new System.Drawing.Size(87, 29);
            this.buttonResimsec.TabIndex = 46;
            this.buttonResimsec.Text = "Resim Seç";
            this.buttonResimsec.UseVisualStyleBackColor = false;
            this.buttonResimsec.Click += new System.EventHandler(this.buttonResimsec_Click);
            // 
            // RchAdres
            // 
            this.RchAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.RchAdres.Location = new System.Drawing.Point(136, 235);
            this.RchAdres.Name = "RchAdres";
            this.RchAdres.Size = new System.Drawing.Size(214, 119);
            this.RchAdres.TabIndex = 40;
            this.RchAdres.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Personel Kodu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(19, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Adı ve Soyadı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(19, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "İşe Giriş Tarihi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(57, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Telefon :";
            // 
            // MskisGiris
            // 
            this.MskisGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.MskisGiris.Location = new System.Drawing.Point(136, 152);
            this.MskisGiris.Mask = "00/00/0000";
            this.MskisGiris.Name = "MskisGiris";
            this.MskisGiris.Size = new System.Drawing.Size(214, 22);
            this.MskisGiris.TabIndex = 33;
            this.MskisGiris.ValidatingType = typeof(System.DateTime);
            // 
            // textGorev
            // 
            this.textGorev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textGorev.Location = new System.Drawing.Point(136, 193);
            this.textGorev.Name = "textGorev";
            this.textGorev.Size = new System.Drawing.Size(214, 22);
            this.textGorev.TabIndex = 39;
            // 
            // MskTelefon
            // 
            this.MskTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.MskTelefon.Location = new System.Drawing.Point(136, 109);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(214, 22);
            this.MskTelefon.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.buttonResimsec);
            this.groupBox1.Controls.Add(this.RchAdres);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.MskisGiris);
            this.groupBox1.Controls.Add(this.textGorev);
            this.groupBox1.Controls.Add(this.MskTelefon);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textAd);
            this.groupBox1.Location = new System.Drawing.Point(32, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 437);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kaydı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(63, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Görevi :";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtid.Location = new System.Drawing.Point(137, 33);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(214, 22);
            this.txtid.TabIndex = 35;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(68, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Adres :";
            // 
            // textAd
            // 
            this.textAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textAd.Location = new System.Drawing.Point(136, 73);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(214, 22);
            this.textAd.TabIndex = 36;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGüncelle.ImageKey = "icons8-update-25.png";
            this.btnGüncelle.ImageList = this.ımageList1;
            this.btnGüncelle.Location = new System.Drawing.Point(759, 230);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(87, 42);
            this.btnGüncelle.TabIndex = 47;
            this.btnGüncelle.Text = "Personel Güncelle";
            this.btnGüncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icons8-save-25.png");
            this.ımageList1.Images.SetKeyName(1, "icons8-update-25.png");
            this.ımageList1.Images.SetKeyName(2, "icons8-delete-25 (3).png");
            this.ımageList1.Images.SetKeyName(3, "icons8-search-25.png");
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAra.ImageKey = "icons8-search-25.png";
            this.btnAra.ImageList = this.ımageList1;
            this.btnAra.Location = new System.Drawing.Point(760, 139);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(87, 42);
            this.btnAra.TabIndex = 49;
            this.btnAra.Text = "Personel Ara";
            this.btnAra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSil.ImageKey = "icons8-delete-25 (3).png";
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(759, 323);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(87, 42);
            this.btnSil.TabIndex = 48;
            this.btnSil.Text = "Personeli Sil";
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // PersonelIslemleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(859, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnSil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonelIslemleriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel İşlemleri";
            this.Load += new System.EventHandler(this.PersonelIslemleriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonResimsec;
        private System.Windows.Forms.RichTextBox RchAdres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox MskisGiris;
        private System.Windows.Forms.TextBox textGorev;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnSil;
    }
}