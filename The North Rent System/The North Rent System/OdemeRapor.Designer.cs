namespace The_North_Rent_System
{
    partial class OdemeRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdemeRapor));
            this.backToMainMenu = new System.Windows.Forms.Button();
            this.pdfExport = new System.Windows.Forms.Button();
            this.odemeRaporTablo = new System.Windows.Forms.DataGridView();
            this.kiralayanPersonel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kimlikNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracPlaka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiralamaTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiralamaBitis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamUcret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odenmeDurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.musterisim = new System.Windows.Forms.TextBox();
            this.durumCombo = new System.Windows.Forms.ComboBox();
            this.guncelleButon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.odemeRaporTablo)).BeginInit();
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
            this.backToMainMenu.TabIndex = 17;
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
            this.pdfExport.Location = new System.Drawing.Point(661, 406);
            this.pdfExport.Name = "pdfExport";
            this.pdfExport.Size = new System.Drawing.Size(127, 32);
            this.pdfExport.TabIndex = 18;
            this.pdfExport.Text = "Export to Pdf";
            this.pdfExport.UseVisualStyleBackColor = false;
            this.pdfExport.Click += new System.EventHandler(this.pdfExport_Click);
            // 
            // odemeRaporTablo
            // 
            this.odemeRaporTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.odemeRaporTablo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kiralayanPersonel,
            this.musteriAd,
            this.kimlikNo,
            this.aracPlaka,
            this.kiralamaTarih,
            this.kiralamaBitis,
            this.toplamUcret,
            this.odenmeDurum});
            this.odemeRaporTablo.Location = new System.Drawing.Point(12, 57);
            this.odemeRaporTablo.Name = "odemeRaporTablo";
            this.odemeRaporTablo.Size = new System.Drawing.Size(776, 340);
            this.odemeRaporTablo.TabIndex = 19;
            this.odemeRaporTablo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.odemeRaporTablo_CellDoubleClick);
            // 
            // kiralayanPersonel
            // 
            this.kiralayanPersonel.DataPropertyName = "personelAdSoyad";
            this.kiralayanPersonel.HeaderText = "Sorumlu Personel";
            this.kiralayanPersonel.Name = "kiralayanPersonel";
            // 
            // musteriAd
            // 
            this.musteriAd.DataPropertyName = "musteriAdSoyad";
            this.musteriAd.HeaderText = "Ad-Soyad";
            this.musteriAd.Name = "musteriAd";
            // 
            // kimlikNo
            // 
            this.kimlikNo.DataPropertyName = "telefonNumarasi";
            this.kimlikNo.HeaderText = "Telefon Numarası";
            this.kimlikNo.Name = "kimlikNo";
            this.kimlikNo.Width = 120;
            // 
            // aracPlaka
            // 
            this.aracPlaka.DataPropertyName = "aracPlaka";
            this.aracPlaka.HeaderText = "Araba Plakası";
            this.aracPlaka.Name = "aracPlaka";
            // 
            // kiralamaTarih
            // 
            this.kiralamaTarih.DataPropertyName = "baslangicTarih";
            this.kiralamaTarih.HeaderText = "Kiralama Başlangıç";
            this.kiralamaTarih.Name = "kiralamaTarih";
            this.kiralamaTarih.Width = 120;
            // 
            // kiralamaBitis
            // 
            this.kiralamaBitis.DataPropertyName = "bitisTarih";
            this.kiralamaBitis.HeaderText = "Kiralama Bitiş";
            this.kiralamaBitis.Name = "kiralamaBitis";
            this.kiralamaBitis.Width = 110;
            // 
            // toplamUcret
            // 
            this.toplamUcret.DataPropertyName = "toplamFiyat";
            this.toplamUcret.HeaderText = "Ödenecek Ücret";
            this.toplamUcret.Name = "toplamUcret";
            // 
            // odenmeDurum
            // 
            this.odenmeDurum.DataPropertyName = "odeme";
            this.odenmeDurum.HeaderText = "Ödenme Durumu";
            this.odenmeDurum.Name = "odenmeDurum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(116, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ad - Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(402, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Durum :";
            // 
            // musterisim
            // 
            this.musterisim.Location = new System.Drawing.Point(209, 15);
            this.musterisim.Name = "musterisim";
            this.musterisim.Size = new System.Drawing.Size(134, 20);
            this.musterisim.TabIndex = 22;
            // 
            // durumCombo
            // 
            this.durumCombo.FormattingEnabled = true;
            this.durumCombo.Items.AddRange(new object[] {
            "Ödenmedi",
            "Ödendi"});
            this.durumCombo.Location = new System.Drawing.Point(467, 14);
            this.durumCombo.Name = "durumCombo";
            this.durumCombo.Size = new System.Drawing.Size(121, 21);
            this.durumCombo.TabIndex = 23;
            // 
            // guncelleButon
            // 
            this.guncelleButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guncelleButon.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.guncelleButon.Location = new System.Drawing.Point(702, 12);
            this.guncelleButon.Name = "guncelleButon";
            this.guncelleButon.Size = new System.Drawing.Size(86, 28);
            this.guncelleButon.TabIndex = 24;
            this.guncelleButon.Text = "Güncelle";
            this.guncelleButon.UseVisualStyleBackColor = true;
            this.guncelleButon.Click += new System.EventHandler(this.guncelleButon_Click);
            // 
            // OdemeRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guncelleButon);
            this.Controls.Add(this.durumCombo);
            this.Controls.Add(this.musterisim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odemeRaporTablo);
            this.Controls.Add(this.pdfExport);
            this.Controls.Add(this.backToMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OdemeRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Rapor";
            this.Load += new System.EventHandler(this.OdemeRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.odemeRaporTablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToMainMenu;
        private System.Windows.Forms.Button pdfExport;
        private System.Windows.Forms.DataGridView odemeRaporTablo;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiralayanPersonel;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn kimlikNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracPlaka;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiralamaTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiralamaBitis;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamUcret;
        private System.Windows.Forms.DataGridViewTextBoxColumn odenmeDurum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox musterisim;
        private System.Windows.Forms.ComboBox durumCombo;
        private System.Windows.Forms.Button guncelleButon;
    }
}