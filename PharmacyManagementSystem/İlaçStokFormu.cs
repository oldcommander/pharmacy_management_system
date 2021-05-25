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
    public partial class İlaçStokFormu : Form
    {
        MySqlConnection baglan;
        MySqlDataAdapter da;
        MySqlCommand komut;
        public İlaçStokFormu()
        {
            InitializeComponent();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtİlaçAdı.Text == "İlaç Adı" || txtİlaçAdı.Text == "" || txtSatışFiyatı.Text == "Satış Fiyatı" || txtSatışFiyatı.Text == "" ||
                txtAlışFiyatı.Text == "Alış Fiyatı" || txtAlışFiyatı.Text == "" || txtAdet.Text == "Adet" || txtAdet.Text == "" || cmbSirket.Text == "")
            {
                MessageBox.Show("Eksik Bilgi Girdiniz Lütfen Kontrol Edin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                this.DialogResult = DialogResult.OK;

                baglan.Open();
                string sorgu = "INSERT INTO ilaçstok (ilaçAdı,alışFiyatı,satışFiyatı,adet,şirketAdı,tarih) VALUES" +
                        " (@ilaçAdı,@alışFiyatı,@satışFiyatı,@adet,@şirketAdı,@tarih)";
                komut = new MySqlCommand(sorgu, baglan);
                komut.Parameters.AddWithValue("@ilaçAdı", txtİlaçAdı.Text);
                komut.Parameters.AddWithValue("@alışFiyatı", txtAlışFiyatı.Text);
                komut.Parameters.AddWithValue("@satışFiyatı", txtSatışFiyatı.Text);
                komut.Parameters.AddWithValue("@adet", txtAdet.Text);
                komut.Parameters.AddWithValue("@şirketAdı", cmbSirket.Text);
                komut.Parameters.AddWithValue("@tarih", dtTarih.Value);
                MessageBox.Show("İlaç Başarılı Bir Şekilde Eklenmiştir", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


                komut.ExecuteNonQuery();
                baglan.Close();
                musteriGetir();

            }

        }



        private void İlaçStokFormu_Load(object sender, EventArgs e)
        {

            musteriGetir();
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


        private void gunaDataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtİlaçAdı.Text = gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtAlışFiyatı.Text = gunaDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtSatışFiyatı.Text = gunaDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtAdet.Text = gunaDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            cmbSirket.Text = gunaDataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            String sorgu = "UPDATE ilaçstok SET alışFiyatı=@alışFiyatı, satışFiyatı=@satışFiyatı, adet=@adet, şirketAdı=@şirketAdı,tarih=@tarih WHERE ilaçAdı=@ilaçAdı" ;
            komut = new MySqlCommand(sorgu, baglan);
            komut.Parameters.AddWithValue("@alışFiyatı", txtAlışFiyatı.Text);
            komut.Parameters.AddWithValue("@satışFiyatı", txtSatışFiyatı.Text);
            komut.Parameters.AddWithValue("@adet", txtAdet.Text);
            komut.Parameters.AddWithValue("@şirketAdı", cmbSirket.Text);
            komut.Parameters.AddWithValue("@tarih", dtTarih.Text);
            komut.Parameters.AddWithValue("@ilaçAdı", txtİlaçAdı.Text);
            
            komut.ExecuteNonQuery();
            MessageBox.Show("Güncelleme İşleminiz Tamalanmıştır","BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglan.Close();
            musteriGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            String sorgu = "DELETE FROM ilaçstok WHERE ilaçAdı=@ilaçAdı";
            komut = new MySqlCommand(sorgu, baglan);
            komut.Parameters.AddWithValue("@alışFiyatı", txtAlışFiyatı.Text);
            komut.Parameters.AddWithValue("@satışFiyatı", txtSatışFiyatı.Text);
            komut.Parameters.AddWithValue("@adet", txtAdet.Text);
            komut.Parameters.AddWithValue("@şirketAdı", cmbSirket.Text);
            komut.Parameters.AddWithValue("@tarih", dtTarih.Text);
            komut.Parameters.AddWithValue("@ilaçAdı", txtİlaçAdı.Text);

            komut.ExecuteNonQuery();
            MessageBox.Show("Silme İşleminiz Tamalanmıştır", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglan.Close();
            musteriGetir();

        }

        private void btnSil_MouseLeave(object sender, EventArgs e)
        {
            btnSil.BaseColor = Color.DimGray;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdet.Text = "Adet";
            txtAlışFiyatı.Text = "Alış Fiyatı";
            txtSatışFiyatı.Text = "Satış Fiyatı";
            txtİlaçAdı.Text = "İlaç Adı";
            cmbSirket.SelectedItem = null;
        }

        private void gunaButton2_Click(object sender, EventArgs e)
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
    }
}
