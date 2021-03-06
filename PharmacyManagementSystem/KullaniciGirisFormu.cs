using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PharmacyManagementSystem
{
    public partial class KullaniciGirisFormu : Form
    {
        MySqlConnection baglan;
        public KullaniciGirisFormu()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(txtKullaniciAdi.Text == "" || txtParola.Text == "" || txtKullaniciAdi.Text == "Kullanıcı Adı" || txtParola.Text == "Parola")
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz","DİKKAT!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }

            else
            {      

                //veritabanı bağlantısı gerekli veriler

                string _server = "localhost";
                string _dbname = "pharmacy";
                string _user = "root";
                string _password = "Kuleli172@";

                string MySQLbaglanti = $"SERVER={_server};DATABASE={_dbname};UID={_user};PWD={_password}";

                using (baglan = new MySqlConnection(MySQLbaglanti))
                {
                    try
                    {
                        baglan.Open();

                    }

                    // bağlantı hatası mesajı
                    catch (Exception hata)
                    {
                        MessageBox.Show("Bağlantı Yapılamadı... Nedeni: \n" + hata.ToString(), "Hata :" + hata.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

                baglan.Open();

                // veritabanındaki sistem için oluşturulan tablodaki verilere erişme

                MySqlCommand cmd = new MySqlCommand("SELECT*FROM yönetici_girişi", baglan);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (txtKullaniciAdi.Text == "admin" && txtParola.Text == dr["parola"].ToString())
                    {
                        yönlendirmeFormu yf = new yönlendirmeFormu();
                        yf.Show();
                        this.Hide();
                        break;
                    }
               
                      MessageBox.Show("Lütfen Bilgilerinizi Kontrol Ediniz!", "Hatalı Giriş!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                baglan.Close();
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            parolamıUnuttum prmu = new parolamıUnuttum();
            this.Hide();
            prmu.Show();
        }
    }
}
