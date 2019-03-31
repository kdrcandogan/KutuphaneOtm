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
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            Data.KutuphaneOtmEntities1 db = new Data.KutuphaneOtmEntities1();

            Data.Uye yeniUye = new Data.Uye
            {
                UyeAd = textBox1.Text,
                UyeSoyad = textBox2.Text,
                UyeTelefon = Convert.ToInt32(textBox3.Text),
                UyeEposta= textBox4.Text,
                UyeAdres= richTextBox1.Text



            };

            db.Uye.Add(yeniUye);
            db.SaveChanges();
            MessageBox.Show("Uye kaydı yapıldı...");
        }
    }
}
