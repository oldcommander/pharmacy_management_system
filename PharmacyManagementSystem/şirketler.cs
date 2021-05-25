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
    public partial class şirketler : Form
    {
        MySqlConnection baglan;
        MySqlDataAdapter da;
        MySqlCommand komut;
        public şirketler()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtşirketID.Text == "Şirket ID" || txtşirketID.Text == "" || txtTelefon.Text == "Telefon" || txtTelefon.Text == "" ||
              txtşirketAdı.Text == "Şirket Adı" || txtşirketAdı.Text == "" || txtAdres.Text == "Adres" || txtAdres.Text == ""
              || txtmail.Text=="Mail" || txtmail.Text=="" || txtparola.Text=="Parola" || txtparola.Text=="")
            {
                MessageBox.Show("Eksik Bilgi Girdiniz Lütfen Kontrol Edin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                this.DialogResult = DialogResult.OK;

                baglan.Open();
                string sorgu = "INSERT INTO şirketler (şirketID,şirketAdı,telefon,adres,mail,parola) VALUES" +
                        " (@şirketID,@şirketAdı,@telefon,@adres,@mail,@parola)";
                komut = new MySqlCommand(sorgu, baglan);
                komut.Parameters.AddWithValue("@şirketID", txtşirketID.Text);
                komut.Parameters.AddWithValue("@şirketAdı", txtşirketAdı.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@adres", txtAdres.Text);
                komut.Parameters.AddWithValue("@mail", txtmail.Text);
                komut.Parameters.AddWithValue("@adres", txtparola.Text);

                MessageBox.Show("Şirket Başarılı Bir Şekilde Eklenmiştir", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


                komut.ExecuteNonQuery();
                baglan.Close();
                musteriGetir();

            }
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
                    da = new MySqlDataAdapter("SELECT *FROM şirketler", baglan);
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

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            String sorgu = "UPDATE şirketler SET şirketAdı=@şirketAdı, telefon=@telefon, adres=@adres, mail=@mail, parola=@parola WHERE şirketID=@şirketID";
            komut = new MySqlCommand(sorgu, baglan);
            komut.Parameters.AddWithValue("@şirketID", txtşirketID.Text);
            komut.Parameters.AddWithValue("@şirketAdı", txtşirketAdı.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@mail", txtmail.Text);
            komut.Parameters.AddWithValue("@parola", txtparola.Text);

            komut.ExecuteNonQuery();
            MessageBox.Show("Güncelleme İşleminiz Tamamlanmıştır", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglan.Close();
            musteriGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            baglan.Open();
            String sorgu = "DELETE FROM şirketler WHERE şirketID=@şirketID";
            komut = new MySqlCommand(sorgu, baglan);
            komut.Parameters.AddWithValue("@şirketID", txtşirketID.Text);
            komut.Parameters.AddWithValue("@şirketAdı", txtşirketAdı.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@mail", txtmail.Text);
            komut.Parameters.AddWithValue("@adres", txtparola.Text);

            komut.ExecuteNonQuery();
            MessageBox.Show("Silme İşleminiz Tamamlanmıştır", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglan.Close();
            musteriGetir();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtşirketID.Text = "Şirket ID";
            txtşirketAdı.Text = "Şirket Adı";
            txtTelefon.Text = "Telefon";
            txtAdres.Text = "Adres";
            txtmail.Text = "Mail";
            txtparola.Text = "Parola";
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            yönlendirmeFormu yf = new yönlendirmeFormu();
            this.Hide();
            yf.Show();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];

            int startCol = 1;
            int startRow = 1;
            for (int j = 0; j < gunaDataGridView1.Columns.Count; j++)
            {
                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[startRow, startCol + j];
                myRange.Value2 = gunaDataGridView1.Columns[j].HeaderText;
            }

            startRow++;

            for (int i = 0; i < gunaDataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < gunaDataGridView1.Columns.Count; j++)
                {


                    try
                    {
                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[startRow + i, startCol + j];
                        myRange.Value2 = gunaDataGridView1[j, i].Value == null ? "" : gunaDataGridView1[j, i].Value;
                    }
                    catch
                    {

                        MessageBox.Show("Hata");
                    }
                }
            }
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtşirketID.Text = gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtşirketAdı.Text = gunaDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtTelefon.Text = gunaDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtAdres.Text = gunaDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtmail.Text = gunaDataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtparola.Text = gunaDataGridView1.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void şirketler_Load(object sender, EventArgs e)
        {
            musteriGetir();
        }
    }
}
