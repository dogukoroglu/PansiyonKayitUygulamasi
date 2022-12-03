using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PansiyonKayitUygulamasi
{
    public partial class FrmSifreGuncelle : Form
    {
        public FrmSifreGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-GPMKKC5N\\SQLEXPRESS;Initial Catalog=PansiyonKayitDB;Integrated Security=True");

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutGuncelle = new SqlCommand("update AdminGiris set kullaniciad=@p1,sifre=@p2 where id=@p3", baglanti);
            komutGuncelle.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            komutGuncelle.Parameters.AddWithValue("@p2", txtSifre.Text);
            komutGuncelle.Parameters.AddWithValue("@p3", txtAdminid.Text);
            komutGuncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Şifre başarılı bir şekilde güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.adminGirisTableAdapter.Fill(this.pansiyonKayitDBDataSet3.AdminGiris);
        }

        private void FrmSifreGuncelle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pansiyonKayitDBDataSet3.AdminGiris' table. You can move, or remove it, as needed.
            this.adminGirisTableAdapter.Fill(this.pansiyonKayitDBDataSet3.AdminGiris);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, kullaniciad, sifre;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            kullaniciad=dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            txtAdminid.Text = id;
            txtKullaniciAdi.Text = kullaniciad;
            txtSifre.Text = sifre;
        }
    }
}
