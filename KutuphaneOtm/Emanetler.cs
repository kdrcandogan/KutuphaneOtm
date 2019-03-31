using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace KutuphaneOtm
{
    public partial class Emanetler : Form
    {
        public Emanetler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_KisiAra_Click(object sender, EventArgs e)
        {
            Data.KutuphaneOtmEntities1 db = new Data.KutuphaneOtmEntities1();

            string UyeAd = txtBoxKisi.Text.ToString();
            var KitapGetir = (from em in db.Emanetler
                              join u in db.Uye on em.UyeID equals u.UyeID
                              join k in db.Kitaplar on em.KitapID equals k.KitapID
                              where u.UyeAd == UyeAd
                              select new
                              {
                                  UyeAd = u.UyeAd,
                                  UyeTel = u.UyeTelefon,
                                  KitapAd = k.KitapAd,
                                  VerilişTarih = em.EmanetVerilmeTarih,
                                  GeriAlışTarih = em.EmanetGeriAlmaTarihi
                              }).ToList();
            dataGridView1.DataSource = KitapGetir;
            DateTime dt = DateTime.Today;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (Convert.ToDateTime(item.Cells[5].Value) < dt)
                {
                    item.DefaultCellStyle.BackColor = Color.Red;
                }


            }
        }

        private void Emanetler_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn dgvBtn = new DataGridViewButtonColumn();
            dgvBtn.HeaderText = "Not";
            dgvBtn.Text = "Not Göster";
            dgvBtn.UseColumnTextForButtonValue = true;
            dgvBtn.DefaultCellStyle.SelectionBackColor = Color.Red;
            dgvBtn.Width = 70;
            dataGridView1.Columns.Add(dgvBtn);

            Data.KutuphaneOtmEntities1 db = new Data.KutuphaneOtmEntities1();

            var EmanetListe2 = (from em in db.Emanetler
                                join u in db.Uye on em.UyeID equals u.UyeID
                                join k in db.Kitaplar on em.KitapID equals k.KitapID

                                select new
                                {
                                    UyeAd = u.UyeAd,
                                    UyeTel = u.UyeTelefon,
                                    KitapAd = k.KitapAd,
                                    VerilişTarih = em.EmanetVerilmeTarih,
                                    GeriAlışTarih = em.EmanetGeriAlmaTarihi,
                                    Not=em.EmanetNot
                                }).ToList();
            dataGridView1.DataSource = EmanetListe2;

            DateTime dt = DateTime.Today;

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (Convert.ToDateTime(item.Cells[5].Value) < dt)
                {
                    item.DefaultCellStyle.BackColor = Color.Red;
                }


            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {// hangi kolona göre işlem yapacaksak onun index i ile karşılaştırıyoruz
                MessageBox.Show(dataGridView1.CurrentRow.Cells[6].Value.ToString(), "Not");
            }
        }

        private void Btn_KitapAra_Click(object sender, EventArgs e)
        {
            Data.KutuphaneOtmEntities1 db = new Data.KutuphaneOtmEntities1();

            string KitapAd = txtBoxKitap.Text.ToString();
            var KitapGetir = (from em in db.Emanetler
                              join u in db.Uye on em.UyeID equals u.UyeID
                              join k in db.Kitaplar on em.KitapID equals k.KitapID
                              where k.KitapAd == KitapAd
                              select new
                              {
                                  UyeAd = u.UyeAd,
                                  UyeTel = u.UyeTelefon,
                                  KitapAd = k.KitapAd,
                                  VerilişTarih = em.EmanetVerilmeTarih,
                                  GeriAlışTarih = em.EmanetGeriAlmaTarihi
                              }).ToList();
            dataGridView1.DataSource = KitapGetir;
            DateTime dt = DateTime.Today;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (Convert.ToDateTime(item.Cells[5].Value) < dt)
                {
                    item.DefaultCellStyle.BackColor = Color.Red;
                }


            }
        }

        private void Btn_Tel_Click(object sender, EventArgs e)
        {
            Data.KutuphaneOtmEntities1 db = new Data.KutuphaneOtmEntities1();

            int uyeTel = Convert.ToInt32(txtBoxTel.Text);
            var KitapGetir = (from em in db.Emanetler
                              join u in db.Uye on em.UyeID equals u.UyeID
                              join k in db.Kitaplar on em.KitapID equals k.KitapID
                              where u.UyeTelefon == uyeTel
                              select new
                              {
                                  UyeAd = u.UyeAd,
                                  UyeTel = u.UyeTelefon,
                                  KitapAd = k.KitapAd,
                                  VerilişTarih = em.EmanetVerilmeTarih,
                                  GeriAlışTarih = em.EmanetGeriAlmaTarihi
                              }).ToList();
            dataGridView1.DataSource = KitapGetir;
            DateTime dt = DateTime.Today;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (Convert.ToDateTime(item.Cells[5].Value) < dt)
                {
                    item.DefaultCellStyle.BackColor = Color.Red;
                }


            }
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            string UyeAd = txtBoxKisi.Text.ToString();
            string KitapAd = txtBoxKitap.Text.ToString();
            //int uyeTel = Convert.ToInt32(txtBoxTel.Text);
            //u.UyeTelefon == uyeTel ||

            Data.KutuphaneOtmEntities1 db = new Data.KutuphaneOtmEntities1();

            var willDelete = (from em in db.Emanetler
                              join u in db.Uye on em.UyeID equals u.UyeID
                              join k in db.Kitaplar on em.KitapID equals k.KitapID
                              where ( k.KitapAd == KitapAd || u.UyeAd == UyeAd)
                              select em).FirstOrDefault();
            //                  select new
            //                  {
            //                      VerilişTarih = em.EmanetVerilmeTarih,
            //                      GeriAlışTarih = em.EmanetGeriAlmaTarihi
            //                  }).FirstOrDefault();

            //var willDelete = db.Kitaplar.Where(t => t.KitapAd == KitapAd || t.KitapYazar == YazarAd).FirstOrDefault();

            db.Emanetler.Remove(willDelete);
            db.SaveChanges();
            MessageBox.Show("Kayıt başarıyla silindi...");
        }

        private void Btn_Güncelle_Click(object sender, EventArgs e)
        {
            Emanetler_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;

            for (int x = 0; x < dataGridView1.SelectedRows.Count; x++)
            {
                for (int j = 0; j < dataGridView1.SelectedRows[x].Cells.Count; j++)
                {

                    Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dataGridView1.SelectedRows[x].Cells[j].Value == null ? "" : dataGridView1.SelectedRows[x].Cells[j].Value;
                }
                StartRow++;
            }
        }
    }
}
