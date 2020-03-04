namespace The_North_Rent_System
{
    partial class arabaEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(arabaEkle));
            this.arabaTablosu = new System.Windows.Forms.DataGridView();
            this.arabaPlaka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uretimyil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kasatip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yakıttip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanzimanTip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geriButton = new System.Windows.Forms.Button();
            this.plaka = new System.Windows.Forms.Label();
            this.plakaText = new System.Windows.Forms.TextBox();
            this.markaTex = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.markaText = new System.Windows.Forms.TextBox();
            this.modelText = new System.Windows.Forms.TextBox();
            this.kasaCombo = new System.Windows.Forms.ComboBox();
            this.KasaTipi = new System.Windows.Forms.Label();
            this.yakitTipi = new System.Windows.Forms.Label();
            this.yakitCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sanzimanCombo = new System.Windows.Forms.ComboBox();
            this.arabaDurumCombo = new System.Windows.Forms.ComboBox();
            this.ArabaDurumu = new System.Windows.Forms.Label();
            this.ucretgun = new System.Windows.Forms.Label();
            this.ucretGunluk = new System.Windows.Forms.TextBox();
            this.arabaEkleme = new System.Windows.Forms.Button();
            this.uretm = new System.Windows.Forms.Label();
            this.uretimYiliText = new System.Windows.Forms.TextBox();
            this.silmeButton = new System.Windows.Forms.Button();
            this.guncellemeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.arabaTablosu)).BeginInit();
            this.SuspendLayout();
            // 
            // arabaTablosu
            // 
            this.arabaTablosu.AllowUserToAddRows = false;
            this.arabaTablosu.BackgroundColor = System.Drawing.Color.Beige;
            this.arabaTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.arabaTablosu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.arabaPlaka,
            this.marka,
            this.model,
            this.uretimyil,
            this.kasatip,
            this.yakıttip,
            this.sanzimanTip,
            this.ucret,
            this.durum});
            this.arabaTablosu.Location = new System.Drawing.Point(254, 12);
            this.arabaTablosu.Name = "arabaTablosu";
            this.arabaTablosu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.arabaTablosu.Size = new System.Drawing.Size(918, 537);
            this.arabaTablosu.StandardTab = true;
            this.arabaTablosu.TabIndex = 0;
            this.arabaTablosu.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.arabaTablosu_CellContentClick);
            // 
            // arabaPlaka
            // 
            this.arabaPlaka.DataPropertyName = "aracPlaka";
            this.arabaPlaka.HeaderText = "Araba Plaka";
            this.arabaPlaka.Name = "arabaPlaka";
            // 
            // marka
            // 
            this.marka.DataPropertyName = "marka";
            this.marka.HeaderText = "Marka";
            this.marka.Name = "marka";
            // 
            // model
            // 
            this.model.DataPropertyName = "model";
            this.model.HeaderText = "Model";
            this.model.Name = "model";
            // 
            // uretimyil
            // 
            this.uretimyil.DataPropertyName = "uretimYili";
            this.uretimyil.HeaderText = "Üretim Yılı";
            this.uretimyil.Name = "uretimyil";
            // 
            // kasatip
            // 
            this.kasatip.DataPropertyName = "kasaTipi";
            this.kasatip.HeaderText = "Kasa Tip";
            this.kasatip.Name = "kasatip";
            // 
            // yakıttip
            // 
            this.yakıttip.DataPropertyName = "yakitTipi";
            this.yakıttip.HeaderText = "Yakıt Tipi";
            this.yakıttip.Name = "yakıttip";
            // 
            // sanzimanTip
            // 
            this.sanzimanTip.DataPropertyName = "sanzimanTipi";
            this.sanzimanTip.HeaderText = "Şanzıman Tip";
            this.sanzimanTip.Name = "sanzimanTip";
            // 
            // ucret
            // 
            this.ucret.DataPropertyName = "ucret";
            this.ucret.HeaderText = "Günlük Ücret";
            this.ucret.Name = "ucret";
            // 
            // durum
            // 
            this.durum.DataPropertyName = "arabaDurum";
            this.durum.HeaderText = "Durum";
            this.durum.Name = "durum";
            // 
            // geriButton
            // 
            this.geriButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geriButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geriButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.geriButton.Location = new System.Drawing.Point(12, 12);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(75, 31);
            this.geriButton.TabIndex = 1;
            this.geriButton.Text = "Geri";
            this.geriButton.UseVisualStyleBackColor = true;
            this.geriButton.Click += new System.EventHandler(this.geriButton_Click);
            // 
            // plaka
            // 
            this.plaka.AutoSize = true;
            this.plaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.plaka.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plaka.Location = new System.Drawing.Point(9, 62);
            this.plaka.Name = "plaka";
            this.plaka.Size = new System.Drawing.Size(93, 17);
            this.plaka.TabIndex = 2;
            this.plaka.Text = "Araba Plaka :";
            // 
            // plakaText
            // 
            this.plakaText.Location = new System.Drawing.Point(108, 62);
            this.plakaText.Name = "plakaText";
            this.plakaText.Size = new System.Drawing.Size(100, 20);
            this.plakaText.TabIndex = 3;
            // 
            // markaTex
            // 
            this.markaTex.AutoSize = true;
            this.markaTex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.markaTex.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.markaTex.Location = new System.Drawing.Point(9, 99);
            this.markaTex.Name = "markaTex";
            this.markaTex.Size = new System.Drawing.Size(55, 17);
            this.markaTex.TabIndex = 4;
            this.markaTex.Text = "Marka :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(9, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Model :";
            // 
            // markaText
            // 
            this.markaText.Location = new System.Drawing.Point(108, 99);
            this.markaText.Name = "markaText";
            this.markaText.Size = new System.Drawing.Size(100, 20);
            this.markaText.TabIndex = 6;
            // 
            // modelText
            // 
            this.modelText.Location = new System.Drawing.Point(108, 140);
            this.modelText.MaxLength = 20;
            this.modelText.Name = "modelText";
            this.modelText.Size = new System.Drawing.Size(100, 20);
            this.modelText.TabIndex = 4;
            // 
            // kasaCombo
            // 
            this.kasaCombo.FormattingEnabled = true;
            this.kasaCombo.Items.AddRange(new object[] {
            "Sedan",
            "Hatchback",
            "Station wagon",
            "Cabrio",
            "Pick up",
            "SUV"});
            this.kasaCombo.Location = new System.Drawing.Point(108, 209);
            this.kasaCombo.Name = "kasaCombo";
            this.kasaCombo.Size = new System.Drawing.Size(121, 21);
            this.kasaCombo.TabIndex = 8;
            // 
            // KasaTipi
            // 
            this.KasaTipi.AutoSize = true;
            this.KasaTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KasaTipi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.KasaTipi.Location = new System.Drawing.Point(9, 210);
            this.KasaTipi.Name = "KasaTipi";
            this.KasaTipi.Size = new System.Drawing.Size(68, 17);
            this.KasaTipi.TabIndex = 9;
            this.KasaTipi.Text = "Kasa Tip:";
            // 
            // yakitTipi
            // 
            this.yakitTipi.AutoSize = true;
            this.yakitTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yakitTipi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.yakitTipi.Location = new System.Drawing.Point(9, 250);
            this.yakitTipi.Name = "yakitTipi";
            this.yakitTipi.Size = new System.Drawing.Size(71, 17);
            this.yakitTipi.TabIndex = 10;
            this.yakitTipi.Text = "Yakıt Tip :";
            // 
            // yakitCombo
            // 
            this.yakitCombo.FormattingEnabled = true;
            this.yakitCombo.Items.AddRange(new object[] {
            "Dizel",
            "LPG",
            "Benzin",
            "Hybrid"});
            this.yakitCombo.Location = new System.Drawing.Point(108, 250);
            this.yakitCombo.Name = "yakitCombo";
            this.yakitCombo.Size = new System.Drawing.Size(121, 21);
            this.yakitCombo.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(9, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Şanzıman Tip :";
            // 
            // sanzimanCombo
            // 
            this.sanzimanCombo.FormattingEnabled = true;
            this.sanzimanCombo.Items.AddRange(new object[] {
            "Manuel",
            "Yarı-Otomatik",
            "Otomatik"});
            this.sanzimanCombo.Location = new System.Drawing.Point(117, 293);
            this.sanzimanCombo.Name = "sanzimanCombo";
            this.sanzimanCombo.Size = new System.Drawing.Size(121, 21);
            this.sanzimanCombo.TabIndex = 13;
            // 
            // arabaDurumCombo
            // 
            this.arabaDurumCombo.FormattingEnabled = true;
            this.arabaDurumCombo.Items.AddRange(new object[] {
            "Boş",
            "Bakım",
            "Kiralandı",
            ""});
            this.arabaDurumCombo.Location = new System.Drawing.Point(115, 379);
            this.arabaDurumCombo.Name = "arabaDurumCombo";
            this.arabaDurumCombo.Size = new System.Drawing.Size(121, 21);
            this.arabaDurumCombo.TabIndex = 14;
            // 
            // ArabaDurumu
            // 
            this.ArabaDurumu.AutoSize = true;
            this.ArabaDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ArabaDurumu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ArabaDurumu.Location = new System.Drawing.Point(9, 379);
            this.ArabaDurumu.Name = "ArabaDurumu";
            this.ArabaDurumu.Size = new System.Drawing.Size(100, 17);
            this.ArabaDurumu.TabIndex = 15;
            this.ArabaDurumu.Text = "Araba Durum :";
            // 
            // ucretgun
            // 
            this.ucretgun.AutoSize = true;
            this.ucretgun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ucretgun.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ucretgun.Location = new System.Drawing.Point(12, 340);
            this.ucretgun.Name = "ucretgun";
            this.ucretgun.Size = new System.Drawing.Size(99, 17);
            this.ucretgun.TabIndex = 16;
            this.ucretgun.Text = "Günlük Ücret :";
            // 
            // ucretGunluk
            // 
            this.ucretGunluk.Location = new System.Drawing.Point(115, 340);
            this.ucretGunluk.Name = "ucretGunluk";
            this.ucretGunluk.Size = new System.Drawing.Size(100, 20);
            this.ucretGunluk.TabIndex = 17;
            // 
            // arabaEkleme
            // 
            this.arabaEkleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arabaEkleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arabaEkleme.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.arabaEkleme.Location = new System.Drawing.Point(12, 427);
            this.arabaEkleme.Name = "arabaEkleme";
            this.arabaEkleme.Size = new System.Drawing.Size(90, 41);
            this.arabaEkleme.TabIndex = 18;
            this.arabaEkleme.Text = "Ekle";
            this.arabaEkleme.UseVisualStyleBackColor = true;
            this.arabaEkleme.Click += new System.EventHandler(this.arabaEkleme_Click);
            // 
            // uretm
            // 
            this.uretm.AutoSize = true;
            this.uretm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uretm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uretm.Location = new System.Drawing.Point(9, 173);
            this.uretm.Name = "uretm";
            this.uretm.Size = new System.Drawing.Size(75, 17);
            this.uretm.TabIndex = 19;
            this.uretm.Text = "Üretim Yılı:";
            // 
            // uretimYiliText
            // 
            this.uretimYiliText.Location = new System.Drawing.Point(108, 173);
            this.uretimYiliText.MaxLength = 4;
            this.uretimYiliText.Name = "uretimYiliText";
            this.uretimYiliText.Size = new System.Drawing.Size(100, 20);
            this.uretimYiliText.TabIndex = 20;
            // 
            // silmeButton
            // 
            this.silmeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.silmeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silmeButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.silmeButton.Location = new System.Drawing.Point(139, 427);
            this.silmeButton.Name = "silmeButton";
            this.silmeButton.Size = new System.Drawing.Size(90, 41);
            this.silmeButton.TabIndex = 21;
            this.silmeButton.Text = "Sil";
            this.silmeButton.UseVisualStyleBackColor = true;
            this.silmeButton.Click += new System.EventHandler(this.silmeButton_Click);
            // 
            // guncellemeButton
            // 
            this.guncellemeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guncellemeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncellemeButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.guncellemeButton.Location = new System.Drawing.Point(70, 492);
            this.guncellemeButton.Name = "guncellemeButton";
            this.guncellemeButton.Size = new System.Drawing.Size(90, 41);
            this.guncellemeButton.TabIndex = 22;
            this.guncellemeButton.Text = "Güncelle";
            this.guncellemeButton.UseVisualStyleBackColor = true;
            this.guncellemeButton.Click += new System.EventHandler(this.guncellemeButton_Click);
            // 
            // arabaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.guncellemeButton);
            this.Controls.Add(this.silmeButton);
            this.Controls.Add(this.uretimYiliText);
            this.Controls.Add(this.uretm);
            this.Controls.Add(this.arabaEkleme);
            this.Controls.Add(this.ucretGunluk);
            this.Controls.Add(this.ucretgun);
            this.Controls.Add(this.ArabaDurumu);
            this.Controls.Add(this.arabaDurumCombo);
            this.Controls.Add(this.sanzimanCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yakitCombo);
            this.Controls.Add(this.yakitTipi);
            this.Controls.Add(this.KasaTipi);
            this.Controls.Add(this.kasaCombo);
            this.Controls.Add(this.modelText);
            this.Controls.Add(this.markaText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.markaTex);
            this.Controls.Add(this.plakaText);
            this.Controls.Add(this.plaka);
            this.Controls.Add(this.geriButton);
            this.Controls.Add(this.arabaTablosu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "arabaEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araba Ekle";
            this.Load += new System.EventHandler(this.arabaEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.arabaTablosu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView arabaTablosu;
        private System.Windows.Forms.Button geriButton;
        private System.Windows.Forms.Label plaka;
        private System.Windows.Forms.TextBox plakaText;
        private System.Windows.Forms.Label markaTex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox markaText;
        private System.Windows.Forms.TextBox modelText;
        private System.Windows.Forms.ComboBox kasaCombo;
        private System.Windows.Forms.Label KasaTipi;
        private System.Windows.Forms.Label yakitTipi;
        private System.Windows.Forms.ComboBox yakitCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sanzimanCombo;
        private System.Windows.Forms.ComboBox arabaDurumCombo;
        private System.Windows.Forms.Label ArabaDurumu;
        private System.Windows.Forms.Label ucretgun;
        private System.Windows.Forms.TextBox ucretGunluk;
        private System.Windows.Forms.Button arabaEkleme;
        private System.Windows.Forms.Label uretm;
        private System.Windows.Forms.TextBox uretimYiliText;
        private System.Windows.Forms.DataGridViewTextBoxColumn arabaPlaka;
        private System.Windows.Forms.DataGridViewTextBoxColumn marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn uretimyil;
        private System.Windows.Forms.DataGridViewTextBoxColumn kasatip;
        private System.Windows.Forms.DataGridViewTextBoxColumn yakıttip;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanzimanTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucret;
        private System.Windows.Forms.DataGridViewTextBoxColumn durum;
        private System.Windows.Forms.Button silmeButton;
        private System.Windows.Forms.Button guncellemeButton;
    }
}