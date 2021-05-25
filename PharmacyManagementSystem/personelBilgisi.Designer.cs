namespace PharmacyManagementSystem
{
    partial class personelBilgisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personelBilgisi));
            this.btnGeri = new Guna.UI.WinForms.GunaButton();
            this.btnTemizle = new Guna.UI.WinForms.GunaButton();
            this.btnSil = new Guna.UI.WinForms.GunaButton();
            this.btnGüncelle = new Guna.UI.WinForms.GunaButton();
            this.btnEkle = new Guna.UI.WinForms.GunaButton();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtUnvan = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtMaaş = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtTelefon = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtPersonelAdı = new Guna.UI.WinForms.GunaLineTextBox();
            this.btnExcel = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.btnGeri.Location = new System.Drawing.Point(283, 655);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGeri.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGeri.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGeri.OnHoverImage = null;
            this.btnGeri.OnPressedColor = System.Drawing.Color.Black;
            this.btnGeri.Radius = 20;
            this.btnGeri.Size = new System.Drawing.Size(160, 42);
            this.btnGeri.TabIndex = 9;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
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
            this.btnTemizle.Location = new System.Drawing.Point(283, 536);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTemizle.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTemizle.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTemizle.OnHoverImage = null;
            this.btnTemizle.OnPressedColor = System.Drawing.Color.Black;
            this.btnTemizle.Radius = 20;
            this.btnTemizle.Size = new System.Drawing.Size(160, 42);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
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
            this.btnSil.Location = new System.Drawing.Point(32, 536);
            this.btnSil.Name = "btnSil";
            this.btnSil.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnSil.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSil.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSil.OnHoverImage = null;
            this.btnSil.OnPressedColor = System.Drawing.Color.Black;
            this.btnSil.Radius = 20;
            this.btnSil.Size = new System.Drawing.Size(160, 42);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "SİL";
            this.btnSil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
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
            this.btnGüncelle.Location = new System.Drawing.Point(283, 428);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.OnHoverBaseColor = System.Drawing.Color.DarkCyan;
            this.btnGüncelle.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGüncelle.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGüncelle.OnHoverImage = null;
            this.btnGüncelle.OnPressedColor = System.Drawing.Color.Black;
            this.btnGüncelle.Radius = 20;
            this.btnGüncelle.Size = new System.Drawing.Size(160, 42);
            this.btnGüncelle.TabIndex = 5;
            this.btnGüncelle.Text = "GÜNCELLE";
            this.btnGüncelle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
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
            this.btnEkle.Location = new System.Drawing.Point(32, 428);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.OnHoverBaseColor = System.Drawing.Color.Lime;
            this.btnEkle.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEkle.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnEkle.OnHoverImage = null;
            this.btnEkle.OnPressedColor = System.Drawing.Color.Black;
            this.btnEkle.Radius = 20;
            this.btnEkle.Size = new System.Drawing.Size(160, 42);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
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
            this.gunaDataGridView1.Location = new System.Drawing.Point(521, 12);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowTemplate.Height = 30;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(881, 734);
            this.gunaDataGridView1.TabIndex = 17;
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
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Brown;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(24, 40);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(463, 46);
            this.bunifuCustomLabel1.TabIndex = 16;
            this.bunifuCustomLabel1.Text = "Personel Bilgi Ekranı";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // txtUnvan
            // 
            this.txtUnvan.BackColor = System.Drawing.SystemColors.Control;
            this.txtUnvan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUnvan.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtUnvan.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUnvan.ForeColor = System.Drawing.Color.Brown;
            this.txtUnvan.LineColor = System.Drawing.Color.Brown;
            this.txtUnvan.Location = new System.Drawing.Point(266, 285);
            this.txtUnvan.Name = "txtUnvan";
            this.txtUnvan.PasswordChar = '\0';
            this.txtUnvan.SelectedText = "";
            this.txtUnvan.Size = new System.Drawing.Size(211, 46);
            this.txtUnvan.TabIndex = 3;
            this.txtUnvan.Text = "Unvanı";
            this.txtUnvan.TextChanged += new System.EventHandler(this.txtUnvan_TextChanged);
            // 
            // txtMaaş
            // 
            this.txtMaaş.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaaş.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaaş.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMaaş.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMaaş.ForeColor = System.Drawing.Color.Brown;
            this.txtMaaş.LineColor = System.Drawing.Color.Brown;
            this.txtMaaş.Location = new System.Drawing.Point(12, 285);
            this.txtMaaş.Name = "txtMaaş";
            this.txtMaaş.PasswordChar = '\0';
            this.txtMaaş.SelectedText = "";
            this.txtMaaş.Size = new System.Drawing.Size(211, 45);
            this.txtMaaş.TabIndex = 2;
            this.txtMaaş.Text = "Maaş";
            this.txtMaaş.TextChanged += new System.EventHandler(this.txtMaaş_TextChanged);
            // 
            // txtTelefon
            // 
            this.txtTelefon.BackColor = System.Drawing.SystemColors.Control;
            this.txtTelefon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefon.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTelefon.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefon.ForeColor = System.Drawing.Color.Brown;
            this.txtTelefon.LineColor = System.Drawing.Color.Brown;
            this.txtTelefon.Location = new System.Drawing.Point(266, 152);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.PasswordChar = '\0';
            this.txtTelefon.SelectedText = "";
            this.txtTelefon.Size = new System.Drawing.Size(211, 45);
            this.txtTelefon.TabIndex = 1;
            this.txtTelefon.Text = "Telefon";
            this.txtTelefon.TextChanged += new System.EventHandler(this.txtTelefon_TextChanged);
            // 
            // txtPersonelAdı
            // 
            this.txtPersonelAdı.BackColor = System.Drawing.SystemColors.Control;
            this.txtPersonelAdı.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPersonelAdı.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPersonelAdı.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelAdı.ForeColor = System.Drawing.Color.Brown;
            this.txtPersonelAdı.LineColor = System.Drawing.Color.Brown;
            this.txtPersonelAdı.Location = new System.Drawing.Point(12, 152);
            this.txtPersonelAdı.Name = "txtPersonelAdı";
            this.txtPersonelAdı.PasswordChar = '\0';
            this.txtPersonelAdı.SelectedText = "";
            this.txtPersonelAdı.Size = new System.Drawing.Size(207, 45);
            this.txtPersonelAdı.TabIndex = 0;
            this.txtPersonelAdı.Text = "Personel Adı";
            this.txtPersonelAdı.TextChanged += new System.EventHandler(this.txtPersonelAdı_TextChanged);
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
            this.btnExcel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Image = null;
            this.btnExcel.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExcel.Location = new System.Drawing.Point(32, 626);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnExcel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExcel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExcel.OnHoverImage = null;
            this.btnExcel.OnPressedColor = System.Drawing.Color.Black;
            this.btnExcel.Radius = 20;
            this.btnExcel.Size = new System.Drawing.Size(160, 89);
            this.btnExcel.TabIndex = 8;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // personelBilgisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 758);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtUnvan);
            this.Controls.Add(this.txtMaaş);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtPersonelAdı);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "personelBilgisi";
            this.Text = "Personel Bilgi Sayfası";
            this.Load += new System.EventHandler(this.personelBilgisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnGeri;
        private Guna.UI.WinForms.GunaButton btnTemizle;
        private Guna.UI.WinForms.GunaButton btnSil;
        private Guna.UI.WinForms.GunaButton btnGüncelle;
        private Guna.UI.WinForms.GunaButton btnEkle;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Guna.UI.WinForms.GunaLineTextBox txtUnvan;
        private Guna.UI.WinForms.GunaLineTextBox txtMaaş;
        private Guna.UI.WinForms.GunaLineTextBox txtTelefon;
        private Guna.UI.WinForms.GunaLineTextBox txtPersonelAdı;
        private Guna.UI.WinForms.GunaButton btnExcel;
    }
}