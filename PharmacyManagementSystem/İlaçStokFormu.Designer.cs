namespace PharmacyManagementSystem
{
    partial class İlaçStokFormu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(İlaçStokFormu));
            this.txtİlaçAdı = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtAlışFiyatı = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtSatışFiyatı = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtAdet = new Guna.UI.WinForms.GunaLineTextBox();
            this.dtTarih = new Guna.UI.WinForms.GunaDateTimePicker();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.cmbSirket = new Guna.UI.WinForms.GunaComboBox();
            this.btnEkle = new Guna.UI.WinForms.GunaButton();
            this.btnGüncelle = new Guna.UI.WinForms.GunaButton();
            this.btnSil = new Guna.UI.WinForms.GunaButton();
            this.btnTemizle = new Guna.UI.WinForms.GunaButton();
            this.btnGeri = new Guna.UI.WinForms.GunaButton();
            this.btnExcel = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtİlaçAdı
            // 
            this.txtİlaçAdı.BackColor = System.Drawing.SystemColors.Control;
            this.txtİlaçAdı.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtİlaçAdı.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtİlaçAdı.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtİlaçAdı.ForeColor = System.Drawing.Color.Brown;
            this.txtİlaçAdı.LineColor = System.Drawing.Color.Brown;
            this.txtİlaçAdı.Location = new System.Drawing.Point(30, 117);
            this.txtİlaçAdı.Name = "txtİlaçAdı";
            this.txtİlaçAdı.PasswordChar = '\0';
            this.txtİlaçAdı.SelectedText = "";
            this.txtİlaçAdı.Size = new System.Drawing.Size(207, 45);
            this.txtİlaçAdı.TabIndex = 0;
            this.txtİlaçAdı.Text = "İlaç Adı";
            // 
            // txtAlışFiyatı
            // 
            this.txtAlışFiyatı.BackColor = System.Drawing.SystemColors.Control;
            this.txtAlışFiyatı.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAlışFiyatı.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAlışFiyatı.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlışFiyatı.ForeColor = System.Drawing.Color.Brown;
            this.txtAlışFiyatı.LineColor = System.Drawing.Color.Brown;
            this.txtAlışFiyatı.Location = new System.Drawing.Point(284, 117);
            this.txtAlışFiyatı.Name = "txtAlışFiyatı";
            this.txtAlışFiyatı.PasswordChar = '\0';
            this.txtAlışFiyatı.SelectedText = "";
            this.txtAlışFiyatı.Size = new System.Drawing.Size(211, 45);
            this.txtAlışFiyatı.TabIndex = 1;
            this.txtAlışFiyatı.Text = "Alış Fiyatı";
            // 
            // txtSatışFiyatı
            // 
            this.txtSatışFiyatı.BackColor = System.Drawing.SystemColors.Control;
            this.txtSatışFiyatı.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSatışFiyatı.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtSatışFiyatı.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatışFiyatı.ForeColor = System.Drawing.Color.Brown;
            this.txtSatışFiyatı.LineColor = System.Drawing.Color.Brown;
            this.txtSatışFiyatı.Location = new System.Drawing.Point(284, 208);
            this.txtSatışFiyatı.Name = "txtSatışFiyatı";
            this.txtSatışFiyatı.PasswordChar = '\0';
            this.txtSatışFiyatı.SelectedText = "";
            this.txtSatışFiyatı.Size = new System.Drawing.Size(211, 45);
            this.txtSatışFiyatı.TabIndex = 3;
            this.txtSatışFiyatı.Text = "Satış Fiyatı\r\n";
            // 
            // txtAdet
            // 
            this.txtAdet.BackColor = System.Drawing.SystemColors.Control;
            this.txtAdet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdet.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAdet.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdet.ForeColor = System.Drawing.Color.Brown;
            this.txtAdet.LineColor = System.Drawing.Color.Brown;
            this.txtAdet.Location = new System.Drawing.Point(284, 301);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.PasswordChar = '\0';
            this.txtAdet.SelectedText = "";
            this.txtAdet.Size = new System.Drawing.Size(211, 46);
            this.txtAdet.TabIndex = 5;
            this.txtAdet.Text = "Adet\r\n";
            // 
            // dtTarih
            // 
            this.dtTarih.BackColor = System.Drawing.Color.Transparent;
            this.dtTarih.BaseColor = System.Drawing.Color.Brown;
            this.dtTarih.BorderColor = System.Drawing.Color.Brown;
            this.dtTarih.CustomFormat = null;
            this.dtTarih.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtTarih.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtTarih.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTarih.ForeColor = System.Drawing.Color.White;
            this.dtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarih.Location = new System.Drawing.Point(30, 208);
            this.dtTarih.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtTarih.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtTarih.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtTarih.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtTarih.OnPressedColor = System.Drawing.Color.Black;
            this.dtTarih.Radius = 10;
            this.dtTarih.Size = new System.Drawing.Size(207, 45);
            this.dtTarih.TabIndex = 2;
            this.dtTarih.Text = "24.02.2021";
            this.dtTarih.Value = new System.DateTime(2021, 2, 24, 22, 9, 28, 96);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Brown;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(151, 21);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(264, 59);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "İlaç Stok\r\n";
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridView1.ColumnHeadersHeight = 27;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.Black;
            this.gunaDataGridView1.Location = new System.Drawing.Point(519, 35);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowTemplate.Height = 30;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(907, 658);
            this.gunaDataGridView1.TabIndex = 4;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Brown;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 27;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Brown;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 30;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellContentClick);
            this.gunaDataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellEnter);
            // 
            // cmbSirket
            // 
            this.cmbSirket.BackColor = System.Drawing.Color.Transparent;
            this.cmbSirket.BaseColor = System.Drawing.Color.White;
            this.cmbSirket.BorderColor = System.Drawing.Color.Silver;
            this.cmbSirket.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSirket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSirket.FocusedColor = System.Drawing.Color.Empty;
            this.cmbSirket.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSirket.ForeColor = System.Drawing.Color.Black;
            this.cmbSirket.FormattingEnabled = true;
            this.cmbSirket.Items.AddRange(new object[] {
            "Deva",
            "Abdiİbrahim",
            "Bayer",
            "Pfizer",
            "Sanovel",
            "Sandoz",
            "Santa Farma",
            "Bilim",
            "Ali Raif",
            "Abdica",
            "Abfen",
            "Akar Farma",
            "Pharma",
            "Intendis",
            "İsse",
            "Keymen",
            "Lokman",
            "Saraç",
            "Nutrifarma",
            "Şifa",
            "Sodhan",
            "Solgar"});
            this.cmbSirket.Location = new System.Drawing.Point(30, 316);
            this.cmbSirket.Name = "cmbSirket";
            this.cmbSirket.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbSirket.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbSirket.Size = new System.Drawing.Size(207, 31);
            this.cmbSirket.TabIndex = 4;
            // 
            // btnEkle
            // 
            this.btnEkle.AnimationHoverSpeed = 0.07F;
            this.btnEkle.AnimationSpeed = 0.03F;
            this.btnEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnEkle.BaseColor = System.Drawing.Color.Brown;
            this.btnEkle.BorderColor = System.Drawing.Color.Black;
            this.btnEkle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEkle.FocusedColor = System.Drawing.Color.Empty;
            this.btnEkle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Image = null;
            this.btnEkle.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEkle.Location = new System.Drawing.Point(41, 436);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.OnHoverBaseColor = System.Drawing.Color.Lime;
            this.btnEkle.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEkle.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnEkle.OnHoverImage = null;
            this.btnEkle.OnPressedColor = System.Drawing.Color.Black;
            this.btnEkle.Radius = 20;
            this.btnEkle.Size = new System.Drawing.Size(160, 42);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.AnimationHoverSpeed = 0.07F;
            this.btnGüncelle.AnimationSpeed = 0.03F;
            this.btnGüncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnGüncelle.BaseColor = System.Drawing.Color.DarkOrange;
            this.btnGüncelle.BorderColor = System.Drawing.Color.Black;
            this.btnGüncelle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGüncelle.FocusedColor = System.Drawing.Color.Empty;
            this.btnGüncelle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.ForeColor = System.Drawing.Color.White;
            this.btnGüncelle.Image = null;
            this.btnGüncelle.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGüncelle.Location = new System.Drawing.Point(301, 436);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.OnHoverBaseColor = System.Drawing.Color.DarkCyan;
            this.btnGüncelle.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGüncelle.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGüncelle.OnHoverImage = null;
            this.btnGüncelle.OnPressedColor = System.Drawing.Color.Black;
            this.btnGüncelle.Radius = 20;
            this.btnGüncelle.Size = new System.Drawing.Size(160, 42);
            this.btnGüncelle.TabIndex = 7;
            this.btnGüncelle.Text = "GÜNCELLE";
            this.btnGüncelle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.AnimationHoverSpeed = 0.07F;
            this.btnSil.AnimationSpeed = 0.03F;
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.BaseColor = System.Drawing.Color.DimGray;
            this.btnSil.BorderColor = System.Drawing.Color.Black;
            this.btnSil.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSil.FocusedColor = System.Drawing.Color.Empty;
            this.btnSil.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Image = null;
            this.btnSil.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSil.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSil.Location = new System.Drawing.Point(41, 545);
            this.btnSil.Name = "btnSil";
            this.btnSil.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnSil.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSil.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSil.OnHoverImage = null;
            this.btnSil.OnPressedColor = System.Drawing.Color.Black;
            this.btnSil.Radius = 20;
            this.btnSil.Size = new System.Drawing.Size(160, 42);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "SİL";
            this.btnSil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            this.btnSil.MouseLeave += new System.EventHandler(this.btnSil_MouseLeave);
            // 
            // btnTemizle
            // 
            this.btnTemizle.AnimationHoverSpeed = 0.07F;
            this.btnTemizle.AnimationSpeed = 0.03F;
            this.btnTemizle.BackColor = System.Drawing.Color.Transparent;
            this.btnTemizle.BaseColor = System.Drawing.Color.DarkMagenta;
            this.btnTemizle.BorderColor = System.Drawing.Color.Black;
            this.btnTemizle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTemizle.FocusedColor = System.Drawing.Color.Empty;
            this.btnTemizle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Image = null;
            this.btnTemizle.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTemizle.Location = new System.Drawing.Point(301, 545);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTemizle.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTemizle.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTemizle.OnHoverImage = null;
            this.btnTemizle.OnPressedColor = System.Drawing.Color.Black;
            this.btnTemizle.Radius = 20;
            this.btnTemizle.Size = new System.Drawing.Size(160, 42);
            this.btnTemizle.TabIndex = 9;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.AnimationHoverSpeed = 0.07F;
            this.btnGeri.AnimationSpeed = 0.03F;
            this.btnGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnGeri.BaseColor = System.Drawing.Color.Green;
            this.btnGeri.BorderColor = System.Drawing.Color.Black;
            this.btnGeri.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGeri.FocusedColor = System.Drawing.Color.Empty;
            this.btnGeri.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.ForeColor = System.Drawing.Color.White;
            this.btnGeri.Image = null;
            this.btnGeri.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGeri.Location = new System.Drawing.Point(301, 651);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGeri.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGeri.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGeri.OnHoverImage = null;
            this.btnGeri.OnPressedColor = System.Drawing.Color.Black;
            this.btnGeri.Radius = 20;
            this.btnGeri.Size = new System.Drawing.Size(160, 42);
            this.btnGeri.TabIndex = 11;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGeri.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.AnimationHoverSpeed = 0.07F;
            this.btnExcel.AnimationSpeed = 0.03F;
            this.btnExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.BackgroundImage")));
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcel.BaseColor = System.Drawing.Color.Transparent;
            this.btnExcel.BorderColor = System.Drawing.Color.Black;
            this.btnExcel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExcel.FocusedColor = System.Drawing.Color.Empty;
            this.btnExcel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Image = null;
            this.btnExcel.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExcel.Location = new System.Drawing.Point(41, 630);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnExcel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExcel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExcel.OnHoverImage = null;
            this.btnExcel.OnPressedColor = System.Drawing.Color.Black;
            this.btnExcel.Radius = 20;
            this.btnExcel.Size = new System.Drawing.Size(179, 80);
            this.btnExcel.TabIndex = 10;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // İlaçStokFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 722);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmbSirket);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.txtSatışFiyatı);
            this.Controls.Add(this.txtAlışFiyatı);
            this.Controls.Add(this.txtİlaçAdı);
            this.ForeColor = System.Drawing.Color.Brown;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "İlaçStokFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İlaç Stok Sayfası";
            this.Load += new System.EventHandler(this.İlaçStokFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLineTextBox txtİlaçAdı;
        private Guna.UI.WinForms.GunaLineTextBox txtAlışFiyatı;
        private Guna.UI.WinForms.GunaLineTextBox txtSatışFiyatı;
        private Guna.UI.WinForms.GunaLineTextBox txtAdet;
        private Guna.UI.WinForms.GunaDateTimePicker dtTarih;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private Guna.UI.WinForms.GunaComboBox cmbSirket;
        private Guna.UI.WinForms.GunaButton btnEkle;
        private Guna.UI.WinForms.GunaButton btnGüncelle;
        private Guna.UI.WinForms.GunaButton btnSil;
        private Guna.UI.WinForms.GunaButton btnTemizle;
        private Guna.UI.WinForms.GunaButton btnGeri;
        private Guna.UI.WinForms.GunaButton btnExcel;
    }
}