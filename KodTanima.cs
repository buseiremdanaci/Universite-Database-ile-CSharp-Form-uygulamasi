using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace VakifbankProje
{
    public partial class KodTanima : Form
    {
        public KodTanima()
        {
            InitializeComponent();
        }
        private Bitmap CaptchaToImage(string text, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bmp);
            SolidBrush sb = new SolidBrush(Color.White);
            g.FillRectangle(sb, 0, 0, bmp.Width, bmp.Height);
            Font font = new Font("Tahoma", 45);
            sb = new SolidBrush(Color.Black);
            g.DrawString(text, font, sb, bmp.Width / 2 - (text.Length / 2) * font.Size, (bmp.Height / 2) - font.Size);
            int count = 0;
            Random rand = new Random();
            while (count < 1000)
            {
                sb = new SolidBrush(Color.YellowGreen);
                g.FillEllipse(sb, rand.Next(0, bmp.Width), rand.Next(0, bmp.Height), 4, 2);
                count++;
            }
            count = 0;
            while (count < 25)
            {
                g.DrawLine(new Pen(Color.Bisque), rand.Next(0, bmp.Width), rand.Next(0, bmp.Height), rand.Next(0, bmp.Width), rand.Next(0, bmp.Height));
                count++;
            }
            return bmp;
        }
        public string MD5(string input)
        {
            using (System.Security.Cryptography.MD5CryptoServiceProvider cryptoServiceProvider = new System.Security.Cryptography.MD5CryptoServiceProvider())
            {
                byte[] hashedBytes = cryptoServiceProvider.ComputeHash(UnicodeEncoding.Unicode.GetBytes(input));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
        string yazi;
        public string RandomString()
        {
            Random rnd = new Random();
            int number = rnd.Next(10000, 99999);
            yazi = MD5(number.ToString()).ToUpperInvariant().Substring(0, 6);
            return yazi;
        }
        private void KodTanima_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = CaptchaToImage(RandomString(), pictureBox1.Width, pictureBox1.Height);
            this.ControlBox = false;
            
        }

        private void dogrulaButon_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == yazi)
            {
                MessageBox.Show("Doğru giriş yaptınız..");
                this.Close();
            }
            else
            {
                MessageBox.Show("Girmek istediğiniz kodu kontrol ediniz.");
                pictureBox1.Image = CaptchaToImage(RandomString(), pictureBox1.Width, pictureBox1.Height);
                textBox1.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = CaptchaToImage(RandomString(), pictureBox1.Width, pictureBox1.Height);
            textBox1.Clear();
        }
    }
}
