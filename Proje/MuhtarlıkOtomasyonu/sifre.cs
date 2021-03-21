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

namespace MuhtarlıkPerformans
{
    public partial class sifre : Form
    {
        public sifre()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-PLC6DRU\\SQLEXPRESS;Initial Catalog=Muhtarlikİslemleri;Integrated Security=True");
        public void connect()
        {

            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sifre;
            connect();
            SqlCommand command = new SqlCommand("SELECT * FROM password where tcKimlik='" + txtMuhtarTc.Text + "' AND anneKizlik='" + txtAnneKizlik.Text + "'", baglan);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                sifre = reader["sifre"].ToString();
                MessageBox.Show("Şifreniz : "+sifre,"Çamlıca Mahallesi Muhtarlığı");
                txtMuhtarTc.Text = "";
                txtAnneKizlik.Text = "";
            }
            else
            {
                MessageBox.Show("Tc Kimlik No Yada Anne Kızlık Soyadını Yanlış Girdiniz, Lütfen Tekrar Deneyiniz","Çamlıca Mahallesi Muhtarlığı");
            }
            baglan.Close();
        
        }

        private void sifre_Load(object sender, EventArgs e)
        {

        }
    }
}
