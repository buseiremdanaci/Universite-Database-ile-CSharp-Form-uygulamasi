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
using System.Net;
using System.Security.Cryptography;
namespace VakifbankProje
{
    public partial class devamSifre : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-08CMBGO\\SQLEXPRESS;Initial Catalog=UniversiteDb;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataReader dr;
        public string k_kullaniciAd;
        public devamSifre()
        {
            InitializeComponent();
            sifreDevam.PasswordChar = '*';
        }

        private void devamEt_Click(object sender, EventArgs e)
        {
            

                baglanti.Open();
                string kayit = "SELECT * from Kullanici where sifre like '" + sifreDevam.Text + "%'";
                cmd = new SqlCommand(kayit, baglanti);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Değişiklikler Başarılı Bir Şekilde Düzenlendi", "Bilgilendirme Mesajı",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                    
                }
                
            
            else
            {
                MessageBox.Show("Şifrenizi Kontrol Ediniz", "Bilgilendirme Mesajı",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
            if (k_kullaniciAd == "Admin")
            {
                this.Hide();
                Ayarlar adminAyar = new Ayarlar();
                adminAyar.k_kullaniciAd = bilgiLBL.Text;
                adminAyar.ShowDialog();
            }
            else
            {
                this.Hide();
                ogrenciAyar ogrenciAyar = new ogrenciAyar();
                ogrenciAyar.k_kullaniciAd = bilgiLBL.Text;
                ogrenciAyar.ShowDialog();
            }
            
            baglanti.Close();

        }

        private void devamSifre_Load(object sender, EventArgs e)
        {
            bilgiLBL.Text = k_kullaniciAd;
        }

        private void sifreGoster_Click(object sender, EventArgs e)
        {

            if (sifreDevam.PasswordChar.ToString() == "*")
            {
                sifreDevam.PasswordChar = char.Parse("\0");

            }
            else
            {
                sifreDevam.PasswordChar = char.Parse("*");

            }
        }
    }
}
