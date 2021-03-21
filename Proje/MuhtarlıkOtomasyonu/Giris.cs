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
    public partial class muhtarlikGiris : Form
    {
        public muhtarlikGiris()
        {
            InitializeComponent();
        }

        private void muhtarlikGiris_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int random = rnd.Next(1000, 10000);
            lblDogrulama.Text = random.ToString();
            btnSifreUnuttum.Enabled = false;
            txtDogrulama.Text = lblDogrulama.Text;
        }

        private void btnMuhtar_Click(object sender, EventArgs e)
        {
            if (txtYönetici.Text=="1524" && lblDogrulama.Text==txtDogrulama.Text)
            {
                yönetici fr = new yönetici();
                fr.Show();
                btnSifreUnuttum.Enabled = false;
                txtYönetici.Text = "";
               
            }
            else if (txtYönetici.Text == "" && txtDogrulama.Text =="")
            {
                MessageBox.Show("Şifre Veya Doğrulama Kodunu Boş Bıraktınız , Lütfen Kontrol Edip Tekrar Deneyiniz..", "Çamlıca Muhtarlığı");
            }
            else 
            {
                MessageBox.Show("Şifre Veya Doğrulama Kodu Yanlış , Lütfen Tekrar Deneyiniz..","Çamlıca Muhtarlığı");
                btnSifreUnuttum.Enabled = true;
                txtYönetici.Text = "";
              

            }
            
            
           
        }

      

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/f1ratbayram/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/f1ratbayram");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/firatbayram/");
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSifreUnuttum_Click(object sender, EventArgs e)
        {
            sifre fr = new sifre();
            fr.Show();
        }
    }
}
