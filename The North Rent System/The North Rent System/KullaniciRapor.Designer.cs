namespace The_North_Rent_System
{
    partial class KullaniciRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciRapor));
            this.tablo = new System.Windows.Forms.DataGridView();
            this.mailAdres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yetkisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backToMainMenu = new System.Windows.Forms.Button();
            this.pdfExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            this.SuspendLayout();
            // 
            // tablo
            // 
            this.tablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mailAdres,
            this.adSoyad,
            this.telefon,
            this.yetkisi});
            this.tablo.Location = new System.Drawing.Point(12, 60);
            this.tablo.Name = "tablo";
            this.tablo.Size = new System.Drawing.Size(663, 321);
            this.tablo.TabIndex = 13;
            // 
            // mailAdres
            // 
            this.mailAdres.DataPropertyName = "kullaniciMailAdres";
            this.mailAdres.HeaderText = "Mail Adresi";
            this.mailAdres.MinimumWidth = 50;
            this.mailAdres.Name = "mailAdres";
            this.mailAdres.Width = 150;
            // 
            // adSoyad
            // 
            this.adSoyad.DataPropertyName = "kullaniciAdSoyad";
            this.adSoyad.HeaderText = "Ad Soyad";
            this.adSoyad.MinimumWidth = 50;
            this.adSoyad.Name = "adSoyad";
            this.adSoyad.Width = 150;
            // 
            // telefon
            // 
            this.telefon.DataPropertyName = "kullaniciTelefon";
            this.telefon.HeaderText = "Telefon Numarası";
            this.telefon.MinimumWidth = 50;
            this.telefon.Name = "telefon";
            this.telefon.Width = 150;
            // 
            // yetkisi
            // 
            this.yetkisi.DataPropertyName = "kullaniciYetkisi";
            this.yetkisi.HeaderText = "Kullanıcı Yetki";
            this.yetkisi.MinimumWidth = 50;
            this.yetkisi.Name = "yetkisi";
            this.yetkisi.Width = 150;
            // 
            // backToMainMenu
            // 
            this.backToMainMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backToMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backToMainMenu.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.backToMainMenu.Location = new System.Drawing.Point(12, 13);
            this.backToMainMenu.Name = "backToMainMenu";
            this.backToMainMenu.Size = new System.Drawing.Size(78, 24);
            this.backToMainMenu.TabIndex = 15;
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
            this.pdfExport.Location = new System.Drawing.Point(548, 12);
            this.pdfExport.Name = "pdfExport";
            this.pdfExport.Size = new System.Drawing.Size(127, 32);
            this.pdfExport.TabIndex = 14;
            this.pdfExport.Text = "Export to Pdf";
            this.pdfExport.UseVisualStyleBackColor = false;
            this.pdfExport.Click += new System.EventHandler(this.pdfExport_Click);
            // 
            // KullaniciRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(686, 393);
            this.Controls.Add(this.backToMainMenu);
            this.Controls.Add(this.pdfExport);
            this.Controls.Add(this.tablo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullaniciRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Raporu";
            this.Load += new System.EventHandler(this.KullaniciRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablo;
        private System.Windows.Forms.Button backToMainMenu;
        private System.Windows.Forms.Button pdfExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailAdres;
        private System.Windows.Forms.DataGridViewTextBoxColumn adSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn yetkisi;
    }
}