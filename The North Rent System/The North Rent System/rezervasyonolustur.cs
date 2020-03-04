using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace The_North_Rent_System
{
    public partial class rezervasyonolustur : Form
    {
        public bool bilgi = false;
        DBOClass rezervasyongiris;
        DataTable data;

        private int ucretA;
        private int gunsayisi;
        private int fiyat;

        public rezervasyonolustur()
        {
            rezervasyongiris = new DBOClass();
            InitializeComponent();
        }

        private void rezervasyonolustur_Load(object sender, EventArgs e)
        {
            TabloYenilemeRez();
            TabloYenilemeMus();
            TabloYenilemeAraba();
        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            MainPage mainpage = new MainPage();
            mainpage.Show();
            this.Hide();
        }

        private void rezervasyonEkleButton_Click(object sender, EventArgs e)
        {
            if (rezervasyongiris.MüsteriKimlikKontrol(TCnoMaskedTextBox.Text))
            {
                MessageBox.Show("Bu TC kimlik numarasıyla zaten bir rezervasyon var!", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (adSoyadTextBox.Text != "" && AdresTextBox.Text != "" && TelnoMaskedTextBox.Text != "" && TCnoMaskedTextBox.Text != "" && baslangicDateTime.Text != ""
                    && bitisDateTime.Text != "" && aracPlakaTextBox.Text != "" && toplamFiyatTextBox.Text != "")
                {

                    bool ekleme = rezervasyongiris.rezervasyonekleme(DBOClass.personelAdSoyad,adSoyadTextBox.Text, AdresTextBox.Text, aracPlakaTextBox.Text,
                        TelnoMaskedTextBox.Text, TCnoMaskedTextBox.Text, baslangicDateTime.Text, bitisDateTime.Text, gunsayisi, fiyat,"Ödenmedi");
                    
                    if (ekleme)
                    {
                        rezervasyongiris.ArabaDurumDegis(aracPlakaTextBox.Text, "Kiralandı");
                        rezervasyongiris.Musteri(adSoyadTextBox.Text, AdresTextBox.Text, TelnoMaskedTextBox.Text, TCnoMaskedTextBox.Text);
                        MessageBox.Show("İşleminiz Başarıyla Gerçeleşmiştir !", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ReadOnlyControl(false);
                    }
                    else
                        MessageBox.Show("Rezervasyon oluşturulamadı !", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Temizleme();
                    TabloYenilemeRez();
                    TabloYenilemeMus();
                    TabloYenilemeAraba();
                }
                else
                {
                    MessageBox.Show("Lütfen Tüm alanları doldurun", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void Temizleme()
        {
            adSoyadTextBox.Clear();
            AdresTextBox.Clear();
            TelnoMaskedTextBox.Clear();
            TCnoMaskedTextBox.Clear();
            aracPlakaTextBox.Clear();
            toplamFiyatTextBox.Clear();
            fiyatTextBox.Clear();
            gunSayisiTextBox.Clear();
        }

        private void rezervasyonSilButton_Click(object sender, EventArgs e)
        {
            if (!bilgi)
            {
                if (rezervasyongiris.MüsteriKimlikKontrol(TCnoMaskedTextBox.Text))
                {
                    if (rezervasyongiris.rezervasyonSilme(TCnoMaskedTextBox.Text))
                    {
                        rezervasyongiris.ArabaDurumDegis(aracPlakaTextBox.Text, "Boş");
                        MessageBox.Show("Rezervasyon başarılı bir şekilde silindi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizleme();
                        TabloYenilemeRez();
                        TabloYenilemeAraba();
                        ReadOnlyControl(false);
                    }
                    else
                    {
                        MessageBox.Show("Rezervasyon Silinemedi!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    if (TCnoMaskedTextBox.Text != "")
                    {
                        MessageBox.Show("Böyle bir rezervasyon bulunmamaktadır !", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lütfen TC Kimlik Numarası Bölümünü Doldurunuz !", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Şuan da güncelleme işlemini yapmaktasınız!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RezervasyonGüncelleButton_Click(object sender, EventArgs e)
        {
            if (adSoyadTextBox.Text != "" && AdresTextBox.Text != "" && TelnoMaskedTextBox.Text != "" && TCnoMaskedTextBox.Text != "" && baslangicDateTime.Text != ""
                    && bitisDateTime.Text != "")
            {
                TotalGun();
                if (rezervasyongiris.RezervasyonGuncelleme(TCnoMaskedTextBox.Text, adSoyadTextBox.Text, AdresTextBox.Text, TelnoMaskedTextBox.Text, baslangicDateTime.Text, bitisDateTime.Text,gunsayisi.ToString(), fiyat))
                {
                    MessageBox.Show("Güncelleme işlemi başarılı bir şekilde yapıldı!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizleme();
                    TabloYenilemeRez();
                    ReadOnlyControl(false);
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi yapılamadı!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Tüm alanları doldurun", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tutarHesaplaButton_Click(object sender, EventArgs e)
        {
            //Toplam gün hesaplama
            TotalGun();

            if (fiyatTextBox.Text != "" && gunSayisiTextBox.Text != "")
            {
                ucretA = Convert.ToInt32(fiyatTextBox.Text);
                gunsayisi = Convert.ToInt32(gunSayisiTextBox.Text);
                fiyat = ucretA * gunsayisi;
                toplamFiyatTextBox.Text = fiyat.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen Ücret Alanının Dolu olduğundan Emin Olunuz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TotalGun()
        {
            DateTime baslangicTarih = baslangicDateTime.Value;
            DateTime bitisTarih = bitisDateTime.Value;
            System.TimeSpan zaman;
            zaman = bitisTarih.Subtract(baslangicTarih);
            gunsayisi = Convert.ToInt32(zaman.TotalDays);
            gunSayisiTextBox.Text = gunsayisi.ToString();
            gunSayisiTextBox.ReadOnly = true;
        }
        private void TelnoMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TCnoMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        
        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int istenen = rezervasyonTablo.SelectedCells[0].RowIndex;
            adSoyadTextBox.Text = rezervasyonTablo.Rows[istenen].Cells[1].Value.ToString();
            AdresTextBox.Text = rezervasyonTablo.Rows[istenen].Cells[2].Value.ToString();
            TelnoMaskedTextBox.Text = rezervasyonTablo.Rows[istenen].Cells[3].Value.ToString();
            aracPlakaTextBox.Text = rezervasyonTablo.Rows[istenen].Cells[4].Value.ToString();
            TCnoMaskedTextBox.Text = rezervasyonTablo.Rows[istenen].Cells[5].Value.ToString();
            toplamFiyatTextBox.Text = rezervasyonTablo.Rows[istenen].Cells[9].Value.ToString();
            fiyatTextBox.Text = rezervasyongiris.GunlukUcret(aracPlakaTextBox.Text);
            ReadOnlyControl(true);

        }
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int istenen = arabaTablo.SelectedCells[0].RowIndex;
            aracPlakaTextBox.Text = arabaTablo.Rows[istenen].Cells[0].Value.ToString();
            fiyatTextBox.Text = arabaTablo.Rows[istenen].Cells[7].Value.ToString();
        }

        private void musteriTablo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            data = new DataTable();
            rezervasyongiris.Listele("musteriTablosu").Fill(data);
        }

        private void TabloYenilemeRez()
        {
            data = new DataTable();
            rezervasyongiris.Listele("rezervasyonOlustur").Fill(data);

            rezervasyonTablo.AllowUserToDeleteRows = false;
            rezervasyonTablo.ReadOnly = true;
            rezervasyonTablo.DataSource = data;
        }
        private void musteriTablo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int istenen = musteriTablo.SelectedCells[0].RowIndex;
            adSoyadTextBox.Text = musteriTablo.Rows[istenen].Cells[0].Value.ToString();
            TCnoMaskedTextBox.Text = musteriTablo.Rows[istenen].Cells[1].Value.ToString();
            AdresTextBox.Text = musteriTablo.Rows[istenen].Cells[2].Value.ToString();
            TelnoMaskedTextBox.Text = musteriTablo.Rows[istenen].Cells[3].Value.ToString();

            ReadOnlyControl(true);
        }

        //Read only olacak alanları seçiyoruz ki sonra sorun olmasın
        private void ReadOnlyControl(bool _value)
        {
            adSoyadTextBox.ReadOnly = _value;
            TCnoMaskedTextBox.ReadOnly = _value;
            AdresTextBox.ReadOnly = _value;
            TelnoMaskedTextBox.ReadOnly = _value;
        }

        private void TabloYenilemeMus()
        {
            data = new DataTable();
            rezervasyongiris.Listele("musteriTablosu").Fill(data);

            musteriTablo.AllowUserToDeleteRows = false;
            musteriTablo.ReadOnly = true;
            musteriTablo.DataSource = data;
        }

        private void TabloYenilemeAraba()
        {
            data = new DataTable();
            rezervasyongiris.Listele("kiralama").Fill(data);

            arabaTablo.AllowUserToDeleteRows = false;
            arabaTablo.ReadOnly = true;
            arabaTablo.DataSource = data;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        
    }
}
