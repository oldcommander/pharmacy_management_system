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
using Excel = Microsoft.Office.Interop.Excel;

namespace PharmacyManagementSystem
{
    public partial class personelBilgisi : Form
    {
        MySqlConnection baglan;
        MySqlCommand komut;
        MySqlDataAdapter da;
        public personelBilgisi()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtPersonelAdı.Text == "Personel Adı" || txtPersonelAdı.Text == "" || txtTelefon.Text == "Telefon" || txtTelefon.Text == "" ||
               txtMaaş.Text == "Maaş" || txtMaaş.Text == "" || txtUnvan.Text == "Unvan" || txtUnvan.Text == "")
            {
                MessageBox.Show("Eksik Bilgi Girdiniz Lütfen Kontrol Edin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                this.DialogResult = DialogResult.OK;

                baglan.Open();
                string sorgu = "INSERT INTO personelbilgi (personelAdı,maaş,telefon,unvanı) VALUES" +
                        " (@personelAdı,@maaş,@telefon,@unvanı)";
                komut = new MySqlCommand(sorgu, baglan);
                komut.Parameters.AddWithValue("@personelAdı", txtPersonelAdı.Text);
                komut.Parameters.AddWithValue("@maaş", txtMaaş.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@unvanı", txtUnvan.Text);

                MessageBox.Show("Personel Başarılı Bir Şekilde Eklenmiştir", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
                    da = new MySqlDataAdapter("SELECT *FROM personelbilgi", baglan);
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

        private void personelBilgisi_Load(object sender, EventArgs e)
        {
            musteriGetir();
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPersonelAdı.Text = gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtMaaş.Text = gunaDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtTelefon.Text = gunaDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtUnvan.Text = gunaDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            String sorgu = "UPDATE personelbilgi SET maaş=@maaş, telefon=@telefon, unvanı=@unvanı WHERE personelAdı=@personelAdı";
            komut = new MySqlCommand(sorgu, baglan);
            komut.Parameters.AddWithValue("@personelAdı", txtPersonelAdı.Text);
            komut.Parameters.AddWithValue("@maaş", txtMaaş.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@unvanı", txtUnvan.Text);

            komut.ExecuteNonQuery();
            MessageBox.Show("Güncelleme İşleminiz Tamalanmıştır", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglan.Close();
            musteriGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            String sorgu = "DELETE FROM personelbilgi WHERE personelAdı=@personelAdı";
            komut = new MySqlCommand(sorgu, baglan);
            komut.Parameters.AddWithValue("@personelAdı", txtPersonelAdı.Text);
            komut.Parameters.AddWithValue("@maaş", txtMaaş.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@unvanı", txtUnvan.Text);

            komut.ExecuteNonQuery();
            MessageBox.Show("Silme İşleminiz Tamalanmıştır", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglan.Close();
            musteriGetir();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtPersonelAdı.Text = "Personel Adı";
            txtMaaş.Text = "Maaş";
            txtTelefon.Text = "Telefon";
            txtUnvan.Text = "Unvan";
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

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtUnvan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaaş_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPersonelAdı_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
