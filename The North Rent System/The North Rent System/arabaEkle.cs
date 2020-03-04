using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_North_Rent_System
{
    public partial class arabaEkle : Form
    {
        DBOClass arabaNesnesi;
        DataTable data;

        public arabaEkle()
        {
            InitializeComponent();
            arabaNesnesi = new DBOClass();
        }

        private void arabaEkle_Load(object sender, EventArgs e)
        {
            TabloYenilemeAraba();
        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            MainPage anaSayfa = new MainPage();
            anaSayfa.Show();
            this.Hide();
        }
        private void TabloYenilemeAraba()
        {
            data = new DataTable();
            arabaNesnesi.Listele("aracEkle").Fill(data);

            arabaTablosu.AllowUserToDeleteRows = false;
            arabaTablosu.ReadOnly = true;
            arabaTablosu.DataSource = data;
        }
        private void Temizleme()
        {
            plakaText.Clear();
            markaText.Clear();
            modelText.Clear();
            uretimYiliText.Clear();
            kasaCombo.ResetText();
            yakitCombo.ResetText();
            sanzimanCombo.ResetText();
            ucretGunluk.Clear();
            arabaDurumCombo.ResetText();
        }
        private void arabaEkleme_Click(object sender, EventArgs e)
        {
            if (arabaNesnesi.ArabaPlakaKontrol(plakaText.Text))
            {
                MessageBox.Show("Bu plakaya ait araba zaten var! Plakayı kontrol edin.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (plakaText.Text != "" && markaText.Text != "" && modelText.Text != "" && uretimYiliText.Text != "" && kasaCombo.Text != ""
                    && yakitCombo.Text != "" && sanzimanCombo.Text != "" && ucretGunluk.Text != "" && arabaDurumCombo.Text != "")
                {
                    bool eklendiMi = arabaNesnesi.ArabaEkleme(plakaText.Text, markaText.Text, modelText.Text, Int32.Parse(uretimYiliText.Text),
                    kasaCombo.Text, yakitCombo.Text, sanzimanCombo.Text, Int32.Parse(ucretGunluk.Text), arabaDurumCombo.Text);
                    
                    if (eklendiMi)
                        MessageBox.Show("İşleminiz Başarıyla Gerçeleşmiştir !", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Araba Eklenemedi !", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    TabloYenilemeAraba();
                    Temizleme();
                }
                else
                {
                    MessageBox.Show("Lütfen Tüm alanları doldurun", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void guncellemeButton_Click(object sender, EventArgs e)
        {
            if (plakaText.Text != "" && markaText.Text != "" && modelText.Text != "" && uretimYiliText.Text != "" && kasaCombo.Text != ""
                    && yakitCombo.Text != "" && sanzimanCombo.Text != "" && ucretGunluk.Text != "" && arabaDurumCombo.Text != "")
            {
                bool silmeBasarili = arabaNesnesi.ArabaGuncelleme(plakaText.Text, markaText.Text, modelText.Text, Int32.Parse(uretimYiliText.Text),
                    kasaCombo.Text, yakitCombo.Text, sanzimanCombo.Text, Int32.Parse(ucretGunluk.Text), arabaDurumCombo.Text);
                if (silmeBasarili)
                    MessageBox.Show("Başarıyla Güncellendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Güncelleme işlemi sırasında bir sorun oluştu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TabloYenilemeAraba();
                Temizleme();
                plakaText.ReadOnly = false;
            }
            else
            {
                MessageBox.Show("Boş kalan alan var.Lütfen girilen bilgileri kontrol edin.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void silmeButton_Click(object sender, EventArgs e)
        {
            if(plakaText.Text != "")
            {
                bool silmeBasarili = arabaNesnesi.ArabaSilme(plakaText.Text);
                if(silmeBasarili)
                    MessageBox.Show("Başarıyla Silindi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Silme işlemi sırasında bir sorun oluştu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TabloYenilemeAraba();
                Temizleme();
            }
            else
            {
                MessageBox.Show("Plaka kısmı boş", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Güncelleme için lazım olacak olan yer
        private void arabaTablosu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int cellRow = arabaTablosu.SelectedCells[0].RowIndex;
            plakaText.Text = arabaTablosu.Rows[cellRow].Cells[0].Value.ToString();
            markaText.Text = arabaTablosu.Rows[cellRow].Cells[1].Value.ToString();
            modelText.Text = arabaTablosu.Rows[cellRow].Cells[2].Value.ToString();
            uretimYiliText.Text = arabaTablosu.Rows[cellRow].Cells[3].Value.ToString();
            kasaCombo.Text = arabaTablosu.Rows[cellRow].Cells[4].Value.ToString();
            yakitCombo.Text = arabaTablosu.Rows[cellRow].Cells[5].Value.ToString();
            sanzimanCombo.Text = arabaTablosu.Rows[cellRow].Cells[6].Value.ToString();
            ucretGunluk.Text = arabaTablosu.Rows[cellRow].Cells[7].Value.ToString();
            arabaDurumCombo.Text = arabaTablosu.Rows[cellRow].Cells[8].Value.ToString();
            plakaText.ReadOnly = true;
        }
    }
}
