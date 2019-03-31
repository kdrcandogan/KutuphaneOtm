namespace KutuphaneOtm
{
    partial class KitapListele
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxYazarAd = new System.Windows.Forms.TextBox();
            this.txtBoxKitapAd = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_Sil = new System.Windows.Forms.Button();
            this.Btn_Güncelle = new System.Windows.Forms.Button();
            this.Btn_Kapat = new System.Windows.Forms.Button();
            this.Btn_Ara2 = new System.Windows.Forms.Button();
            this.Btn_Ara = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtBoxYazarAd);
            this.panel1.Controls.Add(this.txtBoxKitapAd);
            this.panel1.Controls.Add(this.Btn_Sil);
            this.panel1.Controls.Add(this.Btn_Güncelle);
            this.panel1.Controls.Add(this.Btn_Kapat);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.Btn_Ara2);
            this.panel1.Controls.Add(this.Btn_Ara);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 361);
            this.panel1.TabIndex = 0;
            // 
            // txtBoxYazarAd
            // 
            this.txtBoxYazarAd.Location = new System.Drawing.Point(539, 29);
            this.txtBoxYazarAd.Name = "txtBoxYazarAd";
            this.txtBoxYazarAd.Size = new System.Drawing.Size(100, 20);
            this.txtBoxYazarAd.TabIndex = 9;
            // 
            // txtBoxKitapAd
            // 
            this.txtBoxKitapAd.Location = new System.Drawing.Point(74, 28);
            this.txtBoxKitapAd.Name = "txtBoxKitapAd";
            this.txtBoxKitapAd.Size = new System.Drawing.Size(100, 20);
            this.txtBoxKitapAd.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(709, 243);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(490, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yazar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::KutuphaneOtm.Properties.Resources.iconfinder_printer_66871;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(319, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 45);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Sil.BackgroundImage = global::KutuphaneOtm.Properties.Resources.iconfinder_trash_delete_668981;
            this.Btn_Sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Sil.FlatAppearance.BorderSize = 0;
            this.Btn_Sil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Sil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sil.Location = new System.Drawing.Point(669, 313);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(51, 45);
            this.Btn_Sil.TabIndex = 7;
            this.Btn_Sil.UseVisualStyleBackColor = false;
            this.Btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // Btn_Güncelle
            // 
            this.Btn_Güncelle.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Güncelle.BackgroundImage = global::KutuphaneOtm.Properties.Resources.iconfinder_1;
            this.Btn_Güncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Güncelle.FlatAppearance.BorderSize = 0;
            this.Btn_Güncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Güncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Güncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Güncelle.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Güncelle.Location = new System.Drawing.Point(11, 313);
            this.Btn_Güncelle.Name = "Btn_Güncelle";
            this.Btn_Güncelle.Size = new System.Drawing.Size(44, 45);
            this.Btn_Güncelle.TabIndex = 7;
            this.Btn_Güncelle.UseVisualStyleBackColor = false;
            this.Btn_Güncelle.Click += new System.EventHandler(this.Btn_Güncelle_Click);
            // 
            // Btn_Kapat
            // 
            this.Btn_Kapat.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Kapat.BackgroundImage = global::KutuphaneOtm.Properties.Resources.Cikis;
            this.Btn_Kapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Kapat.CausesValidation = false;
            this.Btn_Kapat.FlatAppearance.BorderSize = 0;
            this.Btn_Kapat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Kapat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Kapat.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Kapat.Location = new System.Drawing.Point(706, 0);
            this.Btn_Kapat.Name = "Btn_Kapat";
            this.Btn_Kapat.Size = new System.Drawing.Size(26, 23);
            this.Btn_Kapat.TabIndex = 6;
            this.Btn_Kapat.UseVisualStyleBackColor = false;
            this.Btn_Kapat.Click += new System.EventHandler(this.Btn_Kapat_Click);
            // 
            // Btn_Ara2
            // 
            this.Btn_Ara2.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Ara2.BackgroundImage = global::KutuphaneOtm.Properties.Resources.iconfinder_green_37_478421;
            this.Btn_Ara2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Ara2.FlatAppearance.BorderSize = 0;
            this.Btn_Ara2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Ara2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Ara2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ara2.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Ara2.Location = new System.Drawing.Point(645, 19);
            this.Btn_Ara2.Name = "Btn_Ara2";
            this.Btn_Ara2.Size = new System.Drawing.Size(32, 36);
            this.Btn_Ara2.TabIndex = 4;
            this.Btn_Ara2.UseVisualStyleBackColor = false;
            this.Btn_Ara2.Click += new System.EventHandler(this.Btn_Ara2_Click);
            // 
            // Btn_Ara
            // 
            this.Btn_Ara.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Ara.BackgroundImage = global::KutuphaneOtm.Properties.Resources.iconfinder_green_37_47842;
            this.Btn_Ara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Ara.FlatAppearance.BorderSize = 0;
            this.Btn_Ara.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Ara.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Ara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ara.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Ara.Location = new System.Drawing.Point(180, 18);
            this.Btn_Ara.Name = "Btn_Ara";
            this.Btn_Ara.Size = new System.Drawing.Size(31, 37);
            this.Btn_Ara.TabIndex = 4;
            this.Btn_Ara.UseVisualStyleBackColor = false;
            this.Btn_Ara.Click += new System.EventHandler(this.Btn_Ara_Click);
            // 
            // KitapListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(732, 361);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "KitapListele";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitapListele";
            this.Load += new System.EventHandler(this.KitapListele_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_Ara2;
        private System.Windows.Forms.Button Btn_Ara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Kapat;
        private System.Windows.Forms.Button Btn_Sil;
        private System.Windows.Forms.Button Btn_Güncelle;
        private System.Windows.Forms.TextBox txtBoxYazarAd;
        private System.Windows.Forms.TextBox txtBoxKitapAd;
        private System.Windows.Forms.Button button1;
    }
}