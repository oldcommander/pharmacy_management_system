namespace PharmacyManagementSystem
{
    partial class ÜreticiFirmaGirisFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÜreticiFirmaGirisFormu));
            this.btnGiris = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.txtParola = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtKullaniciAdi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.AnimationHoverSpeed = 0.07F;
            this.btnGiris.AnimationSpeed = 0.03F;
            this.btnGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnGiris.BaseColor = System.Drawing.Color.Chartreuse;
            this.btnGiris.BorderColor = System.Drawing.Color.Black;
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGiris.FocusedColor = System.Drawing.Color.Empty;
            this.btnGiris.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.Black;
            this.btnGiris.Image = null;
            this.btnGiris.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGiris.Location = new System.Drawing.Point(91, 374);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGiris.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGiris.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnGiris.OnHoverImage = null;
            this.btnGiris.OnPressedColor = System.Drawing.Color.Black;
            this.btnGiris.Radius = 15;
            this.btnGiris.Size = new System.Drawing.Size(224, 52);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.Red;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(91, 463);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Brown;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 15;
            this.gunaButton1.Size = new System.Drawing.Size(224, 51);
            this.gunaButton1.TabIndex = 3;
            this.gunaButton1.Text = "Parolamı Unuttum";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // txtParola
            // 
            this.txtParola.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtParola.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtParola.HintForeColor = System.Drawing.Color.Empty;
            this.txtParola.HintText = "";
            this.txtParola.isPassword = true;
            this.txtParola.LineFocusedColor = System.Drawing.Color.Lime;
            this.txtParola.LineIdleColor = System.Drawing.Color.Black;
            this.txtParola.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtParola.LineThickness = 3;
            this.txtParola.Location = new System.Drawing.Point(51, 241);
            this.txtParola.Margin = new System.Windows.Forms.Padding(4);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(300, 58);
            this.txtParola.TabIndex = 1;
            this.txtParola.Text = "Parola";
            this.txtParola.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKullaniciAdi.HintForeColor = System.Drawing.Color.Empty;
            this.txtKullaniciAdi.HintText = "";
            this.txtKullaniciAdi.isPassword = false;
            this.txtKullaniciAdi.LineFocusedColor = System.Drawing.Color.Lime;
            this.txtKullaniciAdi.LineIdleColor = System.Drawing.Color.Black;
            this.txtKullaniciAdi.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtKullaniciAdi.LineThickness = 4;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(51, 145);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(5);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(300, 64);
            this.txtKullaniciAdi.TabIndex = 0;
            this.txtKullaniciAdi.Text = "Kullanıcı Adı";
            this.txtKullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(121, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 52);
            this.label1.TabIndex = 5;
            this.label1.Text = "GİRİŞ";
            // 
            // ÜreticiFirmaGirisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(411, 559);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ÜreticiFirmaGirisFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜreticiFirmaGirisFormu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnGiris;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtParola;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtKullaniciAdi;
        private System.Windows.Forms.Label label1;
    }
}