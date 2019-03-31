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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Kayit_Click(object sender, EventArgs e)
        {
            Kayit kayit = new Kayit();
            kayit.ShowDialog();
        }

        private void Btn_KitapListele_Click(object sender, EventArgs e)
        {
            KitapListele kitapListele = new KitapListele();
            kitapListele.ShowDialog();
        }

        private void Btn_EmanetSorgu_Click(object sender, EventArgs e)
        {
            Emanetler emanetler = new Emanetler();
            emanetler.ShowDialog();
        }

        private void Btn_KitapEkle_Click(object sender, EventArgs e)
        {
            KitapEkle kitapEkle = new KitapEkle();
            kitapEkle.ShowDialog();
        }

        private void Btn_Iletisim_Click(object sender, EventArgs e)
        {
            Iletisim iletisim = new Iletisim();
            iletisim.ShowDialog();
        }

        private void Btn_EmanetVer_Click(object sender, EventArgs e)
        {
            EmanetVer emanetVer = new EmanetVer();
            emanetVer.ShowDialog();
        }

        private void Btn_Uyeler_Click(object sender, EventArgs e)
        {
            UyeListele uyeListele = new UyeListele();
            uyeListele.ShowDialog();
        }
    }
}
