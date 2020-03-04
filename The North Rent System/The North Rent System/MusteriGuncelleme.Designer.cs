namespace The_North_Rent_System
{
    partial class MusteriGuncelleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriGuncelleme));
            this.musteriTablo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.adSoyad = new System.Windows.Forms.TextBox();
            this.kimlikNo = new System.Windows.Forms.TextBox();
            this.adresleme = new System.Windows.Forms.TextBox();
            this.telefonNo = new System.Windows.Forms.TextBox();
            this.musteri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kimlik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guncellemeButton = new System.Windows.Forms.Button();
            this.geriButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.musteriTablo)).BeginInit();
            this.SuspendLayout();
            // 
            // musteriTablo
            // 
            this.musteriTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musteriTablo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteri,
            this.kimlik,
            this.adres,
            this.telefon});
            this.musteriTablo.Location = new System.Drawing.Point(12, 109);
            this.musteriTablo.Name = "musteriTablo";
            this.musteriTablo.Size = new System.Drawing.Size(780, 340);
            this.musteriTablo.TabIndex = 0;
            this.musteriTablo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.musteriTablo_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(124, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(124, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kimlik Numarası :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(460, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefon :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(460, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adres :";
            // 
            // adSoyad
            // 
            this.adSoyad.Location = new System.Drawing.Point(216, 19);
            this.adSoyad.Name = "adSoyad";
            this.adSoyad.Size = new System.Drawing.Size(104, 20);
            this.adSoyad.TabIndex = 5;
            // 
            // kimlikNo
            // 
            this.kimlikNo.Location = new System.Drawing.Point(258, 66);
            this.kimlikNo.MaxLength = 11;
            this.kimlikNo.Name = "kimlikNo";
            this.kimlikNo.Size = new System.Drawing.Size(104, 20);
            this.kimlikNo.TabIndex = 6;
            // 
            // adresleme
            // 
            this.adresleme.Location = new System.Drawing.Point(525, 19);
            this.adresleme.Name = "adresleme";
            this.adresleme.Size = new System.Drawing.Size(218, 20);
            this.adresleme.TabIndex = 7;
            // 
            // telefonNo
            // 
            this.telefonNo.Location = new System.Drawing.Point(536, 66);
            this.telefonNo.MaxLength = 11;
            this.telefonNo.Name = "telefonNo";
            this.telefonNo.Size = new System.Drawing.Size(104, 20);
            this.telefonNo.TabIndex = 8;
            // 
            // musteri
            // 
            this.musteri.DataPropertyName = "adSoyad";
            this.musteri.HeaderText = "Ad Soyad";
            this.musteri.Name = "musteri";
            this.musteri.Width = 150;
            // 
            // kimlik
            // 
            this.kimlik.DataPropertyName = "kimlikNumarası";
            this.kimlik.HeaderText = "Kimlik Numarası";
            this.kimlik.Name = "kimlik";
            this.kimlik.Width = 150;
            // 
            // adres
            // 
            this.adres.DataPropertyName = "adres";
            this.adres.HeaderText = "Adres";
            this.adres.Name = "adres";
            this.adres.Width = 280;
            // 
            // telefon
            // 
            this.telefon.DataPropertyName = "telefon";
            this.telefon.HeaderText = "Telefon";
            this.telefon.Name = "telefon";
            this.telefon.Width = 150;
            // 
            // guncellemeButton
            // 
            this.guncellemeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guncellemeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncellemeButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.guncellemeButton.Location = new System.Drawing.Point(711, 57);
            this.guncellemeButton.Name = "guncellemeButton";
            this.guncellemeButton.Size = new System.Drawing.Size(81, 37);
            this.guncellemeButton.TabIndex = 9;
            this.guncellemeButton.Text = "Güncelle";
            this.guncellemeButton.UseVisualStyleBackColor = true;
            this.guncellemeButton.Click += new System.EventHandler(this.guncellemeButton_Click);
            // 
            // geriButton
            // 
            this.geriButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geriButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geriButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.geriButton.Location = new System.Drawing.Point(12, 10);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(81, 37);
            this.geriButton.TabIndex = 10;
            this.geriButton.Text = "Geri";
            this.geriButton.UseVisualStyleBackColor = true;
            this.geriButton.Click += new System.EventHandler(this.geriButton_Click);
            // 
            // MusteriGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.ControlBox = false;
            this.Controls.Add(this.geriButton);
            this.Controls.Add(this.guncellemeButton);
            this.Controls.Add(this.telefonNo);
            this.Controls.Add(this.adresleme);
            this.Controls.Add(this.kimlikNo);
            this.Controls.Add(this.adSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.musteriTablo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MusteriGuncelleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Güncelle";
            this.Load += new System.EventHandler(this.MusteriGuncelleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musteriTablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView musteriTablo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adSoyad;
        private System.Windows.Forms.TextBox kimlikNo;
        private System.Windows.Forms.TextBox adresleme;
        private System.Windows.Forms.TextBox telefonNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri;
        private System.Windows.Forms.DataGridViewTextBoxColumn kimlik;
        private System.Windows.Forms.DataGridViewTextBoxColumn adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
        private System.Windows.Forms.Button guncellemeButton;
        private System.Windows.Forms.Button geriButton;
    }
}