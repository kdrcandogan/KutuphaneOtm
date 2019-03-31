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
    public partial class EmanetVer : Form
    {
        public EmanetVer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data.KutuphaneOtmEntities1 db = new Data.KutuphaneOtmEntities1();
            //var orderData = db.Emanetler.Include("Uye").ToList();
            Data.Emanetler yeniEmanet = new Data.Emanetler
            {
                KitapID = Convert.ToInt32(textBox1.Text),
                UyeID = Convert.ToInt32(textBox2.Text),
                EmanetVerilmeTarih = Convert.ToDateTime(textBox3.Text),
                EmanetGeriAlmaTarihi= Convert.ToDateTime(textBox4.Text),
                EmanetNot= richTextBox1.Text
            };

            db.Emanetler.Add(yeniEmanet);
            db.SaveChanges();
            MessageBox.Show("Kayıt başarılı...");

            //Data.NorthWindEntities db = new Data.NorthWindEntities();
            //db.Configuration.LazyLoadingEnabled = false;


            //var orderData = db.Orders.Include("Customer").ToList();
            //foreach (var item in orderData)
            //{
            //    listBox1.Items.Add(item.Customer.ContactName);
            //    listBox1.Items.Add(item.Customer.Country);
            //}


            //Data.Uye yeniUye = new Data.Uye
            //{
            //    UyeAd = textBox1.Text,
            //    UyeSoyad = textBox2.Text,
            //    UyeTelefon = Convert.ToInt32(textBox3.Text),
            //    UyeEposta = textBox4.Text,
            //    UyeAdres = richTextBox1.Text



            //};


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
