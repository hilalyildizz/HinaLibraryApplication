namespace Hina
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbEMaİL = new System.Windows.Forms.TextBox();
            this.txtbEskiSifre = new System.Windows.Forms.TextBox();
            this.txtbYeniSifre = new System.Windows.Forms.TextBox();
            this.txtbYeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.txtbSifreHatirlatici = new System.Windows.Forms.TextBox();
            this.bttnKaydet = new System.Windows.Forms.Button();
            this.bttnGeri = new System.Windows.Forms.Button();
            this.pctrbxGeri = new System.Windows.Forms.PictureBox();
            this.pctrbxSayfayiKapat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxGeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxSayfayiKapat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Eski Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yeni Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yeni Şifre(Tekrar)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şifre Hatırlatıcı";
            // 
            // txtbEMaİL
            // 
            this.txtbEMaİL.Location = new System.Drawing.Point(364, 74);
            this.txtbEMaİL.Name = "txtbEMaİL";
            this.txtbEMaİL.Size = new System.Drawing.Size(100, 20);
            this.txtbEMaİL.TabIndex = 5;
            // 
            // txtbEskiSifre
            // 
            this.txtbEskiSifre.Location = new System.Drawing.Point(364, 107);
            this.txtbEskiSifre.Name = "txtbEskiSifre";
            this.txtbEskiSifre.Size = new System.Drawing.Size(100, 20);
            this.txtbEskiSifre.TabIndex = 6;
            // 
            // txtbYeniSifre
            // 
            this.txtbYeniSifre.Location = new System.Drawing.Point(364, 141);
            this.txtbYeniSifre.Name = "txtbYeniSifre";
            this.txtbYeniSifre.Size = new System.Drawing.Size(100, 20);
            this.txtbYeniSifre.TabIndex = 7;
            // 
            // txtbYeniSifreTekrar
            // 
            this.txtbYeniSifreTekrar.Location = new System.Drawing.Point(364, 177);
            this.txtbYeniSifreTekrar.Name = "txtbYeniSifreTekrar";
            this.txtbYeniSifreTekrar.Size = new System.Drawing.Size(100, 20);
            this.txtbYeniSifreTekrar.TabIndex = 8;
            // 
            // txtbSifreHatirlatici
            // 
            this.txtbSifreHatirlatici.Location = new System.Drawing.Point(364, 204);
            this.txtbSifreHatirlatici.Name = "txtbSifreHatirlatici";
            this.txtbSifreHatirlatici.Size = new System.Drawing.Size(100, 20);
            this.txtbSifreHatirlatici.TabIndex = 9;
            // 
            // bttnKaydet
            // 
            this.bttnKaydet.Location = new System.Drawing.Point(265, 269);
            this.bttnKaydet.Name = "bttnKaydet";
            this.bttnKaydet.Size = new System.Drawing.Size(75, 23);
            this.bttnKaydet.TabIndex = 10;
            this.bttnKaydet.Text = "Kaydet";
            this.bttnKaydet.UseVisualStyleBackColor = true;
            // 
            // bttnGeri
            // 
            this.bttnGeri.Location = new System.Drawing.Point(389, 269);
            this.bttnGeri.Name = "bttnGeri";
            this.bttnGeri.Size = new System.Drawing.Size(75, 23);
            this.bttnGeri.TabIndex = 11;
            this.bttnGeri.Text = "Geri";
            this.bttnGeri.UseVisualStyleBackColor = true;
            // 
            // pctrbxGeri
            // 
            this.pctrbxGeri.BackColor = System.Drawing.Color.Transparent;
            this.pctrbxGeri.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxGeri.Image")));
            this.pctrbxGeri.Location = new System.Drawing.Point(24, 13);
            this.pctrbxGeri.Name = "pctrbxGeri";
            this.pctrbxGeri.Size = new System.Drawing.Size(23, 26);
            this.pctrbxGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxGeri.TabIndex = 12;
            this.pctrbxGeri.TabStop = false;
            // 
            // pctrbxSayfayiKapat
            // 
            this.pctrbxSayfayiKapat.BackColor = System.Drawing.Color.Transparent;
            this.pctrbxSayfayiKapat.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxSayfayiKapat.Image")));
            this.pctrbxSayfayiKapat.Location = new System.Drawing.Point(716, 12);
            this.pctrbxSayfayiKapat.Name = "pctrbxSayfayiKapat";
            this.pctrbxSayfayiKapat.Size = new System.Drawing.Size(28, 26);
            this.pctrbxSayfayiKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxSayfayiKapat.TabIndex = 13;
            this.pctrbxSayfayiKapat.TabStop = false;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 411);
            this.Controls.Add(this.pctrbxSayfayiKapat);
            this.Controls.Add(this.pctrbxGeri);
            this.Controls.Add(this.bttnGeri);
            this.Controls.Add(this.bttnKaydet);
            this.Controls.Add(this.txtbSifreHatirlatici);
            this.Controls.Add(this.txtbYeniSifreTekrar);
            this.Controls.Add(this.txtbYeniSifre);
            this.Controls.Add(this.txtbEskiSifre);
            this.Controls.Add(this.txtbEMaİL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangePassword";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxGeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxSayfayiKapat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbEMaİL;
        private System.Windows.Forms.TextBox txtbEskiSifre;
        private System.Windows.Forms.TextBox txtbYeniSifre;
        private System.Windows.Forms.TextBox txtbYeniSifreTekrar;
        private System.Windows.Forms.TextBox txtbSifreHatirlatici;
        private System.Windows.Forms.Button bttnKaydet;
        private System.Windows.Forms.Button bttnGeri;
        private System.Windows.Forms.PictureBox pctrbxGeri;
        private System.Windows.Forms.PictureBox pctrbxSayfayiKapat;
    }
}

