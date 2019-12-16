namespace Hina
{
    partial class BookLend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookLend));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbTcKimlik = new System.Windows.Forms.TextBox();
            this.txtbKitapKodu = new System.Windows.Forms.TextBox();
            this.bttnKaydet = new System.Windows.Forms.Button();
            this.bttnIptal = new System.Windows.Forms.Button();
            this.pctrbxGeri = new System.Windows.Forms.PictureBox();
            this.pctrbxSayfayiKapat = new System.Windows.Forms.PictureBox();
            this.dateTeslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.dateAlımTarihi = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxGeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxSayfayiKapat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(104, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tc Kimlik";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(104, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Kodu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(353, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alım Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(353, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teslim Tarihi";
            // 
            // txtbTcKimlik
            // 
            this.txtbTcKimlik.Location = new System.Drawing.Point(188, 137);
            this.txtbTcKimlik.Name = "txtbTcKimlik";
            this.txtbTcKimlik.Size = new System.Drawing.Size(126, 20);
            this.txtbTcKimlik.TabIndex = 4;
            this.txtbTcKimlik.TextChanged += new System.EventHandler(this.txtbTcKimlik_TextChanged);
            // 
            // txtbKitapKodu
            // 
            this.txtbKitapKodu.Location = new System.Drawing.Point(188, 176);
            this.txtbKitapKodu.Name = "txtbKitapKodu";
            this.txtbKitapKodu.Size = new System.Drawing.Size(126, 20);
            this.txtbKitapKodu.TabIndex = 5;
            this.txtbKitapKodu.TextChanged += new System.EventHandler(this.txtbKitapKodu_TextChanged);
            // 
            // bttnKaydet
            // 
            this.bttnKaydet.Location = new System.Drawing.Point(262, 255);
            this.bttnKaydet.Name = "bttnKaydet";
            this.bttnKaydet.Size = new System.Drawing.Size(75, 23);
            this.bttnKaydet.TabIndex = 8;
            this.bttnKaydet.Text = "Kaydet";
            this.bttnKaydet.UseVisualStyleBackColor = true;
            this.bttnKaydet.Click += new System.EventHandler(this.bttnKaydet_Click);
            // 
            // bttnIptal
            // 
            this.bttnIptal.Location = new System.Drawing.Point(392, 255);
            this.bttnIptal.Name = "bttnIptal";
            this.bttnIptal.Size = new System.Drawing.Size(75, 23);
            this.bttnIptal.TabIndex = 9;
            this.bttnIptal.Text = "İptal";
            this.bttnIptal.UseVisualStyleBackColor = true;
            // 
            // pctrbxGeri
            // 
            this.pctrbxGeri.BackColor = System.Drawing.Color.Transparent;
            this.pctrbxGeri.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxGeri.Image")));
            this.pctrbxGeri.Location = new System.Drawing.Point(12, 12);
            this.pctrbxGeri.Name = "pctrbxGeri";
            this.pctrbxGeri.Size = new System.Drawing.Size(28, 30);
            this.pctrbxGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxGeri.TabIndex = 10;
            this.pctrbxGeri.TabStop = false;
            // 
            // pctrbxSayfayiKapat
            // 
            this.pctrbxSayfayiKapat.BackColor = System.Drawing.Color.Transparent;
            this.pctrbxSayfayiKapat.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxSayfayiKapat.Image")));
            this.pctrbxSayfayiKapat.Location = new System.Drawing.Point(715, 12);
            this.pctrbxSayfayiKapat.Name = "pctrbxSayfayiKapat";
            this.pctrbxSayfayiKapat.Size = new System.Drawing.Size(29, 30);
            this.pctrbxSayfayiKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxSayfayiKapat.TabIndex = 11;
            this.pctrbxSayfayiKapat.TabStop = false;
            // 
            // dateTeslimTarihi
            // 
            this.dateTeslimTarihi.Location = new System.Drawing.Point(462, 176);
            this.dateTeslimTarihi.Name = "dateTeslimTarihi";
            this.dateTeslimTarihi.Size = new System.Drawing.Size(200, 20);
            this.dateTeslimTarihi.TabIndex = 13;
            // 
            // dateAlımTarihi
            // 
            this.dateAlımTarihi.Location = new System.Drawing.Point(462, 135);
            this.dateAlımTarihi.Name = "dateAlımTarihi";
            this.dateAlımTarihi.Size = new System.Drawing.Size(200, 20);
            this.dateAlımTarihi.TabIndex = 14;
            // 
            // BookLend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 450);
            this.Controls.Add(this.dateAlımTarihi);
            this.Controls.Add(this.dateTeslimTarihi);
            this.Controls.Add(this.pctrbxSayfayiKapat);
            this.Controls.Add(this.pctrbxGeri);
            this.Controls.Add(this.bttnIptal);
            this.Controls.Add(this.bttnKaydet);
            this.Controls.Add(this.txtbKitapKodu);
            this.Controls.Add(this.txtbTcKimlik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookLend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox txtbTcKimlik;
        private System.Windows.Forms.TextBox txtbKitapKodu;
        private System.Windows.Forms.Button bttnKaydet;
        private System.Windows.Forms.Button bttnIptal;
        private System.Windows.Forms.PictureBox pctrbxGeri;
        private System.Windows.Forms.PictureBox pctrbxSayfayiKapat;
        private System.Windows.Forms.DateTimePicker dateTeslimTarihi;
        private System.Windows.Forms.DateTimePicker dateAlımTarihi;
    }
}

