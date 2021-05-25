using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class ortakgirisformu : Form
    {
        public ortakgirisformu()
        {
            InitializeComponent();
        }

        private void btntoptan_Click(object sender, EventArgs e)
        {
            KullaniciGirisFormu kgf = new KullaniciGirisFormu();
            this.Hide();
            kgf.Show();
        }

        private void btntoptan2_Click(object sender, EventArgs e)
        {
            KullaniciGirisFormu kgf = new KullaniciGirisFormu();
            this.Hide();
            kgf.Show();
        }

        private void btnuretici2_Click(object sender, EventArgs e)
        {
            ÜreticiFirmaGirisFormu ufg = new ÜreticiFirmaGirisFormu();
            this.Hide();
            ufg.Show();
        }

        private void btnuretici_Click(object sender, EventArgs e)
        {
            ÜreticiFirmaGirisFormu ufg = new ÜreticiFirmaGirisFormu();
            this.Hide();
            ufg.Show();
        }

        private void btneczane2_Click(object sender, EventArgs e)
        {
            EczaneGirisFormu egf = new EczaneGirisFormu();
            this.Hide();
            egf.Show();
        }

        private void btneczane_Click(object sender, EventArgs e)
        {
            EczaneGirisFormu egf = new EczaneGirisFormu();
            this.Hide();
            egf.Show();
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
