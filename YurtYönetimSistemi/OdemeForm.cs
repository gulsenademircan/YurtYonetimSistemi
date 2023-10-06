using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtYönetimSistemi
{
    public partial class OdemeForm : Form
    {
        public OdemeForm()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void OdemeForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet17.Borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter3.Fill(this.yurtOtomasyonuDataSet17.Borclar);
           
     

        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            SqlCommand komutarama = new SqlCommand("Select * from Borclar where OgrAd like '%" + txtAd.Text + "%'", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komutarama);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            bgl.baglanti().Close();
            SqlCommand komutarama2 = new SqlCommand("Select * from Borclar where OgrSoyad like '%" + txtSoyad.Text + "%'", bgl.baglanti());
            SqlDataAdapter da1 = new SqlDataAdapter(komutarama2);
            DataSet ds1 = new DataSet();
            da.Fill(ds1);
            dataGridView1.DataSource = ds1.Tables[0];
            bgl.baglanti().Close();
            
        }


        private void btnOdeme_Click(object sender, EventArgs e)
        {
            //Borç Yazdırma
            int odenen, kalan, yeniborc;
            odenen = Convert.ToInt32(txtOdeme.Text);
            kalan = Convert.ToInt32(txtKalan.Text);
            yeniborc = kalan - odenen;
            txtKalan.Text = yeniborc.ToString();
            SqlCommand komut1 = new SqlCommand("update Borclar set OgrKalanBorc=@p1  where BorcId=@p2", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p2", txtId.Text);
            komut1.Parameters.AddWithValue("@p1", txtKalan.Text);
            komut1.ExecuteNonQuery();
            //Odeme Formuna Ekleme
            SqlCommand komutekle = new SqlCommand("insert into Odeme(OgrAd,OgrSoyad,BorcId,OdemeTarihi,OdenenTutar) values (@a1,@a2,@a3,@a4,@a5)", bgl.baglanti());
            komutekle.Parameters.AddWithValue("@a1", txtAd.Text);
            komutekle.Parameters.AddWithValue("@a2", txtSoyad.Text);
            komutekle.Parameters.AddWithValue("@a3", txtId.Text);
            komutekle.Parameters.AddWithValue("@a4", mskTarih.Text);
            komutekle.Parameters.AddWithValue("@a5", txtOdeme.Text);
            komutekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Borç Ödendi");
            this.borclarTableAdapter3.Fill(this.yurtOtomasyonuDataSet17.Borclar);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            string ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            string soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            string kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtAd.Text = ad;
            txtSoyad.Text = soyad;
            txtKalan.Text = kalan;
            txtId.Text = id;
        }
    }
}
