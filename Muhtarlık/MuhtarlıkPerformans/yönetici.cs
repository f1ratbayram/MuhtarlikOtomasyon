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
    public partial class yönetici : Form
    {
        public yönetici()
        {
            InitializeComponent();
        }

        private void yönetici_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ( MessageBox.Show("Askerlik işlemlerine yönlendirileceksiniz onaylıyormusunuz ?", "Çamlıca Mahallesi Muhtarlığı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                askerlik fr = new askerlik();
                fr.Show();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("İkametgah işlemlerine yönlendirileceksiniz onaylıyormusunuz ?", "Çamlıca Mahallesi Muhtarlığı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ikametgah fr = new ikametgah();
                fr.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Medeni Hal işlemlerine yönlendirileceksiniz onaylıyormusunuz ?", "Çamlıca Mahallesi Muhtarlığı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                medeni fr = new medeni();
                fr.Show();
            }
            
        }

       
    }
}
