using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Security.Cryptography;
namespace VakifbankProje
{
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-08CMBGO\\SQLEXPRESS;Initial Catalog=UniversiteDb;Integrated Security=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            rsmYol.Text = dosyayolu;
            pictureBox1.ImageLocation = dosyayolu;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void cikisButon_Click(object sender, EventArgs e)
        {
            GirisEkran goster = new GirisEkran();
            goster.Show();
        }

        private void anaekranButon_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Admin adminAnaekran = new Admin();
            adminAnaekran.k_adminAd = bilgiLBL.Text;
            adminAnaekran.ShowDialog();
        }
        public string k_kullaniciAd;
        private void Ayarlar_Load(object sender, EventArgs e)
        {
            bilgiLBL.Text = k_kullaniciAd;
             SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM Kullanici where kullaniciAdi='"+k_kullaniciAd+"'";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                kullaniciAdiTextBox.Text = dr["kullaniciAdi"].ToString();
                adTextBox.Text = dr["Adi"].ToString();
                soyadiTextBox.Text = dr["Soyadi"].ToString();
                //sifreTextBox.Text = dr["sifre"].ToString();
                mailTextBox.Text = dr["mail"].ToString();
                pictureBox1.ImageLocation = dr["resim"].ToString();
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            baglanti.Close();
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
        private void kaydetbuton_Click(object sender, EventArgs e)
        {
            if (kullaniciAdiTextBox.Text != string.Empty && adTextBox.Text != string.Empty && soyadiTextBox.Text != string.Empty && mailTextBox.Text != string.Empty)
            {
                baglanti.Open();
                string kayit = "update Kullanici set  kullaniciAdi='" + kullaniciAdiTextBox.Text + "', Adi='" + adTextBox.Text + "', Soyadi='" + soyadiTextBox.Text + "', mail='" + mailTextBox.Text  +"', resim='" + rsmYol.Text + "' where kullaniciAdi='" + kullaniciAdiTextBox.Text + "'";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                devamSifre goster = new devamSifre();
                goster.k_kullaniciAd = k_kullaniciAd;
                goster.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Bütün Alanları Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
