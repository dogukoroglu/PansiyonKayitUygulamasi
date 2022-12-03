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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-GPMKKC5N\\SQLEXPRESS;Initial Catalog=PansiyonKayitDB;Integrated Security=True");

        void stokListele()
        {
            this.stoklarTableAdapter.Fill(this.pansiyonKayitDBDataSet.Stoklar);
        }

        void faturaListele()
        {
            this.faturalarTableAdapter.Fill(this.pansiyonKayitDBDataSet1.Faturalar);
        }
        void veriEkleme1()
        {
            // Stoklara veri girişi 
            baglanti.Open();
            SqlCommand komutEkle1 = new SqlCommand("insert into Stoklar(gida,icecek) values (@s1,@s2)", baglanti);
            komutEkle1.Parameters.AddWithValue("@s1", txtGidalar.Text);
            komutEkle1.Parameters.AddWithValue("@s2", txtIcecekler.Text);
            komutEkle1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt başarılı bir şekilde eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            stokListele();
        }

        void veriEkleme2()
        {
            // Faturalara veri girişi yapma
            baglanti.Open();
            SqlCommand komutEkle2 = new SqlCommand("insert into Faturalar(elektrik,su,internet) values (@f1,@f2,@f3)", baglanti);
            komutEkle2.Parameters.AddWithValue("@f1", txtElektrik.Text);
            komutEkle2.Parameters.AddWithValue("@f2", txtSu.Text);
            komutEkle2.Parameters.AddWithValue("@f3", txtInternet.Text);
            komutEkle2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt başarılı bir şekilde eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            faturaListele();
        }

        void veriSilme1()
        {
            // Stoklardaki verileri id'e göre silme işlemi
            baglanti.Open();
            SqlCommand komutSil1 = new SqlCommand("delete from Stoklar where stokid=@stk1", baglanti);
            komutSil1.Parameters.AddWithValue("@stk1", txtStokid.Text);
            komutSil1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Stok kaydı başarılı bir şekilde silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            stokListele();
        }

        void veriSilme2()
        {
            // Faturalardaki verileri id'e göre silme işlemi
            baglanti.Open();
            SqlCommand komutSil2 = new SqlCommand("delete from Faturalar where faturaid=@ftr1", baglanti);
            komutSil2.Parameters.AddWithValue("@ftr1", txtFaturaid.Text);
            komutSil2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Fatura kaydı başarılı bir şekilde silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            faturaListele();
        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pansiyonKayitDBDataSet1.Faturalar' table. You can move, or remove it, as needed.
            this.faturalarTableAdapter.Fill(this.pansiyonKayitDBDataSet1.Faturalar);
            // TODO: This line of code loads data into the 'pansiyonKayitDBDataSet.Stoklar' table. You can move, or remove it, as needed.
            this.stoklarTableAdapter.Fill(this.pansiyonKayitDBDataSet.Stoklar);

        }
        private void btnFaturaKaydet_Click(object sender, EventArgs e)
        {
            veriEkleme2();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id,gida,icecek;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            gida = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            icecek = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtStokid.Text = id;
            txtGidalar.Text = gida;
            txtIcecekler.Text = icecek;

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, elektrik, su, internet;
            secilen = dataGridView2.SelectedCells[0].RowIndex;
            id = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            elektrik = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            su = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            internet = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
            txtFaturaid.Text = id;
            txtElektrik.Text = elektrik;
            txtSu.Text = su;
            txtInternet.Text = internet;
        }

        private void btnStokSil_Click(object sender, EventArgs e)
        {
            veriSilme1();
        }

        private void btnFaturaSil_Click(object sender, EventArgs e)
        {
            veriSilme2();
        }

        private void btnStokKaydet_Click_1(object sender, EventArgs e)
        {
            veriEkleme1();
        }
    }
}
