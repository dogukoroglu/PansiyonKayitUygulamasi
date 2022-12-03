namespace PansiyonKayitUygulamasi
{
    partial class FrmMusteriler
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.musteriidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giristarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikistarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriEkleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pansiyonKayitDBDataSet1 = new PansiyonKayitUygulamasi.PansiyonKayitDBDataSet1();
            this.musteriEkleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnListele = new System.Windows.Forms.Button();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpCikis = new System.Windows.Forms.DateTimePicker();
            this.dtpGiris = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOdano = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtMusteriId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chkBebek = new System.Windows.Forms.CheckBox();
            this.chkCocuk = new System.Windows.Forms.CheckBox();
            this.chkOgrenci = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pansiyonKayitDBDataSet2 = new PansiyonKayitUygulamasi.PansiyonKayitDBDataSet2();
            this.musteriEkleBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.musteriEkleTableAdapter = new PansiyonKayitUygulamasi.PansiyonKayitDBDataSet2TableAdapters.MusteriEkleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriEkleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pansiyonKayitDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriEkleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pansiyonKayitDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriEkleBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriidDataGridViewTextBoxColumn,
            this.adiDataGridViewTextBoxColumn,
            this.soyadiDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.tcnoDataGridViewTextBoxColumn,
            this.odanoDataGridViewTextBoxColumn,
            this.ucretDataGridViewTextBoxColumn,
            this.giristarihiDataGridViewTextBoxColumn,
            this.cikistarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.musteriEkleBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1147, 234);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // musteriidDataGridViewTextBoxColumn
            // 
            this.musteriidDataGridViewTextBoxColumn.DataPropertyName = "musteriid";
            this.musteriidDataGridViewTextBoxColumn.HeaderText = "musteriid";
            this.musteriidDataGridViewTextBoxColumn.Name = "musteriidDataGridViewTextBoxColumn";
            this.musteriidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adiDataGridViewTextBoxColumn
            // 
            this.adiDataGridViewTextBoxColumn.DataPropertyName = "adi";
            this.adiDataGridViewTextBoxColumn.HeaderText = "adi";
            this.adiDataGridViewTextBoxColumn.Name = "adiDataGridViewTextBoxColumn";
            // 
            // soyadiDataGridViewTextBoxColumn
            // 
            this.soyadiDataGridViewTextBoxColumn.DataPropertyName = "soyadi";
            this.soyadiDataGridViewTextBoxColumn.HeaderText = "soyadi";
            this.soyadiDataGridViewTextBoxColumn.Name = "soyadiDataGridViewTextBoxColumn";
            // 
            // cinsiyetDataGridViewTextBoxColumn
            // 
            this.cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.HeaderText = "cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // tcnoDataGridViewTextBoxColumn
            // 
            this.tcnoDataGridViewTextBoxColumn.DataPropertyName = "tcno";
            this.tcnoDataGridViewTextBoxColumn.HeaderText = "tcno";
            this.tcnoDataGridViewTextBoxColumn.Name = "tcnoDataGridViewTextBoxColumn";
            // 
            // odanoDataGridViewTextBoxColumn
            // 
            this.odanoDataGridViewTextBoxColumn.DataPropertyName = "odano";
            this.odanoDataGridViewTextBoxColumn.HeaderText = "odano";
            this.odanoDataGridViewTextBoxColumn.Name = "odanoDataGridViewTextBoxColumn";
            // 
            // ucretDataGridViewTextBoxColumn
            // 
            this.ucretDataGridViewTextBoxColumn.DataPropertyName = "ucret";
            this.ucretDataGridViewTextBoxColumn.HeaderText = "ucret";
            this.ucretDataGridViewTextBoxColumn.Name = "ucretDataGridViewTextBoxColumn";
            // 
            // giristarihiDataGridViewTextBoxColumn
            // 
            this.giristarihiDataGridViewTextBoxColumn.DataPropertyName = "giristarihi";
            this.giristarihiDataGridViewTextBoxColumn.HeaderText = "giristarihi";
            this.giristarihiDataGridViewTextBoxColumn.Name = "giristarihiDataGridViewTextBoxColumn";
            // 
            // cikistarihiDataGridViewTextBoxColumn
            // 
            this.cikistarihiDataGridViewTextBoxColumn.DataPropertyName = "cikistarihi";
            this.cikistarihiDataGridViewTextBoxColumn.HeaderText = "cikistarihi";
            this.cikistarihiDataGridViewTextBoxColumn.Name = "cikistarihiDataGridViewTextBoxColumn";
            // 
            // musteriEkleBindingSource1
            // 
            this.musteriEkleBindingSource1.DataMember = "MusteriEkle";
            this.musteriEkleBindingSource1.DataSource = this.pansiyonKayitDBDataSet1;
            // 
            // pansiyonKayitDBDataSet1
            // 
            this.pansiyonKayitDBDataSet1.DataSetName = "PansiyonKayitDBDataSet1";
            this.pansiyonKayitDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteriEkleBindingSource
            // 
            this.musteriEkleBindingSource.DataMember = "MusteriEkle";
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(890, 106);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(107, 79);
            this.btnListele.TabIndex = 2;
            this.btnListele.Text = "ANA FORM";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(123, 122);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(227, 30);
            this.cmbCinsiyet.TabIndex = 89;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(33, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 22);
            this.label10.TabIndex = 88;
            this.label10.Text = "Cinsiyet :";
            // 
            // mskTelefon
            // 
            this.mskTelefon.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTelefon.Location = new System.Drawing.Point(123, 155);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(227, 28);
            this.mskTelefon.TabIndex = 87;
            // 
            // txtTc
            // 
            this.txtTc.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTc.Location = new System.Drawing.Point(522, 21);
            this.txtTc.MaxLength = 11;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(227, 28);
            this.txtTc.TabIndex = 86;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(378, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 22);
            this.label5.TabIndex = 85;
            this.label5.Text = "T.C. Kimlik No :";
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(123, 187);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(227, 28);
            this.txtMail.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 22);
            this.label4.TabIndex = 83;
            this.label4.Text = "Mail Adresi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 82;
            this.label3.Text = "Telefon No :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(123, 87);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(227, 28);
            this.txtSoyad.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 80;
            this.label2.Text = "Soyad :";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(123, 55);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(227, 28);
            this.txtAd.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 22);
            this.label1.TabIndex = 78;
            this.label1.Text = "Ad :";
            // 
            // txtUcret
            // 
            this.txtUcret.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUcret.Location = new System.Drawing.Point(522, 89);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(227, 28);
            this.txtUcret.TabIndex = 97;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(453, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 22);
            this.label9.TabIndex = 96;
            this.label9.Text = "Ücret :";
            // 
            // dtpCikis
            // 
            this.dtpCikis.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpCikis.Location = new System.Drawing.Point(522, 155);
            this.dtpCikis.Name = "dtpCikis";
            this.dtpCikis.Size = new System.Drawing.Size(227, 28);
            this.dtpCikis.TabIndex = 95;
            this.dtpCikis.ValueChanged += new System.EventHandler(this.dtpCikis_ValueChanged);
            // 
            // dtpGiris
            // 
            this.dtpGiris.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpGiris.Location = new System.Drawing.Point(522, 123);
            this.dtpGiris.Name = "dtpGiris";
            this.dtpGiris.Size = new System.Drawing.Size(227, 28);
            this.dtpGiris.TabIndex = 94;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(408, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 22);
            this.label8.TabIndex = 93;
            this.label8.Text = "Çıkış Tarihi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(408, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 22);
            this.label7.TabIndex = 92;
            this.label7.Text = "Giriş Tarihi :";
            // 
            // txtOdano
            // 
            this.txtOdano.Enabled = false;
            this.txtOdano.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdano.Location = new System.Drawing.Point(522, 55);
            this.txtOdano.Name = "txtOdano";
            this.txtOdano.Size = new System.Drawing.Size(227, 28);
            this.txtOdano.TabIndex = 91;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(380, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 22);
            this.label6.TabIndex = 90;
            this.label6.Text = "Oda Numarası :";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(890, 23);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(107, 79);
            this.btnGuncelle.TabIndex = 98;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(1003, 23);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(107, 79);
            this.btnSil.TabIndex = 99;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(1003, 106);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(107, 79);
            this.btnAra.TabIndex = 100;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // txtMusteriId
            // 
            this.txtMusteriId.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriId.Location = new System.Drawing.Point(123, 21);
            this.txtMusteriId.Name = "txtMusteriId";
            this.txtMusteriId.Size = new System.Drawing.Size(227, 28);
            this.txtMusteriId.TabIndex = 102;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(79, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 22);
            this.label11.TabIndex = 101;
            this.label11.Text = "ID :";
            // 
            // chkBebek
            // 
            this.chkBebek.AutoSize = true;
            this.chkBebek.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkBebek.ForeColor = System.Drawing.Color.White;
            this.chkBebek.Location = new System.Drawing.Point(685, 189);
            this.chkBebek.Name = "chkBebek";
            this.chkBebek.Size = new System.Drawing.Size(79, 26);
            this.chkBebek.TabIndex = 105;
            this.chkBebek.Text = "Bebek";
            this.chkBebek.UseVisualStyleBackColor = true;
            // 
            // chkCocuk
            // 
            this.chkCocuk.AutoSize = true;
            this.chkCocuk.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkCocuk.ForeColor = System.Drawing.Color.White;
            this.chkCocuk.Location = new System.Drawing.Point(600, 189);
            this.chkCocuk.Name = "chkCocuk";
            this.chkCocuk.Size = new System.Drawing.Size(79, 26);
            this.chkCocuk.TabIndex = 104;
            this.chkCocuk.Text = "Çocuk";
            this.chkCocuk.UseVisualStyleBackColor = true;
            // 
            // chkOgrenci
            // 
            this.chkOgrenci.AutoSize = true;
            this.chkOgrenci.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkOgrenci.ForeColor = System.Drawing.Color.White;
            this.chkOgrenci.Location = new System.Drawing.Point(502, 189);
            this.chkOgrenci.Name = "chkOgrenci";
            this.chkOgrenci.Size = new System.Drawing.Size(92, 26);
            this.chkOgrenci.TabIndex = 103;
            this.chkOgrenci.Text = "Öğrenci";
            this.chkOgrenci.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(413, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 19);
            this.label12.TabIndex = 106;
            this.label12.Text = "label12";
            // 
            // pansiyonKayitDBDataSet2
            // 
            this.pansiyonKayitDBDataSet2.DataSetName = "PansiyonKayitDBDataSet2";
            this.pansiyonKayitDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteriEkleBindingSource2
            // 
            this.musteriEkleBindingSource2.DataMember = "MusteriEkle";
            this.musteriEkleBindingSource2.DataSource = this.pansiyonKayitDBDataSet2;
            // 
            // musteriEkleTableAdapter
            // 
            this.musteriEkleTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(1141, 457);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.chkBebek);
            this.Controls.Add(this.chkCocuk);
            this.Controls.Add(this.chkOgrenci);
            this.Controls.Add(this.txtMusteriId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpCikis);
            this.Controls.Add(this.dtpGiris);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtOdano);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mskTelefon);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMusteriler";
            this.Text = "FrmMusteriler";
            this.Load += new System.EventHandler(this.FrmMusteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriEkleBindingSource1)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.pansiyonKayitDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriEkleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pansiyonKayitDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriEkleBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpCikis;
        private System.Windows.Forms.DateTimePicker dtpGiris;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOdano;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnAra;
        //private PansiyonKayitDBDataSet pansiyonKayitDBDataSet;
        private System.Windows.Forms.BindingSource musteriEkleBindingSource;
        //private PansiyonKayitDBDataSetTableAdapters.MusteriEkleTableAdapter musteriEkleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giristarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikistarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtMusteriId;
        private System.Windows.Forms.Label label11;
        private PansiyonKayitDBDataSet1 pansiyonKayitDBDataSet1;
        private System.Windows.Forms.BindingSource musteriEkleBindingSource1;
        //private PansiyonKayitDBDataSet1TableAdapters.MusteriEkleTableAdapter musteriEkleTableAdapter1;
        private System.Windows.Forms.CheckBox chkBebek;
        private System.Windows.Forms.CheckBox chkCocuk;
        private System.Windows.Forms.CheckBox chkOgrenci;
        private System.Windows.Forms.Label label12;
        private PansiyonKayitDBDataSet2 pansiyonKayitDBDataSet2;
        private System.Windows.Forms.BindingSource musteriEkleBindingSource2;
        private PansiyonKayitDBDataSet2TableAdapters.MusteriEkleTableAdapter musteriEkleTableAdapter;
    }
}