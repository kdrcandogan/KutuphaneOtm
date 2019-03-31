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
    public partial class Iletisim : Form
    {
        public Iletisim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("iletisim@info.com");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("212-755-55-55");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("iletisim@info.com");
        }
    }
}
