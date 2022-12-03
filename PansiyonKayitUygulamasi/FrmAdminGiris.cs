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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-GPMKKC5N\\SQLEXPRESS;Initial Catalog=PansiyonKayitDB;Integrated Security=True");

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutGiris = new SqlCommand("select * from AdminGiris where kullaniciad=@user and sifre=@password", baglanti);
            komutGiris.Parameters.AddWithValue("@user", txtKullaniciAdi.Text);
            komutGiris.Parameters.AddWithValue("@password", txtSifre.Text);
            SqlDataReader oku = komutGiris.ExecuteReader();
            if (oku.Read())
            {
                FrmAnaForm frm = new FrmAnaForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Parola, tekrar deneyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKullaniciAdi.Clear();
                txtSifre.Clear();
            }
            baglanti.Close();
        }

        private void FrmAdminGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
