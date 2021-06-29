
namespace VakifbankProje
{
    partial class devamSifre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(devamSifre));
            this.label1 = new System.Windows.Forms.Label();
            this.sifreDevam = new System.Windows.Forms.TextBox();
            this.devamEt = new System.Windows.Forms.Button();
            this.sifreGoster = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bilgiLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(132, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şifrenizi Giriniz";
            // 
            // sifreDevam
            // 
            this.sifreDevam.Location = new System.Drawing.Point(302, 112);
            this.sifreDevam.Name = "sifreDevam";
            this.sifreDevam.Size = new System.Drawing.Size(150, 22);
            this.sifreDevam.TabIndex = 2;
            // 
            // devamEt
            // 
            this.devamEt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.devamEt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.devamEt.Location = new System.Drawing.Point(182, 178);
            this.devamEt.Name = "devamEt";
            this.devamEt.Size = new System.Drawing.Size(171, 46);
            this.devamEt.TabIndex = 4;
            this.devamEt.Text = "Devam Et";
            this.devamEt.UseVisualStyleBackColor = false;
            this.devamEt.Click += new System.EventHandler(this.devamEt_Click);
            // 
            // sifreGoster
            // 
            this.sifreGoster.BackColor = System.Drawing.Color.White;
            this.sifreGoster.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sifreGoster.ImageKey = "witness.png";
            this.sifreGoster.ImageList = this.ımageList1;
            this.sifreGoster.Location = new System.Drawing.Point(422, 112);
            this.sifreGoster.Name = "sifreGoster";
            this.sifreGoster.Size = new System.Drawing.Size(30, 22);
            this.sifreGoster.TabIndex = 7;
            this.sifreGoster.UseVisualStyleBackColor = false;
            this.sifreGoster.Click += new System.EventHandler(this.sifreGoster_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "witness.png");
            // 
            // bilgiLBL
            // 
            this.bilgiLBL.AutoSize = true;
            this.bilgiLBL.BackColor = System.Drawing.Color.Transparent;
            this.bilgiLBL.ForeColor = System.Drawing.Color.Transparent;
            this.bilgiLBL.Location = new System.Drawing.Point(3, 9);
            this.bilgiLBL.Name = "bilgiLBL";
            this.bilgiLBL.Size = new System.Drawing.Size(0, 17);
            this.bilgiLBL.TabIndex = 8;
            // 
            // devamSifre
            // 
            this.AcceptButton = this.devamEt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VakifbankProje.Properties.Resources.ttt;
            this.ClientSize = new System.Drawing.Size(532, 303);
            this.Controls.Add(this.bilgiLBL);
            this.Controls.Add(this.sifreGoster);
            this.Controls.Add(this.devamEt);
            this.Controls.Add(this.sifreDevam);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "devamSifre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Kontrol";
            this.Load += new System.EventHandler(this.devamSifre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sifreDevam;
        private System.Windows.Forms.Button devamEt;
        private System.Windows.Forms.Button sifreGoster;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label bilgiLBL;
    }
}