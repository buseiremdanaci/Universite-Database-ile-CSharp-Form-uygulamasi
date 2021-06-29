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
namespace VakifbankProje
{
    public partial class Admin : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-08CMBGO\\SQLEXPRESS;Initial Catalog=UniversiteDb;Integrated Security=True;");
        OleDbCommand sqlkomutu;
        OleDbDataAdapter da;
        DataSet ds;
        public string k_adminAd;

        public Admin()
        {
            InitializeComponent();
        }
       
        private void Admin_Load(object sender, EventArgs e)
        {
            bilgiLBL.Text = k_adminAd;
        }

        //KAYIT LİSTELEMELER
        private void kayitGetir()
        {
            baglanti.Open();
            string kayit = "SELECT * from Il" ;
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            adminIlAyar.DataSource = dt;
            baglanti.Close();
            
        }
        private void kayitGetirUniversite()
        {
            baglanti.Open();
            string kayit = "SELECT universite_No,universite_Adi,il_Adi,telNo FROM Universite, Il WHERE Universite.il_Kodu = Il.Il_Kodu";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            adminUniAyari.DataSource = dt;
            baglanti.Close();

        }
        private void kayitGetirUye()
        {
            baglanti.Open();
            string kayit = "SELECT * from OgretimUyesi";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ogretimUyeleriListele.DataSource = dt;
            baglanti.Close();

        }
        private void kayitGetirFakulte()
        {
            baglanti.Open();
            string kayit = "SELECT * from Fakulte";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            fakulteLİsteleAdmin.DataSource = dt;
            baglanti.Close();

        }
        private void kayitGetirBolum()
        {
            baglanti.Open();
            string kayit = "SELECT * from Bolum";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bolumlisteleadmin.DataSource = dt;
            baglanti.Close();

        }
        private void kayitGetirDers()
        {
            baglanti.Open();
            string kayit = "SELECT * from KatalogDers";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dersleriListeleAdmin.DataSource = dt;
            baglanti.Close();

        }
        private void kayitGetirOgrenci()
        {
            baglanti.Open();
            string kayit = "SELECT * from Ogrenci";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ListeleOgrenciAdmin.DataSource = dt;
            baglanti.Close();

        }
        //DATAGRIW TASARIMLARI------------------------------------------------------------------
        void Bolumgriw()
        {

            bolumlisteleadmin.AllowUserToAddRows = false;
            bolumlisteleadmin.AllowUserToDeleteRows = false;
            bolumlisteleadmin.ReadOnly = true;
            bolumlisteleadmin.RowHeadersVisible = false;
            bolumlisteleadmin.BorderStyle = BorderStyle.None;
            bolumlisteleadmin.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            bolumlisteleadmin.DefaultCellStyle.SelectionBackColor = Color.FromArgb(177, 139, 232);
            bolumlisteleadmin.DefaultCellStyle.SelectionForeColor = Color.Black;
            bolumlisteleadmin.BackgroundColor = Color.White;
            bolumlisteleadmin.EnableHeadersVisualStyles = false;
            bolumlisteleadmin.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            bolumlisteleadmin.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(124, 74, 124);
            bolumlisteleadmin.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            bolumlisteleadmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bolumlisteleadmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            bolumlisteleadmin.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        void Ilgriw()
        {
            adminIlAyar.AllowUserToAddRows = false;
            adminIlAyar.AllowUserToDeleteRows = false;
            adminIlAyar.ReadOnly = true;
            adminIlAyar.RowHeadersVisible = false;
            adminIlAyar.BorderStyle = BorderStyle.None;
            adminIlAyar.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            adminIlAyar.DefaultCellStyle.SelectionBackColor = Color.FromArgb(177, 139, 232);
            adminIlAyar.DefaultCellStyle.SelectionForeColor = Color.Black;
            adminIlAyar.BackgroundColor = Color.White;
            adminIlAyar.EnableHeadersVisualStyles = false;
            adminIlAyar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            adminIlAyar.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(124, 74, 124);
            adminIlAyar.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            adminIlAyar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            adminIlAyar.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        void Universitegriw()
        {
            adminUniAyari.AllowUserToAddRows = false;
            adminUniAyari.AllowUserToDeleteRows = false;
            adminUniAyari.ReadOnly = true;
            adminUniAyari.RowHeadersVisible = false;
            adminUniAyari.BorderStyle = BorderStyle.None;
            adminUniAyari.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            adminUniAyari.DefaultCellStyle.SelectionBackColor = Color.FromArgb(177, 139, 232);
            adminUniAyari.DefaultCellStyle.SelectionForeColor = Color.Black;
            adminUniAyari.BackgroundColor = Color.White;
            adminUniAyari.EnableHeadersVisualStyles = false;
            adminUniAyari.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            adminUniAyari.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(124, 74, 124);
            adminUniAyari.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            adminUniAyari.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            adminUniAyari.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            adminUniAyari.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        void Fakultegriw()
        {
            fakulteLİsteleAdmin.AllowUserToAddRows = false;
            fakulteLİsteleAdmin.AllowUserToDeleteRows = false;
            fakulteLİsteleAdmin.ReadOnly = true;
            fakulteLİsteleAdmin.RowHeadersVisible = false;
            fakulteLİsteleAdmin.BorderStyle = BorderStyle.None;
            fakulteLİsteleAdmin.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            fakulteLİsteleAdmin.DefaultCellStyle.SelectionBackColor = Color.FromArgb(177, 139, 232);
            fakulteLİsteleAdmin.DefaultCellStyle.SelectionForeColor = Color.Black;
            fakulteLİsteleAdmin.BackgroundColor = Color.White;
            fakulteLİsteleAdmin.EnableHeadersVisualStyles = false;
            fakulteLİsteleAdmin.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            fakulteLİsteleAdmin.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(124, 74, 124);
            fakulteLİsteleAdmin.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            fakulteLİsteleAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            fakulteLİsteleAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            fakulteLİsteleAdmin.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        void Uyegriw()
        {
            ogretimUyeleriListele.AllowUserToAddRows = false;
            ogretimUyeleriListele.AllowUserToDeleteRows = false;
            ogretimUyeleriListele.ReadOnly = true;
            ogretimUyeleriListele.RowHeadersVisible = false;
            ogretimUyeleriListele.BorderStyle = BorderStyle.None;
            ogretimUyeleriListele.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            ogretimUyeleriListele.DefaultCellStyle.SelectionBackColor = Color.FromArgb(177, 139, 232);
            ogretimUyeleriListele.DefaultCellStyle.SelectionForeColor = Color.Black;
            ogretimUyeleriListele.BackgroundColor = Color.White;
            ogretimUyeleriListele.EnableHeadersVisualStyles = false;
            ogretimUyeleriListele.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ogretimUyeleriListele.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(124, 74, 124);
            ogretimUyeleriListele.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            ogretimUyeleriListele.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ogretimUyeleriListele.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ogretimUyeleriListele.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        void Ogrencigriw()
        {
            ListeleOgrenciAdmin.AllowUserToAddRows = false;
            ListeleOgrenciAdmin.AllowUserToDeleteRows = false;
            ListeleOgrenciAdmin.ReadOnly = true;
            ListeleOgrenciAdmin.RowHeadersVisible = false;
            ListeleOgrenciAdmin.BorderStyle = BorderStyle.None;
            ListeleOgrenciAdmin.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            ListeleOgrenciAdmin.DefaultCellStyle.SelectionBackColor = Color.FromArgb(177, 139, 232);
            ListeleOgrenciAdmin.DefaultCellStyle.SelectionForeColor = Color.Black;
            ListeleOgrenciAdmin.BackgroundColor = Color.White;
            ListeleOgrenciAdmin.EnableHeadersVisualStyles = false;
            ListeleOgrenciAdmin.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ListeleOgrenciAdmin.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(124, 74, 124);
            ListeleOgrenciAdmin.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            ListeleOgrenciAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ListeleOgrenciAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ListeleOgrenciAdmin.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        void dersgriw()
        {
            dersleriListeleAdmin.AllowUserToAddRows = false;
            dersleriListeleAdmin.AllowUserToDeleteRows = false;
            dersleriListeleAdmin.ReadOnly = true;
            dersleriListeleAdmin.RowHeadersVisible = false;
            dersleriListeleAdmin.BorderStyle = BorderStyle.None;
            dersleriListeleAdmin.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dersleriListeleAdmin.DefaultCellStyle.SelectionBackColor = Color.FromArgb(177, 139, 232);
            dersleriListeleAdmin.DefaultCellStyle.SelectionForeColor = Color.Black;
            dersleriListeleAdmin.BackgroundColor = Color.White;
            dersleriListeleAdmin.EnableHeadersVisualStyles = false;
            dersleriListeleAdmin.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dersleriListeleAdmin.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(124, 74, 124);
            dersleriListeleAdmin.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dersleriListeleAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dersleriListeleAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dersleriListeleAdmin.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        // BAŞLIK DÜZELTME
        void baslikBolum()
        {
            bolumlisteleadmin.Columns[0].HeaderText = "BÖLÜM NUMARASI ";
            bolumlisteleadmin.Columns[1].HeaderText = "FAKÜLTE NUMARASI ";

            bolumlisteleadmin.Columns[2].HeaderText = "BÖLÜM ADI ";

        }
       
        void baslikIl()
        {
            adminIlAyar.Columns[0].HeaderText = "İL KODU ";

            adminIlAyar.Columns[1].HeaderText = "İL ADI ";


        }
      
       
        void baslikUniversite()
        {
            adminUniAyari.Columns[0].HeaderText = "ÜNİVERSİTE NO ";

            adminUniAyari.Columns[1].HeaderText = "ÜNİVERSİTE ADI ";

            adminUniAyari.Columns[2].HeaderText = "İL ADI ";

            adminUniAyari.Columns[3].HeaderText = "TELEFON NUMARASI ";


        }
       
       
        void baslikUye()
        {
            ogretimUyeleriListele.Columns[0].HeaderText = "SİCİL NO ";


            ogretimUyeleriListele.Columns[1].HeaderText = "BÖLÜM NO ";

            ogretimUyeleriListele.Columns[2].HeaderText = "ÜYE ADI ";

            ogretimUyeleriListele.Columns[3].HeaderText = "ÜYE SOYADI ";
        }
        void baslikFakulte()
        {
            fakulteLİsteleAdmin.Columns[0].HeaderText = "FAKÜLTE NO ";


            fakulteLİsteleAdmin.Columns[1].HeaderText = "FAKÜLTE ADI ";

            fakulteLİsteleAdmin.Columns[2].HeaderText = "ÜNİVERSİTE NO ";


        }
        void baslikDers()
        {
            dersleriListeleAdmin.Columns[0].HeaderText = "DERS KODU ";


            dersleriListeleAdmin.Columns[1].HeaderText = "DERS ADI ";

            dersleriListeleAdmin.Columns[2].HeaderText = "DERS KREDİSİ ";
            dersleriListeleAdmin.Columns[3].HeaderText = "BÖLÜM NUMARASI ";

        }
        void baslikOgrenci()
        {
            ListeleOgrenciAdmin.Columns[0].HeaderText = "ÖĞRENCİ NO ";
            ListeleOgrenciAdmin.Columns[1].HeaderText = "ÖĞRENCİ ADI ";
            ListeleOgrenciAdmin.Columns[2].HeaderText = " DANIŞMAN SİCİL NO";
            ListeleOgrenciAdmin.Columns[3].HeaderText = "BÖLÜM NO ";
            ListeleOgrenciAdmin.Columns[4].HeaderText = "ÖĞRENCİ SOYADI ";
        }
        // CELLCONTENTCLICK OLAYLARI
        private void fakulteLİsteleAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int SelectedValue = fakulteLİsteleAdmin.CurrentRow.Index;
            fakulteNoAdmin.Text = fakulteLİsteleAdmin.Rows[SelectedValue].Cells["fakulte_No"].Value.ToString();
            fakulteAdiAdmin.Text = fakulteLİsteleAdmin.Rows[SelectedValue].Cells["fakulte_Adi"].Value.ToString();
            universiteNoAdmin.Text = fakulteLİsteleAdmin.Rows[SelectedValue].Cells["universite"].Value.ToString();
        }

        private void adminUniAyari_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int SelectedValue = adminUniAyari.CurrentRow.Index;
            uniNoAdmin.Text = adminUniAyari.Rows[SelectedValue].Cells["universite_No"].Value.ToString();
            uniAdAdmin.Text = adminUniAyari.Rows[SelectedValue].Cells["universite_Adi"].Value.ToString();
            uniIlAdmin.Text = adminUniAyari.Rows[SelectedValue].Cells["il_Adi"].Value.ToString();
            uniTelAdmin.Text = adminUniAyari.Rows[SelectedValue].Cells["telNo"].Value.ToString();
        }
        private void adminIlAyar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int SelectedValue = adminIlAyar.CurrentRow.Index;
            ilKoduAdmin.Text = adminIlAyar.Rows[SelectedValue].Cells["il_Kodu"].Value.ToString();
            ilAdiAdmin.Text = adminIlAyar.Rows[SelectedValue].Cells["il_Adi"].Value.ToString();

        }
        private void bolumlisteleadmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int SelectedValue = bolumlisteleadmin.CurrentRow.Index;
            bolumNoAdmin.Text = bolumlisteleadmin.Rows[SelectedValue].Cells["bolum_No"].Value.ToString();
            fakulteNoAdminn.Text = bolumlisteleadmin.Rows[SelectedValue].Cells["fakulte_No"].Value.ToString();
            bolumAdiAdmin.Text = bolumlisteleadmin.Rows[SelectedValue].Cells["bolum_Adi"].Value.ToString();
        }
        private void dersleriListeleAdmin_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int SelectedValue = dersleriListeleAdmin.CurrentRow.Index;
            dersKoduAdmin.Text = dersleriListeleAdmin.Rows[SelectedValue].Cells["ders_Kodu"].Value.ToString();
            dersAdiAdmin.Text = dersleriListeleAdmin.Rows[SelectedValue].Cells["ders_Adi"].Value.ToString();
            krediAdmin.Text = dersleriListeleAdmin.Rows[SelectedValue].Cells["ders_Kredi"].Value.ToString();
            bolumNoAdminn.Text = dersleriListeleAdmin.Rows[SelectedValue].Cells["bolum_No"].Value.ToString();
        }

        private void ogretimUyeleriListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int SelectedValue = ogretimUyeleriListele.CurrentRow.Index;
            sicilNoAdmin.Text = ogretimUyeleriListele.Rows[SelectedValue].Cells["sicil_No"].Value.ToString();
            noAdmin.Text = ogretimUyeleriListele.Rows[SelectedValue].Cells["bolum_No"].Value.ToString();
            uyeadadmin.Text = ogretimUyeleriListele.Rows[SelectedValue].Cells["ogrUye_Adi"].Value.ToString();
            uyesoyadadmin.Text = ogretimUyeleriListele.Rows[SelectedValue].Cells["ogrUye_Soyadi"].Value.ToString();

        }
        private void ListeleOgrenciAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int SelectedValue = ListeleOgrenciAdmin.CurrentRow.Index;
            ogrnoadmin.Text = ListeleOgrenciAdmin.Rows[SelectedValue].Cells["ogrenci_No"].Value.ToString();
            dadmin.Text = ListeleOgrenciAdmin.Rows[SelectedValue].Cells["ogrenci_Adi"].Value.ToString();
            ogrenciDanisman.Text = ListeleOgrenciAdmin.Rows[SelectedValue].Cells["ogrenci_Soyadi"].Value.ToString();
            sadmin.Text = ListeleOgrenciAdmin.Rows[SelectedValue].Cells["bolum_No"].Value.ToString();
            blmnoadmin.Text = ListeleOgrenciAdmin.Rows[SelectedValue].Cells["ogrenci_Danisman"].Value.ToString();

        }
        //İL İŞLEMLERİ
        private void button1_Click(object sender, EventArgs e)
        {
            Ilgriw();
            kayitGetir();
            baslikIl();
        }

        private void ilEkleAdmin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select count(*) from Il", baglanti);
            baglanti.Open();
            int kayitSayisi = Convert.ToInt32(cmd.ExecuteScalar());
            baglanti.Close();
            if (ilKoduAdmin.Text != string.Empty && ilAdiAdmin.Text != string.Empty && Convert.ToInt32(ilKoduAdmin.Text)==kayitSayisi+1)
            {
                baglanti.Open();
                string kayit = "insert into Il (Il_Kodu, il_Adi) values('" + ilKoduAdmin.Text.ToString() + "','" + ilAdiAdmin.Text.ToString() + "')";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                ilKoduAdmin.Clear();
                ilAdiAdmin.Clear();
                MessageBox.Show("İL BAŞARILI BİR ŞEKİLDE EKLENDİ");
            }
            else if (Convert.ToInt32(ilKoduAdmin.Text) > kayitSayisi+1)
            {
                MessageBox.Show("İl sıra düzeni bozulmamaktadır.");
            }
            else
            {
                MessageBox.Show("Bütün Alanları Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
     
        private void ilGuncelleAdmin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select count(*) from Il", baglanti);
            baglanti.Open();
            int kayitSayisi = Convert.ToInt32(cmd.ExecuteScalar());
            baglanti.Close();
            if (ilKoduAdmin.Text != string.Empty && ilAdiAdmin.Text != string.Empty&& Convert.ToInt32(ilKoduAdmin.Text) == kayitSayisi)
            {
                baglanti.Open();
                string kayit = "update Il set  Il_Kodu='" + ilKoduAdmin.Text + "', il_Adi='" + ilAdiAdmin.Text +"' where Il_Kodu=" + ilKoduAdmin.Text + "";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                ilKoduAdmin.Clear();
                ilAdiAdmin.Clear();
                MessageBox.Show("İL BAŞARILI BİR ŞEKİLDE GÜNCELLENDİ");
            }
            else if (Convert.ToInt32(ilKoduAdmin.Text) > kayitSayisi)
            {
                MessageBox.Show("Geçerli bir il değeri giriniz.");
            }
            else
            {
                MessageBox.Show("Bütün Alanları Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ilSilAdmin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select count(*) from Il", baglanti);
            baglanti.Open();
            int kayitSayisi = Convert.ToInt32(cmd.ExecuteScalar());
            baglanti.Close();
            if (ilKoduAdmin.Text != string.Empty && ilAdiAdmin.Text != string.Empty&& Convert.ToInt32(ilKoduAdmin.Text) < kayitSayisi+1)
            {
                baglanti.Open();
                string kayit = "delete from Il where Il_Kodu = " + ilKoduAdmin.Text + "";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                ilKoduAdmin.Clear();
                ilAdiAdmin.Clear();
                MessageBox.Show("İL BAŞARILI BİR ŞEKİLDE SİLİNDİ");
            }
            else if (Convert.ToInt32(ilKoduAdmin.Text) > kayitSayisi)
            {
                MessageBox.Show("Geçerli bir il değeri giriniz.");
            }
            else
            {
                MessageBox.Show("Bütün Alanları Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //ÜNİVERSİTE İŞLEMLERİ
        private void universiteLİsteleAdmin_Click(object sender, EventArgs e)
        {
            kayitGetirUniversite();
            Universitegriw();
            baslikUniversite();
        }
       
        private void uniEkleAdmin_Click(object sender, EventArgs e)
        {
           
            List<string> strList = new List<string>();
            SqlCommand com = new SqlCommand("select * from Universite order by  universite_No desc ", baglanti);
            baglanti.Open();
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                strList.Add(dr["universite_No"].ToString());
            }
            int gelen = Convert.ToInt32(strList[0]);
            baglanti.Close();

            if (uniNoAdmin.Text != string.Empty && uniAdAdmin.Text != string.Empty && uniTelAdmin.Text != string.Empty && uniIlAdmin.Text != string.Empty && Convert.ToInt32(uniNoAdmin.Text) == gelen + 1)
            {
                baglanti.Open();
                string kayit = "insert into Universite (universite_No, universite_Adi,telNo,il_Kodu) values('" + uniNoAdmin.Text.ToString() + "','" + uniAdAdmin.Text.ToString() + "','" + uniTelAdmin.Text.ToString() + "','" + uniIlAdmin.Text + "')";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                uniNoAdmin.Clear();
                uniAdAdmin.Clear();
                uniTelAdmin.Clear();
                uniIlAdmin.Clear();
                MessageBox.Show("ÜNİVERSİTE BAŞARILI BİR ŞEKİLDE EKLENDİ");
            }
            else if(Convert.ToInt32(uniNoAdmin.Text)>gelen+1)
            {
                MessageBox.Show("Geçerli bir üniversite numarası giriniz.");
            }
            else
            {
                MessageBox.Show("Bütün Alanları Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

       

        private void uniGuncelleAdmin_Click(object sender, EventArgs e)
        {
            List<string> strList = new List<string>();
            SqlCommand com = new SqlCommand("select * from Universite order by  universite_No desc ", baglanti);
            baglanti.Open();
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                strList.Add(dr["universite_No"].ToString());
            }
            int gelen = Convert.ToInt32(strList[0]);
            baglanti.Close();

            if (uniNoAdmin.Text != string.Empty && uniAdAdmin.Text != string.Empty && uniTelAdmin.Text != string.Empty && uniIlAdmin.Text != string.Empty&& Convert.ToInt32(uniNoAdmin.Text) == gelen)
            {
                baglanti.Open();
                string kayit = "update Universite set  universite_No='" + uniNoAdmin.Text + "', universite_Adi='" + uniAdAdmin.Text + "', telNo='" + uniTelAdmin.Text + "', il_Kodu='" + uniIlAdmin.Text + "' where universite_No=" + uniNoAdmin.Text + "";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                uniNoAdmin.Clear();
                uniAdAdmin.Clear();
                uniTelAdmin.Clear();
                uniIlAdmin.Clear();
                MessageBox.Show("ÜNİVERSİTE BAŞARILI BİR ŞEKİLDE GÜNCELLENDİ");
            }
            else if (Convert.ToInt32(uniNoAdmin.Text) > gelen)
            {
                MessageBox.Show("Geçerli bir üniversite numarası giriniz.");
            }
            else
            {
                MessageBox.Show("Bütün Alanları Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void uniSilAdmin_Click(object sender, EventArgs e)
        {

            List<string> strList = new List<string>();
            SqlCommand com = new SqlCommand("select * from Universite order by  universite_No desc ", baglanti);
            baglanti.Open();
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                strList.Add(dr["universite_No"].ToString());
            }
            int gelen = Convert.ToInt32(strList[0]);
            baglanti.Close();

            if (uniNoAdmin.Text != string.Empty && uniAdAdmin.Text != string.Empty && uniTelAdmin.Text != string.Empty && uniIlAdmin.Text != string.Empty&& Convert.ToInt32(uniNoAdmin.Text) < gelen +1)
            {
                baglanti.Open();
                string kayit = "delete from Universite where universite_No = " + uniNoAdmin.Text + "";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                uniNoAdmin.Clear();
                uniAdAdmin.Clear();
                uniTelAdmin.Clear();
                uniIlAdmin.Clear();
                MessageBox.Show("ÜNİVERSİTE BAŞARILI BİR ŞEKİLDE SİLİNDİ");
            }
            else if (Convert.ToInt32(uniNoAdmin.Text) > gelen)
            {
                MessageBox.Show("Geçerli bir üniversite numarası giriniz.");
            }
            else
            {
                MessageBox.Show("Bütün Alanları Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //FAKÜLTE İŞLEMLERİ
        private void fakülteListeleAdmin_Click(object sender, EventArgs e)
        {
            kayitGetirFakulte();
            Fakultegriw();
            baslikFakulte();
        }

        
        private void fakulteEkleAdmin_Click(object sender, EventArgs e)
        {
            List<string> strList = new List<string>();
            SqlCommand com = new SqlCommand("select * from Fakulte order by  fakulte_No desc ", baglanti);
            baglanti.Open();
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                strList.Add(dr["fakulte_No"].ToString());
            }
            int gelen = Convert.ToInt32(strList[0]);
            baglanti.Close();

            if (fakulteNoAdmin.Text != string.Empty && fakulteAdiAdmin.Text != string.Empty && universiteNoAdmin.Text != string.Empty && Convert.ToInt32(fakulteNoAdmin.Text) == gelen +1)
            {
                baglanti.Open();
                string kayit = "insert into Fakulte (fakulte_No, fakulte_Adi,universite) values('" + fakulteNoAdmin.Text.ToString() +  "','" + fakulteAdiAdmin.Text.ToString() + "','" + universiteNoAdmin.Text.ToString() + "')";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                fakulteNoAdmin.Clear();
                fakulteAdiAdmin.Clear();
                universiteNoAdmin.Clear();
                MessageBox.Show("FAKÜLTE BAŞARILI BİR ŞEKİLDE EKLENDİ");
            }
            else if (Convert.ToInt32(fakulteNoAdmin.Text) > gelen + 1)
            {
                MessageBox.Show("Fakülte sıra düzeni bozulmamaktadır.");
            }
            else
            {
                MessageBox.Show("Bütün Alanları Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fakulteGuncelleAdmin_Click(object sender, EventArgs e)
        {
            List<string> strList = new List<string>();
            SqlCommand com = new SqlCommand("select * from Fakulte order by  fakulte_No desc ", baglanti);
            baglanti.Open();
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                strList.Add(dr["fakulte_No"].ToString());
            }
            int gelen = Convert.ToInt32(strList[0]);
            baglanti.Close();
            if (fakulteNoAdmin.Text != string.Empty && fakulteAdiAdmin.Text != string.Empty  && universiteNoAdmin.Text != string.Empty&& Convert.ToInt32(fakulteNoAdmin.Text) < gelen +1)
            {
                baglanti.Open();
                string kayit = "update Fakulte set  fakulte_No='" + fakulteNoAdmin.Text + "', fakulte_Adi='" + fakulteAdiAdmin.Text + "', universite=" + universiteNoAdmin.Text + " where fakulte_No=" + fakulteNoAdmin.Text + "";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                fakulteNoAdmin.Clear();
                fakulteAdiAdmin.Clear();
                universiteNoAdmin.Clear();
                MessageBox.Show("FAKÜLTE BAŞARILI BİR ŞEKİLDE GÜNCELLENDİ");
            }
            else if (Convert.ToInt32(fakulteNoAdmin.Text) > gelen)
            {
                MessageBox.Show("Geçerli bir fakülte numarası giriniz.");
            }
            else
            {
                MessageBox.Show("Bütün Alanları Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fakulteSilAdmin_Click(object sender, EventArgs e)
        {
            List<string> strList = new List<string>();
            SqlCommand com = new SqlCommand("select * from Fakulte order by  fakulte_No desc ", baglanti);
            baglanti.Open();
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                strList.Add(dr["fakulte_No"].ToString());
            }
            int gelen = Convert.ToInt32(strList[0]);
            baglanti.Close();

            if (fakulteNoAdmin.Text != string.Empty && fakulteAdiAdmin.Text != string.Empty && universiteNoAdmin.Text != string.Empty&& Convert.ToInt32(fakulteNoAdmin.Text) < gelen +1)
            {
                baglanti.Open();
                string kayit = "delete from Fakulte where fakulte_No = " + fakulteNoAdmin.Text + "";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                fakulteNoAdmin.Clear();
                fakulteAdiAdmin.Clear();
                universiteNoAdmin.Clear();
                MessageBox.Show("FAKÜLTE BAŞARILI BİR ŞEKİLDE SİLİNDİ");
            }
            else if (Convert.ToInt32(fakulteNoAdmin.Text) > gelen)
            {
                MessageBox.Show("Geçerli fakülte numarası giriniz.");
            }
            else
            {
                MessageBox.Show("Bütün Alanları Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //BÖLÜM İŞLEMLERİ
        private void bolumleriListeleAdmin_Click(object sender, EventArgs e)
        {
            Bolumgriw();
            kayitGetirBolum();
            baslikBolum();
        }

      
        private void bolumEkleAdmin_Click(object sender, EventArgs e)
        {
            List<string> strList = new List<string>();
            SqlCommand com = new SqlCommand("select * from Bolum order by  bolum_No desc ", baglanti);
            baglanti.Open();
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                strList.Add(dr["bolum_No"].ToString());
            }
            int gelen = Convert.ToInt32(strList[0]);
            baglanti.Close();

            if (bolumNoAdmin.Text != string.Empty && bolumAdiAdmin.Text != string.Empty && fakulteNoAdminn.Text != string.Empty&& Convert.ToInt32(bolumNoAdmin.Text) == gelen + 1)
            {
                baglanti.Open();
                string kayit = "insert into Bolum (bolum_No, fakulte_No,bolum_Adi) values('" + bolumNoAdmin.Text.ToString() + "','" + fakulteNoAdminn.Text.ToString() + "','"  + bolumAdiAdmin.Text.ToString() + "')";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                bolumNoAdmin.Clear();
                fakulteNoAdminn.Clear();
                bolumAdiAdmin.Clear();
                MessageBox.Show("BÖLÜM BAŞARILI BİR ŞEKİLDE EKLENDİ");
            }
            else if (Convert.ToInt32(bolumNoAdmin.Text) > gelen + 1)
            {
                MessageBox.Show("Bölüm sıra düzeni bozulmamaktadır.");
            }
            else
            {
                MessageBox.Show("Bütün Alanları Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bolumGuncelleAdmin_Click(object sender, EventArgs e)
        {
            List<string> strList = new List<string>();
            SqlCommand com = new SqlCommand("select * from Bolum order by  bolum_No desc ", baglanti);
            baglanti.Open();
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                strList.Add(dr["bolum_No"].ToString());
            }
            int gelen = Convert.ToInt32(strList[0]);
            baglanti.Close();

            if (bolumNoAdmin.Text != string.Empty && bolumAdiAdmin.Text != string.Empty && fakulteNoAdminn.Text != string.Empty && Convert.ToInt32(bolumNoAdmin.Text) == gelen + 1)
            {
                baglanti.Open();
                string kayit = "update Bolum set  bolum_No='" + bolumNoAdmin.Text + "', fakulte_No='" + fakulteNoAdminn.Text + "', bolum_Adi='" + bolumAdiAdmin.Text + "' where bolum_No=" + bolumNoAdmin.Text + "";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                bolumNoAdmin.Clear();
                fakulteNoAdminn.Clear();
                bolumAdiAdmin.Clear();
                MessageBox.Show("BÖLÜM BAŞARILI BİR ŞEKİLDE GÜNCELLENDİ");
            }
            else if (Convert.ToInt32(bolumNoAdmin.Text) > gelen)
            {
                MessageBox.Show("Geçerli bir bölüm numarası giriniz.");
            }
            else
            {
                MessageBox.Show("Bütün Alanları Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bolumSilAdmin_Click(object sender, EventArgs e)
        {
            List<string> strList = new List<string>();
            SqlCommand com = new SqlCommand("select * from Bolum order by  bolum_No desc ", baglanti);
            baglanti.Open();
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                strList.Add(dr["bolum_No"].ToString());
            }
            int gelen = Convert.ToInt32(strList[0]);
            baglanti.Close();
            if (bolumNoAdmin.Text != string.Empty && bolumAdiAdmin.Text != string.Empty && fakulteNoAdminn.Text != string.Empty&& Convert.ToInt32(bolumNoAdmin.Text) < gelen +1)
            {
                baglanti.Open();
                string kayit = "delete from Bolum where bolum_No = " + bolumNoAdmin.Text + "";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                fakulteNoAdmin.Clear();
                fakulteAdiAdmin.Clear();
                universiteNoAdmin.Clear();
                MessageBox.Show("BÖLÜM BAŞARILI BİR ŞEKİLDE SİLİNDİ");
            }
            else if (Convert.ToInt32(bolumNoAdmin.Text) > gelen)
            {
                MessageBox.Show("Geçerli bir bölüm numarası giriniz.");
            }
            else
            {
                MessageBox.Show("Bütün Alanları Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //DERS İŞLEMLERİ
        private void dersListeleAdmin_Click(object sender, EventArgs e)
        {
            dersgriw();
            kayitGetirDers();
            baslikDers();
        }

        private void dersEkleAdmin_Click(object sender, EventArgs e)
        {
            if (dersKoduAdmin.Text != string.Empty && dersAdiAdmin.Text != string.Empty && krediAdmin.Text != string.Empty && bolumNoAdminn.Text != string.Empty)
            {
                baglanti.Open();
                string kayit = "insert into KatalogDers (ders_Kodu, ders_Adi, ders_Kredi,bolum_No) values('" + dersKoduAdmin.Text.ToString() + "','" + dersAdiAdmin.Text.ToString() + "','" + krediAdmin.Text.ToString() + "','" + bolumNoAdminn.Text.ToString() + "')";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                dersKoduAdmin.Clear();
                dersAdiAdmin.Clear();
                krediAdmin.Clear();
                bolumNoAdminn.Clear();
                MessageBox.Show("DERS BAŞARILI BİR ŞEKİLDE EKLENDİ.");
            }
            else
            {
                MessageBox.Show("Bütün Alanları Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dersGuncelleAdmin_Click(object sender, EventArgs e)
        {
            if (dersKoduAdmin.Text != string.Empty && dersAdiAdmin.Text != string.Empty && krediAdmin.Text != string.Empty && bolumNoAdminn.Text != string.Empty)
            {
                baglanti.Open();
                string kayit = "update KatalogDers set  ders_Kodu='" + dersKoduAdmin.Text + "', ders_Adi='" + dersAdiAdmin.Text + "', ders_Kredi='" + krediAdmin.Text + "', bolum_No='" + bolumNoAdminn.Text + "' where ders_Kodu='" + dersKoduAdmin.Text + "'";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                dersKoduAdmin.Clear();
                dersAdiAdmin.Clear();
                krediAdmin.Clear();
                bolumNoAdminn.Clear();
                MessageBox.Show("DERS BAŞARILI BİR ŞEKİLDE GÜNCELLENDİ.");
            }
            else
            {
                MessageBox.Show("Bütün Alanları Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dersSilAdmin_Click(object sender, EventArgs e)
        {
            if (dersKoduAdmin.Text != string.Empty && dersAdiAdmin.Text != string.Empty && krediAdmin.Text != string.Empty && bolumNoAdminn.Text != string.Empty)
            {
                baglanti.Open();
                string kayit = "delete from KatalogDers where ders_Kodu = '" + dersKoduAdmin.Text + "'";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                dersKoduAdmin.Clear();
                dersAdiAdmin.Clear();
                krediAdmin.Clear();
                bolumNoAdminn.Clear();
                MessageBox.Show("DERS BAŞARILI BİR ŞEKİLDE SİLİNDİ.");
            }
            else
            {
                MessageBox.Show("Bütün Alanları Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // ÖĞRETİM ÜYESİ İŞLEMLERİ
        private void uyeleriListele_Click(object sender, EventArgs e)
        {
            Uyegriw();
            kayitGetirUye();
            baslikUye();
        }


        private void uyeEkleAdmin_Click(object sender, EventArgs e)
        {
            List<string> strList = new List<string>();
            SqlCommand com = new SqlCommand("select * from OgretimUyesi order by  sicil_No desc ", baglanti);
            baglanti.Open();
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                strList.Add(dr["sicil_No"].ToString());
            }
            int gelen = Convert.ToInt32(strList[0]);
            baglanti.Close();
            if (sicilNoAdmin.Text != string.Empty && noAdmin.Text != string.Empty && uyeadadmin.Text != string.Empty && uyesoyadadmin.Text != string.Empty && Convert.ToInt32(sicilNoAdmin.Text) == gelen + 1)
            {
                baglanti.Open();
                string kayit = "insert into OgretimUyesi (sicil_No, bolum_No, ogrUye_Adi,ogrUye_Soyadi) values('" + sicilNoAdmin.Text.ToString() + "','" + noAdmin.Text.ToString() + "','" + uyeadadmin.Text.ToString() + "','" + uyesoyadadmin.Text.ToString() + "')";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                sicilNoAdmin.Clear();
                noAdmin.Clear();
                uyeadadmin.Clear();
                uyesoyadadmin.Clear();
                MessageBox.Show("ÜYE BAŞARILI BİR ŞEKİLDE EKLENDİ.");
            }
            else if (Convert.ToInt32(sicilNoAdmin.Text) > gelen + 1)
            {
                MessageBox.Show("Öğretim üyesi sıra düzeni bozulmamaktadır.");
            }
            else
            {
                MessageBox.Show("Bütün Alanları Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void uyeGuncelleAdmin_Click(object sender, EventArgs e)
        {
            List<string> strList = new List<string>();
            SqlCommand com = new SqlCommand("select * from OgretimUyesi order by  sicil_No desc ", baglanti);
            baglanti.Open();
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                strList.Add(dr["sicil_No"].ToString());
            }
            int gelen = Convert.ToInt32(strList[0]);
            baglanti.Close();
            if (sicilNoAdmin.Text != string.Empty && noAdmin.Text != string.Empty && uyeadadmin.Text != string.Empty && uyesoyadadmin.Text != string.Empty&& Convert.ToInt32(sicilNoAdmin.Text) < gelen+1)
            {
                baglanti.Open();
                string kayit = "update OgretimUyesi set  sicil_No='" + sicilNoAdmin.Text + "', bolum_No='" + noAdmin.Text + "', ogrUye_Adi='" + uyeadadmin.Text + "', ogrUye_Soyadi='" + uyesoyadadmin.Text + "' where sicil_No='" + sicilNoAdmin.Text + "'";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                sicilNoAdmin.Clear();
                noAdmin.Clear();
                uyeadadmin.Clear();
                uyesoyadadmin.Clear();
                MessageBox.Show("ÜYE BAŞARILI BİR ŞEKİLDE GÜNCELLENDİ.");
            }
            else if (Convert.ToInt32(sicilNoAdmin.Text) > gelen)
            {
                MessageBox.Show("Geçerli bir sicil numarası giriniz.");
            }
            else
            {
                MessageBox.Show("Bütün Alanları Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void uyeSilAdmin_Click(object sender, EventArgs e)
        {
            List<string> strList = new List<string>();
            SqlCommand com = new SqlCommand("select * from OgretimUyesi order by  sicil_No desc ", baglanti);
            baglanti.Open();
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                strList.Add(dr["sicil_No"].ToString());
            }
            int gelen = Convert.ToInt32(strList[0]);
            baglanti.Close();
            if (sicilNoAdmin.Text != string.Empty && noAdmin.Text != string.Empty && uyeadadmin.Text != string.Empty && uyesoyadadmin.Text != string.Empty && Convert.ToInt32(sicilNoAdmin.Text) < gelen + 1)
            {
                baglanti.Open();
                string kayit = "delete from OgretimUyesi where sicil_No = '" + sicilNoAdmin.Text + "'";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                sicilNoAdmin.Clear();
                noAdmin.Clear();
                uyeadadmin.Clear();
                uyesoyadadmin.Clear();
                MessageBox.Show("ÜYE BAŞARILI BİR ŞEKİLDE SİLİNDİ.");
            }
            else if (Convert.ToInt32(sicilNoAdmin.Text) > gelen)
            {
                MessageBox.Show("Geçerli bir sicil numarası giriniz.");
            }
            else
            {
                MessageBox.Show("Bütün Alanları Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

     
        //ÖĞRENCİ İŞLEMLERİ
        private void ogrenciListeleAdmin_Click(object sender, EventArgs e)
        {
            kayitGetirOgrenci();
            Ogrencigriw();
            baslikOgrenci();
        }

        private void ogrenciEkleAdmin_Click(object sender, EventArgs e)
        {
            if (ogrnoadmin.Text != string.Empty && blmnoadmin.Text != string.Empty && dadmin.Text != string.Empty && sadmin.Text != string.Empty && ogrenciDanisman.Text != string.Empty)
            {
                baglanti.Open();
                string kayit = "insert into Ogrenci (ogrenci_No, ogrenci_Adi, ogrenci_Danisman,bolum_No,ogrenci_Soyadi) values('" + ogrnoadmin.Text.ToString() + "','" + dadmin.Text.ToString() + "','" + ogrenciDanisman.Text.ToString() + "','" + blmnoadmin.Text.ToString() + "','" + sadmin.Text.ToString() + "')";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                ogrnoadmin.Clear();
                dadmin.Clear();
                ogrenciDanisman.Clear();
                blmnoadmin.Clear();
                sadmin.Clear();
                MessageBox.Show("ÖĞRENCİ BAŞARILI BİR ŞEKİLDE EKLENDİ.");
            }
            else
            {
                MessageBox.Show("Bütün Alanları Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ogrenciGuncelleAdmin_Click(object sender, EventArgs e)
        {
            if (ogrnoadmin.Text != string.Empty && blmnoadmin.Text != string.Empty && dadmin.Text != string.Empty && sadmin.Text != string.Empty && ogrenciDanisman.Text != string.Empty)
            {
                baglanti.Open();
                string kayit = "update Ogrenci set  ogrenci_No='" + ogrnoadmin.Text + "', ogrenci_Adi='" + dadmin.Text + "', ogrenci_Danisman='" + ogrenciDanisman.Text + "', bolum_No='" + blmnoadmin.Text + "', ogrenci_Soyadi='" + sadmin.Text + "' where ogrenci_No='" + ogrnoadmin.Text + "'";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                ogrnoadmin.Clear();
                dadmin.Clear();
                ogrenciDanisman.Clear();
                blmnoadmin.Clear();
                sadmin.Clear();
                MessageBox.Show("ÖĞRENCİ BAŞARILI BİR ŞEKİLDE GÜNCELLENDİ.");
            }
            else
            {
                MessageBox.Show("Bütün Alanları Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ogrenciSilAdmin_Click(object sender, EventArgs e)
        {
            if (ogrnoadmin.Text != string.Empty && blmnoadmin.Text != string.Empty && dadmin.Text != string.Empty && sadmin.Text != string.Empty && ogrenciDanisman.Text != string.Empty)
            {
                baglanti.Open();
                string kayit = "delete from Ogrenci where ogrenci_No = '" + ogrnoadmin.Text + "'";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                ogrnoadmin.Clear();
                dadmin.Clear();
                ogrenciDanisman.Clear();
                blmnoadmin.Clear();
                sadmin.Clear();
                MessageBox.Show("ÖĞRENCİ BAŞARILI BİR ŞEKİLDE SİLİNDİ.");
            }
            else
            {
                MessageBox.Show("Bütün Alanları Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //ÜST MENU-----------------------
        private void cikisButon_Click(object sender, EventArgs e)
        {
            GirisEkran goster = new GirisEkran();
            this.Hide();
            goster.Show();
        }
        private void anaekranButon_Click(object sender, EventArgs e)
        {
            Admin homeAdminDonus = new Admin();
           //this.Hide();
            homeAdminDonus.Show();
        }

        private void ayarlarButon_Click(object sender, EventArgs e)
        {
            //Ayarlar adminAyarlar = new Ayarlar();
            this.Hide();
            //adminAyarlar.Show();
            Ayarlar adminAyarlar = new Ayarlar();
            adminAyarlar.k_kullaniciAd = bilgiLBL.Text;
            adminAyarlar.ShowDialog();
        }
    }
}
