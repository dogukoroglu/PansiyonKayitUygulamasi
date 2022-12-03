namespace PansiyonKayitUygulamasi
{
    partial class FrmStoklar
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
            this.stoklarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStokSil = new System.Windows.Forms.Button();
            this.txtStokid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnStokKaydet = new System.Windows.Forms.Button();
            this.txtIcecekler = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGidalar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFaturaid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFaturaSil = new System.Windows.Forms.Button();
            this.txtInternet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFaturaKaydet = new System.Windows.Forms.Button();
            this.txtSu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtElektrik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.faturalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.faturalarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stoklarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stokidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icecekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoklarBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pansiyonKayitDBDataSet = new PansiyonKayitUygulamasi.PansiyonKayitDBDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.faturaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elektrikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturalarBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pansiyonKayitDBDataSet1 = new PansiyonKayitUygulamasi.PansiyonKayitDBDataSet1();
            this.stoklarTableAdapter = new PansiyonKayitUygulamasi.PansiyonKayitDBDataSetTableAdapters.StoklarTableAdapter();
            this.faturalarTableAdapter = new PansiyonKayitUygulamasi.PansiyonKayitDBDataSet1TableAdapters.FaturalarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.stoklarBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faturalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturalarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoklarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoklarBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pansiyonKayitDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturalarBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pansiyonKayitDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // stoklarBindingSource
            // 
            this.stoklarBindingSource.DataMember = "Stoklar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStokSil);
            this.groupBox1.Controls.Add(this.txtStokid);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnStokKaydet);
            this.groupBox1.Controls.Add(this.txtIcecekler);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGidalar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 251);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mutfak Giderleri";
            // 
            // btnStokSil
            // 
            this.btnStokSil.BackColor = System.Drawing.Color.Red;
            this.btnStokSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStokSil.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStokSil.ForeColor = System.Drawing.Color.White;
            this.btnStokSil.Location = new System.Drawing.Point(181, 153);
            this.btnStokSil.Name = "btnStokSil";
            this.btnStokSil.Size = new System.Drawing.Size(128, 31);
            this.btnStokSil.TabIndex = 20;
            this.btnStokSil.Text = "Sil";
            this.btnStokSil.UseVisualStyleBackColor = false;
            this.btnStokSil.Click += new System.EventHandler(this.btnStokSil_Click);
            // 
            // txtStokid
            // 
            this.txtStokid.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStokid.ForeColor = System.Drawing.Color.Black;
            this.txtStokid.Location = new System.Drawing.Point(129, 48);
            this.txtStokid.Name = "txtStokid";
            this.txtStokid.Size = new System.Drawing.Size(180, 28);
            this.txtStokid.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(48, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Stok ID :";
            // 
            // btnStokKaydet
            // 
            this.btnStokKaydet.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStokKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnStokKaydet.Location = new System.Drawing.Point(47, 153);
            this.btnStokKaydet.Name = "btnStokKaydet";
            this.btnStokKaydet.Size = new System.Drawing.Size(128, 31);
            this.btnStokKaydet.TabIndex = 9;
            this.btnStokKaydet.Text = "Kaydet";
            this.btnStokKaydet.UseVisualStyleBackColor = true;
            this.btnStokKaydet.Click += new System.EventHandler(this.btnStokKaydet_Click_1);
            // 
            // txtIcecekler
            // 
            this.txtIcecekler.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIcecekler.ForeColor = System.Drawing.Color.Black;
            this.txtIcecekler.Location = new System.Drawing.Point(129, 116);
            this.txtIcecekler.Name = "txtIcecekler";
            this.txtIcecekler.Size = new System.Drawing.Size(180, 28);
            this.txtIcecekler.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "İçecek Tutarı :";
            // 
            // txtGidalar
            // 
            this.txtGidalar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGidalar.ForeColor = System.Drawing.Color.Black;
            this.txtGidalar.Location = new System.Drawing.Point(129, 82);
            this.txtGidalar.Name = "txtGidalar";
            this.txtGidalar.Size = new System.Drawing.Size(180, 28);
            this.txtGidalar.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gıda Tutarı :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFaturaid);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnFaturaSil);
            this.groupBox2.Controls.Add(this.txtInternet);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnFaturaKaydet);
            this.groupBox2.Controls.Add(this.txtSu);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtElektrik);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(353, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 251);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Faturalar";
            // 
            // txtFaturaid
            // 
            this.txtFaturaid.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFaturaid.ForeColor = System.Drawing.Color.Black;
            this.txtFaturaid.Location = new System.Drawing.Point(133, 44);
            this.txtFaturaid.Name = "txtFaturaid";
            this.txtFaturaid.Size = new System.Drawing.Size(180, 28);
            this.txtFaturaid.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(37, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Fatura ID :";
            // 
            // btnFaturaSil
            // 
            this.btnFaturaSil.BackColor = System.Drawing.Color.Red;
            this.btnFaturaSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFaturaSil.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFaturaSil.ForeColor = System.Drawing.Color.White;
            this.btnFaturaSil.Location = new System.Drawing.Point(185, 184);
            this.btnFaturaSil.Name = "btnFaturaSil";
            this.btnFaturaSil.Size = new System.Drawing.Size(128, 31);
            this.btnFaturaSil.TabIndex = 17;
            this.btnFaturaSil.Text = "Sil";
            this.btnFaturaSil.UseVisualStyleBackColor = false;
            this.btnFaturaSil.Click += new System.EventHandler(this.btnFaturaSil_Click);
            // 
            // txtInternet
            // 
            this.txtInternet.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtInternet.ForeColor = System.Drawing.Color.Black;
            this.txtInternet.Location = new System.Drawing.Point(133, 150);
            this.txtInternet.Name = "txtInternet";
            this.txtInternet.Size = new System.Drawing.Size(180, 28);
            this.txtInternet.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(47, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "İnternet :";
            // 
            // btnFaturaKaydet
            // 
            this.btnFaturaKaydet.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFaturaKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnFaturaKaydet.Location = new System.Drawing.Point(51, 184);
            this.btnFaturaKaydet.Name = "btnFaturaKaydet";
            this.btnFaturaKaydet.Size = new System.Drawing.Size(128, 31);
            this.btnFaturaKaydet.TabIndex = 14;
            this.btnFaturaKaydet.Text = "Kaydet";
            this.btnFaturaKaydet.UseVisualStyleBackColor = true;
            this.btnFaturaKaydet.Click += new System.EventHandler(this.btnFaturaKaydet_Click);
            // 
            // txtSu
            // 
            this.txtSu.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSu.ForeColor = System.Drawing.Color.Black;
            this.txtSu.Location = new System.Drawing.Point(133, 116);
            this.txtSu.Name = "txtSu";
            this.txtSu.Size = new System.Drawing.Size(180, 28);
            this.txtSu.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(89, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Su :";
            // 
            // txtElektrik
            // 
            this.txtElektrik.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtElektrik.ForeColor = System.Drawing.Color.Black;
            this.txtElektrik.Location = new System.Drawing.Point(133, 82);
            this.txtElektrik.Name = "txtElektrik";
            this.txtElektrik.Size = new System.Drawing.Size(180, 28);
            this.txtElektrik.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(52, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Elektrik :";
            // 
            // faturalarBindingSource
            // 
            this.faturalarBindingSource.DataMember = "Faturalar";
            // 
            // faturalarBindingSource1
            // 
            this.faturalarBindingSource1.DataMember = "Faturalar";
            // 
            // stoklarBindingSource1
            // 
            this.stoklarBindingSource1.DataMember = "Stoklar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stokidDataGridViewTextBoxColumn,
            this.gidaDataGridViewTextBoxColumn,
            this.icecekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stoklarBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(335, 150);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // stokidDataGridViewTextBoxColumn
            // 
            this.stokidDataGridViewTextBoxColumn.DataPropertyName = "stokid";
            this.stokidDataGridViewTextBoxColumn.HeaderText = "stokid";
            this.stokidDataGridViewTextBoxColumn.Name = "stokidDataGridViewTextBoxColumn";
            this.stokidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gidaDataGridViewTextBoxColumn
            // 
            this.gidaDataGridViewTextBoxColumn.DataPropertyName = "gida";
            this.gidaDataGridViewTextBoxColumn.HeaderText = "gida";
            this.gidaDataGridViewTextBoxColumn.Name = "gidaDataGridViewTextBoxColumn";
            // 
            // icecekDataGridViewTextBoxColumn
            // 
            this.icecekDataGridViewTextBoxColumn.DataPropertyName = "icecek";
            this.icecekDataGridViewTextBoxColumn.HeaderText = "icecek";
            this.icecekDataGridViewTextBoxColumn.Name = "icecekDataGridViewTextBoxColumn";
            // 
            // stoklarBindingSource2
            // 
            this.stoklarBindingSource2.DataMember = "Stoklar";
            this.stoklarBindingSource2.DataSource = this.pansiyonKayitDBDataSet;
            // 
            // pansiyonKayitDBDataSet
            // 
            this.pansiyonKayitDBDataSet.DataSetName = "PansiyonKayitDBDataSet";
            this.pansiyonKayitDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.faturaidDataGridViewTextBoxColumn,
            this.elektrikDataGridViewTextBoxColumn,
            this.suDataGridViewTextBoxColumn,
            this.internetDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.faturalarBindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(353, 272);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(422, 150);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // faturaidDataGridViewTextBoxColumn
            // 
            this.faturaidDataGridViewTextBoxColumn.DataPropertyName = "faturaid";
            this.faturaidDataGridViewTextBoxColumn.HeaderText = "faturaid";
            this.faturaidDataGridViewTextBoxColumn.Name = "faturaidDataGridViewTextBoxColumn";
            this.faturaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // elektrikDataGridViewTextBoxColumn
            // 
            this.elektrikDataGridViewTextBoxColumn.DataPropertyName = "elektrik";
            this.elektrikDataGridViewTextBoxColumn.HeaderText = "elektrik";
            this.elektrikDataGridViewTextBoxColumn.Name = "elektrikDataGridViewTextBoxColumn";
            // 
            // suDataGridViewTextBoxColumn
            // 
            this.suDataGridViewTextBoxColumn.DataPropertyName = "su";
            this.suDataGridViewTextBoxColumn.HeaderText = "su";
            this.suDataGridViewTextBoxColumn.Name = "suDataGridViewTextBoxColumn";
            // 
            // internetDataGridViewTextBoxColumn
            // 
            this.internetDataGridViewTextBoxColumn.DataPropertyName = "internet";
            this.internetDataGridViewTextBoxColumn.HeaderText = "internet";
            this.internetDataGridViewTextBoxColumn.Name = "internetDataGridViewTextBoxColumn";
            // 
            // faturalarBindingSource2
            // 
            this.faturalarBindingSource2.DataMember = "Faturalar";
            this.faturalarBindingSource2.DataSource = this.pansiyonKayitDBDataSet1;
            // 
            // pansiyonKayitDBDataSet1
            // 
            this.pansiyonKayitDBDataSet1.DataSetName = "PansiyonKayitDBDataSet1";
            this.pansiyonKayitDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stoklarTableAdapter
            // 
            this.stoklarTableAdapter.ClearBeforeFill = true;
            // 
            // faturalarTableAdapter
            // 
            this.faturalarTableAdapter.ClearBeforeFill = true;
            // 
            // FrmStoklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(787, 434);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStoklar";
            this.Text = "Stoklar & Faturalar";
            this.Load += new System.EventHandler(this.FrmStoklar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stoklarBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faturalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturalarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoklarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoklarBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pansiyonKayitDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturalarBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pansiyonKayitDBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        //private PansiyonKayitDBDataSet pansiyonKayitDBDataSet;
        private System.Windows.Forms.BindingSource stoklarBindingSource;
        //private PansiyonKayitDBDataSetTableAdapters.StoklarTableAdapter stoklarTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStokKaydet;
        private System.Windows.Forms.TextBox txtIcecekler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGidalar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtInternet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFaturaKaydet;
        private System.Windows.Forms.TextBox txtSu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtElektrik;
        private System.Windows.Forms.Label label4;
        //private PansiyonKayitDBDataSet2 pansiyonKayitDBDataSet2;
        private System.Windows.Forms.BindingSource faturalarBindingSource;
        //private PansiyonKayitDBDataSet2TableAdapters.FaturalarTableAdapter faturalarTableAdapter;
        private System.Windows.Forms.Button btnFaturaSil;
        private System.Windows.Forms.TextBox txtStokid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFaturaid;
        private System.Windows.Forms.Label label6;
        //private PansiyonKayitDBDataSet3 pansiyonKayitDBDataSet3;
        private System.Windows.Forms.BindingSource stoklarBindingSource1;
        //private PansiyonKayitDBDataSet3TableAdapters.StoklarTableAdapter stoklarTableAdapter1;
        //private PansiyonKayitDBDataSet4 pansiyonKayitDBDataSet4;
        private System.Windows.Forms.BindingSource faturalarBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private PansiyonKayitDBDataSet pansiyonKayitDBDataSet;
        private System.Windows.Forms.BindingSource stoklarBindingSource2;
        private PansiyonKayitDBDataSetTableAdapters.StoklarTableAdapter stoklarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn icecekDataGridViewTextBoxColumn;
        private PansiyonKayitDBDataSet1 pansiyonKayitDBDataSet1;
        private System.Windows.Forms.BindingSource faturalarBindingSource2;
        private PansiyonKayitDBDataSet1TableAdapters.FaturalarTableAdapter faturalarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elektrikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internetDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnStokSil;
        //private PansiyonKayitDBDataSet4TableAdapters.FaturalarTableAdapter faturalarTableAdapter1;
    }
}