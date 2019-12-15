namespace VTYS3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbTcKimlik = new System.Windows.Forms.TextBox();
            this.txtbKitapKodu = new System.Windows.Forms.TextBox();
            this.txtbAlimTarihi = new System.Windows.Forms.TextBox();
            this.txtbTeslimTarihi = new System.Windows.Forms.TextBox();
            this.bttnKaydet = new System.Windows.Forms.Button();
            this.bttnIptal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tc Kimlik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Kodu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alım Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teslim Tarihi";
            // 
            // txtbTcKimlik
            // 
            this.txtbTcKimlik.Location = new System.Drawing.Point(86, 86);
            this.txtbTcKimlik.Name = "txtbTcKimlik";
            this.txtbTcKimlik.Size = new System.Drawing.Size(100, 20);
            this.txtbTcKimlik.TabIndex = 4;
            // 
            // txtbKitapKodu
            // 
            this.txtbKitapKodu.Location = new System.Drawing.Point(86, 125);
            this.txtbKitapKodu.Name = "txtbKitapKodu";
            this.txtbKitapKodu.Size = new System.Drawing.Size(100, 20);
            this.txtbKitapKodu.TabIndex = 5;
            // 
            // txtbAlimTarihi
            // 
            this.txtbAlimTarihi.Location = new System.Drawing.Point(299, 86);
            this.txtbAlimTarihi.Name = "txtbAlimTarihi";
            this.txtbAlimTarihi.Size = new System.Drawing.Size(100, 20);
            this.txtbAlimTarihi.TabIndex = 6;
            // 
            // txtbTeslimTarihi
            // 
            this.txtbTeslimTarihi.Location = new System.Drawing.Point(299, 125);
            this.txtbTeslimTarihi.Name = "txtbTeslimTarihi";
            this.txtbTeslimTarihi.Size = new System.Drawing.Size(100, 20);
            this.txtbTeslimTarihi.TabIndex = 7;
            // 
            // bttnKaydet
            // 
            this.bttnKaydet.Location = new System.Drawing.Point(111, 207);
            this.bttnKaydet.Name = "bttnKaydet";
            this.bttnKaydet.Size = new System.Drawing.Size(75, 23);
            this.bttnKaydet.TabIndex = 8;
            this.bttnKaydet.Text = "Kaydet";
            this.bttnKaydet.UseVisualStyleBackColor = true;
            // 
            // bttnIptal
            // 
            this.bttnIptal.Location = new System.Drawing.Point(241, 207);
            this.bttnIptal.Name = "bttnIptal";
            this.bttnIptal.Size = new System.Drawing.Size(75, 23);
            this.bttnIptal.TabIndex = 9;
            this.bttnIptal.Text = "İptal";
            this.bttnIptal.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(392, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 363);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bttnIptal);
            this.Controls.Add(this.bttnKaydet);
            this.Controls.Add(this.txtbTeslimTarihi);
            this.Controls.Add(this.txtbAlimTarihi);
            this.Controls.Add(this.txtbKitapKodu);
            this.Controls.Add(this.txtbTcKimlik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbTcKimlik;
        private System.Windows.Forms.TextBox txtbKitapKodu;
        private System.Windows.Forms.TextBox txtbAlimTarihi;
        private System.Windows.Forms.TextBox txtbTeslimTarihi;
        private System.Windows.Forms.Button bttnKaydet;
        private System.Windows.Forms.Button bttnIptal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

