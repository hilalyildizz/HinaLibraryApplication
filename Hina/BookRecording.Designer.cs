﻿namespace VTYS0
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbIsbn = new System.Windows.Forms.TextBox();
            this.txtbKod = new System.Windows.Forms.TextBox();
            this.txtbKitapAdi = new System.Windows.Forms.TextBox();
            this.txtbYazar = new System.Windows.Forms.TextBox();
            this.txtbYayinevi = new System.Windows.Forms.TextBox();
            this.txtbBasimTarihi = new System.Windows.Forms.TextBox();
            this.txtbKategori = new System.Windows.Forms.TextBox();
            this.txtbTur = new System.Windows.Forms.TextBox();
            this.bttnTemizle = new System.Windows.Forms.Button();
            this.bttnKaydet = new System.Windows.Forms.Button();
            this.bttnSil = new System.Windows.Forms.Button();
            this.bttnGuncelle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttnAramaTemizle = new System.Windows.Forms.Button();
            this.bttnAramaBul = new System.Windows.Forms.Button();
            this.txtbArama = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBNNO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kod";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kitap Adı";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Yazar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Yayınevi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Basım Tarihii";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Kategori";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tür";
            // 
            // txtbIsbn
            // 
            this.txtbIsbn.Location = new System.Drawing.Point(84, 26);
            this.txtbIsbn.Name = "txtbIsbn";
            this.txtbIsbn.Size = new System.Drawing.Size(100, 20);
            this.txtbIsbn.TabIndex = 15;
            // 
            // txtbKod
            // 
            this.txtbKod.Location = new System.Drawing.Point(84, 58);
            this.txtbKod.Name = "txtbKod";
            this.txtbKod.Size = new System.Drawing.Size(100, 20);
            this.txtbKod.TabIndex = 17;
            // 
            // txtbKitapAdi
            // 
            this.txtbKitapAdi.Location = new System.Drawing.Point(84, 87);
            this.txtbKitapAdi.Name = "txtbKitapAdi";
            this.txtbKitapAdi.Size = new System.Drawing.Size(100, 20);
            this.txtbKitapAdi.TabIndex = 19;
            // 
            // txtbYazar
            // 
            this.txtbYazar.Location = new System.Drawing.Point(84, 115);
            this.txtbYazar.Name = "txtbYazar";
            this.txtbYazar.Size = new System.Drawing.Size(100, 20);
            this.txtbYazar.TabIndex = 21;
            // 
            // txtbYayinevi
            // 
            this.txtbYayinevi.Location = new System.Drawing.Point(288, 26);
            this.txtbYayinevi.Name = "txtbYayinevi";
            this.txtbYayinevi.Size = new System.Drawing.Size(100, 20);
            this.txtbYayinevi.TabIndex = 23;
            // 
            // txtbBasimTarihi
            // 
            this.txtbBasimTarihi.Location = new System.Drawing.Point(288, 55);
            this.txtbBasimTarihi.Name = "txtbBasimTarihi";
            this.txtbBasimTarihi.Size = new System.Drawing.Size(100, 20);
            this.txtbBasimTarihi.TabIndex = 25;
            // 
            // txtbKategori
            // 
            this.txtbKategori.Location = new System.Drawing.Point(288, 84);
            this.txtbKategori.Name = "txtbKategori";
            this.txtbKategori.Size = new System.Drawing.Size(100, 20);
            this.txtbKategori.TabIndex = 27;
            // 
            // txtbTur
            // 
            this.txtbTur.Location = new System.Drawing.Point(288, 115);
            this.txtbTur.Name = "txtbTur";
            this.txtbTur.Size = new System.Drawing.Size(100, 20);
            this.txtbTur.TabIndex = 29;
            // 
            // bttnTemizle
            // 
            this.bttnTemizle.Location = new System.Drawing.Point(197, 150);
            this.bttnTemizle.Name = "bttnTemizle";
            this.bttnTemizle.Size = new System.Drawing.Size(55, 28);
            this.bttnTemizle.TabIndex = 30;
            this.bttnTemizle.Text = "Temizle";
            this.bttnTemizle.UseVisualStyleBackColor = true;
            // 
            // bttnKaydet
            // 
            this.bttnKaydet.Location = new System.Drawing.Point(61, 184);
            this.bttnKaydet.Name = "bttnKaydet";
            this.bttnKaydet.Size = new System.Drawing.Size(75, 23);
            this.bttnKaydet.TabIndex = 32;
            this.bttnKaydet.Text = "Kaydet";
            this.bttnKaydet.UseVisualStyleBackColor = true;
            // 
            // bttnSil
            // 
            this.bttnSil.Location = new System.Drawing.Point(188, 184);
            this.bttnSil.Name = "bttnSil";
            this.bttnSil.Size = new System.Drawing.Size(75, 23);
            this.bttnSil.TabIndex = 34;
            this.bttnSil.Text = "Sil";
            this.bttnSil.UseVisualStyleBackColor = true;
            // 
            // bttnGuncelle
            // 
            this.bttnGuncelle.Location = new System.Drawing.Point(322, 184);
            this.bttnGuncelle.Name = "bttnGuncelle";
            this.bttnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.bttnGuncelle.TabIndex = 36;
            this.bttnGuncelle.Text = "Güncelle";
            this.bttnGuncelle.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.txtbArama);
            this.groupBox1.Controls.Add(this.bttnAramaTemizle);
            this.groupBox1.Controls.Add(this.bttnAramaBul);
            this.groupBox1.Location = new System.Drawing.Point(3, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 130);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıtlı Kitapların Listesi";
            // 
            // bttnAramaTemizle
            // 
            this.bttnAramaTemizle.Location = new System.Drawing.Point(265, 19);
            this.bttnAramaTemizle.Name = "bttnAramaTemizle";
            this.bttnAramaTemizle.Size = new System.Drawing.Size(75, 23);
            this.bttnAramaTemizle.TabIndex = 34;
            this.bttnAramaTemizle.Text = "Temizle";
            this.bttnAramaTemizle.UseVisualStyleBackColor = true;
            // 
            // bttnAramaBul
            // 
            this.bttnAramaBul.Location = new System.Drawing.Point(184, 19);
            this.bttnAramaBul.Name = "bttnAramaBul";
            this.bttnAramaBul.Size = new System.Drawing.Size(75, 23);
            this.bttnAramaBul.TabIndex = 33;
            this.bttnAramaBul.Text = "Bul";
            this.bttnAramaBul.UseVisualStyleBackColor = true;
            // 
            // txtbArama
            // 
            this.txtbArama.Location = new System.Drawing.Point(33, 21);
            this.txtbArama.Name = "txtbArama";
            this.txtbArama.Size = new System.Drawing.Size(134, 20);
            this.txtbArama.TabIndex = 51;
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
            this.listView1.Location = new System.Drawing.Point(0, 47);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(470, 77);
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(437, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 354);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bttnGuncelle);
            this.Controls.Add(this.bttnSil);
            this.Controls.Add(this.bttnKaydet);
            this.Controls.Add(this.bttnTemizle);
            this.Controls.Add(this.txtbTur);
            this.Controls.Add(this.txtbKategori);
            this.Controls.Add(this.txtbBasimTarihi);
            this.Controls.Add(this.txtbYayinevi);
            this.Controls.Add(this.txtbYazar);
            this.Controls.Add(this.txtbKitapAdi);
            this.Controls.Add(this.txtbKod);
            this.Controls.Add(this.txtbIsbn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbIsbn;
        private System.Windows.Forms.TextBox txtbKod;
        private System.Windows.Forms.TextBox txtbKitapAdi;
        private System.Windows.Forms.TextBox txtbYazar;
        private System.Windows.Forms.TextBox txtbYayinevi;
        private System.Windows.Forms.TextBox txtbBasimTarihi;
        private System.Windows.Forms.TextBox txtbKategori;
        private System.Windows.Forms.TextBox txtbTur;
        private System.Windows.Forms.Button bttnTemizle;
        private System.Windows.Forms.Button bttnKaydet;
        private System.Windows.Forms.Button bttnSil;
        private System.Windows.Forms.Button bttnGuncelle;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

