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
    public partial class UyeListele : Form
    {
        public UyeListele()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UyeListele_Load(object sender, EventArgs e)
        {
            Data.KutuphaneOtmEntities1 db = new Data.KutuphaneOtmEntities1();
            //var Uyeler = db.Uye.ToList();
            var Uyeler = (from u in db.Uye
                          select new
                          {
                              u.UyeAd,
                              u.UyeSoyad,
                              u.UyeTelefon,
                              u.UyeEposta,
                              u.UyeAdres

                          }

           ).ToList();
            dataGridView1.DataSource = Uyeler;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data.KutuphaneOtmEntities1 db = new Data.KutuphaneOtmEntities1();
            string UyeAd = txtBoxUyeAd.Text.ToString();
            var UyeGetir = (from u in db.Uye
                              where u.UyeAd == UyeAd
                              select new
                              {
                                  u.UyeAd,
                                  u.UyeSoyad,
                                  u.UyeTelefon,
                                  u.UyeEposta,
                                  u.UyeAdres

                              }).ToList();
            dataGridView1.DataSource = UyeGetir;
        }

        private void button3_Click(object sender, EventArgs e)
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
