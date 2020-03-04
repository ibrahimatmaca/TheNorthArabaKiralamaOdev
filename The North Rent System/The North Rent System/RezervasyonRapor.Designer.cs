namespace The_North_Rent_System
{
    partial class RezervasyonRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RezervasyonRapor));
            this.backToMainMenu = new System.Windows.Forms.Button();
            this.pdfExport = new System.Windows.Forms.Button();
            this.rezervasyon = new System.Windows.Forms.DataGridView();
            this.personel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kimlikNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracPlaka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baslangic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitisTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamgun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odemedurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyon)).BeginInit();
            this.SuspendLayout();
            // 
            // backToMainMenu
            // 
            this.backToMainMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backToMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backToMainMenu.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.backToMainMenu.Location = new System.Drawing.Point(12, 12);
            this.backToMainMenu.Name = "backToMainMenu";
            this.backToMainMenu.Size = new System.Drawing.Size(78, 24);
            this.backToMainMenu.TabIndex = 18;
            this.backToMainMenu.Text = "Geri";
            this.backToMainMenu.UseVisualStyleBackColor = false;
            this.backToMainMenu.Click += new System.EventHandler(this.backToMainMenu_Click);
            // 
            // pdfExport
            // 
            this.pdfExport.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pdfExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pdfExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pdfExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pdfExport.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pdfExport.Location = new System.Drawing.Point(661, 12);
            this.pdfExport.Name = "pdfExport";
            this.pdfExport.Size = new System.Drawing.Size(127, 32);
            this.pdfExport.TabIndex = 19;
            this.pdfExport.Text = "Export to Pdf";
            this.pdfExport.UseVisualStyleBackColor = false;
            this.pdfExport.Click += new System.EventHandler(this.pdfExport_Click);
            // 
            // rezervasyon
            // 
            this.rezervasyon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rezervasyon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personel,
            this.adSoyad,
            this.adres,
            this.telefon,
            this.kimlikNo,
            this.aracPlaka,
            this.baslangic,
            this.bitisTarih,
            this.toplamgun,
            this.toplamTutar,
            this.odemedurum});
            this.rezervasyon.Location = new System.Drawing.Point(12, 54);
            this.rezervasyon.Name = "rezervasyon";
            this.rezervasyon.Size = new System.Drawing.Size(776, 384);
            this.rezervasyon.TabIndex = 20;
            // 
            // personel
            // 
            this.personel.DataPropertyName = "personelAdSoyad";
            this.personel.HeaderText = "Kiralayan Personel";
            this.personel.Name = "personel";
            this.personel.Width = 120;
            // 
            // adSoyad
            // 
            this.adSoyad.DataPropertyName = "musteriAdSoyad";
            this.adSoyad.HeaderText = "Müşteri Ad-Soyad";
            this.adSoyad.Name = "adSoyad";
            this.adSoyad.Width = 120;
            // 
            // adres
            // 
            this.adres.DataPropertyName = "adres";
            this.adres.HeaderText = "Adres";
            this.adres.Name = "adres";
            this.adres.Width = 120;
            // 
            // telefon
            // 
            this.telefon.DataPropertyName = "telefonNumarasi";
            this.telefon.HeaderText = "Telefon Numarası";
            this.telefon.Name = "telefon";
            // 
            // kimlikNo
            // 
            this.kimlikNo.DataPropertyName = "kimlikNumarasi";
            this.kimlikNo.HeaderText = "Kimlik Numarası";
            this.kimlikNo.Name = "kimlikNo";
            // 
            // aracPlaka
            // 
            this.aracPlaka.DataPropertyName = "aracPlaka";
            this.aracPlaka.HeaderText = "Araç Plaka";
            this.aracPlaka.Name = "aracPlaka";
            // 
            // baslangic
            // 
            this.baslangic.DataPropertyName = "baslangicTarih";
            this.baslangic.HeaderText = "Baslangic Tarihi";
            this.baslangic.Name = "baslangic";
            // 
            // bitisTarih
            // 
            this.bitisTarih.DataPropertyName = "bitisTarih";
            this.bitisTarih.HeaderText = "Bitiş Tarih";
            this.bitisTarih.Name = "bitisTarih";
            // 
            // toplamgun
            // 
            this.toplamgun.DataPropertyName = "toplamGun";
            this.toplamgun.HeaderText = "Kiralanan Toplam Gün";
            this.toplamgun.Name = "toplamgun";
            // 
            // toplamTutar
            // 
            this.toplamTutar.DataPropertyName = "toplamFiyat";
            this.toplamTutar.HeaderText = "Toplam Tutar";
            this.toplamTutar.Name = "toplamTutar";
            // 
            // odemedurum
            // 
            this.odemedurum.DataPropertyName = "odeme";
            this.odemedurum.HeaderText = "Ödeme Durumu";
            this.odemedurum.Name = "odemedurum";
            // 
            // RezervasyonRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rezervasyon);
            this.Controls.Add(this.pdfExport);
            this.Controls.Add(this.backToMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RezervasyonRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervasyon Raporu";
            this.Load += new System.EventHandler(this.RezervasyonRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backToMainMenu;
        private System.Windows.Forms.Button pdfExport;
        private System.Windows.Forms.DataGridView rezervasyon;
        private System.Windows.Forms.DataGridViewTextBoxColumn personel;
        private System.Windows.Forms.DataGridViewTextBoxColumn adSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn kimlikNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracPlaka;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslangic;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitisTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamgun;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemedurum;
    }
}