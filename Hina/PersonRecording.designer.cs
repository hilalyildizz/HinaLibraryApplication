namespace VTYS1
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
            this.txtbTcKimlik = new System.Windows.Forms.TextBox();
            this.txtbAd = new System.Windows.Forms.TextBox();
            this.txtbSoyad = new System.Windows.Forms.TextBox();
            this.txtbTelefonNo = new System.Windows.Forms.TextBox();
            this.txtbEMail = new System.Windows.Forms.TextBox();
            this.rdbttnKadin = new System.Windows.Forms.RadioButton();
            this.rdbttnErkek = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtbDaire = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbSokak = new System.Windows.Forms.TextBox();
            this.txtbMahalle = new System.Windows.Forms.TextBox();
            this.txtbCadde = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bttnTemizle = new System.Windows.Forms.Button();
            this.bttnKaydet = new System.Windows.Forms.Button();
            this.bttnKaydiSil = new System.Windows.Forms.Button();
            this.bttnKaydiGuncelle = new System.Windows.Forms.Button();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tc Kimlik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cinsiyet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "E-Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefon No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Adres";
            // 
            // txtbTcKimlik
            // 
            this.txtbTcKimlik.Location = new System.Drawing.Point(103, 28);
            this.txtbTcKimlik.Name = "txtbTcKimlik";
            this.txtbTcKimlik.Size = new System.Drawing.Size(100, 20);
            this.txtbTcKimlik.TabIndex = 15;
            // 
            // txtbAd
            // 
            this.txtbAd.Location = new System.Drawing.Point(103, 60);
            this.txtbAd.Name = "txtbAd";
            this.txtbAd.Size = new System.Drawing.Size(100, 20);
            this.txtbAd.TabIndex = 17;
            // 
            // txtbSoyad
            // 
            this.txtbSoyad.Location = new System.Drawing.Point(103, 95);
            this.txtbSoyad.Name = "txtbSoyad";
            this.txtbSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtbSoyad.TabIndex = 19;
            // 
            // txtbTelefonNo
            // 
            this.txtbTelefonNo.Location = new System.Drawing.Point(325, 28);
            this.txtbTelefonNo.Name = "txtbTelefonNo";
            this.txtbTelefonNo.Size = new System.Drawing.Size(100, 20);
            this.txtbTelefonNo.TabIndex = 21;
            // 
            // txtbEMail
            // 
            this.txtbEMail.Location = new System.Drawing.Point(325, 60);
            this.txtbEMail.Name = "txtbEMail";
            this.txtbEMail.Size = new System.Drawing.Size(100, 20);
            this.txtbEMail.TabIndex = 23;
            // 
            // rdbttnKadin
            // 
            this.rdbttnKadin.AutoSize = true;
            this.rdbttnKadin.Location = new System.Drawing.Point(103, 131);
            this.rdbttnKadin.Name = "rdbttnKadin";
            this.rdbttnKadin.Size = new System.Drawing.Size(32, 17);
            this.rdbttnKadin.TabIndex = 24;
            this.rdbttnKadin.TabStop = true;
            this.rdbttnKadin.Text = "K";
            this.rdbttnKadin.UseVisualStyleBackColor = true;
            // 
            // rdbttnErkek
            // 
            this.rdbttnErkek.AutoSize = true;
            this.rdbttnErkek.Location = new System.Drawing.Point(167, 131);
            this.rdbttnErkek.Name = "rdbttnErkek";
            this.rdbttnErkek.Size = new System.Drawing.Size(32, 17);
            this.rdbttnErkek.TabIndex = 25;
            this.rdbttnErkek.TabStop = true;
            this.rdbttnErkek.Text = "E";
            this.rdbttnErkek.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtbDaire);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtbNo);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtbSokak);
            this.panel1.Controls.Add(this.txtbMahalle);
            this.panel1.Controls.Add(this.txtbCadde);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(325, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 142);
            this.panel1.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Daire";
            // 
            // txtbDaire
            // 
            this.txtbDaire.Location = new System.Drawing.Point(50, 106);
            this.txtbDaire.Name = "txtbDaire";
            this.txtbDaire.Size = new System.Drawing.Size(100, 20);
            this.txtbDaire.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "No";
            // 
            // txtbNo
            // 
            this.txtbNo.Location = new System.Drawing.Point(50, 80);
            this.txtbNo.Name = "txtbNo";
            this.txtbNo.Size = new System.Drawing.Size(100, 20);
            this.txtbNo.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Sokak";
            // 
            // txtbSokak
            // 
            this.txtbSokak.Location = new System.Drawing.Point(50, 57);
            this.txtbSokak.Name = "txtbSokak";
            this.txtbSokak.Size = new System.Drawing.Size(100, 20);
            this.txtbSokak.TabIndex = 7;
            // 
            // txtbMahalle
            // 
            this.txtbMahalle.Location = new System.Drawing.Point(50, 31);
            this.txtbMahalle.Name = "txtbMahalle";
            this.txtbMahalle.Size = new System.Drawing.Size(100, 20);
            this.txtbMahalle.TabIndex = 5;
            // 
            // txtbCadde
            // 
            this.txtbCadde.Location = new System.Drawing.Point(50, 5);
            this.txtbCadde.Name = "txtbCadde";
            this.txtbCadde.Size = new System.Drawing.Size(100, 20);
            this.txtbCadde.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Mahhalle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cadde";
            // 
            // bttnTemizle
            // 
            this.bttnTemizle.Location = new System.Drawing.Point(124, 158);
            this.bttnTemizle.Name = "bttnTemizle";
            this.bttnTemizle.Size = new System.Drawing.Size(75, 23);
            this.bttnTemizle.TabIndex = 27;
            this.bttnTemizle.Text = "Temizle";
            this.bttnTemizle.UseVisualStyleBackColor = true;
            // 
            // bttnKaydet
            // 
            this.bttnKaydet.Location = new System.Drawing.Point(30, 199);
            this.bttnKaydet.Name = "bttnKaydet";
            this.bttnKaydet.Size = new System.Drawing.Size(75, 23);
            this.bttnKaydet.TabIndex = 28;
            this.bttnKaydet.Text = "Kaydet";
            this.bttnKaydet.UseVisualStyleBackColor = true;
            // 
            // bttnKaydiSil
            // 
            this.bttnKaydiSil.Location = new System.Drawing.Point(128, 199);
            this.bttnKaydiSil.Name = "bttnKaydiSil";
            this.bttnKaydiSil.Size = new System.Drawing.Size(75, 23);
            this.bttnKaydiSil.TabIndex = 29;
            this.bttnKaydiSil.Text = "Sil";
            this.bttnKaydiSil.UseVisualStyleBackColor = true;
            // 
            // bttnKaydiGuncelle
            // 
            this.bttnKaydiGuncelle.Location = new System.Drawing.Point(219, 199);
            this.bttnKaydiGuncelle.Name = "bttnKaydiGuncelle";
            this.bttnKaydiGuncelle.Size = new System.Drawing.Size(75, 23);
            this.bttnKaydiGuncelle.TabIndex = 30;
            this.bttnKaydiGuncelle.Text = "Güncelle";
            this.bttnKaydiGuncelle.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.txtbArama);
            this.groupBox1.Controls.Add(this.bttnAramaTemizle);
            this.groupBox1.Controls.Add(this.bttnAramaBul);
            this.groupBox1.Location = new System.Drawing.Point(2, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 111);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Listesi";
            // 
            // bttnAramaTemizle
            // 
            this.bttnAramaTemizle.Location = new System.Drawing.Point(284, 19);
            this.bttnAramaTemizle.Name = "bttnAramaTemizle";
            this.bttnAramaTemizle.Size = new System.Drawing.Size(75, 23);
            this.bttnAramaTemizle.TabIndex = 30;
            this.bttnAramaTemizle.Text = "Temizle";
            this.bttnAramaTemizle.UseVisualStyleBackColor = true;
            // 
            // bttnAramaBul
            // 
            this.bttnAramaBul.Location = new System.Drawing.Point(194, 19);
            this.bttnAramaBul.Name = "bttnAramaBul";
            this.bttnAramaBul.Size = new System.Drawing.Size(75, 23);
            this.bttnAramaBul.TabIndex = 29;
            this.bttnAramaBul.Text = "Bul";
            this.bttnAramaBul.UseVisualStyleBackColor = true;
            // 
            // txtbArama
            // 
            this.txtbArama.Location = new System.Drawing.Point(13, 21);
            this.txtbArama.Name = "txtbArama";
            this.txtbArama.Size = new System.Drawing.Size(164, 20);
            this.txtbArama.TabIndex = 39;
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
            this.columnHeader7});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(484, 70);
            this.listView1.TabIndex = 40;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TcKimlik";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyad";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cinsiyet";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "TelefonNo";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "E-Mail";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Adres";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(451, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 359);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bttnKaydiGuncelle);
            this.Controls.Add(this.bttnKaydiSil);
            this.Controls.Add(this.bttnKaydet);
            this.Controls.Add(this.bttnTemizle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rdbttnErkek);
            this.Controls.Add(this.rdbttnKadin);
            this.Controls.Add(this.txtbEMail);
            this.Controls.Add(this.txtbTelefonNo);
            this.Controls.Add(this.txtbSoyad);
            this.Controls.Add(this.txtbAd);
            this.Controls.Add(this.txtbTcKimlik);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtbTcKimlik;
        private System.Windows.Forms.TextBox txtbAd;
        private System.Windows.Forms.TextBox txtbSoyad;
        private System.Windows.Forms.TextBox txtbTelefonNo;
        private System.Windows.Forms.TextBox txtbEMail;
        private System.Windows.Forms.RadioButton rdbttnKadin;
        private System.Windows.Forms.RadioButton rdbttnErkek;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtbDaire;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbSokak;
        private System.Windows.Forms.TextBox txtbMahalle;
        private System.Windows.Forms.TextBox txtbCadde;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bttnTemizle;
        private System.Windows.Forms.Button bttnKaydet;
        private System.Windows.Forms.Button bttnKaydiSil;
        private System.Windows.Forms.Button bttnKaydiGuncelle;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

