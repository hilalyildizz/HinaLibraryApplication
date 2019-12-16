namespace Hina
{
    partial class RegisterOption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterOption));
            this.bttnPersonel = new System.Windows.Forms.Button();
            this.bttnKullanici = new System.Windows.Forms.Button();
            this.pctrbxGeri = new System.Windows.Forms.PictureBox();
            this.pctrbxSayfayiKapat = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxGeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxSayfayiKapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnPersonel
            // 
            this.bttnPersonel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bttnPersonel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnPersonel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnPersonel.ForeColor = System.Drawing.Color.Black;
            this.bttnPersonel.Location = new System.Drawing.Point(249, 192);
            this.bttnPersonel.Name = "bttnPersonel";
            this.bttnPersonel.Size = new System.Drawing.Size(91, 35);
            this.bttnPersonel.TabIndex = 0;
            this.bttnPersonel.Text = "Personel";
            this.bttnPersonel.UseVisualStyleBackColor = false;
            this.bttnPersonel.Click += new System.EventHandler(this.bttnPersonel_Click);
            // 
            // bttnKullanici
            // 
            this.bttnKullanici.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnKullanici.Location = new System.Drawing.Point(412, 192);
            this.bttnKullanici.Name = "bttnKullanici";
            this.bttnKullanici.Size = new System.Drawing.Size(89, 35);
            this.bttnKullanici.TabIndex = 1;
            this.bttnKullanici.Text = "Kullanıcı";
            this.bttnKullanici.UseVisualStyleBackColor = true;
            this.bttnKullanici.Click += new System.EventHandler(this.bttnKullanici_Click);
            // 
            // pctrbxGeri
            // 
            this.pctrbxGeri.BackColor = System.Drawing.Color.Transparent;
            this.pctrbxGeri.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxGeri.Image")));
            this.pctrbxGeri.Location = new System.Drawing.Point(12, 12);
            this.pctrbxGeri.Name = "pctrbxGeri";
            this.pctrbxGeri.Size = new System.Drawing.Size(20, 20);
            this.pctrbxGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxGeri.TabIndex = 2;
            this.pctrbxGeri.TabStop = false;
            this.pctrbxGeri.Click += new System.EventHandler(this.pctrbxGeri_Click);
            // 
            // pctrbxSayfayiKapat
            // 
            this.pctrbxSayfayiKapat.BackColor = System.Drawing.Color.Transparent;
            this.pctrbxSayfayiKapat.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxSayfayiKapat.Image")));
            this.pctrbxSayfayiKapat.Location = new System.Drawing.Point(732, 12);
            this.pctrbxSayfayiKapat.Name = "pctrbxSayfayiKapat";
            this.pctrbxSayfayiKapat.Size = new System.Drawing.Size(21, 21);
            this.pctrbxSayfayiKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxSayfayiKapat.TabIndex = 3;
            this.pctrbxSayfayiKapat.TabStop = false;
            this.pctrbxSayfayiKapat.Click += new System.EventHandler(this.pctrbxSayfayiKapat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(280, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 23);
            this.label1.TabIndex = 47;
            this.label1.Text = "Personel ve Üye Seçeneği";
            // 
            // RegisterOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(772, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pctrbxSayfayiKapat);
            this.Controls.Add(this.pctrbxGeri);
            this.Controls.Add(this.bttnKullanici);
            this.Controls.Add(this.bttnPersonel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterOption";
            this.Text = "RegisterOption";
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxGeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxSayfayiKapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnPersonel;
        private System.Windows.Forms.Button bttnKullanici;
        private System.Windows.Forms.PictureBox pctrbxGeri;
        private System.Windows.Forms.PictureBox pctrbxSayfayiKapat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}