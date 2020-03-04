using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace The_North_Rent_System
{
    public partial class KullaniciBilgileri : Form
    {
        public bool bilgi = false;
        DBOClass kullaniciGiris;
        DataTable sqlData;

        public KullaniciBilgileri()
        {
            InitializeComponent();
            kullaniciGiris = new DBOClass();
        }

        private void KullaniciBilgileri_Load(object sender, EventArgs e)
        {
            TabloYenileme();
            telefonTextBox.MaxLength = 10;

        }

        private void eklemeButton_Click(object sender, EventArgs e)
        {
            if (!bilgi)
            {
                if (kullaniciGiris.KisiMailKontrol(eMailTextBox.Text))
                {
                    MessageBox.Show("Eklemeye çalıştığınız mail adresi zaten var!", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if(telefonTextBox.TextLength == 10)
                    {
                        if (adSoyadTextBox.Text != "" && eMailTextBox.Text != "" && telefonTextBox.Text != "" &&
                    sifreTextBox.Text != "" && yetkiComboBox.Text != "")
                        {

                            bool durum = kullaniciGiris.kullaniciEkleme(adSoyadTextBox.Text, eMailTextBox.Text,
                         telefonTextBox.Text, sifreTextBox.Text, yetkiComboBox.Text);
                            if (durum)
                                MessageBox.Show("İşleminiz Başarıyla Gerçeleşmiştir !", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("İşleminizde Hata Meydana Geldi !", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Temizleme();
                            TabloYenileme();

                        }
                        else
                        {
                            MessageBox.Show("Lütfen Tüm alanları doldurun", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Telefon Numaranız hatalı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
                MessageBox.Show("Şuan da güncelleme işlemini yapmaktasınız!",
                    "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TabloYenileme()
        {
            sqlData = new DataTable();
            kullaniciGiris.Listele("kullaniciTablosu").Fill(sqlData);

            kullanicilar.AllowUserToAddRows = false;
            kullanicilar.AllowUserToDeleteRows = false;
            kullanicilar.ReadOnly = true;
            kullanicilar.DataSource = sqlData;
        }

        private void Temizleme()
        {
            adSoyadTextBox.Clear();
            eMailTextBox.Clear();
            telefonTextBox.Clear();
            sifreTextBox.Clear();
            yetkiComboBox.ResetText();
        }

        private void silmeButton_Click(object sender, EventArgs e)
        {
            if (bilgi)
            {
                if (kullaniciGiris.KisiMailKontrol(eMailTextBox.Text))
                {
                    if (kullaniciGiris.KullaniciSilme(eMailTextBox.Text))
                    {
                        MessageBox.Show("Kullanıcı başarılı bir şekilde silindi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TabloYenileme();
                        Temizleme();
                        bilgi = false;
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Silinemedi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (eMailTextBox.Text != "")
                    {
                        MessageBox.Show("Böyle bir kullanıcı yok." +
                            "Lütfen E-mail adresini kontrol edin!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Lütfen E-mail alanını doldurun!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Şuan da güncelleme işlemini yapmaktasınız!",
                    "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void güncellemeButton_Click(object sender, EventArgs e)
        {
            if (yetkiComboBox.Text != "")
            {
                if (kullaniciGiris.GuncellemeIslemi(eMailTextBox.Text, adSoyadTextBox.Text,
                telefonTextBox.Text, sifreTextBox.Text, yetkiComboBox.Text))
                {
                    MessageBox.Show("Başarılı bir şekilde güncellendi.", "Bilgilendirme");
                    eMailTextBox.ReadOnly = false;
                    bilgi = false;
                    Temizleme();
                    TabloYenileme();
                }
                else
                {
                    MessageBox.Show("Bir hata oluştu.", "Hata");
                }
            }
            else
                MessageBox.Show("Yetki alanı boş olabilir.Lütfen doldurun",
                    "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Double Click mevzusu hallet burada
        private void bilgileriGetir_Click(object sender, EventArgs e)
        {
            
        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            MainPage anaSayfa = new MainPage();
            anaSayfa.Show();
            this.Hide();
        }

        private void telefonTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void telefonTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void kullanicilar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bilgi = true;
            int istenen = kullanicilar.SelectedCells[0].RowIndex;
            eMailTextBox.Text = kullanicilar.Rows[istenen].Cells[0].Value.ToString();
            adSoyadTextBox.Text = kullanicilar.Rows[istenen].Cells[1].Value.ToString();
            telefonTextBox.Text = kullanicilar.Rows[istenen].Cells[2].Value.ToString();
            yetkiComboBox.Text = kullanicilar.Rows[istenen].Cells[3].Value.ToString();
        }
    }
}
