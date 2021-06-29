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
using System.Security.Cryptography;
namespace VakifbankProje
{
    public partial class GirisEkran : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-08CMBGO\\SQLEXPRESS;Initial Catalog=UniversiteDb;Integrated Security=True;");
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlDataReader dr;
        public GirisEkran()
        {
            InitializeComponent();
            sifre.PasswordChar = '*';
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
        private void girisButon_Click(object sender, EventArgs e)
        {
                        
            string sorgu = "SELECT * FROM Kullanici where  ( kullaniciAdi COLLATE Latin1_general_CS_AS = '" + k_ad.Text + "' )AND sifre = '" + MD5Hash(sifre.Text) + "'";
            string adminSorgu = "Select * from Kullanici where(kullaniciAdi COLLLATE Latin1_general_CS_AS='Admin'" + "and (sifre='" + MD5Hash(sifre.Text) + "')";
            cmd = new SqlCommand(sorgu, baglanti);
            cmd2 = new SqlCommand(adminSorgu, baglanti);
            baglanti.Open();
                dr = cmd.ExecuteReader();
            UniversiteDb ogrencigiris = new UniversiteDb();
            Admin admingiris = new Admin();
            ogrencigiris.k_kullaniciAd = k_ad.Text;
            
            if (dr.Read())
            {
                if (k_ad.Text == "Admin")
                {
                    // Admin frm = new Admin();
                    this.Hide();
                    admingiris.k_adminAd = k_ad.Text;
                    admingiris.ShowDialog();

                }
                else 
                {
                    //UniversiteDb frm = new UniversiteDb();
                    this.Hide();
                    ogrencigiris.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
                baglanti.Close();
            
        }

        
        private void GirisEkran_Load(object sender, EventArgs e)
        {
            girisButon.Enabled = false;

        }

        private void kullaniciAdi_Click(object sender, EventArgs e)
        {

        }

        private void sifreGoster_Click(object sender, EventArgs e)
        {
           
            if (sifre.PasswordChar.ToString() == "*")
            {
                sifre.PasswordChar = char.Parse("\0");

            }
            else
            {
                sifre.PasswordChar = char.Parse("*");

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttum goster = new SifremiUnuttum();
            goster.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            girisButon.Enabled = true;
            if (checkBox1.Checked = true)
            {
                KodTanima goster = new KodTanima();
                goster.ShowDialog();
                if (goster.Enabled == false)
                {
                    checkBox1.Checked = true;
                }
            }


        }
        private void checkBox1_Click(object sender, EventArgs e)
        {
            
            
           
        }
    }
}
