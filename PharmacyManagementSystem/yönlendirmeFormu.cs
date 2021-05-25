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
    public partial class yönlendirmeFormu : Form
    {
        public yönlendirmeFormu()
        {
            InitializeComponent();
        }

        private void btnİlaçStok_Click(object sender, EventArgs e)
        {
            İlaçStokFormu isf = new İlaçStokFormu();
            this.Hide();
            isf.Show();
        }

        private void btnŞirketler_Click(object sender, EventArgs e)
        {
            şirketler s = new şirketler();
            s.Show();
            this.Hide();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            personelBilgisi pb = new personelBilgisi();
            this.Hide();
            pb.Show();
        }

        private void gunaImageButton3_Click(object sender, EventArgs e)
        {
            ortakgirisformu ogf = new ortakgirisformu();
            ogf.Show();
            this.Close();
        }

        private void btnFatura_Click(object sender, EventArgs e)
        {
            Fatura f = new Fatura();
            f.Show();
            this.Hide();
        }
    }
}
