using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuhtarlıkPerformans
{
    public partial class ikametgah : Form
    {
        public ikametgah()
        {
            InitializeComponent();
        }
        ikametgahKodlar kod = new ikametgahKodlar();


        private void ikametgah_Load(object sender, EventArgs e)
        {
            
            kod.TcKimlik = txtTc.Text;
            kod.Adi = txtAdi.Text;
            kod.Soyadi = txtSoyadi.Text;
            kod.İl = comboBox1.Text;
            kod.İlce = txtİlce.Text;
            kod.Mahalle = txtMahalle.Text;
            kod.CaddeSokak = txtCaddeSokak.Text;
            kod.DaireNo = txtDaireNo.Text;


            dataGridView1.DataSource = kod.Getir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtİlce.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtMahalle.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtCaddeSokak.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtDaireNo.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
          
            kod.TcKimlik = txtTc.Text;
            kod.Adi = txtAdi.Text;
            kod.Soyadi = txtSoyadi.Text;
            kod.İl = comboBox1.Text;
            kod.İlce = txtİlce.Text;
            kod.Mahalle = txtMahalle.Text;
            kod.CaddeSokak = txtCaddeSokak.Text;
            kod.DaireNo = txtDaireNo.Text;


            kod.kaydet();
            MessageBox.Show("Kayıt İşlemi Başarılı", "Çamlıca Mahallesi Muhtarlığı");
            dataGridView1.DataSource = kod.Getir();
            txtTc.Text = "";
            txtAdi.Text = "";
            txtSoyadi.Text = "";
            comboBox1.Text = "";
            txtİlce.Text = "";
            txtMahalle.Text = "";
            txtCaddeSokak.Text = "";
            txtDaireNo.Text = "";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
            kod.TcKimlik = txtTc.Text;
            kod.Adi = txtAdi.Text;
            kod.Soyadi = txtSoyadi.Text;
            kod.İl = comboBox1.Text;
            kod.İlce = txtİlce.Text;
            kod.Mahalle = txtMahalle.Text;
            kod.CaddeSokak = txtCaddeSokak.Text;
            kod.DaireNo = txtDaireNo.Text;

            kod.sil();
            MessageBox.Show("Silme İşlemi Başarılı", "Çamlıca Mahallesi Muhtarlığı");
            dataGridView1.DataSource = kod.Getir();

            txtTc.Text = "";
            txtAdi.Text = "";
            txtSoyadi.Text = "";
            comboBox1.Text = "";
            txtİlce.Text = "";
            txtMahalle.Text = "";
            txtCaddeSokak.Text = "";
            txtDaireNo.Text = "";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            kod.TcKimlik = txtTc.Text;
            kod.Adi = txtAdi.Text;
            kod.Soyadi = txtSoyadi.Text;
            kod.İl = comboBox1.Text;
            kod.İlce = txtİlce.Text;
            kod.Mahalle = txtMahalle.Text;
            kod.CaddeSokak = txtCaddeSokak.Text;
            kod.DaireNo = txtDaireNo.Text;

            kod.guncelle();
            MessageBox.Show("Güncelleme İşlemi Başarılı", "Çamlıca Mahallesi Muhtarlığı");
            dataGridView1.DataSource = kod.Getir();

            txtTc.Text = "";
            txtAdi.Text = "";
            txtSoyadi.Text = "";
            comboBox1.Text = "";
            txtİlce.Text = "";
            txtMahalle.Text = "";
            txtCaddeSokak.Text = "";
            txtDaireNo.Text = "";
        }
    }
}
