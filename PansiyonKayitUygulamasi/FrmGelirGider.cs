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
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-GPMKKC5N\\SQLEXPRESS;Initial Catalog=PansiyonKayitDB;Integrated Security=True");

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            // Kasadaki toplam tutar
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" select sum(ucret) as toplam from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblKasaToplam.Text = oku["toplam"].ToString();
            }
            baglanti.Close();

            // Gıdaların giderlerini toplama
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(gida) as toplam1 from Stoklar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                lblAlinanUrunler2.Text = oku2["toplam1"].ToString();
            }
            baglanti.Close();

            // İçeceklerin giderlerini toplama
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select sum(icecek) as toplam2 from Stoklar", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                lblAlinanUrunler3.Text = oku3["toplam2"].ToString();
            }
            baglanti.Close();

            // Elektrik giderlerini toplama
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select sum(elektrik) as toplam3 from Faturalar", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                lblFaturalar1.Text = oku4["toplam3"].ToString();
            }
            baglanti.Close();

            // Su giderlerini toplama
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select sum(su) as toplam4 from Faturalar", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                lblFaturalar2.Text = oku5["toplam4"].ToString();
            }
            baglanti.Close();

            // İnternet giderlerini toplama
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select sum(internet) as toplam5 from Faturalar", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                lblFaturalar3.Text = oku6["toplam5"].ToString();
            }
            baglanti.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int personel;
            personel = Convert.ToInt32(txtPersonelSayisi.Text);
            lblPersonelMaas.Text = (personel * 1500).ToString();

            double tplSonuc;
            tplSonuc = (Convert.ToDouble(lblKasaToplam.Text)) - (Convert.ToDouble(lblPersonelMaas.Text) + Convert.ToDouble(lblAlinanUrunler2.Text) + Convert.ToDouble(lblAlinanUrunler3.Text) + Convert.ToDouble(lblFaturalar1.Text) + Convert.ToDouble(lblFaturalar2.Text) + Convert.ToDouble(lblFaturalar3.Text));
            lblSonuc.Text = tplSonuc.ToString();
        }
    }
}
