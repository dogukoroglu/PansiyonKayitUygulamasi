using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PansiyonKayitUygulamasi
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminGiris frmAdmin = new FrmAdminGiris();
            frmAdmin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri frmYeniMusteri = new FrmYeniMusteri();
            frmYeniMusteri.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMusteriler frmMusteriler = new FrmMusteriler();
            frmMusteriler.Show();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pansiyon Kayıt Uygulaması / 2022","Hakkımızda",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmOdalar frmOda = new FrmOdalar();
            frmOda.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmGelirGider frm = new FrmGelirGider();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmStoklar frm = new FrmStoklar();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmSifreGuncelle frm = new FrmSifreGuncelle();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmMesajlar frm = new FrmMesajlar();
            frm.Show();
        }
    }
}
