
namespace VakifbankProje
{
    partial class GirisEkran
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkran));
            this.girisButon = new System.Windows.Forms.Button();
            this.k_ad = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.kullaniciAdi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.sifreGoster = new System.Windows.Forms.Button();
            this.iconlar = new System.Windows.Forms.ImageList(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // girisButon
            // 
            this.girisButon.BackColor = System.Drawing.Color.Snow;
            this.girisButon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.girisButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisButon.Location = new System.Drawing.Point(384, 389);
            this.girisButon.Name = "girisButon";
            this.girisButon.Size = new System.Drawing.Size(203, 50);
            this.girisButon.TabIndex = 0;
            this.girisButon.Text = "Giriş";
            this.girisButon.UseVisualStyleBackColor = false;
            this.girisButon.Click += new System.EventHandler(this.girisButon_Click);
            // 
            // k_ad
            // 
            this.k_ad.Location = new System.Drawing.Point(458, 168);
            this.k_ad.Name = "k_ad";
            this.k_ad.Size = new System.Drawing.Size(150, 22);
            this.k_ad.TabIndex = 1;
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(458, 220);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(150, 22);
            this.sifre.TabIndex = 2;
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.AutoSize = true;
            this.kullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.kullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciAdi.ForeColor = System.Drawing.Color.White;
            this.kullaniciAdi.Location = new System.Drawing.Point(330, 168);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(101, 20);
            this.kullaniciAdi.TabIndex = 3;
            this.kullaniciAdi.Text = "Kullanıcı Adı";
            this.kullaniciAdi.Click += new System.EventHandler(this.kullaniciAdi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(333, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(479, 264);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(129, 18);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifremi Unuttum";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // sifreGoster
            // 
            this.sifreGoster.BackColor = System.Drawing.Color.White;
            this.sifreGoster.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sifreGoster.ImageKey = "witness.png";
            this.sifreGoster.ImageList = this.iconlar;
            this.sifreGoster.Location = new System.Drawing.Point(578, 220);
            this.sifreGoster.Name = "sifreGoster";
            this.sifreGoster.Size = new System.Drawing.Size(30, 22);
            this.sifreGoster.TabIndex = 6;
            this.sifreGoster.UseVisualStyleBackColor = false;
            this.sifreGoster.Click += new System.EventHandler(this.sifreGoster_Click);
            // 
            // iconlar
            // 
            this.iconlar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconlar.ImageStream")));
            this.iconlar.TransparentColor = System.Drawing.Color.Transparent;
            this.iconlar.Images.SetKeyName(0, "witness.png");
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Location = new System.Drawing.Point(18, 35);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(147, 22);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "  Robot Değilim";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Purple;
            this.groupBox1.BackgroundImage = global::VakifbankProje.Properties.Resources.ttt;
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(337, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 85);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // GirisEkran
            // 
            this.AcceptButton = this.girisButon;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 551);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sifreGoster);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.girisButon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kullaniciAdi);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.k_ad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GirisEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.GirisEkran_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button girisButon;
        private System.Windows.Forms.TextBox k_ad;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Label kullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button sifreGoster;
        private System.Windows.Forms.ImageList iconlar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}