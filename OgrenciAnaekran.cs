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
using System.Windows.Forms.DataVisualization.Charting;

namespace VakifbankProje
{
    public partial class UniversiteDb : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-08CMBGO\\SQLEXPRESS;Initial Catalog=UniversiteDb;Integrated Security=True;");
        private SqlDataReader reader;
        public string k_kullaniciAd;
        public UniversiteDb()
        {
            InitializeComponent();
        }
        void grafik()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-08CMBGO\\SQLEXPRESS;Initial Catalog=UniversiteDb;Integrated Security=True;");
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select AcilanDers.ders_Kodu, AcilanDers.ogretim_Uyesi, COUNT(*) as [ogrenciSayi] from DersKayit inner join AcilanDers on AcilanDers.acilanDers_Kodu=DersKayit.acilanDers_Kodu group by AcilanDers.ders_Kodu,ogretim_Uyesi ",baglanti);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet st = new DataSet();
            sda.Fill(st, "ogrenciSayi");

            chart.DataSource = st.Tables["ogrenciSayi"];
            chart.Series["VeriYapilari"].XValueMember = "acilanDers_Adi";
            chart.Series["VeriYapilari"].YValueMembers = "ogrenciSayi";
            chart.Series["VeriYapilari"].ChartType = SeriesChartType.Pie;
            chart.Series["VeriYapilari"].IsValueShownAsLabel = true;
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            grafik();
            griw2();
            griw();
            bilgiLBL.Text = k_kullaniciAd;
            //SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-KCIHE60\\SQLEXPRESS;Initial Catalog=university_Database;Integrated Security=True;");
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM Il";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ilSec.Items.Add(dr["il_Adi"]);
            }
            baglanti.Close();

        }

        private void dersListele_Click(object sender, EventArgs e)
        {
            kayitGetir();
        }

        private void bolumSec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void universiteSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komutFakulte = new SqlCommand();
            int FakulteText = universiteSec.SelectedIndex + 100;
            komutFakulte.CommandText = "select * from Fakulte where universite= " + FakulteText;
            komutFakulte.Connection = baglanti;
            komutFakulte.CommandType = CommandType.Text;
            fakulteSec.Items.Clear();
            baglanti.Open();
            SqlDataReader dr;
            dr = komutFakulte.ExecuteReader();
            while (dr.Read())
            {
                fakulteSec.Items.Add(dr["fakulte_Adi"]);
            }
            baglanti.Close();
        }

        private void ilSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komutUniversite = new SqlCommand();
            int universiteText = ilSec.SelectedIndex + 1;
            komutUniversite.CommandText = "SELECT *FROM Universite where il_Kodu =" + universiteText;
            komutUniversite.Connection = baglanti;
            komutUniversite.CommandType = CommandType.Text;
            universiteSec.Items.Clear();
            fakulteSec.Items.Clear();
            bolumSec.Items.Clear();
            dataGridView1.Rows.Clear();
            SqlDataReader dr;
            baglanti.Open();
            dr = komutUniversite.ExecuteReader();
            while (dr.Read())
            {
                universiteSec.Items.Add(dr["universite_Adi"]);
            }
            baglanti.Close();
        }

        private void acilacakDersler_Click(object sender, EventArgs e)
        {

        }

        private void fakulteSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komutBolum = new SqlCommand();
            int bolumText = fakulteSec.SelectedIndex + 300;
            komutBolum.CommandText = "SELECT *FROM Bolum where fakulte_No=" + bolumText;
            bolumSec.Items.Clear();
            komutBolum.Connection = baglanti;
            komutBolum.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komutBolum.ExecuteReader();
            while (dr.Read())
            {
                bolumSec.Items.Add(dr["bolum_Adi"]);
            }
            baglanti.Close();

        }
        private void kayitGetir()
        {
            baglanti.Open();
            int acilanDersText = bolumSec.SelectedIndex + 400;
            string kayit = "SELECT * from KatalogDers where bolum_No=" + acilanDersText;
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            baslik();
        }
        private void kayitGetir2()
        {
            baglanti.Open();
            string kayit = "SELECT * from Notlar where ogrenci_No like '" + ogr_no.Text + "%'";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            notLST.DataSource = dt;
            baglanti.Close();
        }
        void baslik()
        {
            dataGridView1.Columns[0].HeaderText = "DERS KODU";
            dataGridView1.Columns[1].HeaderText = "BÖLÜM ADI";
            dataGridView1.Columns[2].HeaderText = "DERS KREDİ";
            dataGridView1.Columns[3].HeaderText = "BÖLÜM NUMARASI";
        }
        void basliknot()
        {
            notLST.Columns[0].HeaderText = "NOT KAYIT NUMARASI";
            notLST.Columns[1].HeaderText = "VİZE";
            notLST.Columns[2].HeaderText = "FİNAL";
            notLST.Columns[3].HeaderText = "ORTALAMA NOT";
            notLST.Columns[4].HeaderText = "ÖĞRENCİ NUMARASI";
        }



        private void notlariGetir_Click(object sender, EventArgs e)
        {

            kayitGetir2();
            basliknot();
            grafikGoster.Checked = false;
            foreach (var series in OGRENCİ.Series)
            {
                series.Points.Clear();
            }

        }

        private void cikisButon_Click(object sender, EventArgs e)
        {
            GirisEkran goster = new GirisEkran();
            this.Hide();
            goster.Show();
        }
        void hesapla()
        {
            baglanti.Open();
            string kayit = "SELECT * from Notlar where ogrenci_No like '" + ogr_no.Text + "%'";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataReader sdr = komut.ExecuteReader();
            while (sdr.Read())
            {

                int ortalamaNot = Int32.Parse(sdr["ortalama"].ToString());

                if (ortalamaNot >= 0 && ortalamaNot <= 49)
                {
                    harfNotu.Text = "FF";
                }
                else if (ortalamaNot >= 50 && ortalamaNot <= 59)
                {
                    harfNotu.Text = "FD";
                }
                else if (ortalamaNot >= 60 && ortalamaNot <= 64)
                {
                    harfNotu.Text = "DD";
                }
                else if (ortalamaNot >= 65 && ortalamaNot <= 69)
                {
                    harfNotu.Text = "DC";
                }
                else if (ortalamaNot >= 70 && ortalamaNot <= 74)
                {
                    harfNotu.Text = "CC";
                }
                else if (ortalamaNot >= 75 && ortalamaNot <= 79)
                {
                    harfNotu.Text = "CB";
                }
                else if (ortalamaNot >= 80 && ortalamaNot <= 84)
                {
                    harfNotu.Text = "BB";
                }
                else if (ortalamaNot >= 85 && ortalamaNot <= 89)
                {
                    harfNotu.Text = "BA";
                }
                else if (ortalamaNot >= 90 && ortalamaNot <= 100)
                {
                    harfNotu.Text = "BA";
                }

            }
            baglanti.Close();

        }
        private void notLST_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int SelectedValue = notLST.CurrentRow.Index;
            vizeNot.Text = notLST.Rows[SelectedValue].Cells["vize"].Value.ToString();
            finalNot.Text = notLST.Rows[SelectedValue].Cells["final"].Value.ToString();
            hesapla();

        }
        void griw()
        {
            notLST.AllowUserToAddRows = false;
            notLST.AllowUserToDeleteRows = false;
            notLST.ReadOnly = true;
            notLST.RowHeadersVisible = false;
            notLST.BorderStyle = BorderStyle.None;
            notLST.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            notLST.DefaultCellStyle.SelectionBackColor = Color.FromArgb(177, 139, 232);
            notLST.DefaultCellStyle.SelectionForeColor = Color.Black;
            notLST.BackgroundColor = Color.White;
            notLST.EnableHeadersVisualStyles = false;
            notLST.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            notLST.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(124, 74, 124);
            notLST.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            notLST.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            notLST.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        void griw2()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(177, 139, 232);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(124, 74, 124);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        private void grafik_Click(object sender, EventArgs e)
        {

        }

        private void OGRENCİ_Click(object sender, EventArgs e)
        {

        }

        private void grafikGoster_CheckedChanged(object sender, EventArgs e)
        {

            double not1, not2;
            not1 = Convert.ToDouble(vizeNot.Text);
            not2 = Convert.ToDouble(finalNot.Text);
            this.OGRENCİ.Series["Vize"].Points.AddXY("Notlar", not1);
            this.OGRENCİ.Series["Final"].Points.AddXY("Notlar", not2);



        }
        void hesaplaDersKayit()
        {
            baglanti.Open();
            string kayit = "SELECT * from DersKayit count ogrenci_No like '" + ogr_no.Text + "%'";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataReader sdr = komut.ExecuteReader();
            while (sdr.Read())
            {

                int ortalamaNot = Int32.Parse(sdr["ortalama"].ToString());

            }
        }

        private void ayarlarButon_Click(object sender, EventArgs e)
        {
            this.Hide();
            ogrenciAyar ayar = new ogrenciAyar();
            ayar.k_kullaniciAd = bilgiLBL.Text;
            ayar.ShowDialog();
        }

        private void anaekranButon_Click(object sender, EventArgs e)
        {
            this.Hide();
            UniversiteDb ogrenciEkran = new UniversiteDb();
            ogrenciEkran.k_kullaniciAd = bilgiLBL.Text;
            ogrenciEkran.ShowDialog();
        }

        private void harfNotu_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
