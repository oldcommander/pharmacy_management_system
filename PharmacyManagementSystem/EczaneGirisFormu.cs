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
    public partial class EczaneGirisFormu : Form
    {
        public EczaneGirisFormu()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            parolamıUnuttum pu = new parolamıUnuttum();
            this.Hide();
                pu.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            EczaneEkrani eek = new EczaneEkrani();
            this.Hide();
            eek.Show();
        }
    }
}
