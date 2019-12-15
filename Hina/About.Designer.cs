namespace Hina
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pctrbxAnasayfa = new System.Windows.Forms.PictureBox();
            this.pctrbxGeri = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxAnasayfa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxGeri)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AlternateGothic2 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kütüphane Uygulaması";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("AlternateGothic2 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(154, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Copyright 2019";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("AlternateGothic2 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(170, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Version 1,0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("AlternateGothic2 BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(155, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "HAKKINDA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(230, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pctrbxAnasayfa
            // 
            this.pctrbxAnasayfa.BackColor = System.Drawing.Color.Transparent;
            this.pctrbxAnasayfa.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxAnasayfa.Image")));
            this.pctrbxAnasayfa.Location = new System.Drawing.Point(388, 12);
            this.pctrbxAnasayfa.Name = "pctrbxAnasayfa";
            this.pctrbxAnasayfa.Size = new System.Drawing.Size(21, 21);
            this.pctrbxAnasayfa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxAnasayfa.TabIndex = 7;
            this.pctrbxAnasayfa.TabStop = false;
            this.pctrbxAnasayfa.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pctrbxGeri
            // 
            this.pctrbxGeri.BackColor = System.Drawing.Color.Transparent;
            this.pctrbxGeri.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxGeri.Image")));
            this.pctrbxGeri.Location = new System.Drawing.Point(12, 12);
            this.pctrbxGeri.Name = "pctrbxGeri";
            this.pctrbxGeri.Size = new System.Drawing.Size(21, 21);
            this.pctrbxGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxGeri.TabIndex = 8;
            this.pctrbxGeri.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 363);
            this.Controls.Add(this.pctrbxGeri);
            this.Controls.Add(this.pctrbxAnasayfa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxAnasayfa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxGeri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pctrbxAnasayfa;
        private System.Windows.Forms.PictureBox pctrbxGeri;
    }
}

