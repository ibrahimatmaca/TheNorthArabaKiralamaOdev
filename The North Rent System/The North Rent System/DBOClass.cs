using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace The_North_Rent_System
{
    class DBOClass
    {
        static string baglantiString = "Data Source = bilgisayarAD; Initial Catalog = veri tabanı ismi; Integrated Security = True";
        public SqlConnection baglantiS = new SqlConnection(baglantiString);
        SqlCommand sqlKomut;
        public SqlDataAdapter sqlDataSorgu; // Kullanıcıları listelemek için sqlData adapter
        public SqlDataReader reader; // Tablodan veri okumak!

        public bool yetkiDurum; // Bazı sayfaları açabilmek için yetki gerekli
        public static string kullanicininYetki; //Buradan dönen değer mainpage de kontrol ediliyor!
        public static string personelAdSoyad;

        public bool FirstPageLogin(string kullaniciAdi, string sifre)
        {
            bool durum = false;
            string sorguGir = "SELECT * FROM kullaniciTablosu WHERE kullaniciMailAdres=@kullaniciMailData AND kullaniciSifre=@sifreData;";
            sqlKomut = new SqlCommand(sorguGir, baglantiS);
            sqlKomut.Parameters.AddWithValue("@kullaniciMailData", kullaniciAdi);
            sqlKomut.Parameters.AddWithValue("@sifreData", sifre);

            if (baglantiS.State != System.Data.ConnectionState.Open)
                baglantiS.Open();
            reader = sqlKomut.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
                durum = true;
            else
                durum = false;

            reader.Close();
            return durum;
        }
        public bool YetkiOgrenme(string kullaniciAdi)
        {
            string sorgu = "SELECT kullaniciYetkisi,kullaniciAdSoyad FROM kullaniciTablosu WHERE kullaniciMailAdres=@mailAdres;";
            sqlKomut = new SqlCommand(sorgu, baglantiS);
            sqlKomut.Parameters.AddWithValue("@mailAdres", kullaniciAdi);
            if (baglantiS.State != System.Data.ConnectionState.Open)
                baglantiS.Open();
            sqlDataSorgu = new SqlDataAdapter(sqlKomut);
            reader = sqlKomut.ExecuteReader();
            if (reader.Read())
            {
                kullanicininYetki = reader["kullaniciYetkisi"].ToString();
                personelAdSoyad = reader["kullaniciAdSoyad"].ToString();
                yetkiDurum = true;
            }
            baglantiS.Close();
            return yetkiDurum;
        }
        public bool KisiMailKontrol(string kullaniciAdi)
        {
            bool kisiVar = false;
            string sorguGir = "SELECT * FROM kullaniciTablosu WHERE kullaniciMailAdres=@kullaniciMailData;";
            sqlKomut = new SqlCommand(sorguGir, baglantiS);
            sqlKomut.Parameters.AddWithValue("@kullaniciMailData", kullaniciAdi);
            if(baglantiS.State != System.Data.ConnectionState.Open)
                baglantiS.Open();
            reader = sqlKomut.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
                kisiVar = true;
            else
                kisiVar = false;
            reader.Close();
            return kisiVar;
        }
        //Aşağıdaki Listeleme fonksiyonunda gerekli verileri çekip grid data source da listelemeye yarıyor!
        //Buradan girilen değişkene göre farklı farklı listeleme yapabiliriz!
        public SqlDataAdapter Listele(string gelenTablo)
        {
            if (gelenTablo == "kullaniciTablosu")
            {
                sqlDataSorgu = new SqlDataAdapter("SELECT kullaniciMailAdres," +
                    "kullaniciAdSoyad,kullaniciTelefon,kullaniciYetkisi FROM kullaniciTablosu", baglantiString);
            }
            else if (gelenTablo == "kiralama")
            {
                sqlDataSorgu = new SqlDataAdapter("SELECT aracPlaka,marka,model," +
                    "uretimYili,kasaTipi,yakitTipi,sanzimanTipi,ucret FROM aracEkle WHERE arabaDurum = 'Boş'", baglantiString);
            }
            else if (gelenTablo == "aracEkle")
            {
                sqlDataSorgu = new SqlDataAdapter("SELECT aracPlaka,marka,model," +
                    "uretimYili,kasaTipi,yakitTipi,sanzimanTipi,ucret,arabaDurum FROM aracEkle", baglantiString);
            }
            else if (gelenTablo == "rezervasyonOlustur")
            {
                sqlDataSorgu = new SqlDataAdapter("SELECT personelAdSoyad,musteriAdSoyad,adres,telefonNumarasi," +
                    "aracPlaka,kimlikNumarasi,baslangicTarih,bitisTarih," +
                    "toplamGun,toplamFiyat,odeme FROM rezervasyonOlustur", baglantiString);
            }
            else if(gelenTablo == "odemeRapor")
            {
                sqlDataSorgu = new SqlDataAdapter("SELECT personelAdSoyad,musteriAdSoyad,telefonNumarasi,aracPlaka," +
                    "baslangicTarih,bitisTarih,toplamFiyat,odeme FROM rezervasyonOlustur", baglantiString);
            }
            else if (gelenTablo == "musteriTablosu")
                sqlDataSorgu = new SqlDataAdapter("SELECT adSoyad,kimlikNumarası,adres,telefon FROM musteriTablosu", baglantiString);


            baglantiS.Close();
            return sqlDataSorgu;
        }
        public bool kullaniciEkleme(string adSoyad, string eMailAdres, string telefon, string sifre, string kullaniciYetki)
        {
            bool durum = false;

            string sorguGir = "INSERT INTO kullaniciTablosu VALUES(@eMailAdres,@adSoyad,@telefon,@sifre,@kullaniciYetki);";
            sqlKomut = new SqlCommand(sorguGir, baglantiS);
            sqlKomut.Parameters.AddWithValue("@eMailAdres", eMailAdres);
            sqlKomut.Parameters.AddWithValue("@adSoyad", adSoyad);
            sqlKomut.Parameters.AddWithValue("@telefon", telefon);
            sqlKomut.Parameters.AddWithValue("@sifre", sifre);
            sqlKomut.Parameters.AddWithValue("@kullaniciYetki", kullaniciYetki);
            if (baglantiS.State != System.Data.ConnectionState.Open)
                baglantiS.Open();
            try
            {
                sqlKomut.ExecuteNonQuery();
                durum = true;
            }
            catch (Exception)
            {
                durum = false;
            }
            baglantiS.Close();
            return durum;
        }
        public bool KullaniciSilme(string eMailAdres)
        {
            bool durum = false;
            string sorguGir = "DELETE kullaniciTablosu FROM kullaniciTablosu WHERE kullaniciMailAdres=@kullaniciMailData;";
            sqlKomut = new SqlCommand(sorguGir, baglantiS);
            sqlKomut.Parameters.AddWithValue("@kullaniciMailData", eMailAdres);
            if (baglantiS.State != System.Data.ConnectionState.Open)
                baglantiS.Open();
            try
            {
                sqlKomut.ExecuteNonQuery();
                durum = true;
            }
            catch (Exception)
            {

            }
            baglantiS.Close();
            return durum;
        }
        public bool GuncellemeIslemi(string eMail, string adSoyad, string telefon, string sifre, string yetki)
        {
            bool basariliMi = false;
            string sorguGir = "UPDATE kullaniciTablosu SET " +
                "kullaniciAdSoyad=@kAd,kullaniciTelefon=@kTelefon,kullaniciSifre=@kSifre," +
                "kullaniciYetkisi=@kYetki WHERE kullaniciMailAdres=@mailAdres;";
            sqlKomut = new SqlCommand(sorguGir, baglantiS);

            sqlKomut.Parameters.AddWithValue("@mailAdres", eMail);
            sqlKomut.Parameters.AddWithValue("@kAd", adSoyad);
            sqlKomut.Parameters.AddWithValue("@kTelefon", telefon);
            sqlKomut.Parameters.AddWithValue("@kSifre", sifre);
            sqlKomut.Parameters.AddWithValue("@kYetki", yetki);
            if (baglantiS.State != System.Data.ConnectionState.Open)
                baglantiS.Open();
            try
            {
                sqlKomut.ExecuteNonQuery();
                basariliMi = true;
                baglantiS.Close();
            }
            catch (Exception)
            {

                basariliMi = false;
                baglantiS.Close();
            }

            return basariliMi;
        }
        public bool GuncellemeBilgileriGetir(string eMailAdres)
        {
            bool guncellemeDurum = false;
            string sorgu = "SELECT * FROM kullaniciTablosu WHERE kullaniciMailAdres=@kullaniciMailData;";
            sqlKomut = new SqlCommand(sorgu, baglantiS);
            sqlKomut.Parameters.AddWithValue("@kullaniciMailData", eMailAdres);
            sqlDataSorgu = new SqlDataAdapter(sqlKomut);
            if (baglantiS.State != System.Data.ConnectionState.Open)
                baglantiS.Open();
            reader = sqlKomut.ExecuteReader();
            if (reader.Read())
            {
                guncellemeDurum = true;
            }
            return guncellemeDurum;
        }
        public bool ArabaPlakaKontrol(string aracPlaka)
        {
            bool plakaVarMi = false;
            string sorguGir = "SELECT aracPlaka FROM aracEkle WHERE aracPlaka=@aracPlaka;";
            sqlKomut = new SqlCommand(sorguGir, baglantiS);
            sqlKomut.Parameters.AddWithValue("@aracPlaka", aracPlaka);
            if (baglantiS.State != System.Data.ConnectionState.Open)
                baglantiS.Open();
            reader = sqlKomut.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
                plakaVarMi = true;
            else
                plakaVarMi = false;
            reader.Close();
            return plakaVarMi;
        }
        public bool ArabaEkleme(string aracPlaka,string marka, string model, int uretimYil, string kasatip, string yakitTip, string sanzimanTip, int ucret, string arabaDurum)
        {
            bool eklendi = false;
            string sorguGir = "INSERT INTO aracEkle VALUES(@aracPlaka,@marka,@model,@uretimYil,@kasatip,@yakitTip,@sanzimanTip,@ucret,@arabaDurum);";
            sqlKomut = new SqlCommand(sorguGir, baglantiS);
            sqlKomut.Parameters.AddWithValue("@aracPlaka", aracPlaka);
            sqlKomut.Parameters.AddWithValue("@marka", marka);
            sqlKomut.Parameters.AddWithValue("@model", model);
            sqlKomut.Parameters.AddWithValue("@uretimYil", uretimYil);
            sqlKomut.Parameters.AddWithValue("@kasatip", kasatip);
            sqlKomut.Parameters.AddWithValue("@yakitTip", yakitTip);
            sqlKomut.Parameters.AddWithValue("@sanzimanTip", sanzimanTip);
            sqlKomut.Parameters.AddWithValue("@ucret", ucret);
            sqlKomut.Parameters.AddWithValue("@arabaDurum", arabaDurum);

            if (baglantiS.State != System.Data.ConnectionState.Open)
                baglantiS.Open();
            try
            {
                sqlKomut.ExecuteNonQuery();
                eklendi = true;
            }
            catch (Exception)
            {
                eklendi = false;
            }
            baglantiS.Close();
            return eklendi;
        }
        public bool ArabaSilme(string aracPlaka)
        {
            bool durum = false;
            string sorguGir = "DELETE FROM aracEkle WHERE aracPlaka=@aracPlaka;";
            sqlKomut = new SqlCommand(sorguGir, baglantiS);
            sqlKomut.Parameters.AddWithValue("@aracPlaka", aracPlaka);
            if (baglantiS.State != System.Data.ConnectionState.Open)
                baglantiS.Open();
            try
            {
                sqlKomut.ExecuteNonQuery();
                durum = true;
            }
            catch (Exception)
            {

            }
            baglantiS.Close();
            return durum;
        }
        public bool ArabaGuncelleme(string aracPlaka, string marka, string model, int uretimYil, string kasatip, string yakitTip, string sanzimanTip, int ucret, string arabaDurum)
        {
            bool basariliMi = false;
            string sorguGir = "UPDATE aracEkle SET marka=@marka," +
                "model=@model,uretimYili=@uretimYil,kasaTipi=@kasatip,yakitTipi=@yakitTip," +
                "sanzimanTipi=@sanzimanTip,ucret=@ucret,arabaDurum=@arabaDurum WHERE aracPlaka=@aracPlaka;";
            sqlKomut = new SqlCommand(sorguGir, baglantiS);
            sqlKomut.Parameters.AddWithValue("@aracPlaka", aracPlaka);
            sqlKomut.Parameters.AddWithValue("@marka", marka);
            sqlKomut.Parameters.AddWithValue("@model", model);
            sqlKomut.Parameters.AddWithValue("@uretimYil", uretimYil);
            sqlKomut.Parameters.AddWithValue("@kasatip", kasatip);
            sqlKomut.Parameters.AddWithValue("@yakitTip", yakitTip);
            sqlKomut.Parameters.AddWithValue("@sanzimanTip", sanzimanTip);
            sqlKomut.Parameters.AddWithValue("@ucret", ucret);
            sqlKomut.Parameters.AddWithValue("@arabaDurum", arabaDurum);
            if (baglantiS.State != System.Data.ConnectionState.Open)
                baglantiS.Open();
            try
            {
                sqlKomut.ExecuteNonQuery();
                basariliMi = true;
            }
            catch (Exception)
            {
                basariliMi = false;
            }
            baglantiS.Close();
            return basariliMi;
        }
        public bool rezervasyonekleme(string personelAd, string adSoyad, string Adres, string plaka, string telefonNumarasi, string kimlikNumarasi, string baslangicTarih, string bitisTarih,int gun, int toplamUcret, string durum)
        {
            bool eklenecek = false;
            // SQL DATABSAE TARİH AYARI SADECE ONUN YAPILMASI GEREKİYOR!!
            string sorguGir = "INSERT INTO rezervasyonOlustur VALUES(@personelAdSoyad,@adSoyad,@adres,@aracPlaka,@telefonNumarasi,@kimlikNumarasi,@baslangicTarih,@bitisTarih,@toplamGun,@toplamFiyat,@odeme);";
            sqlKomut = new SqlCommand(sorguGir, baglantiS);
            sqlKomut.Parameters.AddWithValue("@personelAdSoyad", personelAd);
            sqlKomut.Parameters.AddWithValue("@adSoyad", adSoyad);
            sqlKomut.Parameters.AddWithValue("@adres", Adres);
            sqlKomut.Parameters.AddWithValue("@aracPlaka", plaka);
            sqlKomut.Parameters.AddWithValue("@telefonNumarasi", telefonNumarasi);
            sqlKomut.Parameters.AddWithValue("@kimlikNumarasi", kimlikNumarasi);
            sqlKomut.Parameters.AddWithValue("@baslangicTarih", baslangicTarih);
            sqlKomut.Parameters.AddWithValue("@bitisTarih", bitisTarih);
            sqlKomut.Parameters.AddWithValue("@toplamGun", gun);
            sqlKomut.Parameters.AddWithValue("@toplamFiyat", toplamUcret);
            sqlKomut.Parameters.AddWithValue("@odeme", durum);

            if (baglantiS.State != System.Data.ConnectionState.Open)
                baglantiS.Open();
            try
            {
                sqlKomut.ExecuteNonQuery();
                eklenecek = true;
            }
            catch (Exception)
            {
                eklenecek = false;
            }
            baglantiS.Close();
            return eklenecek;
        }
        public bool Musteri(string adSoyad, string Adres, string telefonNumarasi, string kimlikNumarasi)
        {
            bool ekleme = false;
            string sorguGir = "INSERT INTO musteriTablosu VALUES(@adSoyad,@kimlikNumarasi,@adres,@telefonNumarasi);";
            sqlKomut = new SqlCommand(sorguGir, baglantiS);
            sqlKomut.Parameters.AddWithValue("@adSoyad", adSoyad);
            sqlKomut.Parameters.AddWithValue("@kimlikNumarasi", kimlikNumarasi);
            sqlKomut.Parameters.AddWithValue("@adres", Adres);
            sqlKomut.Parameters.AddWithValue("@telefonNumarasi", telefonNumarasi);

            if (baglantiS.State != System.Data.ConnectionState.Open)
                baglantiS.Open();
            try
            {
                sqlKomut.ExecuteNonQuery();
                ekleme = true;
            }
            catch (Exception)
            {
                ekleme = false;
            }
            baglantiS.Close();
            return ekleme;
        }
        public bool rezervasyonSilme(string kimlikNumarasi)
        {
            bool durum = false;
            string sorguGir = "DELETE rezervasyonOlustur FROM rezervasyonOlustur WHERE kimlikNumarasi=@musteriTcData;";
            sqlKomut = new SqlCommand(sorguGir, baglantiS);
            sqlKomut.Parameters.AddWithValue("@musteriTcData", kimlikNumarasi);

            if (baglantiS.State != System.Data.ConnectionState.Open)
                baglantiS.Open();
            try
            {
                sqlKomut.ExecuteNonQuery();
                durum = true;
            }
            catch (Exception)
            {

            }
            baglantiS.Close();
            return durum;
        }
        public bool RezervasyonGuncelleme(string kimlikNumarasi,string adSoyad,string Adres,string telefonNumarasi,string baslangicTarih,string bitisTarih,string gunsayisi,int toplamUcret)
        {
            bool durum = false;
            string sorguGir = "UPDATE rezervasyonOlustur SET musteriAdSoyad = @mAd, adres = @mAdres, telefonNumarasi = @mTelno," +
               "baslangicTarih = @rBaslangic, bitisTarih = @rBitis, toplamGun=@gunsayisi, toplamFiyat=@toplamFiyat, odeme='Ödenmedi' WHERE kimlikNumarasi=@mKimlik;";
            sqlKomut = new SqlCommand(sorguGir, baglantiS);

            sqlKomut.Parameters.AddWithValue("@mKimlik", kimlikNumarasi);
            sqlKomut.Parameters.AddWithValue("@mAd", adSoyad);
            sqlKomut.Parameters.AddWithValue("@mAdres", Adres);
            sqlKomut.Parameters.AddWithValue("@mTelno", telefonNumarasi);
            sqlKomut.Parameters.AddWithValue("@rBaslangic", baslangicTarih);
            sqlKomut.Parameters.AddWithValue("@rBitis", bitisTarih);
            sqlKomut.Parameters.AddWithValue("@gunsayisi", gunsayisi);
            sqlKomut.Parameters.AddWithValue("@toplamFiyat", toplamUcret);

            if (baglantiS.State != System.Data.ConnectionState.Open)
                baglantiS.Open();
            try
            {
                sqlKomut.ExecuteNonQuery();
                durum = true;
                baglantiS.Close();
            }
            catch (Exception)
            {

                durum = false;
                baglantiS.Close();
            }
            return durum;
        }
        public bool MüsteriKimlikKontrol(string kimlikNumarasi)
        {
            bool kisiVar = false;
            string sorguGir = "SELECT kimlikNumarasi FROM rezervasyonOlustur WHERE kimlikNumarasi=@musteriTcData;";
            sqlKomut = new SqlCommand(sorguGir, baglantiS);
            sqlKomut.Parameters.AddWithValue("@musteriTcData", kimlikNumarasi);
            if (baglantiS.State != System.Data.ConnectionState.Open)
                baglantiS.Open();
            reader = sqlKomut.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
                kisiVar = true;
            else
                kisiVar = false;
            reader.Close();
            return kisiVar;
        }
        public bool ArabaDurumDegis(string plaka, string durum)
        {
            bool basariliMi = false;
            string sorguGir = "UPDATE aracEkle SET arabaDurum=@arabaDurum WHERE aracPlaka=@aracPlaka;";
            sqlKomut = new SqlCommand(sorguGir, baglantiS);

            sqlKomut.Parameters.AddWithValue("@aracPlaka", plaka);
            sqlKomut.Parameters.AddWithValue("@arabaDurum",durum);

            baglantiS.Open();
            try
            {
                sqlKomut.ExecuteNonQuery();
                basariliMi = true;
                baglantiS.Close();
            }
            catch (Exception)
            {

                basariliMi = false;
                baglantiS.Close();
            }
            return basariliMi;
        }
        public bool MusteriGuncelleme(string musteriAd,string kimlikNo,string telefon,string adres, string hedef)
        {
            bool durum = false;
            string sorguGir = "UPDATE musteriTablosu SET adSoyad = @mAd, kimlikNumarası = @kimlik, adres = @mAdres, telefon = @mTelno WHERE kimlikNumarası=@hedef";
            sqlKomut = new SqlCommand(sorguGir, baglantiS);

            sqlKomut.Parameters.AddWithValue("@hedef", hedef);
            sqlKomut.Parameters.AddWithValue("@mAd", musteriAd);
            sqlKomut.Parameters.AddWithValue("@kimlik", kimlikNo);
            sqlKomut.Parameters.AddWithValue("@mAdres", telefon);
            sqlKomut.Parameters.AddWithValue("@mTelno", adres);

            if (baglantiS.State != System.Data.ConnectionState.Open)
                baglantiS.Open();
            try
            {
                sqlKomut.ExecuteNonQuery();
                durum = true;
                baglantiS.Close();
            }
            catch (Exception)
            {

                durum = false;
                baglantiS.Close();
            }
            return durum;
        }
        public bool OdemeDurumGuncelle(string plaka, string telefon, string odeme)
        {
            bool basariliMi = false;
            string sorguGir = "UPDATE rezervasyonOlustur SET odeme=@odeme WHERE telefonNumarasi=@tel AND aracPlaka=@plaka ;";
            sqlKomut = new SqlCommand(sorguGir, baglantiS);

            sqlKomut.Parameters.AddWithValue("@plaka", plaka);
            sqlKomut.Parameters.AddWithValue("@tel", telefon);
            sqlKomut.Parameters.AddWithValue("@odeme", odeme);

            baglantiS.Open();
            try
            {
                sqlKomut.ExecuteNonQuery();
                basariliMi = true;
                baglantiS.Close();
            }
            catch (Exception)
            {

                basariliMi = false;
                baglantiS.Close();
            }
            return basariliMi;
        }
        public string GunlukUcret(string plaka)
        {
            string ucret = "0";
            string sorguGir = "SELECT ucret FROM aracEkle WHERE aracPlaka=@plaka;";
            sqlKomut = new SqlCommand(sorguGir, baglantiS);
            sqlKomut.Parameters.AddWithValue("@plaka", plaka);
            if (baglantiS.State != System.Data.ConnectionState.Open)
                baglantiS.Open();
            reader = sqlKomut.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
                ucret = reader["ucret"].ToString();
            else
                ucret = "0";
            reader.Close();
            return ucret;
        }
    }
}
