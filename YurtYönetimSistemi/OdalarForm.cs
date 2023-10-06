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
using System.Security.Cryptography;

namespace YurtYönetimSistemi
{
    public partial class OdalarForm : Form
    {
        public OdalarForm()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void SorguYap(string odaNo)
        {
            SqlCommand komutarama = new SqlCommand("SELECT OgrAd, OgrSoyad FROM Ogrenci WHERE OgrOdaNo = @OdaNo", bgl.baglanti());
            komutarama.Parameters.AddWithValue("@OdaNo", odaNo);
            SqlDataAdapter da = new SqlDataAdapter(komutarama);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                string isimler = "";

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string ogrAd = row["OgrAd"].ToString();
                    string ogrSoyad = row["OgrSoyad"].ToString();

                    isimler += ogrAd + " " + ogrSoyad + "\n";
                }

                label1.Text = isimler;
            }
            else
            {
                label1.Text = "Oda Boş !";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SorguYap("101");
            string aktarilacakDeger = label1.Text;
            OdaKalan frm2=new OdaKalan();
            frm2.AktarilanDeger = aktarilacakDeger;
            frm2.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn102_Click(object sender, EventArgs e)
        {
            SorguYap("102");
            string aktarilacakDeger = label1.Text;
            OdaKalan frm2 = new OdaKalan();
            frm2.AktarilanDeger = aktarilacakDeger;
            frm2.Show();
        }

        private void btn103_Click(object sender, EventArgs e)
        {
            SorguYap("103");
            string aktarilacakDeger = label1.Text;
            OdaKalan frm2 = new OdaKalan();
            frm2.AktarilanDeger = aktarilacakDeger;
            frm2.Show();
        }

        private void btn104_Click(object sender, EventArgs e)
        {
            SorguYap("104");
            string aktarilacakDeger = label1.Text;
            OdaKalan frm2 = new OdaKalan();
            frm2.AktarilanDeger = aktarilacakDeger;
            frm2.Show();
        }

        private void btn105_Click(object sender, EventArgs e)
        {
            SorguYap("105");
            string aktarilacakDeger = label1.Text;
            OdaKalan frm2 = new OdaKalan();
            frm2.AktarilanDeger = aktarilacakDeger;
            frm2.Show();
        }

        private void btn201_Click(object sender, EventArgs e)
        {
            SorguYap("201");
            string aktarilacakDeger = label1.Text;
            OdaKalan frm2 = new OdaKalan();
            frm2.AktarilanDeger = aktarilacakDeger;
            frm2.Show();
        }

        private void btn202_Click(object sender, EventArgs e)
        {
            SorguYap("202");
            string aktarilacakDeger = label1.Text;
            OdaKalan frm2 = new OdaKalan();
            frm2.AktarilanDeger = aktarilacakDeger;
            frm2.Show();
        }

        private void btn203_Click(object sender, EventArgs e)
        {
            SorguYap("203");
            string aktarilacakDeger = label1.Text;
            OdaKalan frm2 = new OdaKalan();
            frm2.AktarilanDeger = aktarilacakDeger;
            frm2.Show();
        }

        private void btn204_Click(object sender, EventArgs e)
        {
            SorguYap("204");
            string aktarilacakDeger = label1.Text;
            OdaKalan frm2 = new OdaKalan();
            frm2.AktarilanDeger = aktarilacakDeger;
            frm2.Show();
        }

        private void btn205_Click(object sender, EventArgs e)
        {
            SorguYap("205");
            string aktarilacakDeger = label1.Text;
            OdaKalan frm2 = new OdaKalan();
            frm2.AktarilanDeger = aktarilacakDeger;
            frm2.Show();
        }

        private void btn301_Click(object sender, EventArgs e)
        {
            SorguYap("301");
            string aktarilacakDeger = label1.Text;
            OdaKalan frm2 = new OdaKalan();
            frm2.AktarilanDeger = aktarilacakDeger;
            frm2.Show();
        }

        private void btn302_Click(object sender, EventArgs e)
        {
            SorguYap("302");
            string aktarilacakDeger = label1.Text;
            OdaKalan frm2 = new OdaKalan();
            frm2.AktarilanDeger = aktarilacakDeger;
            frm2.Show();
        }

        private void btn303_Click(object sender, EventArgs e)
        {
            SorguYap("303");
            string aktarilacakDeger = label1.Text;
            OdaKalan frm2 = new OdaKalan();
            frm2.AktarilanDeger = aktarilacakDeger;
            frm2.Show();
        }

        private void btn304_Click(object sender, EventArgs e)
        {
            SorguYap("304");
            string aktarilacakDeger = label1.Text;
            OdaKalan frm2 = new OdaKalan();
            frm2.AktarilanDeger = aktarilacakDeger;
            frm2.Show();
        }

        private void btn305_Click(object sender, EventArgs e)
        {
            SorguYap("305");
            string aktarilacakDeger = label1.Text;
            OdaKalan frm2 = new OdaKalan();
            frm2.AktarilanDeger = aktarilacakDeger;
            frm2.Show();
        }

        private void btn401_Click(object sender, EventArgs e)
        {
            SorguYap("401");
            string aktarilacakDeger = label1.Text;
            OdaKalan frm2 = new OdaKalan();
            frm2.AktarilanDeger = aktarilacakDeger;
            frm2.Show();
        }

        private void btn402_Click(object sender, EventArgs e)
        {
            SorguYap("402");
            string aktarilacakDeger = label1.Text;
            OdaKalan frm2 = new OdaKalan();
            frm2.AktarilanDeger = aktarilacakDeger;
            frm2.Show();
        }

        private void btn403_Click(object sender, EventArgs e)
        {
            SorguYap("403");
            string aktarilacakDeger = label1.Text;
            OdaKalan frm2 = new OdaKalan();
            frm2.AktarilanDeger = aktarilacakDeger;
            frm2.Show();
        }

        private void btn404_Click(object sender, EventArgs e)
        {
            SorguYap("404");
            string aktarilacakDeger = label1.Text;
            OdaKalan frm2 = new OdaKalan();
            frm2.AktarilanDeger = aktarilacakDeger;
            frm2.Show();
        }

        private void btn405_Click(object sender, EventArgs e)
        {
            SorguYap("405");
            string aktarilacakDeger = label1.Text;
            OdaKalan frm2 = new OdaKalan();
            frm2.AktarilanDeger = aktarilacakDeger;
            frm2.Show();
        }

        private void OdalarForm_Load(object sender, EventArgs e)
        {

        }
    }
}
