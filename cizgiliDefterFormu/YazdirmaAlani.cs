using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSEB_e_Boyahane_Uretim_Yonetimi
{
    public partial class YazdirmaAlani : Form
    {
        public YazdirmaAlani()
        {
            InitializeComponent();
        }
        int z = 10;
        int sayfa = 0;
        private void YazdırBTN_Click(object sender, EventArgs e)
        {
            printPreviewControl1.Document.Print();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printPreviewControl1.Document;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDialog1.Document.Print();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            z = z + 1;
            if (z > 7)
            {
                z = 7;
            }

            this.printPreviewControl1.Zoom = z * 0.2;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            z = z - 1;
            if (z < 1)
            {
                z = 1;
            }
            this.printPreviewControl1.Zoom = z * 0.2;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            sayfa--;
            if (sayfa < 0)
            {
                sayfa = 0;
            }

            textBox1.Text = Convert.ToString(sayfa + 1);
            this.printPreviewControl1.StartPage = sayfa;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            sayfa++;

            textBox1.Text = Convert.ToString(sayfa + 1);
            this.printPreviewControl1.StartPage = sayfa;
        }
    }
}
