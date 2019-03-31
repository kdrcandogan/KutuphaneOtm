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
    public partial class KitapListele : Form
    {
        public KitapListele()
        {
            InitializeComponent();
        }




        private void KitapListele_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn dgvBtn = new DataGridViewButtonColumn();
            dgvBtn.HeaderText = "Detay";
            dgvBtn.Text = "Detay Getir";
            dgvBtn.UseColumnTextForButtonValue = true;
            dgvBtn.DefaultCellStyle.SelectionBackColor = Color.Red;
            dgvBtn.Width = 70;
            dataGridView1.Columns.Add(dgvBtn);

            Data.KutuphaneOtmEntities1 db = new Data.KutuphaneOtmEntities1();
            //var KitapListe = db.Kitaplar.ToList();
            var KitapListe = (from k in db.Kitaplar

                              select new
                              {
                                  KitapAd = k.KitapAd,
                                  KitapTur = k.KitapTur,
                                  KitapYazar = k.KitapYazar,
                                  KitapYayınEvi = k.KitapYayinEvi,
                                  KitapSayfa = k.KitapSayfaSayısı,
                                  KitapDil = k.KitapDil,
                                  KitapACiklama = k.KitapAciklama

                              }

                       ).ToList();
            dataGridView1.DataSource = KitapListe;



            


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {// hangi kolona göre işlem yapacaksak onun index i ile karşılaştırıyoruz
                MessageBox.Show(dataGridView1.CurrentRow.Cells[8].Value.ToString(), "Özet");
            }
        }

        private void Btn_Ara_Click(object sender, EventArgs e)
        {
            Data.KutuphaneOtmEntities1 db = new Data.KutuphaneOtmEntities1();
            string KitapAd = txtBoxKitapAd.Text.ToString();
            var KitapGetir = (from k in db.Kitaplar
                              where k.KitapAd == KitapAd
                              select new
                              {
                                  KitapAd = k.KitapAd,
                                  KitapTur = k.KitapTur,
                                  KitapYazar = k.KitapYazar,
                                  KitapYayınEvi = k.KitapYayinEvi,
                                  KitapSayfa = k.KitapSayfaSayısı,
                                  KitapDil = k.KitapDil,
                                  KitapACiklama = k.KitapAciklama

                              }).ToList();
            dataGridView1.DataSource = KitapGetir;
        }

        private void Btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Ara2_Click(object sender, EventArgs e)
        {
            Data.KutuphaneOtmEntities1 db = new Data.KutuphaneOtmEntities1();
            string YazarAd = txtBoxYazarAd.Text.ToString();
            var KitapGetir = (from k in db.Kitaplar
                              where k.KitapYazar == YazarAd
                              select new
                              {
                                  KitapAd = k.KitapAd,
                                  KitapTur = k.KitapTur,
                                  KitapYazar = k.KitapYazar,
                                  KitapYayınEvi = k.KitapYayinEvi,
                                  KitapSayfa = k.KitapSayfaSayısı,
                                  KitapDil = k.KitapDil,
                                  KitapACiklama = k.KitapAciklama

                              }).ToList();
            dataGridView1.DataSource = KitapGetir;
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            string KitapAd = txtBoxKitapAd.Text.ToString();
            string YazarAd = txtBoxYazarAd.Text.ToString();
            Data.KutuphaneOtmEntities1 db = new Data.KutuphaneOtmEntities1();


            var willDelete = db.Kitaplar.Where(t => t.KitapAd == KitapAd||t.KitapYazar== YazarAd).FirstOrDefault();

            db.Kitaplar.Remove(willDelete);
            db.SaveChanges();
        }

        private void Btn_Güncelle_Click(object sender, EventArgs e)
        {
            KitapListele_Load(sender, e);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dataGridView1.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {

                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                    myRange.Select();


                }
            }
        }
    }
    }
