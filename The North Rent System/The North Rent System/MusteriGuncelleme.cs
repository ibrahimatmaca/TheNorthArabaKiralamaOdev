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
    public partial class MusteriGuncelleme : Form
    {
        DBOClass musteriT;
        DataTable sqlData;
        string hedefKimlik;

        public MusteriGuncelleme()
        {
            InitializeComponent();
            musteriT = new DBOClass();
        }

        private void MusteriGuncelleme_Load(object sender, EventArgs e)
        {
            TabloYenileme();
        }

        private void musteriTablo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int istenen = musteriTablo.SelectedCells[0].RowIndex;
            adSoyad.Text = musteriTablo.Rows[istenen].Cells[0].Value.ToString();
            kimlikNo.Text = musteriTablo.Rows[istenen].Cells[1].Value.ToString();
            adresleme.Text = musteriTablo.Rows[istenen].Cells[2].Value.ToString();
            telefonNo.Text = musteriTablo.Rows[istenen].Cells[3].Value.ToString();
            
            hedefKimlik = kimlikNo.Text;
        }

        private void TabloYenileme()
        {
            sqlData = new DataTable();
            musteriT.Listele("musteriTablosu").Fill(sqlData);

            musteriTablo.AllowUserToAddRows = false;
            musteriTablo.AllowUserToDeleteRows = false;
            musteriTablo.ReadOnly = true;
            musteriTablo.DataSource = sqlData;
        }

        private void Temizle()
        {
            adSoyad.Clear();
            kimlikNo.Clear();
            adresleme.Clear();
            telefonNo.Clear();
        }

        private void guncellemeButton_Click(object sender, EventArgs e)
        {
            if(adSoyad.Text != "" && kimlikNo.Text != "" && adresleme.Text != "" && telefonNo.Text != "")
            {
                if (musteriT.MusteriGuncelleme(adSoyad.Text,kimlikNo.Text,telefonNo.Text, adresleme.Text,hedefKimlik))
                {
                    TabloYenileme();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Ekleme işlemi sırasında hata ile karşılaşıldı.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen boş alanları doldurun!", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            MainPage nesne = new MainPage();
            nesne.Show();
            this.Hide();
        }
    }
}
