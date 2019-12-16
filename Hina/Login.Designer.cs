namespace Hina
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btngiris = new System.Windows.Forms.Button();
            this.txtbsifre = new System.Windows.Forms.TextBox();
            this.txtbeposta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pctrbxSayfayiKapat = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxSayfayiKapat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btngiris);
            this.panel1.Controls.Add(this.txtbsifre);
            this.panel1.Controls.Add(this.txtbeposta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(242, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 279);
            this.panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(182, 234);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(32, 14);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "kayıt";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(42, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hesabın yok mu ? Hemen           ol !";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "ŞİFRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-POSTA";
            // 
            // btngiris
            // 
            this.btngiris.BackColor = System.Drawing.Color.PeachPuff;
            this.btngiris.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btngiris.FlatAppearance.BorderSize = 0;
            this.btngiris.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngiris.Location = new System.Drawing.Point(96, 192);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(75, 27);
            this.btngiris.TabIndex = 3;
            this.btngiris.Text = "GİRİŞ";
            this.btngiris.UseVisualStyleBackColor = false;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // txtbsifre
            // 
            this.txtbsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbsifre.Location = new System.Drawing.Point(47, 147);
            this.txtbsifre.Name = "txtbsifre";
            this.txtbsifre.Size = new System.Drawing.Size(174, 27);
            this.txtbsifre.TabIndex = 2;
            // 
            // txtbeposta
            // 
            this.txtbeposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbeposta.Location = new System.Drawing.Point(47, 89);
            this.txtbeposta.Name = "txtbeposta";
            this.txtbeposta.Size = new System.Drawing.Size(174, 27);
            this.txtbeposta.TabIndex = 1;
            this.txtbeposta.TextChanged += new System.EventHandler(this.txtbeposta_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giriş Yap";
            // 
            // pctrbxSayfayiKapat
            // 
            this.pctrbxSayfayiKapat.BackColor = System.Drawing.Color.Transparent;
            this.pctrbxSayfayiKapat.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxSayfayiKapat.Image")));
            this.pctrbxSayfayiKapat.Location = new System.Drawing.Point(739, 12);
            this.pctrbxSayfayiKapat.Name = "pctrbxSayfayiKapat";
            this.pctrbxSayfayiKapat.Size = new System.Drawing.Size(21, 21);
            this.pctrbxSayfayiKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxSayfayiKapat.TabIndex = 2;
            this.pctrbxSayfayiKapat.TabStop = false;
            this.pctrbxSayfayiKapat.Click += new System.EventHandler(this.pctrbxSayfayiKapat_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(772, 450);
            this.Controls.Add(this.pctrbxSayfayiKapat);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxSayfayiKapat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.TextBox txtbsifre;
        private System.Windows.Forms.TextBox txtbeposta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pctrbxSayfayiKapat;
    }
}