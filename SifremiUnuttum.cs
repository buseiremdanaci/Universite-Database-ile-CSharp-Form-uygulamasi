using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Documents;
using System.Data.Linq;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;
namespace VakifbankProje
{
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-08CMBGO\\SQLEXPRESS;Initial Catalog=UniversiteDb;Integrated Security=True;");
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlCommand cmd3;
        SqlDataReader reader;
        
         
        private void SifremiUnuttum_Load(object sender, EventArgs e)
        {
            
        }
        
        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }
       
           
        
        private void kontrolEt_Click(object sender, EventArgs e)
        {
            //Randon kod üretmek için..
            Random rastgeleKodUretici = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 6; i++)
            {
                int ascii = rastgeleKodUretici.Next(64, 122);
                char karakter = Convert.ToChar(ascii);
                sb.Append(karakter);
            }
            //mail gondermek icin..
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;
            string kime = k_mailKontrol.Text;
            string konu = "-- Sifre Yenileme Kodu --";
            string icerik = "Bilgilerinizin dogrululugu kontrol edilmistir. Yeni sifre belirlemeden once mail adresinize gelen" +
                "kontrol kodumuzu uygulamaya girmeniz gerekmektedir. '" + sb.ToString() + "'";
            sc.Credentials = new NetworkCredential("mailsender4test@gmail.com", "password4test");
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("mailsender4test@gmail.com", "Sifre Yenileme");
            mail.To.Add(kime);
            mail.Subject = konu;
            mail.IsBodyHtml = true;
            mail.Body = icerik;
            if (kadKontrol.Text != "" && k_mailKontrol.Text != "")
            {
                
                try
                {
                    string sorguDogrulamaKod = "UPDATE Kullanici set dogrulamaKodu='" + sb.ToString() + "' where kullaniciAdi ='" + k_adKontrol.Text + "'";
                    string sorgu = "SELECT * FROM Kullanici WHERE kullaniciAdi='" + k_adKontrol.Text + "' AND Adi='" + kadKontrol.Text + "' AND Soyadi='" + k_soyadKontrol.Text + "'";
                    cmd = new SqlCommand(sorgu, baglanti);
                    cmd2 = new SqlCommand(sorguDogrulamaKod, baglanti);
                    baglanti.Open();
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                          groupBox1.Enabled = true;
                        MessageBox.Show("Doğrulama kodunu giriniz.");
                        //maili gonderme ic kısma alınacak 
                        sc.Send(mail);
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı bilgileri eksik veya hatalı girildi. Tekrar deneyiniz!", "Bilgilendirme Mesajı",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayınız!", "Bilgilendirme Mesajı",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            baglanti.Close();
        }
        public static string _OnayKodu = "";
       
        private void Yolla_Click(object sender, EventArgs e)
        {
            
        }
        private void kaydet_Click(object sender, EventArgs e)
        {
            if (kadKontrol.Text != "")
            {
                try
                {
                    
                    
                    if (yeniSifreTekrar.Text == yeniSifre.Text)
                    {
                        string sorgu = "UPDATE Kullanici SET sifre=@ksifre WHERE kullaniciAdi='" + k_adKontrol.Text + "'";
                        cmd = new SqlCommand(sorgu, baglanti);
                        cmd.Parameters.AddWithValue("@ksifre", MD5Hash(yeniSifre.Text));
                        baglanti.Open();
                        reader = cmd.ExecuteReader();
                        MessageBox.Show("Kaydedildi.");

                    }
                    else
                    {
                        MessageBox.Show("Şifreler Birbiriyle Eşleşmiyor!", "Bilgilendirme Mesajı",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayınız!", "Bilgilendirme Mesajı",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            baglanti.Close();
        }
        int kiyasla()
        {
            
            return 1;
        }
        void dogrulama()
        {
            baglanti.Open();
            string kayit = "SELECT * from Kullanici where dogrulamaKodu like '" + sifreKontrol.Text + "%'";
            cmd3 = new SqlCommand(kayit, baglanti);
            reader = cmd3.ExecuteReader();
            if (reader.Read())
            {
                groupBox1.Enabled = true;
            }
            baglanti.Close();
        }
        private void yolla_Click_1(object sender, EventArgs e)
        {
            
            if (sifreKontrol.Text != "")
            {

                dogrulama();
            }
            else
            {
                MessageBox.Show("yanlış", "Bilgilendirme Mesajı",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            baglanti.Close();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void anaekranButon_Click(object sender, EventArgs e)
        {
            GirisEkran sifreDonus = new GirisEkran();
            this.Hide();
            sifreDonus.Show();
        }
    }
}

