using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtm
{
    public partial class KitapEkle : Form
    {
        public KitapEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data.KutuphaneOtmEntities1 db = new Data.KutuphaneOtmEntities1();

            Data.Kitaplar yeniKitap = new Data.Kitaplar
            {
                KitapAd = textBox1.Text,
                KitapTur = textBox2.Text,
                KitapYayinEvi = textBox3.Text,
                KitapSayfaSayısı = Convert.ToInt32( textBox6.Text),
                KitapYazar = textBox4.Text,
                KitapDil= textBox5.Text,
                KitapAciklama= richTextBox1.Text,
                KitapAdet= Convert.ToInt32(textBox7.Text)

            };

            db.Kitaplar.Add(yeniKitap);
            db.SaveChanges();
            MessageBox.Show("Yeni Kitap Eklendi...");
        }
    }
}
