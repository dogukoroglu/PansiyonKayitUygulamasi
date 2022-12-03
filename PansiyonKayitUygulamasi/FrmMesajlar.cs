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
    public partial class FrmMesajlar : Form
    {
        public FrmMesajlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-GPMKKC5N\\SQLEXPRESS;Initial Catalog=PansiyonKayitDB;Integrated Security=True");

        private void FrmMesajlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pansiyonKayitDBDataSet4.Mesajlar' table. You can move, or remove it, as needed.
            this.mesajlarTableAdapter.Fill(this.pansiyonKayitDBDataSet4.Mesajlar);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutEkle = new SqlCommand("insert into Mesajlar(adsoyad,mesaj) values (@p1,@p2)", baglanti);
            komutEkle.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
            komutEkle.Parameters.AddWithValue("@p2", rchMesaj.Text);
            komutEkle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Mesaj başarılı bir şekilde kayıt edildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.mesajlarTableAdapter.Fill(this.pansiyonKayitDBDataSet4.Mesajlar);
        }
    }
}
