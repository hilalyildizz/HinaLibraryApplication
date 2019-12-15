namespace Hina
{
    partial class BookRecording
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookRecording));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtbArama = new System.Windows.Forms.TextBox();
            this.bttnAramaTemizle = new System.Windows.Forms.Button();
            this.bttnAramaBul = new System.Windows.Forms.Button();
            this.pctrbxSayfayiKapat = new System.Windows.Forms.PictureBox();
            this.pctrbxGeri = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbYayinevi = new System.Windows.Forms.TextBox();
            this.txtbBasimTarihi = new System.Windows.Forms.TextBox();
            this.txtbYazar = new System.Windows.Forms.TextBox();
            this.txtbKitapAdi = new System.Windows.Forms.TextBox();
            this.txtbTur = new System.Windows.Forms.TextBox();
            this.txtbKod = new System.Windows.Forms.TextBox();
            this.bttnTemizle = new System.Windows.Forms.Button();
            this.txtbIsbn = new System.Windows.Forms.TextBox();
            this.bttnKaydet = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.bttnSil = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.bttnGuncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbDurum = new System.Windows.Forms.TextBox();
            this.txtbKategori = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxSayfayiKapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxGeri)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.txtbArama);
            this.groupBox1.Controls.Add(this.bttnAramaTemizle);
            this.groupBox1.Controls.Add(this.bttnAramaBul);
            this.groupBox1.Location = new System.Drawing.Point(68, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 177);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıtlı Kitapların Listesi";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 47);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(607, 123);
            this.listView1.TabIndex = 52;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ISBNNO";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kod";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "KitapAdı";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Yazar";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Yayınevi";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "BasımTarihi";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Kategori";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tür";
            // 
            // txtbArama
            // 
            this.txtbArama.Location = new System.Drawing.Point(33, 21);
            this.txtbArama.Name = "txtbArama";
            this.txtbArama.Size = new System.Drawing.Size(202, 20);
            this.txtbArama.TabIndex = 51;
            // 
            // bttnAramaTemizle
            // 
            this.bttnAramaTemizle.Location = new System.Drawing.Point(382, 18);
            this.bttnAramaTemizle.Name = "bttnAramaTemizle";
            this.bttnAramaTemizle.Size = new System.Drawing.Size(75, 23);
            this.bttnAramaTemizle.TabIndex = 34;
            this.bttnAramaTemizle.Text = "Temizle";
            this.bttnAramaTemizle.UseVisualStyleBackColor = true;
            // 
            // bttnAramaBul
            // 
            this.bttnAramaBul.Location = new System.Drawing.Point(256, 18);
            this.bttnAramaBul.Name = "bttnAramaBul";
            this.bttnAramaBul.Size = new System.Drawing.Size(75, 23);
            this.bttnAramaBul.TabIndex = 33;
            this.bttnAramaBul.Text = "Bul";
            this.bttnAramaBul.UseVisualStyleBackColor = true;
            // 
            // pctrbxSayfayiKapat
            // 
            this.pctrbxSayfayiKapat.BackColor = System.Drawing.Color.Transparent;
            this.pctrbxSayfayiKapat.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxSayfayiKapat.Image")));
            this.pctrbxSayfayiKapat.Location = new System.Drawing.Point(724, 12);
            this.pctrbxSayfayiKapat.Name = "pctrbxSayfayiKapat";
            this.pctrbxSayfayiKapat.Size = new System.Drawing.Size(36, 30);
            this.pctrbxSayfayiKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxSayfayiKapat.TabIndex = 38;
            this.pctrbxSayfayiKapat.TabStop = false;
            // 
            // pctrbxGeri
            // 
            this.pctrbxGeri.BackColor = System.Drawing.Color.Transparent;
            this.pctrbxGeri.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxGeri.Image")));
            this.pctrbxGeri.Location = new System.Drawing.Point(3, 12);
            this.pctrbxGeri.Name = "pctrbxGeri";
            this.pctrbxGeri.Size = new System.Drawing.Size(21, 24);
            this.pctrbxGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxGeri.TabIndex = 39;
            this.pctrbxGeri.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(321, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 23);
            this.label9.TabIndex = 40;
            this.label9.Text = "KİTAP EKLEME";
            // 
            // txtbYayinevi
            // 
            this.txtbYayinevi.Location = new System.Drawing.Point(357, 33);
            this.txtbYayinevi.Name = "txtbYayinevi";
            this.txtbYayinevi.Size = new System.Drawing.Size(100, 20);
            this.txtbYayinevi.TabIndex = 23;
            // 
            // txtbBasimTarihi
            // 
            this.txtbBasimTarihi.Location = new System.Drawing.Point(357, 64);
            this.txtbBasimTarihi.Name = "txtbBasimTarihi";
            this.txtbBasimTarihi.Size = new System.Drawing.Size(100, 20);
            this.txtbBasimTarihi.TabIndex = 25;
            // 
            // txtbYazar
            // 
            this.txtbYazar.Location = new System.Drawing.Point(153, 111);
            this.txtbYazar.Name = "txtbYazar";
            this.txtbYazar.Size = new System.Drawing.Size(100, 20);
            this.txtbYazar.TabIndex = 21;
            // 
            // txtbKitapAdi
            // 
            this.txtbKitapAdi.Location = new System.Drawing.Point(153, 83);
            this.txtbKitapAdi.Name = "txtbKitapAdi";
            this.txtbKitapAdi.Size = new System.Drawing.Size(100, 20);
            this.txtbKitapAdi.TabIndex = 19;
            // 
            // txtbTur
            // 
            this.txtbTur.Location = new System.Drawing.Point(357, 116);
            this.txtbTur.Name = "txtbTur";
            this.txtbTur.Size = new System.Drawing.Size(100, 20);
            this.txtbTur.TabIndex = 29;
            // 
            // txtbKod
            // 
            this.txtbKod.Location = new System.Drawing.Point(153, 54);
            this.txtbKod.Name = "txtbKod";
            this.txtbKod.Size = new System.Drawing.Size(100, 20);
            this.txtbKod.TabIndex = 17;
            // 
            // bttnTemizle
            // 
            this.bttnTemizle.Location = new System.Drawing.Point(527, 69);
            this.bttnTemizle.Name = "bttnTemizle";
            this.bttnTemizle.Size = new System.Drawing.Size(55, 41);
            this.bttnTemizle.TabIndex = 30;
            this.bttnTemizle.Text = "Temizle";
            this.bttnTemizle.UseVisualStyleBackColor = true;
            // 
            // txtbIsbn
            // 
            this.txtbIsbn.Location = new System.Drawing.Point(153, 22);
            this.txtbIsbn.Name = "txtbIsbn";
            this.txtbIsbn.Size = new System.Drawing.Size(100, 20);
            this.txtbIsbn.TabIndex = 15;
            // 
            // bttnKaydet
            // 
            this.bttnKaydet.Location = new System.Drawing.Point(178, 180);
            this.bttnKaydet.Name = "bttnKaydet";
            this.bttnKaydet.Size = new System.Drawing.Size(75, 23);
            this.bttnKaydet.TabIndex = 32;
            this.bttnKaydet.Text = "Kaydet";
            this.bttnKaydet.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(276, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tür";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // bttnSil
            // 
            this.bttnSil.Location = new System.Drawing.Point(257, 180);
            this.bttnSil.Name = "bttnSil";
            this.bttnSil.Size = new System.Drawing.Size(75, 23);
            this.bttnSil.TabIndex = 34;
            this.bttnSil.Text = "Sil";
            this.bttnSil.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(276, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Kategori";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // bttnGuncelle
            // 
            this.bttnGuncelle.Location = new System.Drawing.Point(338, 180);
            this.bttnGuncelle.Name = "bttnGuncelle";
            this.bttnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.bttnGuncelle.TabIndex = 36;
            this.bttnGuncelle.Text = "Güncelle";
            this.bttnGuncelle.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(276, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Basım Tarihi";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(276, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Yayınevi";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(97, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Yazar";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(97, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kitap Adı";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(97, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kod";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(97, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 41;
            this.label10.Text = "Durum";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(97, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBNNO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbDurum
            // 
            this.txtbDurum.Location = new System.Drawing.Point(153, 140);
            this.txtbDurum.Name = "txtbDurum";
            this.txtbDurum.Size = new System.Drawing.Size(100, 20);
            this.txtbDurum.TabIndex = 42;
            // 
            // txtbKategori
            // 
            this.txtbKategori.Location = new System.Drawing.Point(357, 90);
            this.txtbKategori.Name = "txtbKategori";
            this.txtbKategori.Size = new System.Drawing.Size(100, 20);
            this.txtbKategori.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bttnGuncelle);
            this.groupBox2.Controls.Add(this.txtbKategori);
            this.groupBox2.Controls.Add(this.txtbIsbn);
            this.groupBox2.Controls.Add(this.txtbDurum);
            this.groupBox2.Controls.Add(this.bttnKaydet);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.bttnTemizle);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtbKod);
            this.groupBox2.Controls.Add(this.bttnSil);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtbTur);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtbKitapAdi);
            this.groupBox2.Controls.Add(this.txtbYazar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtbYayinevi);
            this.groupBox2.Controls.Add(this.txtbBasimTarihi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(68, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(619, 216);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // BookRecording
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pctrbxGeri);
            this.Controls.Add(this.pctrbxSayfayiKapat);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookRecording";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxSayfayiKapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxGeri)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttnAramaTemizle;
        private System.Windows.Forms.Button bttnAramaBul;
        private System.Windows.Forms.TextBox txtbArama;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.PictureBox pctrbxSayfayiKapat;
        private System.Windows.Forms.PictureBox pctrbxGeri;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbYayinevi;
        private System.Windows.Forms.TextBox txtbBasimTarihi;
        private System.Windows.Forms.TextBox txtbYazar;
        private System.Windows.Forms.TextBox txtbKitapAdi;
        private System.Windows.Forms.TextBox txtbTur;
        private System.Windows.Forms.TextBox txtbKod;
        private System.Windows.Forms.Button bttnTemizle;
        private System.Windows.Forms.TextBox txtbIsbn;
        private System.Windows.Forms.Button bttnKaydet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bttnSil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bttnGuncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbDurum;
        private System.Windows.Forms.TextBox txtbKategori;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

