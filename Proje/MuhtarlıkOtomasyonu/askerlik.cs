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
    public partial class askerlik : Form
    {
        public askerlik()
        {
            InitializeComponent();
        }
        askerlikKodlar kod = new askerlikKodlar();
        private void checkTamamlandi_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox1.Enabled = true;
            checkTamamlanmadi.Checked = false;
        }

        private void askerlik_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = kod.Getir();
        }

        private void checkTamamlanmadi_CheckedChanged(object sender, EventArgs e)
        {
            
            comboBox1.Enabled = false;
            checkTamamlandi.Checked = false;
            comboBox1.Text ="Yapılmadı";
           
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            kod.TcKimlik = txtTc.Text;
            kod.Adi = txtAdi.Text;
            kod.Soyadi = txtSoyadi.Text;
            if (checkTamamlandi.Checked)
            {
                kod.AskerlikDurumu = checkTamamlandi.Text;
            }
            else if (checkTamamlanmadi.Checked)
            {
                kod.AskerlikDurumu = checkTamamlanmadi.Text;
               
            }
            kod.AskerlikBölgesi = comboBox1.Text;


            kod.kaydet();
            MessageBox.Show("Kayıt İşlemi Başarılı", "Çamlıca Mahallesi Muhtarlığı");
            dataGridView1.DataSource = kod.Getir();

            txtTc.Text = "";
            txtAdi.Text = "";
            txtSoyadi.Text = "";
            checkTamamlandi.Checked = false;
            checkTamamlanmadi.Checked = false;
            comboBox1.Text = "";
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            kod.TcKimlik = txtTc.Text;
            kod.Adi = txtAdi.Text;
            kod.Soyadi = txtSoyadi.Text;
            if (checkTamamlandi.Checked)
            {
                kod.AskerlikDurumu = checkTamamlandi.Text;
            }
            else if (checkTamamlanmadi.Checked)
            {
                kod.AskerlikDurumu = checkTamamlanmadi.Text;

            }
            kod.AskerlikBölgesi = comboBox1.Text;


            kod.guncelle();
            MessageBox.Show("Güncelleme İşlemi Başarılı", "Çamlıca Mahallesi Muhtarlığı");
            dataGridView1.DataSource = kod.Getir();

            txtTc.Text = "";
            txtAdi.Text = "";
            txtSoyadi.Text = "";
            checkTamamlandi.Checked = false;
            checkTamamlanmadi.Checked = false;
            comboBox1.Text = "";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            kod.TcKimlik = txtTc.Text;
            kod.Adi = txtAdi.Text;
            kod.Soyadi = txtSoyadi.Text;
            if (checkTamamlandi.Checked)
            {
                kod.AskerlikDurumu = checkTamamlandi.Text;
            }
            else if (checkTamamlanmadi.Checked)
            {
                kod.AskerlikDurumu = checkTamamlanmadi.Text;

            }
            kod.AskerlikBölgesi = comboBox1.Text;


            kod.sil();
            MessageBox.Show("Silme İşlemi Başarılı", "Çamlıca Mahallesi Muhtarlığı");
            dataGridView1.DataSource = kod.Getir();

            txtTc.Text = "";
            txtAdi.Text = "";
            txtSoyadi.Text = "";
            checkTamamlandi.Checked = false;
            checkTamamlanmadi.Checked = false;
            comboBox1.Text = "";


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
          
        }
    }
}
