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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-GPMKKC5N\\SQLEXPRESS;Initial Catalog=PansiyonKayitDB;Integrated Security=True");

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pansiyonKayitDBDataSet2.MusteriEkle' table. You can move, or remove it, as needed.
            this.musteriEkleTableAdapter.Fill(this.pansiyonKayitDBDataSet2.MusteriEkle);
        }
        void Listele()
        {
            this.musteriEkleTableAdapter.Fill(this.pansiyonKayitDBDataSet2.MusteriEkle);
        }

        void Temizle()
        {
            txtMusteriId.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            cmbCinsiyet.Text = "";
            mskTelefon.Clear();
            txtMail.Clear();
            txtTc.Clear();
            txtOdano.Clear();
            txtUcret.Clear();
            dtpGiris.Text = "";
            dtpCikis.Text = "";
            txtMusteriId.Focus();
        }

        void GunlukUcret2()
        {
            double ucret, gunlukUcret;
            gunlukUcret = 50;
            DateTime kucukTarih = Convert.ToDateTime(dtpGiris.Text);
            DateTime buyukTarih = Convert.ToDateTime(dtpCikis.Text);

            TimeSpan sonuc = buyukTarih - kucukTarih;

            label11.Text = sonuc.TotalDays.ToString();

            ucret = Convert.ToInt32(label11.Text) * gunlukUcret;
            if (chkOgrenci.Checked == true)
            {
                ucret = ucret - (ucret * 0.25);
                txtUcret.Text = ucret.ToString();
            }
            else if (chkCocuk.Checked == true)
            {
                ucret = ucret - (ucret * 0.5);
                txtUcret.Text = ucret.ToString();
            }
            else if (chkBebek.Checked == true)
            {
                ucret = ucret - (ucret * 0.75);
                txtUcret.Text = ucret.ToString();
            }
            else
            {
                txtUcret.Text = ucret.ToString();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtMusteriId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbCinsiyet.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskTelefon.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtMail.Text= dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtTc.Text= dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtOdano.Text= dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txtUcret.Text= dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            dtpGiris.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            dtpCikis.Text= dataGridView1.Rows[secilen].Cells[10].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutSil = new SqlCommand("delete from MusteriEkle where musteriid=@p1", baglanti);
            komutSil.Parameters.AddWithValue("@p1", txtMusteriId.Text);
            komutSil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri kaydı başarılı bir şekilde silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komutGuncelle = new SqlCommand("update MusteriEkle set adi=@p1,soyadi=@p2,cinsiyet=@p3,telefon=@p4,mail=@p5,tcno=@p6,odano=@p7,ucret=@p8,giristarihi=@p9,cikistarihi=@p10 where musteriid=@p11", baglanti);
                komutGuncelle.Parameters.AddWithValue("@p1", txtAd.Text);
                komutGuncelle.Parameters.AddWithValue("@p2", txtSoyad.Text);
                komutGuncelle.Parameters.AddWithValue("@p3", cmbCinsiyet.Text);
                komutGuncelle.Parameters.AddWithValue("@p4", mskTelefon.Text);
                komutGuncelle.Parameters.AddWithValue("@p5", txtMail.Text);
                komutGuncelle.Parameters.AddWithValue("@p6", txtTc.Text);
                komutGuncelle.Parameters.AddWithValue("@p7", txtOdano.Text);
                komutGuncelle.Parameters.AddWithValue("@p8", Convert.ToDecimal(txtUcret.Text));
                komutGuncelle.Parameters.AddWithValue("@p9", dtpGiris.Value.ToString("yyyy-MM-dd"));
                komutGuncelle.Parameters.AddWithValue("@p10", dtpCikis.Value.ToString("yyyy-MM-dd"));
                komutGuncelle.Parameters.AddWithValue("@p11", txtMusteriId.Text);
                komutGuncelle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Müşteri kaydı başarılı bir şekilde güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                Temizle();
            }
            catch (Exception)
            {
                MessageBox.Show("Müşteri kaydı güncellenemedi, lütfen tekrar deneyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpCikis_ValueChanged(object sender, EventArgs e)
        {
            GunlukUcret2();
        }
    }
}
