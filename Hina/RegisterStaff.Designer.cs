namespace Hina
{
    partial class RegisterStaff
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
            this.bttnKitapIslemleri = new System.Windows.Forms.Button();
            this.bttnUyeIslemleri = new System.Windows.Forms.Button();
            this.bttnGecikmisKitaplar = new System.Windows.Forms.Button();
            this.bttnAyarlar = new System.Windows.Forms.Button();
            this.bttnEmanetIslemleri = new System.Windows.Forms.Button();
            this.bttnHakkinda = new System.Windows.Forms.Button();
            this.bttnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnKitapIslemleri
            // 
            this.bttnKitapIslemleri.Location = new System.Drawing.Point(119, 55);
            this.bttnKitapIslemleri.Name = "bttnKitapIslemleri";
            this.bttnKitapIslemleri.Size = new System.Drawing.Size(75, 44);
            this.bttnKitapIslemleri.TabIndex = 0;
            this.bttnKitapIslemleri.Text = "Kitap İşlemleri";
            this.bttnKitapIslemleri.UseVisualStyleBackColor = true;
            // 
            // bttnUyeIslemleri
            // 
            this.bttnUyeIslemleri.Location = new System.Drawing.Point(321, 55);
            this.bttnUyeIslemleri.Name = "bttnUyeIslemleri";
            this.bttnUyeIslemleri.Size = new System.Drawing.Size(75, 44);
            this.bttnUyeIslemleri.TabIndex = 1;
            this.bttnUyeIslemleri.Text = "Üye İşlemleri";
            this.bttnUyeIslemleri.UseVisualStyleBackColor = true;
            // 
            // bttnGecikmisKitaplar
            // 
            this.bttnGecikmisKitaplar.Location = new System.Drawing.Point(529, 55);
            this.bttnGecikmisKitaplar.Name = "bttnGecikmisKitaplar";
            this.bttnGecikmisKitaplar.Size = new System.Drawing.Size(75, 44);
            this.bttnGecikmisKitaplar.TabIndex = 2;
            this.bttnGecikmisKitaplar.Text = "Gecikmiş Kitaplar";
            this.bttnGecikmisKitaplar.UseVisualStyleBackColor = true;
            // 
            // bttnAyarlar
            // 
            this.bttnAyarlar.Location = new System.Drawing.Point(119, 196);
            this.bttnAyarlar.Name = "bttnAyarlar";
            this.bttnAyarlar.Size = new System.Drawing.Size(75, 46);
            this.bttnAyarlar.TabIndex = 3;
            this.bttnAyarlar.Text = "Ayarlar";
            this.bttnAyarlar.UseVisualStyleBackColor = true;
            // 
            // bttnEmanetIslemleri
            // 
            this.bttnEmanetIslemleri.Location = new System.Drawing.Point(321, 196);
            this.bttnEmanetIslemleri.Name = "bttnEmanetIslemleri";
            this.bttnEmanetIslemleri.Size = new System.Drawing.Size(75, 46);
            this.bttnEmanetIslemleri.TabIndex = 4;
            this.bttnEmanetIslemleri.Text = "Emanet İşlemleri";
            this.bttnEmanetIslemleri.UseVisualStyleBackColor = true;
            // 
            // bttnHakkinda
            // 
            this.bttnHakkinda.Location = new System.Drawing.Point(529, 196);
            this.bttnHakkinda.Name = "bttnHakkinda";
            this.bttnHakkinda.Size = new System.Drawing.Size(75, 46);
            this.bttnHakkinda.TabIndex = 5;
            this.bttnHakkinda.Text = "Hakkında";
            this.bttnHakkinda.UseVisualStyleBackColor = true;
            // 
            // bttnCikis
            // 
            this.bttnCikis.Location = new System.Drawing.Point(321, 305);
            this.bttnCikis.Name = "bttnCikis";
            this.bttnCikis.Size = new System.Drawing.Size(75, 45);
            this.bttnCikis.TabIndex = 6;
            this.bttnCikis.Text = "Çıkış";
            this.bttnCikis.UseVisualStyleBackColor = true;
            // 
            // RegisterStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 450);
            this.Controls.Add(this.bttnCikis);
            this.Controls.Add(this.bttnHakkinda);
            this.Controls.Add(this.bttnEmanetIslemleri);
            this.Controls.Add(this.bttnAyarlar);
            this.Controls.Add(this.bttnGecikmisKitaplar);
            this.Controls.Add(this.bttnUyeIslemleri);
            this.Controls.Add(this.bttnKitapIslemleri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterStaff";
            this.Text = "RegisterStaff";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnKitapIslemleri;
        private System.Windows.Forms.Button bttnUyeIslemleri;
        private System.Windows.Forms.Button bttnGecikmisKitaplar;
        private System.Windows.Forms.Button bttnAyarlar;
        private System.Windows.Forms.Button bttnEmanetIslemleri;
        private System.Windows.Forms.Button bttnHakkinda;
        private System.Windows.Forms.Button bttnCikis;
    }
}