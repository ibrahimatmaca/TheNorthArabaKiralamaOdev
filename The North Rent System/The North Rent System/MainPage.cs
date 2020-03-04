using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace The_North_Rent_System
{
    public partial class MainPage : Form
    {
        DBOClass kullanici;

        public MainPage()
        {
            InitializeComponent();
            kullanici = new DBOClass();
        }

        private void kullaniciEkle_Click(object sender, EventArgs e)
        {
            
            if (DBOClass.kullanicininYetki == "SuperAdmin")
            {
                KullaniciBilgileri kullaniciBilgileri = new KullaniciBilgileri();
                kullaniciBilgileri.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş yapabilmek için yeterli yetkiniz yok!","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void kullanıcıRaporu_Click(object sender, EventArgs e)
        {
            KullaniciRapor kullaniciRapor = new KullaniciRapor();
            kullaniciRapor.Show();
            this.Hide();
        }

        private void arabaRapor_Click(object sender, EventArgs e)
        {
            arabaRapor araba = new arabaRapor();
            araba.Show();
            this.Hide();
        }

        private void odemeRapor_Click(object sender, EventArgs e)
        {
            OdemeRapor odemeR = new OdemeRapor();
            odemeR.Show();
            this.Hide();
        }

        private void rezervasyonRapor_Click(object sender, EventArgs e)
        {
            RezervasyonRapor rezerve = new RezervasyonRapor();
            rezerve.Show();
            this.Hide();
        }

        private void rezervasyonBilgiler_Click(object sender, EventArgs e)
        {
            rezervasyonolustur rezNesne = new rezervasyonolustur();
            rezNesne.Show();
            this.Hide();
        }

        private void arabaEkleButton_Click(object sender, EventArgs e)
        {
            arabaEkle arabeEkleme = new arabaEkle();
            arabeEkleme.Show();
            this.Hide();
        }

        private void musteriButton_Click(object sender, EventArgs e)
        {
            MusteriGuncelleme nesnesi = new MusteriGuncelleme();
            nesnesi.Show();
            this.Hide();
        }
    }
}







