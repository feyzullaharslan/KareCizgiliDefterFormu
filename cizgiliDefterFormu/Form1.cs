using BSEB_e_Boyahane_Uretim_Yonetimi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cizgiliDefterFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Pen kalem;
        private void yazdirBtn_Click(object sender, EventArgs e)
        {
            YazdirmaAlani pr = new YazdirmaAlani();
            pr.printPreviewControl1.Document = printDocument1;
            pr.printPreviewControl1.Zoom = 1;
            pr.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics cizer2 = e.Graphics;
            cizer2.PageUnit = GraphicsUnit.Millimeter;
            cizer2.DrawString("Tarih :", new Font("Tahoma", 10, FontStyle.Bold), Brushes.Black, 160, 14);


            if (griButton.Checked)
            {
                kalem = new Pen(Brushes.Gray, 0.0F);
            }
            else if (kirmiziButton.Checked)
            {
                kalem = new Pen(Brushes.Red, 0.0F);
            }
            else if (siyahButton.Checked)
            {
                kalem = new Pen(Brushes.Black, 0.0F);
            }
            else if (lacivertButton.Checked)
            {
                kalem = new Pen(Brushes.Navy, 0.0F);
            }
            else if (sariButton.Checked)
            {
                kalem = new Pen(Brushes.Yellow, 0.0F);
            }


            int xDikdortgenSayisi = Convert.ToInt32(xDikdörtgenSayisiTxt.Text);//59;
            float xDikdortgenYukseklik = 4.5F;
            float xDikdortgenBoyu = 193.5F;

            int yDikdortgenSayisi = Convert.ToInt32(yDikdörtgenSayisiTxt.Text);// 43;
            float yDikdortgenYukseklik = 261;
            float yDikdortgenBoyu = 4.5F;

            int xBaslangic = Convert.ToInt32(xBaslangicTxt.Text);// 5;
            float yBaslangic = Convert.ToInt32(yBaslangicTxt.Text);//20;




            for (int i = 0; i < xDikdortgenSayisi; i++)
            {
                cizer2.DrawRectangle(kalem, xBaslangic, yBaslangic, xDikdortgenBoyu, xDikdortgenYukseklik * i);
            }



            for (int y = 0; y < yDikdortgenSayisi; y++)
            {
                cizer2.DrawRectangle(kalem, xBaslangic, yBaslangic, yDikdortgenBoyu * y, yDikdortgenYukseklik);
            }
        }
    }
}
