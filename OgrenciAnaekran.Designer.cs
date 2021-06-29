
namespace VakifbankProje
{
    partial class UniversiteDb
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UniversiteDb));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.GenelKontrol = new System.Windows.Forms.TabControl();
            this.acilacakDersler = new System.Windows.Forms.TabPage();
            this.dersListele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fakulteSec = new System.Windows.Forms.ComboBox();
            this.bolumSec = new System.Windows.Forms.ComboBox();
            this.universiteSec = new System.Windows.Forms.ComboBox();
            this.ilSec = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notHesaplama = new System.Windows.Forms.TabPage();
            this.grafikGoster = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.harfNotu = new System.Windows.Forms.Label();
            this.OGRENCİ = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.notLST = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.ogr_no = new System.Windows.Forms.TextBox();
            this.finallbl = new System.Windows.Forms.Label();
            this.vizelbl = new System.Windows.Forms.Label();
            this.finalNot = new System.Windows.Forms.TextBox();
            this.vizeNot = new System.Windows.Forms.TextBox();
            this.notlariGetir = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList3 = new System.Windows.Forms.ImageList(this.components);
            this.ayarlarButon = new System.Windows.Forms.Button();
            this.cikisButon = new System.Windows.Forms.Button();
            this.anaekranButon = new System.Windows.Forms.Button();
            this.hsgldnLb = new System.Windows.Forms.Label();
            this.bilgiLBL = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GenelKontrol.SuspendLayout();
            this.acilacakDersler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.notHesaplama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OGRENCİ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notLST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // GenelKontrol
            // 
            this.GenelKontrol.Controls.Add(this.acilacakDersler);
            this.GenelKontrol.Controls.Add(this.notHesaplama);
            this.GenelKontrol.Controls.Add(this.tabPage1);
            this.GenelKontrol.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenelKontrol.Location = new System.Drawing.Point(22, 64);
            this.GenelKontrol.Name = "GenelKontrol";
            this.GenelKontrol.SelectedIndex = 0;
            this.GenelKontrol.Size = new System.Drawing.Size(939, 475);
            this.GenelKontrol.TabIndex = 0;
            // 
            // acilacakDersler
            // 
            this.acilacakDersler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("acilacakDersler.BackgroundImage")));
            this.acilacakDersler.Controls.Add(this.dersListele);
            this.acilacakDersler.Controls.Add(this.dataGridView1);
            this.acilacakDersler.Controls.Add(this.fakulteSec);
            this.acilacakDersler.Controls.Add(this.bolumSec);
            this.acilacakDersler.Controls.Add(this.universiteSec);
            this.acilacakDersler.Controls.Add(this.ilSec);
            this.acilacakDersler.Controls.Add(this.label5);
            this.acilacakDersler.Controls.Add(this.label3);
            this.acilacakDersler.Controls.Add(this.label2);
            this.acilacakDersler.Controls.Add(this.label1);
            this.acilacakDersler.Font = new System.Drawing.Font("Microsoft JhengHei", 8.861538F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acilacakDersler.Location = new System.Drawing.Point(4, 28);
            this.acilacakDersler.Name = "acilacakDersler";
            this.acilacakDersler.Padding = new System.Windows.Forms.Padding(3);
            this.acilacakDersler.Size = new System.Drawing.Size(931, 443);
            this.acilacakDersler.TabIndex = 0;
            this.acilacakDersler.Text = "Açılacak Dersler";
            this.acilacakDersler.UseVisualStyleBackColor = true;
            this.acilacakDersler.Click += new System.EventHandler(this.acilacakDersler_Click);
            // 
            // dersListele
            // 
            this.dersListele.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dersListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dersListele.Location = new System.Drawing.Point(337, 188);
            this.dersListele.Name = "dersListele";
            this.dersListele.Size = new System.Drawing.Size(267, 50);
            this.dersListele.TabIndex = 18;
            this.dersListele.Text = "Dersleri Listele";
            this.dersListele.UseVisualStyleBackColor = false;
            this.dersListele.Click += new System.EventHandler(this.dersListele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(118, 266);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei", 8.861538F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowHeadersWidth = 56;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(695, 170);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // fakulteSec
            // 
            this.fakulteSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fakulteSec.FormattingEnabled = true;
            this.fakulteSec.Location = new System.Drawing.Point(218, 116);
            this.fakulteSec.Name = "fakulteSec";
            this.fakulteSec.Size = new System.Drawing.Size(200, 27);
            this.fakulteSec.TabIndex = 16;
            this.fakulteSec.SelectedIndexChanged += new System.EventHandler(this.fakulteSec_SelectedIndexChanged);
            // 
            // bolumSec
            // 
            this.bolumSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bolumSec.FormattingEnabled = true;
            this.bolumSec.Location = new System.Drawing.Point(613, 111);
            this.bolumSec.Name = "bolumSec";
            this.bolumSec.Size = new System.Drawing.Size(200, 27);
            this.bolumSec.TabIndex = 14;
            this.bolumSec.SelectedIndexChanged += new System.EventHandler(this.bolumSec_SelectedIndexChanged);
            // 
            // universiteSec
            // 
            this.universiteSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.universiteSec.FormattingEnabled = true;
            this.universiteSec.Location = new System.Drawing.Point(612, 64);
            this.universiteSec.Name = "universiteSec";
            this.universiteSec.Size = new System.Drawing.Size(200, 27);
            this.universiteSec.TabIndex = 13;
            this.universiteSec.SelectedIndexChanged += new System.EventHandler(this.universiteSec_SelectedIndexChanged);
            // 
            // ilSec
            // 
            this.ilSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ilSec.FormattingEnabled = true;
            this.ilSec.Location = new System.Drawing.Point(218, 64);
            this.ilSec.Name = "ilSec";
            this.ilSec.Size = new System.Drawing.Size(200, 27);
            this.ilSec.TabIndex = 12;
            this.ilSec.SelectedIndexChanged += new System.EventHandler(this.ilSec_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(112, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fakülte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(506, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bölüm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(506, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Üniversite";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(112, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "İl";
            // 
            // notHesaplama
            // 
            this.notHesaplama.BackgroundImage = global::VakifbankProje.Properties.Resources.ttt;
            this.notHesaplama.Controls.Add(this.grafikGoster);
            this.notHesaplama.Controls.Add(this.label4);
            this.notHesaplama.Controls.Add(this.harfNotu);
            this.notHesaplama.Controls.Add(this.OGRENCİ);
            this.notHesaplama.Controls.Add(this.notLST);
            this.notHesaplama.Controls.Add(this.dataGridView3);
            this.notHesaplama.Controls.Add(this.dataGridView2);
            this.notHesaplama.Controls.Add(this.label8);
            this.notHesaplama.Controls.Add(this.ogr_no);
            this.notHesaplama.Controls.Add(this.finallbl);
            this.notHesaplama.Controls.Add(this.vizelbl);
            this.notHesaplama.Controls.Add(this.finalNot);
            this.notHesaplama.Controls.Add(this.vizeNot);
            this.notHesaplama.Controls.Add(this.notlariGetir);
            this.notHesaplama.Location = new System.Drawing.Point(4, 28);
            this.notHesaplama.Name = "notHesaplama";
            this.notHesaplama.Padding = new System.Windows.Forms.Padding(3);
            this.notHesaplama.Size = new System.Drawing.Size(931, 443);
            this.notHesaplama.TabIndex = 1;
            this.notHesaplama.Text = "Not Hesaplama";
            this.notHesaplama.UseVisualStyleBackColor = true;
            // 
            // grafikGoster
            // 
            this.grafikGoster.AutoSize = true;
            this.grafikGoster.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grafikGoster.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grafikGoster.Location = new System.Drawing.Point(475, 316);
            this.grafikGoster.Name = "grafikGoster";
            this.grafikGoster.Size = new System.Drawing.Size(159, 26);
            this.grafikGoster.TabIndex = 19;
            this.grafikGoster.TabStop = true;
            this.grafikGoster.Text = "Grafikte Göster";
            this.grafikGoster.UseVisualStyleBackColor = true;
            this.grafikGoster.CheckedChanged += new System.EventHandler(this.grafikGoster_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(471, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Harf Notunuz";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // harfNotu
            // 
            this.harfNotu.AutoSize = true;
            this.harfNotu.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harfNotu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.harfNotu.Location = new System.Drawing.Point(600, 278);
            this.harfNotu.Name = "harfNotu";
            this.harfNotu.Size = new System.Drawing.Size(47, 22);
            this.harfNotu.TabIndex = 16;
            this.harfNotu.Text = "  not";
            this.harfNotu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.harfNotu.Click += new System.EventHandler(this.harfNotu_Click);
            // 
            // OGRENCİ
            // 
            chartArea1.Name = "ChartArea1";
            this.OGRENCİ.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.OGRENCİ.Legends.Add(legend1);
            this.OGRENCİ.Location = new System.Drawing.Point(91, 205);
            this.OGRENCİ.Name = "OGRENCİ";
            this.OGRENCİ.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Vize";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Final";
            this.OGRENCİ.Series.Add(series1);
            this.OGRENCİ.Series.Add(series2);
            this.OGRENCİ.Size = new System.Drawing.Size(371, 214);
            this.OGRENCİ.TabIndex = 13;
            this.OGRENCİ.Text = "chart1";
            this.OGRENCİ.Click += new System.EventHandler(this.OGRENCİ_Click);
            // 
            // notLST
            // 
            this.notLST.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.notLST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.notLST.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.notLST.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.notLST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notLST.Location = new System.Drawing.Point(91, 57);
            this.notLST.Name = "notLST";
            this.notLST.RowHeadersWidth = 700;
            this.notLST.RowTemplate.Height = 24;
            this.notLST.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.notLST.Size = new System.Drawing.Size(790, 139);
            this.notLST.TabIndex = 12;
            this.notLST.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.notLST_CellContentClick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(-54, -149);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(240, 150);
            this.dataGridView3.TabIndex = 11;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-54, -149);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(198, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 22);
            this.label8.TabIndex = 9;
            this.label8.Text = "Öğrenci Numarası";
            // 
            // ogr_no
            // 
            this.ogr_no.Location = new System.Drawing.Point(368, 19);
            this.ogr_no.Name = "ogr_no";
            this.ogr_no.Size = new System.Drawing.Size(150, 27);
            this.ogr_no.TabIndex = 6;
            // 
            // finallbl
            // 
            this.finallbl.AutoSize = true;
            this.finallbl.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finallbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.finallbl.Location = new System.Drawing.Point(686, 235);
            this.finallbl.Name = "finallbl";
            this.finallbl.Size = new System.Drawing.Size(50, 22);
            this.finallbl.TabIndex = 5;
            this.finallbl.Text = "Final";
            // 
            // vizelbl
            // 
            this.vizelbl.AutoSize = true;
            this.vizelbl.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vizelbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.vizelbl.Location = new System.Drawing.Point(471, 236);
            this.vizelbl.Name = "vizelbl";
            this.vizelbl.Size = new System.Drawing.Size(45, 22);
            this.vizelbl.TabIndex = 4;
            this.vizelbl.Text = "Vize";
            // 
            // finalNot
            // 
            this.finalNot.Location = new System.Drawing.Point(751, 231);
            this.finalNot.Name = "finalNot";
            this.finalNot.Size = new System.Drawing.Size(130, 27);
            this.finalNot.TabIndex = 3;
            // 
            // vizeNot
            // 
            this.vizeNot.Location = new System.Drawing.Point(536, 233);
            this.vizeNot.Name = "vizeNot";
            this.vizeNot.Size = new System.Drawing.Size(130, 27);
            this.vizeNot.TabIndex = 2;
            // 
            // notlariGetir
            // 
            this.notlariGetir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notlariGetir.Location = new System.Drawing.Point(568, 6);
            this.notlariGetir.Name = "notlariGetir";
            this.notlariGetir.Size = new System.Drawing.Size(187, 45);
            this.notlariGetir.TabIndex = 1;
            this.notlariGetir.Text = "Notları Getir";
            this.notlariGetir.UseVisualStyleBackColor = false;
            this.notlariGetir.Click += new System.EventHandler(this.notlariGetir_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "cancel.png");
            this.ımageList1.Images.SetKeyName(1, "settings.png");
            this.ımageList1.Images.SetKeyName(2, "home (1).png");
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "cancel (3).png");
            // 
            // ımageList3
            // 
            this.ımageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList3.ImageStream")));
            this.ımageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList3.Images.SetKeyName(0, "home (3).png");
            this.ımageList3.Images.SetKeyName(1, "power-button.png");
            this.ımageList3.Images.SetKeyName(2, "question.png");
            this.ımageList3.Images.SetKeyName(3, "settings (2).png");
            this.ımageList3.Images.SetKeyName(4, "user (1).png");
            // 
            // ayarlarButon
            // 
            this.ayarlarButon.BackColor = System.Drawing.Color.Transparent;
            this.ayarlarButon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ayarlarButon.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ayarlarButon.ImageKey = "settings (2).png";
            this.ayarlarButon.ImageList = this.ımageList3;
            this.ayarlarButon.Location = new System.Drawing.Point(860, 1);
            this.ayarlarButon.Name = "ayarlarButon";
            this.ayarlarButon.Size = new System.Drawing.Size(60, 60);
            this.ayarlarButon.TabIndex = 10;
            this.ayarlarButon.UseVisualStyleBackColor = false;
            this.ayarlarButon.Click += new System.EventHandler(this.ayarlarButon_Click);
            // 
            // cikisButon
            // 
            this.cikisButon.BackColor = System.Drawing.Color.Transparent;
            this.cikisButon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cikisButon.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.cikisButon.ImageKey = "power-button.png";
            this.cikisButon.ImageList = this.ımageList3;
            this.cikisButon.Location = new System.Drawing.Point(921, 1);
            this.cikisButon.Name = "cikisButon";
            this.cikisButon.Size = new System.Drawing.Size(60, 60);
            this.cikisButon.TabIndex = 7;
            this.cikisButon.UseVisualStyleBackColor = false;
            this.cikisButon.Click += new System.EventHandler(this.cikisButon_Click);
            // 
            // anaekranButon
            // 
            this.anaekranButon.BackColor = System.Drawing.Color.Transparent;
            this.anaekranButon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.anaekranButon.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.anaekranButon.ImageKey = "home (3).png";
            this.anaekranButon.ImageList = this.ımageList3;
            this.anaekranButon.Location = new System.Drawing.Point(797, 1);
            this.anaekranButon.Name = "anaekranButon";
            this.anaekranButon.Size = new System.Drawing.Size(60, 60);
            this.anaekranButon.TabIndex = 9;
            this.anaekranButon.UseVisualStyleBackColor = false;
            this.anaekranButon.Click += new System.EventHandler(this.anaekranButon_Click);
            // 
            // hsgldnLb
            // 
            this.hsgldnLb.AutoSize = true;
            this.hsgldnLb.BackColor = System.Drawing.Color.Transparent;
            this.hsgldnLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hsgldnLb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hsgldnLb.Location = new System.Drawing.Point(24, 21);
            this.hsgldnLb.Name = "hsgldnLb";
            this.hsgldnLb.Size = new System.Drawing.Size(93, 20);
            this.hsgldnLb.TabIndex = 11;
            this.hsgldnLb.Text = "Hoşgeldin";
            // 
            // bilgiLBL
            // 
            this.bilgiLBL.AutoSize = true;
            this.bilgiLBL.BackColor = System.Drawing.Color.Transparent;
            this.bilgiLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgiLBL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bilgiLBL.Location = new System.Drawing.Point(123, 21);
            this.bilgiLBL.Name = "bilgiLBL";
            this.bilgiLBL.Size = new System.Drawing.Size(69, 20);
            this.bilgiLBL.TabIndex = 12;
            this.bilgiLBL.Text = "Bilgiler";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(931, 443);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Ders Yoğunluğu";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(256, 3);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "VeriYapilari";
            this.chart.Series.Add(series3);
            this.chart.Size = new System.Drawing.Size(440, 440);
            this.chart.TabIndex = 1;
            this.chart.Text = "chart1";
            // 
            // UniversiteDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 551);
            this.Controls.Add(this.bilgiLBL);
            this.Controls.Add(this.hsgldnLb);
            this.Controls.Add(this.ayarlarButon);
            this.Controls.Add(this.cikisButon);
            this.Controls.Add(this.anaekranButon);
            this.Controls.Add(this.GenelKontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UniversiteDb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Ana Ekran";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GenelKontrol.ResumeLayout(false);
            this.acilacakDersler.ResumeLayout(false);
            this.acilacakDersler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.notHesaplama.ResumeLayout(false);
            this.notHesaplama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OGRENCİ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notLST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl GenelKontrol;
        private System.Windows.Forms.TabPage acilacakDersler;
        private System.Windows.Forms.Button dersListele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox fakulteSec;
        private System.Windows.Forms.ComboBox bolumSec;
        private System.Windows.Forms.ComboBox universiteSec;
        private System.Windows.Forms.ComboBox ilSec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage notHesaplama;
        private System.Windows.Forms.Label finallbl;
        private System.Windows.Forms.Label vizelbl;
        private System.Windows.Forms.TextBox finalNot;
        private System.Windows.Forms.TextBox vizeNot;
        private System.Windows.Forms.Button notlariGetir;
        private System.Windows.Forms.TextBox ogr_no;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.ImageList ımageList3;
        private System.Windows.Forms.Button ayarlarButon;
        private System.Windows.Forms.Button cikisButon;
        private System.Windows.Forms.Button anaekranButon;
        private System.Windows.Forms.DataGridView notLST;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataVisualization.Charting.Chart OGRENCİ;
        private System.Windows.Forms.Label harfNotu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton grafikGoster;
        private System.Windows.Forms.Label hsgldnLb;
        private System.Windows.Forms.Label bilgiLBL;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}

