namespace PansiyonKayitUygulamasi
{
    partial class FrmMesajlar
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
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rchMesaj = new System.Windows.Forms.RichTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pansiyonKayitDBDataSet4 = new PansiyonKayitUygulamasi.PansiyonKayitDBDataSet4();
            this.mesajlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mesajlarTableAdapter = new PansiyonKayitUygulamasi.PansiyonKayitDBDataSet4TableAdapters.MesajlarTableAdapter();
            this.mesajidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pansiyonKayitDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesajlarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyad.Location = new System.Drawing.Point(127, 23);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(357, 28);
            this.txtAdSoyad.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 80;
            this.label1.Text = "Ad - Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 82;
            this.label2.Text = "Mesaj :";
            // 
            // rchMesaj
            // 
            this.rchMesaj.Location = new System.Drawing.Point(127, 57);
            this.rchMesaj.Name = "rchMesaj";
            this.rchMesaj.Size = new System.Drawing.Size(357, 169);
            this.rchMesaj.TabIndex = 83;
            this.rchMesaj.Text = "";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(377, 232);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(107, 35);
            this.btnKaydet.TabIndex = 84;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mesajidDataGridViewTextBoxColumn,
            this.adsoyadDataGridViewTextBoxColumn,
            this.mesajDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mesajlarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 303);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(506, 165);
            this.dataGridView1.TabIndex = 85;
            // 
            // pansiyonKayitDBDataSet4
            // 
            this.pansiyonKayitDBDataSet4.DataSetName = "PansiyonKayitDBDataSet4";
            this.pansiyonKayitDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mesajlarBindingSource
            // 
            this.mesajlarBindingSource.DataMember = "Mesajlar";
            this.mesajlarBindingSource.DataSource = this.pansiyonKayitDBDataSet4;
            // 
            // mesajlarTableAdapter
            // 
            this.mesajlarTableAdapter.ClearBeforeFill = true;
            // 
            // mesajidDataGridViewTextBoxColumn
            // 
            this.mesajidDataGridViewTextBoxColumn.DataPropertyName = "mesajid";
            this.mesajidDataGridViewTextBoxColumn.HeaderText = "mesajid";
            this.mesajidDataGridViewTextBoxColumn.Name = "mesajidDataGridViewTextBoxColumn";
            // 
            // adsoyadDataGridViewTextBoxColumn
            // 
            this.adsoyadDataGridViewTextBoxColumn.DataPropertyName = "adsoyad";
            this.adsoyadDataGridViewTextBoxColumn.HeaderText = "adsoyad";
            this.adsoyadDataGridViewTextBoxColumn.Name = "adsoyadDataGridViewTextBoxColumn";
            // 
            // mesajDataGridViewTextBoxColumn
            // 
            this.mesajDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mesajDataGridViewTextBoxColumn.DataPropertyName = "mesaj";
            this.mesajDataGridViewTextBoxColumn.HeaderText = "mesaj";
            this.mesajDataGridViewTextBoxColumn.Name = "mesajDataGridViewTextBoxColumn";
            // 
            // FrmMesajlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(530, 480);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.rchMesaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMesajlar";
            this.Text = "FrmMesajlar";
            this.Load += new System.EventHandler(this.FrmMesajlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pansiyonKayitDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesajlarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rchMesaj;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PansiyonKayitDBDataSet4 pansiyonKayitDBDataSet4;
        private System.Windows.Forms.BindingSource mesajlarBindingSource;
        private PansiyonKayitDBDataSet4TableAdapters.MesajlarTableAdapter mesajlarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesajidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesajDataGridViewTextBoxColumn;
    }
}