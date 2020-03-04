namespace The_North_Rent_System
{
    partial class arabaRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(arabaRapor));
            this.backToMainMenu = new System.Windows.Forms.Button();
            this.pdfExport = new System.Windows.Forms.Button();
            this.arabaRaporTablo = new System.Windows.Forms.DataGridView();
            this.aracPlaka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arabaMarka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arabaModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arabayil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arabaTip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yakitTip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanzimanTip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucrert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arabaDURU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.arabaRaporTablo)).BeginInit();
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
            this.backToMainMenu.TabIndex = 16;
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
            this.pdfExport.TabIndex = 17;
            this.pdfExport.Text = "Export to Pdf";
            this.pdfExport.UseVisualStyleBackColor = false;
            this.pdfExport.Click += new System.EventHandler(this.pdfExport_Click);
            // 
            // arabaRaporTablo
            // 
            this.arabaRaporTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.arabaRaporTablo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aracPlaka,
            this.arabaMarka,
            this.arabaModel,
            this.arabayil,
            this.arabaTip,
            this.yakitTip,
            this.sanzimanTip,
            this.ucrert,
            this.arabaDURU});
            this.arabaRaporTablo.Location = new System.Drawing.Point(12, 54);
            this.arabaRaporTablo.Name = "arabaRaporTablo";
            this.arabaRaporTablo.Size = new System.Drawing.Size(776, 384);
            this.arabaRaporTablo.TabIndex = 18;
            // 
            // aracPlaka
            // 
            this.aracPlaka.DataPropertyName = "aracPlaka";
            this.aracPlaka.HeaderText = "Araba Plaka";
            this.aracPlaka.Name = "aracPlaka";
            // 
            // arabaMarka
            // 
            this.arabaMarka.DataPropertyName = "marka";
            this.arabaMarka.HeaderText = "Araba Markası";
            this.arabaMarka.Name = "arabaMarka";
            // 
            // arabaModel
            // 
            this.arabaModel.DataPropertyName = "model";
            this.arabaModel.HeaderText = "Araba Modeli";
            this.arabaModel.Name = "arabaModel";
            // 
            // arabayil
            // 
            this.arabayil.DataPropertyName = "uretimYili";
            this.arabayil.HeaderText = "Üretim Yılı";
            this.arabayil.Name = "arabayil";
            // 
            // arabaTip
            // 
            this.arabaTip.DataPropertyName = "kasaTipi";
            this.arabaTip.HeaderText = "Araba Tipi";
            this.arabaTip.Name = "arabaTip";
            // 
            // yakitTip
            // 
            this.yakitTip.DataPropertyName = "yakitTipi";
            this.yakitTip.HeaderText = "Yakıt Tipi";
            this.yakitTip.Name = "yakitTip";
            // 
            // sanzimanTip
            // 
            this.sanzimanTip.DataPropertyName = "sanzimanTipi";
            this.sanzimanTip.HeaderText = "Şanzıman Tipi";
            this.sanzimanTip.Name = "sanzimanTip";
            // 
            // ucrert
            // 
            this.ucrert.DataPropertyName = "ucret";
            this.ucrert.HeaderText = "Günlük Ücret";
            this.ucrert.Name = "ucrert";
            // 
            // arabaDURU
            // 
            this.arabaDURU.DataPropertyName = "arabaDurum";
            this.arabaDURU.HeaderText = "Araba Durum";
            this.arabaDURU.Name = "arabaDURU";
            // 
            // arabaRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.arabaRaporTablo);
            this.Controls.Add(this.pdfExport);
            this.Controls.Add(this.backToMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "arabaRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araba Rapor";
            this.Load += new System.EventHandler(this.arabaRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.arabaRaporTablo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backToMainMenu;
        private System.Windows.Forms.Button pdfExport;
        private System.Windows.Forms.DataGridView arabaRaporTablo;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracPlaka;
        private System.Windows.Forms.DataGridViewTextBoxColumn arabaMarka;
        private System.Windows.Forms.DataGridViewTextBoxColumn arabaModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn arabayil;
        private System.Windows.Forms.DataGridViewTextBoxColumn arabaTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn yakitTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanzimanTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucrert;
        private System.Windows.Forms.DataGridViewTextBoxColumn arabaDURU;
    }
}