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
            this.pctrbxAnasayfa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxGeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxAnasayfa)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnPersonel
            // 
            this.bttnPersonel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bttnPersonel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnPersonel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnPersonel.ForeColor = System.Drawing.Color.Black;
            this.bttnPersonel.Location = new System.Drawing.Point(139, 172);
            this.bttnPersonel.Name = "bttnPersonel";
            this.bttnPersonel.Size = new System.Drawing.Size(91, 35);
            this.bttnPersonel.TabIndex = 0;
            this.bttnPersonel.Text = "Personel";
            this.bttnPersonel.UseVisualStyleBackColor = false;
            // 
            // bttnKullanici
            // 
            this.bttnKullanici.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnKullanici.Location = new System.Drawing.Point(302, 172);
            this.bttnKullanici.Name = "bttnKullanici";
            this.bttnKullanici.Size = new System.Drawing.Size(89, 35);
            this.bttnKullanici.TabIndex = 1;
            this.bttnKullanici.Text = "Kullanıcı";
            this.bttnKullanici.UseVisualStyleBackColor = true;
            // 
            // pctrbxGeri
            // 
            this.pctrbxGeri.BackColor = System.Drawing.Color.Transparent;
            this.pctrbxGeri.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxGeri.Image")));
            this.pctrbxGeri.Location = new System.Drawing.Point(12, 12);
            this.pctrbxGeri.Name = "pctrbxGeri";
            this.pctrbxGeri.Size = new System.Drawing.Size(24, 25);
            this.pctrbxGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxGeri.TabIndex = 2;
            this.pctrbxGeri.TabStop = false;
            // 
            // pctrbxAnasayfa
            // 
            this.pctrbxAnasayfa.BackColor = System.Drawing.Color.Transparent;
            this.pctrbxAnasayfa.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxAnasayfa.Image")));
            this.pctrbxAnasayfa.Location = new System.Drawing.Point(476, 12);
            this.pctrbxAnasayfa.Name = "pctrbxAnasayfa";
            this.pctrbxAnasayfa.Size = new System.Drawing.Size(28, 25);
            this.pctrbxAnasayfa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxAnasayfa.TabIndex = 3;
            this.pctrbxAnasayfa.TabStop = false;
            // 
            // RegisterOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(530, 372);
            this.Controls.Add(this.pctrbxAnasayfa);
            this.Controls.Add(this.pctrbxGeri);
            this.Controls.Add(this.bttnKullanici);
            this.Controls.Add(this.bttnPersonel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterOption";
            this.Text = "RegisterOption";
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxGeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxAnasayfa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnPersonel;
        private System.Windows.Forms.Button bttnKullanici;
        private System.Windows.Forms.PictureBox pctrbxGeri;
        private System.Windows.Forms.PictureBox pctrbxAnasayfa;
    }
}