namespace YurtYönetimSistemi
{
    partial class EsyaIslemleriForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EsyaIslemleriForm));
            this.txtTarih = new System.Windows.Forms.MaskedTextBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnBul = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.txtTarih1 = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.rchDetay = new System.Windows.Forms.RichTextBox();
            this.txtKisi = new System.Windows.Forms.TextBox();
            this.txtYer = new System.Windows.Forms.TextBox();
            this.txtEsya = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.txtdurum1 = new System.Windows.Forms.TextBox();
            this.mskTelefon1 = new System.Windows.Forms.MaskedTextBox();
            this.rchDetay1 = new System.Windows.Forms.RichTextBox();
            this.txtKisi1 = new System.Windows.Forms.TextBox();
            this.txtYer1 = new System.Windows.Forms.TextBox();
            this.txtEsya1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTarih
            // 
            this.txtTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTarih.Location = new System.Drawing.Point(195, 106);
            this.txtTarih.Margin = new System.Windows.Forms.Padding(4);
            this.txtTarih.Mask = "00/00/0000";
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(214, 22);
            this.txtTarih.TabIndex = 56;
            this.txtTarih.ValidatingType = typeof(System.DateTime);
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
            // btnBul
            // 
            this.btnBul.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBul.ImageKey = "icons8-search-25.png";
            this.btnBul.ImageList = this.ımageList1;
            this.btnBul.Location = new System.Drawing.Point(599, 156);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(84, 43);
            this.btnBul.TabIndex = 34;
            this.btnBul.Text = "Eşya Bul";
            this.btnBul.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGüncelle.ImageKey = "icons8-save-25.png";
            this.btnGüncelle.ImageList = this.ımageList1;
            this.btnGüncelle.Location = new System.Drawing.Point(599, 252);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(84, 49);
            this.btnGüncelle.TabIndex = 33;
            this.btnGüncelle.Text = "Eşya Bilgi Güncelle";
            this.btnGüncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtTarih1
            // 
            this.txtTarih1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTarih1.Location = new System.Drawing.Point(193, 107);
            this.txtTarih1.Margin = new System.Windows.Forms.Padding(4);
            this.txtTarih1.Mask = "00/00/0000";
            this.txtTarih1.Name = "txtTarih1";
            this.txtTarih1.Size = new System.Drawing.Size(213, 22);
            this.txtTarih1.TabIndex = 56;
            this.txtTarih1.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label9.Location = new System.Drawing.Point(119, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 47;
            this.label9.Text = "Detaylar : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label10.Location = new System.Drawing.Point(73, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 16);
            this.label10.TabIndex = 46;
            this.label10.Text = "Bulunduğu Tarih : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label11.Location = new System.Drawing.Point(98, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 45;
            this.label11.Text = "Bulunan Yer : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label12.Location = new System.Drawing.Point(95, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 16);
            this.label12.TabIndex = 44;
            this.label12.Text = "Eşya Tanımı : ";
            // 
            // MskTelefon
            // 
            this.MskTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.MskTelefon.Location = new System.Drawing.Point(196, 238);
            this.MskTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(213, 22);
            this.MskTelefon.TabIndex = 55;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(117, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(462, 347);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtDurum);
            this.tabPage1.Controls.Add(this.txtTarih);
            this.tabPage1.Controls.Add(this.MskTelefon);
            this.tabPage1.Controls.Add(this.rchDetay);
            this.tabPage1.Controls.Add(this.txtKisi);
            this.tabPage1.Controls.Add(this.txtYer);
            this.tabPage1.Controls.Add(this.txtEsya);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(454, 321);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kayıp Eşya";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label13.Location = new System.Drawing.Point(134, 279);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 16);
            this.label13.TabIndex = 58;
            this.label13.Text = "Durum : ";
            // 
            // txtDurum
            // 
            this.txtDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDurum.Location = new System.Drawing.Point(196, 276);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(214, 22);
            this.txtDurum.TabIndex = 57;
            // 
            // rchDetay
            // 
            this.rchDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rchDetay.Location = new System.Drawing.Point(195, 136);
            this.rchDetay.Name = "rchDetay";
            this.rchDetay.Size = new System.Drawing.Size(214, 58);
            this.rchDetay.TabIndex = 54;
            this.rchDetay.Text = "";
            // 
            // txtKisi
            // 
            this.txtKisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtKisi.Location = new System.Drawing.Point(195, 205);
            this.txtKisi.Name = "txtKisi";
            this.txtKisi.Size = new System.Drawing.Size(214, 22);
            this.txtKisi.TabIndex = 53;
            // 
            // txtYer
            // 
            this.txtYer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtYer.Location = new System.Drawing.Point(195, 74);
            this.txtYer.Name = "txtYer";
            this.txtYer.Size = new System.Drawing.Size(214, 22);
            this.txtYer.TabIndex = 51;
            // 
            // txtEsya
            // 
            this.txtEsya.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtEsya.Location = new System.Drawing.Point(195, 40);
            this.txtEsya.Name = "txtEsya";
            this.txtEsya.Size = new System.Drawing.Size(214, 22);
            this.txtEsya.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(46, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "Eşya Sahibi Numarası : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(101, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 48;
            this.label5.Text = "Eşya Sahibi : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(122, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 47;
            this.label4.Text = "Detaylar : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(67, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Kaybolduğu Tarih : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(77, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "Kaybolduğu Yer : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(98, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Eşya Tanımı : ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.txtdurum1);
            this.tabPage2.Controls.Add(this.txtTarih1);
            this.tabPage2.Controls.Add(this.mskTelefon1);
            this.tabPage2.Controls.Add(this.rchDetay1);
            this.tabPage2.Controls.Add(this.txtKisi1);
            this.tabPage2.Controls.Add(this.txtYer1);
            this.tabPage2.Controls.Add(this.txtEsya1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(454, 321);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bulunan Eşya";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label14.Location = new System.Drawing.Point(130, 281);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 16);
            this.label14.TabIndex = 60;
            this.label14.Text = "Durum : ";
            // 
            // txtdurum1
            // 
            this.txtdurum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtdurum1.Location = new System.Drawing.Point(192, 278);
            this.txtdurum1.Name = "txtdurum1";
            this.txtdurum1.Size = new System.Drawing.Size(214, 22);
            this.txtdurum1.TabIndex = 59;
            // 
            // mskTelefon1
            // 
            this.mskTelefon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.mskTelefon1.Location = new System.Drawing.Point(193, 238);
            this.mskTelefon1.Margin = new System.Windows.Forms.Padding(4);
            this.mskTelefon1.Mask = "(999) 000-0000";
            this.mskTelefon1.Name = "mskTelefon1";
            this.mskTelefon1.Size = new System.Drawing.Size(213, 22);
            this.mskTelefon1.TabIndex = 55;
            // 
            // rchDetay1
            // 
            this.rchDetay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rchDetay1.Location = new System.Drawing.Point(192, 136);
            this.rchDetay1.Name = "rchDetay1";
            this.rchDetay1.Size = new System.Drawing.Size(214, 58);
            this.rchDetay1.TabIndex = 54;
            this.rchDetay1.Text = "";
            // 
            // txtKisi1
            // 
            this.txtKisi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtKisi1.Location = new System.Drawing.Point(192, 205);
            this.txtKisi1.Name = "txtKisi1";
            this.txtKisi1.Size = new System.Drawing.Size(214, 22);
            this.txtKisi1.TabIndex = 53;
            // 
            // txtYer1
            // 
            this.txtYer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtYer1.Location = new System.Drawing.Point(192, 74);
            this.txtYer1.Name = "txtYer1";
            this.txtYer1.Size = new System.Drawing.Size(214, 22);
            this.txtYer1.TabIndex = 51;
            // 
            // txtEsya1
            // 
            this.txtEsya1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtEsya1.Location = new System.Drawing.Point(192, 40);
            this.txtEsya1.Name = "txtEsya1";
            this.txtEsya1.Size = new System.Drawing.Size(214, 22);
            this.txtEsya1.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.Location = new System.Drawing.Point(51, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 16);
            this.label7.TabIndex = 49;
            this.label7.Text = "Bulan Kişi Numarası : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label8.Location = new System.Drawing.Point(112, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 48;
            this.label8.Text = "Bulan Kişi : ";
            // 
            // EsyaIslemleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EsyaIslemleriForm";
            this.Text = "Kayıp Eşya İşlemleri";
            this.Load += new System.EventHandler(this.EsyaIslemleriForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtTarih;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.MaskedTextBox txtTarih1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox rchDetay;
        private System.Windows.Forms.TextBox txtKisi;
        private System.Windows.Forms.TextBox txtYer;
        private System.Windows.Forms.TextBox txtEsya;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MaskedTextBox mskTelefon1;
        private System.Windows.Forms.RichTextBox rchDetay1;
        private System.Windows.Forms.TextBox txtKisi1;
        private System.Windows.Forms.TextBox txtYer1;
        private System.Windows.Forms.TextBox txtEsya1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtdurum1;
    }
}