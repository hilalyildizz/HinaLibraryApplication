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
            this.pctrbxGeri = new System.Windows.Forms.PictureBox();
            this.pctrbxSayfayiKapat = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttnOduncVer = new System.Windows.Forms.Button();
            this.dateAlımTarihi = new System.Windows.Forms.DateTimePicker();
            this.dateTeslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.bttnTemizle = new System.Windows.Forms.Button();
            this.bttnTeslimAl = new System.Windows.Forms.Button();
            this.txtbKitapKodu = new System.Windows.Forms.TextBox();
            this.txtbTcKimlik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxGeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxSayfayiKapat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pctrbxGeri
            // 
            this.pctrbxGeri.BackColor = System.Drawing.Color.Transparent;
            this.pctrbxGeri.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxGeri.Image")));
            this.pctrbxGeri.Location = new System.Drawing.Point(12, 12);
            this.pctrbxGeri.Name = "pctrbxGeri";
            this.pctrbxGeri.Size = new System.Drawing.Size(20, 20);
            this.pctrbxGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxGeri.TabIndex = 10;
            this.pctrbxGeri.TabStop = false;
            // 
            // pctrbxSayfayiKapat
            // 
            this.pctrbxSayfayiKapat.BackColor = System.Drawing.Color.Transparent;
            this.pctrbxSayfayiKapat.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxSayfayiKapat.Image")));
            this.pctrbxSayfayiKapat.Location = new System.Drawing.Point(730, 11);
            this.pctrbxSayfayiKapat.Name = "pctrbxSayfayiKapat";
            this.pctrbxSayfayiKapat.Size = new System.Drawing.Size(21, 21);
            this.pctrbxSayfayiKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxSayfayiKapat.TabIndex = 11;
            this.pctrbxSayfayiKapat.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttnOduncVer);
            this.groupBox1.Controls.Add(this.dateAlımTarihi);
            this.groupBox1.Controls.Add(this.dateTeslimTarihi);
            this.groupBox1.Controls.Add(this.bttnTemizle);
            this.groupBox1.Controls.Add(this.bttnTeslimAl);
            this.groupBox1.Controls.Add(this.txtbKitapKodu);
            this.groupBox1.Controls.Add(this.txtbTcKimlik);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(81, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 231);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // bttnOduncVer
            // 
            this.bttnOduncVer.Location = new System.Drawing.Point(133, 163);
            this.bttnOduncVer.Name = "bttnOduncVer";
            this.bttnOduncVer.Size = new System.Drawing.Size(75, 23);
            this.bttnOduncVer.TabIndex = 26;
            this.bttnOduncVer.Text = "Ödünç Ver";
            this.bttnOduncVer.UseVisualStyleBackColor = true;
            this.bttnOduncVer.Click += new System.EventHandler(this.bttnOduncVer_Click);
            // 
            // dateAlımTarihi
            // 
            this.dateAlımTarihi.Location = new System.Drawing.Point(373, 44);
            this.dateAlımTarihi.Name = "dateAlımTarihi";
            this.dateAlımTarihi.Size = new System.Drawing.Size(200, 20);
            this.dateAlımTarihi.TabIndex = 25;
            // 
            // dateTeslimTarihi
            // 
            this.dateTeslimTarihi.Location = new System.Drawing.Point(373, 85);
            this.dateTeslimTarihi.Name = "dateTeslimTarihi";
            this.dateTeslimTarihi.Size = new System.Drawing.Size(200, 20);
            this.dateTeslimTarihi.TabIndex = 24;
            // 
            // bttnTemizle
            // 
            this.bttnTemizle.Location = new System.Drawing.Point(405, 164);
            this.bttnTemizle.Name = "bttnTemizle";
            this.bttnTemizle.Size = new System.Drawing.Size(75, 23);
            this.bttnTemizle.TabIndex = 23;
            this.bttnTemizle.Text = "Temizle";
            this.bttnTemizle.UseVisualStyleBackColor = true;
            // 
            // bttnTeslimAl
            // 
            this.bttnTeslimAl.Location = new System.Drawing.Point(267, 163);
            this.bttnTeslimAl.Name = "bttnTeslimAl";
            this.bttnTeslimAl.Size = new System.Drawing.Size(75, 23);
            this.bttnTeslimAl.TabIndex = 22;
            this.bttnTeslimAl.Text = "Teslim Al";
            this.bttnTeslimAl.UseVisualStyleBackColor = true;
            // 
            // txtbKitapKodu
            // 
            this.txtbKitapKodu.Location = new System.Drawing.Point(99, 85);
            this.txtbKitapKodu.Name = "txtbKitapKodu";
            this.txtbKitapKodu.Size = new System.Drawing.Size(126, 20);
            this.txtbKitapKodu.TabIndex = 21;
            // 
            // txtbTcKimlik
            // 
            this.txtbTcKimlik.Location = new System.Drawing.Point(99, 46);
            this.txtbTcKimlik.Name = "txtbTcKimlik";
            this.txtbTcKimlik.Size = new System.Drawing.Size(126, 20);
            this.txtbTcKimlik.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(264, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Teslim Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(264, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Alım Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Kitap Kodu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tc Kimlik";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Location = new System.Drawing.Point(81, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(588, 163);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ödünç Verilen Kitaplar";
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
            this.listView1.Location = new System.Drawing.Point(6, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(576, 123);
            this.listView1.TabIndex = 53;
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
            this.columnHeader4.Text = "Yazar Ad";
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
            this.pictureBox1.Location = new System.Drawing.Point(38, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(196, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(356, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "Personel Ödünç Verme  Ve Teslim Alma İşlemi";
            // 
            // BookLend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pctrbxSayfayiKapat);
            this.Controls.Add(this.pctrbxGeri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookLend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxGeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxSayfayiKapat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pctrbxGeri;
        private System.Windows.Forms.PictureBox pctrbxSayfayiKapat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttnOduncVer;
        private System.Windows.Forms.DateTimePicker dateAlımTarihi;
        private System.Windows.Forms.DateTimePicker dateTeslimTarihi;
        private System.Windows.Forms.Button bttnTemizle;
        private System.Windows.Forms.Button bttnTeslimAl;
        private System.Windows.Forms.TextBox txtbKitapKodu;
        private System.Windows.Forms.TextBox txtbTcKimlik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.Label label5;
    }
}

