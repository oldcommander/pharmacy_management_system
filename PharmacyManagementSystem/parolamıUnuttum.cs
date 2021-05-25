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
using System.Net.Mail;
using System.Net;

namespace PharmacyManagementSystem
{
    public partial class parolamıUnuttum : Form
    {
        MySqlConnection baglan;
        public parolamıUnuttum()
        {
            InitializeComponent();
        }

        private void btnMailGönder_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdiP.Text == "" || txtKullaniciAdiP.Text == "Mail") 
            {
                MessageBox.Show("Gerekli Alanı Doldurunuz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

                string parola;

                while (dr.Read())
                {
                    if (txtKullaniciAdiP.Text == dr["email"].ToString())
                    {
                        SmtpClient sc = new SmtpClient();
                        sc.Port = 587;
                        sc.Host = "smtp.gmail.com";
                        sc.EnableSsl = true;
                        sc.Credentials = new NetworkCredential("tezkontrolsistemi@gmail.com", "tezkontrol");

                        // sistem için oluşturulmuş mail hesabından kullanıcının hesabına veritabanındaki parolası iletilecektir.

                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress("tezkontrolsistemi@gmail.com", "Eczane Yönetim Sistemi Parola Hatırlatma Servisi");
                        mail.To.Add(txtKullaniciAdiP.Text);
                        mail.IsBodyHtml = true;
                        parola = dr["Parola"].ToString();
                        mail.Body = "Parolanız: " + parola + " Lütfen Kimseyle Paylaşmayınız.";
                        mail.Subject = " Parola Hatırlatma ";
                        sc.Send(mail);
                        MessageBox.Show("Parolanız Mail Adresine İletilmiştir", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        ortakgirisformu ogf = new ortakgirisformu();
                        ogf.Show();
                        break;
                    }

                    MessageBox.Show("Lütfen Bilgilerinizi Kontrol Edin", "Hatalı Giriş!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                baglan.Close();
            }
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            ortakgirisformu ogf = new ortakgirisformu();
            this.Close();
            ogf.Show();
        }
    }
}
