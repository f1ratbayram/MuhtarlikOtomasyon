using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuhtarlıkPerformans
{
    public partial class medeni : Form
    {

        public medeni()
        {
            InitializeComponent();
        }
        medeniKodlar kod = new medeniKodlar();
        private void medeni_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = kod.Getir();
            
        }

        private void checkEvli_CheckedChanged(object sender, EventArgs e)
        {
            txtCocukSayi.Enabled = true;
            
           
          

        }

        private void checkBekar_CheckedChanged(object sender, EventArgs e)
        {
            txtCocukSayi.Enabled = false;
            txtCocukSayi.Text = "";
          
           
        }

        private void checkVar_CheckedChanged(object sender, EventArgs e)
        {
            txtCocukSayi.Enabled = true;
           
        }

        private void checkYok_CheckedChanged(object sender, EventArgs e)
        {
            txtCocukSayi.Enabled = false;
          
            txtCocukSayi.Text = "0";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            kod.TcKimlik = txtTc.Text;
            kod.Adi = txtAdi.Text;
            kod.Soyadi = txtSoyadi.Text;          
            kod.MedeniDurum = txtMedeniDurum.Text;
            kod.CocukSayisi = txtCocukSayi.Text;


            kod.kaydet();
            MessageBox.Show("Kayıt İşlemi Başarılı", "Çamlıca Mahallesi Muhtarlığı");
            dataGridView1.DataSource = kod.Getir();

            txtTc.Text = "";
            txtAdi.Text = "";
            txtSoyadi.Text = "";
            txtMedeniDurum.Text = "";

            txtCocukSayi.Text = "";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            kod.TcKimlik = txtTc.Text;
            kod.Adi = txtAdi.Text;
            kod.Soyadi = txtSoyadi.Text;
            kod.MedeniDurum = txtMedeniDurum.Text;
            kod.CocukSayisi = txtCocukSayi.Text;


            kod.guncelle();
            MessageBox.Show("Güncelleme İşlemi Başarılı", "Çamlıca Mahallesi Muhtarlığı");
            dataGridView1.DataSource = kod.Getir();

            txtTc.Text = "";
            txtAdi.Text = "";
            txtSoyadi.Text = "";
            txtMedeniDurum.Text = "";

            txtCocukSayi.Text = "";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            kod.TcKimlik = txtTc.Text;
            kod.Adi = txtAdi.Text;
            kod.Soyadi = txtSoyadi.Text;
            kod.MedeniDurum = txtMedeniDurum.Text;
            kod.CocukSayisi = txtCocukSayi.Text;


            kod.sil();
            MessageBox.Show("Güncelleme İşlemi Başarılı", "Çamlıca Mahallesi Muhtarlığı");
            dataGridView1.DataSource = kod.Getir();

            txtTc.Text = "";
            txtAdi.Text = "";
            txtSoyadi.Text = "";
            txtMedeniDurum.Text = "";

            txtCocukSayi.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtMedeniDurum.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtCocukSayi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
     
    }
}
