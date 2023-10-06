using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtYönetimSistemi
{
    public partial class OgrenciListesiForm : Form
    {
        public OgrenciListesiForm()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        
        private void OgrenciListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet7.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter2.Fill(this.yurtOtomasyonuDataSet7.Ogrenci);
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet3.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter1.Fill(this.yurtOtomasyonuDataSet3.Ogrenci);
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter.Fill(this.yurtOtomasyonuDataSet.Ogrenci);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Arama İşlemleri
            if (radioAd.Checked == true)
            {
                SqlCommand komut = new SqlCommand("Select * from Ogrenci where OgrAd like '%" + txtAd.Text + "%'", bgl.baglanti());
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                bgl.baglanti().Close();
            }
            if (radioSoyad.Checked == true)
            {
                SqlCommand komut = new SqlCommand("Select * from Ogrenci where OgrSoyad like '%" + txtAd.Text + "%'", bgl.baglanti());
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                bgl.baglanti().Close();
            }
            if (radioAra.Checked == true)
            {
                SqlCommand komut = new SqlCommand("Select * from Ogrenci where OgrOdaNo like '%" + txtAd.Text + "%'", bgl.baglanti());
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                bgl.baglanti().Close();
            }

        }
        int secilen;
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            OgrenciIslemleriForm frm = new OgrenciIslemleriForm();
            frm.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            frm.ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            frm.soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            frm.Tc = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            frm.telefon = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            frm.dogumtarih = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            frm.bolum = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            frm.mail = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            frm.odano = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            frm.yillik = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            frm.veliad = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            frm.velitelefon = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            frm.veliadres = dataGridView1.Rows[secilen].Cells[12].Value.ToString();
            frm.saglik = dataGridView1.Rows[secilen].Cells[14].Value.ToString();
            frm.kangrubu = dataGridView1.Rows[secilen].Cells[15].Value.ToString();
            frm.resim= (byte[])dataGridView1.Rows[secilen].Cells[13].Value;
            frm.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void printButton_Click(object sender, EventArgs e)
        {
            
        }

      

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
