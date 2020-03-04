namespace The_North_Rent_System
{
    partial class KullaniciBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciBilgileri));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.yetkiComboBox = new System.Windows.Forms.ComboBox();
            this.adSoyadTextBox = new System.Windows.Forms.TextBox();
            this.eMailTextBox = new System.Windows.Forms.TextBox();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.kullanicilar = new System.Windows.Forms.DataGridView();
            this.mailAdres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yetkisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eklemeButton = new System.Windows.Forms.Button();
            this.silmeButton = new System.Windows.Forms.Button();
            this.güncellemeButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.geriButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(23, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad-Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(23, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-mail Adres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(23, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon Numarası:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(23, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(23, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kullanıcı Yetkisi:";
            // 
            // yetkiComboBox
            // 
            this.yetkiComboBox.FormattingEnabled = true;
            this.yetkiComboBox.Items.AddRange(new object[] {
            "SuperAdmin",
            "Personel"});
            this.yetkiComboBox.Location = new System.Drawing.Point(182, 280);
            this.yetkiComboBox.Name = "yetkiComboBox";
            this.yetkiComboBox.Size = new System.Drawing.Size(121, 21);
            this.yetkiComboBox.TabIndex = 6;
            // 
            // adSoyadTextBox
            // 
            this.adSoyadTextBox.Location = new System.Drawing.Point(136, 98);
            this.adSoyadTextBox.Name = "adSoyadTextBox";
            this.adSoyadTextBox.Size = new System.Drawing.Size(123, 20);
            this.adSoyadTextBox.TabIndex = 7;
            // 
            // eMailTextBox
            // 
            this.eMailTextBox.Location = new System.Drawing.Point(159, 143);
            this.eMailTextBox.Name = "eMailTextBox";
            this.eMailTextBox.Size = new System.Drawing.Size(144, 20);
            this.eMailTextBox.TabIndex = 8;
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Location = new System.Drawing.Point(87, 236);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(100, 20);
            this.sifreTextBox.TabIndex = 10;
            // 
            // kullanicilar
            // 
            this.kullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kullanicilar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mailAdres,
            this.adSoyad,
            this.telefon,
            this.yetkisi});
            this.kullanicilar.Location = new System.Drawing.Point(529, 93);
            this.kullanicilar.Name = "kullanicilar";
            this.kullanicilar.Size = new System.Drawing.Size(643, 456);
            this.kullanicilar.TabIndex = 12;
            this.kullanicilar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kullanicilar_CellDoubleClick);
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
            // eklemeButton
            // 
            this.eklemeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eklemeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eklemeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eklemeButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.eklemeButton.Location = new System.Drawing.Point(15, 413);
            this.eklemeButton.Name = "eklemeButton";
            this.eklemeButton.Size = new System.Drawing.Size(127, 47);
            this.eklemeButton.TabIndex = 13;
            this.eklemeButton.Text = "Ekle";
            this.eklemeButton.UseVisualStyleBackColor = true;
            this.eklemeButton.Click += new System.EventHandler(this.eklemeButton_Click);
            // 
            // silmeButton
            // 
            this.silmeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.silmeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.silmeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silmeButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.silmeButton.Location = new System.Drawing.Point(201, 413);
            this.silmeButton.Name = "silmeButton";
            this.silmeButton.Size = new System.Drawing.Size(127, 47);
            this.silmeButton.TabIndex = 14;
            this.silmeButton.Text = "Sil";
            this.silmeButton.UseVisualStyleBackColor = true;
            this.silmeButton.Click += new System.EventHandler(this.silmeButton_Click);
            // 
            // güncellemeButton
            // 
            this.güncellemeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.güncellemeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.güncellemeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.güncellemeButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.güncellemeButton.Location = new System.Drawing.Point(383, 413);
            this.güncellemeButton.Name = "güncellemeButton";
            this.güncellemeButton.Size = new System.Drawing.Size(127, 47);
            this.güncellemeButton.TabIndex = 15;
            this.güncellemeButton.Text = "Güncelle";
            this.güncellemeButton.UseVisualStyleBackColor = true;
            this.güncellemeButton.Click += new System.EventHandler(this.güncellemeButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(12, 559);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(395, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Silme: Bu işlem için sadece mail adresini girmeniz yeterlidir!";
            // 
            // geriButton
            // 
            this.geriButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geriButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geriButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.geriButton.Location = new System.Drawing.Point(15, 12);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(80, 43);
            this.geriButton.TabIndex = 18;
            this.geriButton.Text = "Geri";
            this.geriButton.UseVisualStyleBackColor = true;
            this.geriButton.Click += new System.EventHandler(this.geriButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1220, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telefonTextBox.Location = new System.Drawing.Point(201, 189);
            this.telefonTextBox.MaxLength = 10;
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonTextBox.TabIndex = 21;
            this.telefonTextBox.TextChanged += new System.EventHandler(this.telefonTextBox_TextChanged);
            this.telefonTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefonTextBox_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1055, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 86);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // KullaniciBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.geriButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.güncellemeButton);
            this.Controls.Add(this.silmeButton);
            this.Controls.Add(this.eklemeButton);
            this.Controls.Add(this.kullanicilar);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.eMailTextBox);
            this.Controls.Add(this.adSoyadTextBox);
            this.Controls.Add(this.yetkiComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "KullaniciBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciBilgileri";
            this.Load += new System.EventHandler(this.KullaniciBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox yetkiComboBox;
        private System.Windows.Forms.TextBox adSoyadTextBox;
        private System.Windows.Forms.TextBox eMailTextBox;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.DataGridView kullanicilar;
        private System.Windows.Forms.Button eklemeButton;
        private System.Windows.Forms.Button silmeButton;
        private System.Windows.Forms.Button güncellemeButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button geriButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailAdres;
        private System.Windows.Forms.DataGridViewTextBoxColumn adSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn yetkisi;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}