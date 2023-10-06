using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtYönetimSistemi
{
    public partial class YazdirForm : Form
    {
        public YazdirForm()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        public string ad, odano, izinbaslangic, izinbitis, izinsebebi;

        private void deneme_Load(object sender, EventArgs e)
        {
            lblAdSoyad.Text = ad;
            lblOdaNo.Text = odano;
            lblIzinSebep.Text = izinsebebi;
            lblIzinBaslangic.Text = izinbaslangic;
            lblIzinBitis.Text = izinbitis;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Font font = new Font("Arial", 10);
                SolidBrush firca = new SolidBrush(Color.Black);
                e.Graphics.DrawString($"Tarih= {DateTime.Now.ToString("dd.MM.yyyy  HH:mm:ss")}", font, firca, 600, 25);

               font= new Font("Arial", 14);
                e.Graphics.DrawString("FIRAT ÖĞRENCİ YURDU İZİN TALEBİ", font, firca, 230, 160);
                e.Graphics.DrawString("----------------------------------------------------", font, firca, 230, 170);

              font = new Font("Arial", 12);
                e.Graphics.DrawString("Yurdunuz " + lblOdaNo.Text+ " numaralı odada kalmaktayım. "+lblIzinSebep.Text+ "    sebeplerinden dolayı  ( Sağlık problemleri",font,firca,50,200);
              font = new Font("Arial", 12);
                e.Graphics.DrawString("aile yanında kalma vs.gibi...)   "+ lblIzinBaslangic.Text+" - "+lblIzinBitis.Text+ "   tarihleri arasında  izin verilmesini, ", font,firca,50,230);
             font = new Font("Arial", 12);
                e.Graphics.DrawString("Saygılarımla arz ederim.", font, firca, 50, 260);
             font = new Font("Arial", 13);
                e.Graphics.DrawString(lblAdSoyad.Text, font, firca, 600, 450);
             font = new Font("Arial", 13);
                e.Graphics.DrawString("İmza", font, firca, 600, 490);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
