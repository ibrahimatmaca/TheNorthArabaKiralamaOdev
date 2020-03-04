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
    public partial class FirstPage : Form
    {
        DBOClass kullaniciGiris;
        
        public FirstPage()
        {
            InitializeComponent();
            sifreTextBox.PasswordChar = '•';
            kullaniciGiris = new DBOClass();
        }
        
        private void FirstPage_Load(object sender, EventArgs e){
            try
            {
                kullaniciGiris.baglantiS.Open();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
                kullaniciGiris.baglantiS.Close();
            }
        
        }

        private void girisButton_Click(object sender, EventArgs e)
        {
            if ((kullaniciAdiTextBox.Text == string.Empty) && sifreTextBox.Text == string.Empty)
            {
                MessageBox.Show("Lütfen alanları gerekli alanları doldurun.");
                return;
            }
            else
            {
                if(kullaniciGiris.FirstPageLogin(kullaniciAdiTextBox.Text, sifreTextBox.Text))
                {
                   
                    if (kullaniciGiris.YetkiOgrenme(kullaniciAdiTextBox.Text))
                    {
                        MainPage mainPage = new MainPage();
                        mainPage.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Yetki hatası");
                    }
                }
                else
                {
                    MessageBox.Show("Geçersiz Giriş");
                    kullaniciAdiTextBox.Clear();
                    sifreTextBox.Clear();
                    return;
                }
            }
        }
    }
}
