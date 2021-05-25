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
using System.IO;
using Microsoft.Office.Interop.Word;

namespace PharmacyManagementSystem
{
    public partial class Fatura : Form
    {
        MySqlConnection baglan;
        MySqlDataAdapter da;

        String ilaçAdi;
        String miktar;
        String alışFiyatı;
        int toplam;

        public Fatura()
        {
            InitializeComponent();
        }

        private void txtGeri_Click(object sender, EventArgs e)
        {
            yönlendirmeFormu yf = new yönlendirmeFormu();
            yf.Show();
            this.Hide();

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtŞirketAdı.Text = gunaDataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            ilaçAdi = gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            miktar = gunaDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            alışFiyatı = gunaDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            toplam = Convert.ToInt32(alışFiyatı) * Convert.ToInt32(miktar);
        }

        void musteriGetir()
        {
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
                    da = new MySqlDataAdapter("SELECT *FROM ilaçstok", baglan);
                    var ds = new DataSet();
                    da.Fill(ds);
                    gunaDataGridView1.ReadOnly = true;
                    gunaDataGridView1.DataSource = ds.Tables[0];
                    baglan.Close();

                }
                catch (Exception hata)
                {
                    MessageBox.Show("Bağlantı Yapılamadı... Nedeni: \n" + hata.ToString(), "Hata :" + hata.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {

            string _path = "C:\\Users\\tr\\Desktop\\fatura.docx";
                if (!File.Exists(_path))
                {
                    System.Windows.Forms.MessageBox.Show("Dosya bulunamadı.");
                }
                else
                {
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                    object missing = System.Reflection.Missing.Value;
                    object readOnly = false;
                    object fileName = _path;

                    //+Word dosyamızı açıyoruz.
                    Document doc = wordApp.Documents.Open(ref fileName, ref missing, ref readOnly, ref readOnly,
                    ref missing, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing, ref missing);

                    //Aktif sayfayı açıyoruz.
                    doc.Activate();

                    //word dosyası ekrana çıkartılır
                    wordApp.Visible = true;
                    //-


                    object bookMarksName = "sirketadi";
                doc.Bookmarks.get_Item(ref bookMarksName).Range.Text = txtŞirketAdı.Text;

                    object bookMarksSoyadi = "ilacadi";
                doc.Bookmarks.get_Item(ref bookMarksSoyadi).Range.Text = ilaçAdi;

                    object bookMarksEmail = "miktar";
                doc.Bookmarks.get_Item(ref bookMarksEmail).Range.Text = miktar;

                    object bookMarksAciklama = "alisfiyati";
                doc.Bookmarks.get_Item(ref bookMarksAciklama).Range.Text = alışFiyatı;

                    object bookMarksToplam = "toplam";
                doc.Bookmarks.get_Item(ref bookMarksToplam).Range.Text = toplam.ToString();


                //-

                ////Kaydedilir ve otomatik olarak çıkılır.
                ////Dosya kaydedilir.
                //doc.SaveAs2(ref fileName);
                ////Dosya kapatılır.
                //doc.Close(ref missing, ref missing, ref missing);
                //doc = null;
                ////Word uygulaması kapatılır
                //wordApp.Quit(ref missing, ref missing, ref missing);
                //wordApp = null;
            }
            }

        private void Fatura_Load(object sender, EventArgs e)
        {
            musteriGetir();
        }
    }
    }
    

