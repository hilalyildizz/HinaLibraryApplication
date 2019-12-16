namespace Hina
{
    partial class PersonRecording
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonRecording));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtbArama = new System.Windows.Forms.TextBox();
            this.bttnAramaTemizle = new System.Windows.Forms.Button();
            this.bttnAramaBul = new System.Windows.Forms.Button();
            this.pctrbxGeri = new System.Windows.Forms.PictureBox();
            this.pctrbxSayfayiKapat = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtbxİlce = new System.Windows.Forms.TextBox();
            this.txtbxİl = new System.Windows.Forms.TextBox();
            this.txtbxBinaAdi = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
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
            this.bttnKaydiGuncelle = new System.Windows.Forms.Button();
            this.bttnKaydiSil = new System.Windows.Forms.Button();
            this.bttnKaydet = new System.Windows.Forms.Button();
            this.bttnTemizle = new System.Windows.Forms.Button();
            this.rdbttnErkek = new System.Windows.Forms.RadioButton();
            this.rdbttnKadin = new System.Windows.Forms.RadioButton();
            this.txtbEMail = new System.Windows.Forms.TextBox();
            this.txtbTelefonNo = new System.Windows.Forms.TextBox();
            this.txtbSoyad = new System.Windows.Forms.TextBox();
            this.txtbAd = new System.Windows.Forms.TextBox();
            this.txtbTcKimlik = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxGeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxSayfayiKapat)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.txtbArama);
            this.groupBox1.Controls.Add(this.bttnAramaTemizle);
            this.groupBox1.Controls.Add(this.bttnAramaBul);
            this.groupBox1.Location = new System.Drawing.Point(40, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 155);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Listesi";
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
            this.listView1.Location = new System.Drawing.Point(6, 53);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(693, 99);
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
            // txtbArama
            // 
            this.txtbArama.Location = new System.Drawing.Point(13, 21);
            this.txtbArama.Name = "txtbArama";
            this.txtbArama.Size = new System.Drawing.Size(239, 20);
            this.txtbArama.TabIndex = 39;
            // 
            // bttnAramaTemizle
            // 
            this.bttnAramaTemizle.Location = new System.Drawing.Point(394, 19);
            this.bttnAramaTemizle.Name = "bttnAramaTemizle";
            this.bttnAramaTemizle.Size = new System.Drawing.Size(75, 23);
            this.bttnAramaTemizle.TabIndex = 30;
            this.bttnAramaTemizle.Text = "Temizle";
            this.bttnAramaTemizle.UseVisualStyleBackColor = true;
            // 
            // bttnAramaBul
            // 
            this.bttnAramaBul.Location = new System.Drawing.Point(308, 19);
            this.bttnAramaBul.Name = "bttnAramaBul";
            this.bttnAramaBul.Size = new System.Drawing.Size(75, 23);
            this.bttnAramaBul.TabIndex = 29;
            this.bttnAramaBul.Text = "Bul";
            this.bttnAramaBul.UseVisualStyleBackColor = true;
            // 
            // pctrbxGeri
            // 
            this.pctrbxGeri.BackColor = System.Drawing.Color.Transparent;
            this.pctrbxGeri.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxGeri.Image")));
            this.pctrbxGeri.Location = new System.Drawing.Point(12, 12);
            this.pctrbxGeri.Name = "pctrbxGeri";
            this.pctrbxGeri.Size = new System.Drawing.Size(20, 20);
            this.pctrbxGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxGeri.TabIndex = 32;
            this.pctrbxGeri.TabStop = false;
            // 
            // pctrbxSayfayiKapat
            // 
            this.pctrbxSayfayiKapat.BackColor = System.Drawing.Color.Transparent;
            this.pctrbxSayfayiKapat.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxSayfayiKapat.Image")));
            this.pctrbxSayfayiKapat.Location = new System.Drawing.Point(739, 11);
            this.pctrbxSayfayiKapat.Name = "pctrbxSayfayiKapat";
            this.pctrbxSayfayiKapat.Size = new System.Drawing.Size(21, 21);
            this.pctrbxSayfayiKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxSayfayiKapat.TabIndex = 33;
            this.pctrbxSayfayiKapat.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.bttnKaydiGuncelle);
            this.groupBox2.Controls.Add(this.bttnKaydiSil);
            this.groupBox2.Controls.Add(this.bttnKaydet);
            this.groupBox2.Controls.Add(this.bttnTemizle);
            this.groupBox2.Controls.Add(this.rdbttnErkek);
            this.groupBox2.Controls.Add(this.rdbttnKadin);
            this.groupBox2.Controls.Add(this.txtbEMail);
            this.groupBox2.Controls.Add(this.txtbTelefonNo);
            this.groupBox2.Controls.Add(this.txtbSoyad);
            this.groupBox2.Controls.Add(this.txtbAd);
            this.groupBox2.Controls.Add(this.txtbTcKimlik);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(40, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(693, 248);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(257, 83);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 13);
            this.label16.TabIndex = 93;
            this.label16.Text = "Şifre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(324, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 20);
            this.textBox1.TabIndex = 92;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtbxİlce);
            this.groupBox3.Controls.Add(this.txtbxİl);
            this.groupBox3.Controls.Add(this.txtbxBinaAdi);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtbDaire);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtbNo);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtbSokak);
            this.groupBox3.Controls.Add(this.txtbMahalle);
            this.groupBox3.Controls.Add(this.txtbCadde);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(324, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 136);
            this.groupBox3.TabIndex = 91;
            this.groupBox3.TabStop = false;
            // 
            // txtbxİlce
            // 
            this.txtbxİlce.Location = new System.Drawing.Point(229, 56);
            this.txtbxİlce.Name = "txtbxİlce";
            this.txtbxİlce.Size = new System.Drawing.Size(100, 20);
            this.txtbxİlce.TabIndex = 45;
            // 
            // txtbxİl
            // 
            this.txtbxİl.Location = new System.Drawing.Point(229, 32);
            this.txtbxİl.Name = "txtbxİl";
            this.txtbxİl.Size = new System.Drawing.Size(100, 20);
            this.txtbxİl.TabIndex = 44;
            // 
            // txtbxBinaAdi
            // 
            this.txtbxBinaAdi.Location = new System.Drawing.Point(229, 9);
            this.txtbxBinaAdi.Name = "txtbxBinaAdi";
            this.txtbxBinaAdi.Size = new System.Drawing.Size(100, 20);
            this.txtbxBinaAdi.TabIndex = 43;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(181, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "İlçe";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(181, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(12, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "İl";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(181, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "Bina Adı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Daire";
            // 
            // txtbDaire
            // 
            this.txtbDaire.Location = new System.Drawing.Point(53, 110);
            this.txtbDaire.Name = "txtbDaire";
            this.txtbDaire.Size = new System.Drawing.Size(100, 20);
            this.txtbDaire.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "No";
            // 
            // txtbNo
            // 
            this.txtbNo.Location = new System.Drawing.Point(53, 84);
            this.txtbNo.Name = "txtbNo";
            this.txtbNo.Size = new System.Drawing.Size(100, 20);
            this.txtbNo.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Sokak";
            // 
            // txtbSokak
            // 
            this.txtbSokak.Location = new System.Drawing.Point(53, 61);
            this.txtbSokak.Name = "txtbSokak";
            this.txtbSokak.Size = new System.Drawing.Size(100, 20);
            this.txtbSokak.TabIndex = 34;
            // 
            // txtbMahalle
            // 
            this.txtbMahalle.Location = new System.Drawing.Point(53, 35);
            this.txtbMahalle.Name = "txtbMahalle";
            this.txtbMahalle.Size = new System.Drawing.Size(100, 20);
            this.txtbMahalle.TabIndex = 33;
            // 
            // txtbCadde
            // 
            this.txtbCadde.Location = new System.Drawing.Point(53, 9);
            this.txtbCadde.Name = "txtbCadde";
            this.txtbCadde.Size = new System.Drawing.Size(100, 20);
            this.txtbCadde.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Mahhalle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Cadde";
            // 
            // bttnKaydiGuncelle
            // 
            this.bttnKaydiGuncelle.Location = new System.Drawing.Point(213, 192);
            this.bttnKaydiGuncelle.Name = "bttnKaydiGuncelle";
            this.bttnKaydiGuncelle.Size = new System.Drawing.Size(75, 23);
            this.bttnKaydiGuncelle.TabIndex = 90;
            this.bttnKaydiGuncelle.Text = "Güncelle";
            this.bttnKaydiGuncelle.UseVisualStyleBackColor = true;
            // 
            // bttnKaydiSil
            // 
            this.bttnKaydiSil.Location = new System.Drawing.Point(122, 192);
            this.bttnKaydiSil.Name = "bttnKaydiSil";
            this.bttnKaydiSil.Size = new System.Drawing.Size(75, 23);
            this.bttnKaydiSil.TabIndex = 89;
            this.bttnKaydiSil.Text = "Sil";
            this.bttnKaydiSil.UseVisualStyleBackColor = true;
            // 
            // bttnKaydet
            // 
            this.bttnKaydet.Location = new System.Drawing.Point(24, 192);
            this.bttnKaydet.Name = "bttnKaydet";
            this.bttnKaydet.Size = new System.Drawing.Size(75, 23);
            this.bttnKaydet.TabIndex = 88;
            this.bttnKaydet.Text = "Kaydet";
            this.bttnKaydet.UseVisualStyleBackColor = true;
            // 
            // bttnTemizle
            // 
            this.bttnTemizle.Location = new System.Drawing.Point(118, 151);
            this.bttnTemizle.Name = "bttnTemizle";
            this.bttnTemizle.Size = new System.Drawing.Size(75, 23);
            this.bttnTemizle.TabIndex = 87;
            this.bttnTemizle.Text = "Temizle";
            this.bttnTemizle.UseVisualStyleBackColor = true;
            // 
            // rdbttnErkek
            // 
            this.rdbttnErkek.AutoSize = true;
            this.rdbttnErkek.Location = new System.Drawing.Point(161, 124);
            this.rdbttnErkek.Name = "rdbttnErkek";
            this.rdbttnErkek.Size = new System.Drawing.Size(53, 17);
            this.rdbttnErkek.TabIndex = 85;
            this.rdbttnErkek.TabStop = true;
            this.rdbttnErkek.Text = "Erkek";
            this.rdbttnErkek.UseVisualStyleBackColor = true;
            // 
            // rdbttnKadin
            // 
            this.rdbttnKadin.AutoSize = true;
            this.rdbttnKadin.Location = new System.Drawing.Point(97, 124);
            this.rdbttnKadin.Name = "rdbttnKadin";
            this.rdbttnKadin.Size = new System.Drawing.Size(52, 17);
            this.rdbttnKadin.TabIndex = 84;
            this.rdbttnKadin.TabStop = true;
            this.rdbttnKadin.Text = "Kadın";
            this.rdbttnKadin.UseVisualStyleBackColor = true;
            // 
            // txtbEMail
            // 
            this.txtbEMail.Location = new System.Drawing.Point(324, 53);
            this.txtbEMail.Name = "txtbEMail";
            this.txtbEMail.Size = new System.Drawing.Size(114, 20);
            this.txtbEMail.TabIndex = 83;
            // 
            // txtbTelefonNo
            // 
            this.txtbTelefonNo.Location = new System.Drawing.Point(324, 21);
            this.txtbTelefonNo.Name = "txtbTelefonNo";
            this.txtbTelefonNo.Size = new System.Drawing.Size(114, 20);
            this.txtbTelefonNo.TabIndex = 82;
            // 
            // txtbSoyad
            // 
            this.txtbSoyad.Location = new System.Drawing.Point(97, 88);
            this.txtbSoyad.Name = "txtbSoyad";
            this.txtbSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtbSoyad.TabIndex = 81;
            // 
            // txtbAd
            // 
            this.txtbAd.Location = new System.Drawing.Point(97, 53);
            this.txtbAd.Name = "txtbAd";
            this.txtbAd.Size = new System.Drawing.Size(100, 20);
            this.txtbAd.TabIndex = 80;
            // 
            // txtbTcKimlik
            // 
            this.txtbTcKimlik.Location = new System.Drawing.Point(97, 21);
            this.txtbTcKimlik.Name = "txtbTcKimlik";
            this.txtbTcKimlik.Size = new System.Drawing.Size(100, 20);
            this.txtbTcKimlik.TabIndex = 79;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 78;
            this.label7.Text = "Adres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 77;
            this.label6.Text = "Telefon No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 76;
            this.label5.Text = "E-Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "Cinsiyet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Tc Kimlik";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(289, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(131, 23);
            this.label17.TabIndex = 95;
            this.label17.Text = "Üye Kayıt İşlemi";
            // 
            // PersonRecording
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 450);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pctrbxSayfayiKapat);
            this.Controls.Add(this.pctrbxGeri);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonRecording";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxGeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxSayfayiKapat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.PictureBox pctrbxGeri;
        private System.Windows.Forms.PictureBox pctrbxSayfayiKapat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtbxİlce;
        private System.Windows.Forms.TextBox txtbxİl;
        private System.Windows.Forms.TextBox txtbxBinaAdi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
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
        private System.Windows.Forms.Button bttnKaydiGuncelle;
        private System.Windows.Forms.Button bttnKaydiSil;
        private System.Windows.Forms.Button bttnKaydet;
        private System.Windows.Forms.Button bttnTemizle;
        private System.Windows.Forms.RadioButton rdbttnErkek;
        private System.Windows.Forms.RadioButton rdbttnKadin;
        private System.Windows.Forms.TextBox txtbEMail;
        private System.Windows.Forms.TextBox txtbTelefonNo;
        private System.Windows.Forms.TextBox txtbSoyad;
        private System.Windows.Forms.TextBox txtbAd;
        private System.Windows.Forms.TextBox txtbTcKimlik;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label17;
    }
}

