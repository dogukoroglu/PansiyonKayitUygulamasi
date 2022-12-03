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
using System.Reflection.Emit;

namespace PansiyonKayitUygulamasi
{
    public partial class FrmYeniMusteri : Form
    {

        public FrmMusteriler fry;

        public FrmYeniMusteri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-GPMKKC5N\\SQLEXPRESS;Initial Catalog=PansiyonKayitDB;Integrated Security=True");

        private void btnOda101_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "101";
            baglanti.Open();
            SqlCommand komut101 = new SqlCommand("insert into oda101(adi,soyadi) values (@p1,@p2)", baglanti);
            komut101.Parameters.AddWithValue("@p1", txtAd.Text);
            komut101.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut101.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda102_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "102";
            baglanti.Open();
            SqlCommand komut102 = new SqlCommand("insert into oda102(adi,soyadi) values (@p1,@p2)", baglanti);
            komut102.Parameters.AddWithValue("@p1", txtAd.Text);
            komut102.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut102.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda103_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "103";
            baglanti.Open();
            SqlCommand komut103 = new SqlCommand("insert into oda103(adi,soyadi) values (@p1,@p2)", baglanti);
            komut103.Parameters.AddWithValue("@p1", txtAd.Text);
            komut103.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut103.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda104_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "104";
            baglanti.Open();
            SqlCommand komut104 = new SqlCommand("insert into oda104(adi,soyadi) values (@p1,@p2)", baglanti);
            komut104.Parameters.AddWithValue("@p1", txtAd.Text);
            komut104.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut104.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda105_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "105";
            baglanti.Open();
            SqlCommand komut105 = new SqlCommand("insert into oda105(adi,soyadi) values (@p1,@p2)", baglanti);
            komut105.Parameters.AddWithValue("@p1", txtAd.Text);
            komut105.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut105.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda106_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "106";
            baglanti.Open();
            SqlCommand komut106 = new SqlCommand("insert into oda106(adi,soyadi) values (@p1,@p2)", baglanti);
            komut106.Parameters.AddWithValue("@p1", txtAd.Text);
            komut106.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut106.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda107_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "107";
            baglanti.Open();
            SqlCommand komut107 = new SqlCommand("insert into oda107(adi,soyadi) values (@p1,@p2)", baglanti);
            komut107.Parameters.AddWithValue("@p1", txtAd.Text);
            komut107.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut107.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda108_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "108";
            baglanti.Open();
            SqlCommand komut108 = new SqlCommand("insert into oda108(adi,soyadi) values (@p1,@p2)", baglanti);
            komut108.Parameters.AddWithValue("@p1", txtAd.Text);
            komut108.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut108.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda109_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "109";
            baglanti.Open();
            SqlCommand komut109 = new SqlCommand("insert into oda109(adi,soyadi) values (@p1,@p2)", baglanti);
            komut109.Parameters.AddWithValue("@p1", txtAd.Text);
            komut109.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut109.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli butonlar dolu odaları gösterir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renkli butonlar dolu odaları gösterir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void GunlukUcret()
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
        private void dtpCikis_ValueChanged(object sender, EventArgs e)
        {
            GunlukUcret();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komutKaydet = new SqlCommand("insert into MusteriEkle (adi,soyadi,cinsiyet,telefon,mail,tcno,odano,ucret,giristarihi,cikistarihi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", baglanti);
                komutKaydet.Parameters.AddWithValue("@p1", txtAd.Text);
                komutKaydet.Parameters.AddWithValue("@p2", txtSoyad.Text);
                komutKaydet.Parameters.AddWithValue("@p3", cmbCinsiyet.Text);
                komutKaydet.Parameters.AddWithValue("@p4", mskTelefon.Text);
                komutKaydet.Parameters.AddWithValue("@p5", txtMail.Text);
                komutKaydet.Parameters.AddWithValue("@p6", txtTc.Text);
                komutKaydet.Parameters.AddWithValue("@p7", txtOdano.Text);
                komutKaydet.Parameters.AddWithValue("@p8", Convert.ToDecimal(txtUcret.Text));
                komutKaydet.Parameters.AddWithValue("@p9", dtpGiris.Value.ToString("yyyy-MM-dd"));
                komutKaydet.Parameters.AddWithValue("@p10", dtpCikis.Value.ToString("yyyy-MM-dd"));
                komutKaydet.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Müşteri kaydı başarılı bir şekilde yapıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Müşteri kaydı başarısız, tekrar deneyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            // ODA 101
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                btnOda101.Text = oku1["adi"].ToString() + " " + oku1["soyadi"].ToString();
            }
            baglanti.Close();
            if (btnOda101.Text != "101")
            {
                btnOda101.BackColor = Color.Red;
                btnOda101.Enabled = false;
            }

            // ODA 102
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                btnOda102.Text = oku2["adi"].ToString() + " " + oku2["soyadi"].ToString();
            }
            baglanti.Close();
            if (btnOda102.Text != "102")
            {
                btnOda102.BackColor = Color.Red;
                btnOda102.Enabled = false;
            }

            // ODA 103
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                btnOda103.Text = oku3["adi"].ToString() + " " + oku3["soyadi"].ToString();
            }
            baglanti.Close();
            if (btnOda103.Text != "103")
            {
                btnOda103.BackColor = Color.Red;
                btnOda103.Enabled = false;
            }

            // ODA 104
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                btnOda104.Text = oku4["adi"].ToString() + " " + oku4["soyadi"].ToString();
            }
            baglanti.Close();
            if (btnOda104.Text != "104")
            {
                btnOda104.BackColor = Color.Red;
                btnOda104.Enabled = false;
            }

            // ODA 105
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                btnOda105.Text = oku5["adi"].ToString() + " " + oku5["soyadi"].ToString();
            }
            baglanti.Close();
            if (btnOda105.Text != "105")
            {
                btnOda105.BackColor = Color.Red;
                btnOda105.Enabled = false;
            }

            // ODA 106
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                btnOda106.Text = oku6["adi"].ToString() + " " + oku6["soyadi"].ToString();
            }
            baglanti.Close();
            if (btnOda106.Text != "106")
            {
                btnOda106.BackColor = Color.Red;
                btnOda106.Enabled = false;
            }

            // ODA 107
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                btnOda107.Text = oku7["adi"].ToString() + " " + oku7["soyadi"].ToString();
            }
            baglanti.Close();
            if (btnOda107.Text != "107")
            {
                btnOda107.BackColor = Color.Red;
                btnOda107.Enabled = false;
            }

            // ODA 108
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from oda108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();
            while (oku8.Read())
            {
                btnOda108.Text = oku8["adi"].ToString() + " " + oku8["soyadi"].ToString();
            }
            baglanti.Close();
            if (btnOda108.Text != "108")
            {
                btnOda108.BackColor = Color.Red;
                btnOda108.Enabled = false;
            }

            // ODA 109
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from oda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();
            while (oku9.Read())
            {
                btnOda109.Text = oku9["adi"].ToString() + " " + oku9["soyadi"].ToString();
            }
            baglanti.Close();
            if (btnOda109.Text != "109")
            {
                btnOda109.BackColor = Color.Red;
                btnOda109.Enabled = false;
            }
        }
    }
}
// Data Source=LAPTOP-GPMKKC5N\SQLEXPRESS;Initial Catalog=PansiyonKayitDB;Integrated Security=True
// satır 129 = burada veritabanında sütunun veritipi decimal olduğu için convert işlemi kullandık ve hata ortadan kalktı