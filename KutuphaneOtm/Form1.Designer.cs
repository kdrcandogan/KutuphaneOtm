namespace KutuphaneOtm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Uyeler = new System.Windows.Forms.Button();
            this.Btn_EmanetVer = new System.Windows.Forms.Button();
            this.Btn_Kayit = new System.Windows.Forms.Button();
            this.Btn_Cikis = new System.Windows.Forms.Button();
            this.Btn_Iletisim = new System.Windows.Forms.Button();
            this.Btn_KitapListele = new System.Windows.Forms.Button();
            this.Btn_KitapEkle = new System.Windows.Forms.Button();
            this.Btn_EmanetSorgu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::KutuphaneOtm.Properties.Resources.AnaResim1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Btn_Uyeler);
            this.panel1.Controls.Add(this.Btn_EmanetVer);
            this.panel1.Controls.Add(this.Btn_Kayit);
            this.panel1.Controls.Add(this.Btn_Cikis);
            this.panel1.Controls.Add(this.Btn_Iletisim);
            this.panel1.Controls.Add(this.Btn_KitapListele);
            this.panel1.Controls.Add(this.Btn_KitapEkle);
            this.panel1.Controls.Add(this.Btn_EmanetSorgu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 6;
            // 
            // Btn_Uyeler
            // 
            this.Btn_Uyeler.Location = new System.Drawing.Point(505, 292);
            this.Btn_Uyeler.Name = "Btn_Uyeler";
            this.Btn_Uyeler.Size = new System.Drawing.Size(75, 23);
            this.Btn_Uyeler.TabIndex = 7;
            this.Btn_Uyeler.Text = "Uyeler";
            this.Btn_Uyeler.UseVisualStyleBackColor = true;
            this.Btn_Uyeler.Click += new System.EventHandler(this.Btn_Uyeler_Click);
            // 
            // Btn_EmanetVer
            // 
            this.Btn_EmanetVer.Location = new System.Drawing.Point(595, 292);
            this.Btn_EmanetVer.Name = "Btn_EmanetVer";
            this.Btn_EmanetVer.Size = new System.Drawing.Size(75, 23);
            this.Btn_EmanetVer.TabIndex = 6;
            this.Btn_EmanetVer.Text = "Emanet Ver";
            this.Btn_EmanetVer.UseVisualStyleBackColor = true;
            this.Btn_EmanetVer.Click += new System.EventHandler(this.Btn_EmanetVer_Click);
            // 
            // Btn_Kayit
            // 
            this.Btn_Kayit.Location = new System.Drawing.Point(412, 292);
            this.Btn_Kayit.Name = "Btn_Kayit";
            this.Btn_Kayit.Size = new System.Drawing.Size(75, 23);
            this.Btn_Kayit.TabIndex = 2;
            this.Btn_Kayit.Text = "Kayıt";
            this.Btn_Kayit.UseVisualStyleBackColor = true;
            this.Btn_Kayit.Click += new System.EventHandler(this.Btn_Kayit_Click);
            // 
            // Btn_Cikis
            // 
            this.Btn_Cikis.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Cikis.BackgroundImage = global::KutuphaneOtm.Properties.Resources.Cikis2;
            this.Btn_Cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Cikis.FlatAppearance.BorderSize = 0;
            this.Btn_Cikis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Cikis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cikis.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Cikis.Location = new System.Drawing.Point(773, 0);
            this.Btn_Cikis.Name = "Btn_Cikis";
            this.Btn_Cikis.Size = new System.Drawing.Size(27, 23);
            this.Btn_Cikis.TabIndex = 1;
            this.Btn_Cikis.UseVisualStyleBackColor = false;
            this.Btn_Cikis.Click += new System.EventHandler(this.Btn_Cikis_Click);
            // 
            // Btn_Iletisim
            // 
            this.Btn_Iletisim.Location = new System.Drawing.Point(421, 0);
            this.Btn_Iletisim.Name = "Btn_Iletisim";
            this.Btn_Iletisim.Size = new System.Drawing.Size(159, 23);
            this.Btn_Iletisim.TabIndex = 5;
            this.Btn_Iletisim.Text = "İletişim";
            this.Btn_Iletisim.UseVisualStyleBackColor = true;
            this.Btn_Iletisim.Click += new System.EventHandler(this.Btn_Iletisim_Click);
            // 
            // Btn_KitapListele
            // 
            this.Btn_KitapListele.Location = new System.Drawing.Point(135, 122);
            this.Btn_KitapListele.Name = "Btn_KitapListele";
            this.Btn_KitapListele.Size = new System.Drawing.Size(75, 23);
            this.Btn_KitapListele.TabIndex = 0;
            this.Btn_KitapListele.Text = "Kitap Listele";
            this.Btn_KitapListele.UseVisualStyleBackColor = true;
            this.Btn_KitapListele.Click += new System.EventHandler(this.Btn_KitapListele_Click);
            // 
            // Btn_KitapEkle
            // 
            this.Btn_KitapEkle.Location = new System.Drawing.Point(135, 23);
            this.Btn_KitapEkle.Name = "Btn_KitapEkle";
            this.Btn_KitapEkle.Size = new System.Drawing.Size(75, 23);
            this.Btn_KitapEkle.TabIndex = 4;
            this.Btn_KitapEkle.Text = "Kitap Ekle";
            this.Btn_KitapEkle.UseVisualStyleBackColor = true;
            this.Btn_KitapEkle.Click += new System.EventHandler(this.Btn_KitapEkle_Click);
            // 
            // Btn_EmanetSorgu
            // 
            this.Btn_EmanetSorgu.Location = new System.Drawing.Point(135, 208);
            this.Btn_EmanetSorgu.Name = "Btn_EmanetSorgu";
            this.Btn_EmanetSorgu.Size = new System.Drawing.Size(75, 23);
            this.Btn_EmanetSorgu.TabIndex = 3;
            this.Btn_EmanetSorgu.Text = "Emanetler";
            this.Btn_EmanetSorgu.UseVisualStyleBackColor = true;
            this.Btn_EmanetSorgu.Click += new System.EventHandler(this.Btn_EmanetSorgu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_KitapListele;
        private System.Windows.Forms.Button Btn_Cikis;
        private System.Windows.Forms.Button Btn_Kayit;
        private System.Windows.Forms.Button Btn_EmanetSorgu;
        private System.Windows.Forms.Button Btn_KitapEkle;
        private System.Windows.Forms.Button Btn_Iletisim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_EmanetVer;
        private System.Windows.Forms.Button Btn_Uyeler;
    }
}

