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
using static System.Net.Mime.MediaTypeNames;

namespace YurtYönetimSistemi
{
    public partial class HarcamaForm : Form
    {
        public HarcamaForm()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void HarcamaForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet21.Harcamalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.harcamalarTableAdapter2.Fill(this.yurtOtomasyonuDataSet21.Harcamalar);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutekle = new SqlCommand("insert into Harcamalar (HarcamaTarih,HarcamaKisi,HarcamaTutar,HarcamaDetay) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komutekle.Parameters.AddWithValue("@p1", mskTarih.Text);
            komutekle.Parameters.AddWithValue("@p2", txtKisi.Text);
            komutekle.Parameters.AddWithValue("@p3", txtTutar.Text);
            komutekle.Parameters.AddWithValue("@p4", txtAciklama.Text);
            komutekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Eklendi...");
            this.harcamalarTableAdapter2.Fill(this.yurtOtomasyonuDataSet21.Harcamalar);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("delete from Harcamalar where HarcamaId=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", label5.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Harcama Silindi...");
            this.harcamalarTableAdapter2.Fill(this.yurtOtomasyonuDataSet21.Harcamalar);
        }

     

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string tarih, kisi, tutar, detay, id;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            tarih = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            tutar = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            kisi = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            detay = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            id = dataGridView1.Rows[secilen].Cells[4].Value.ToString(); 
            mskTarih.Text = tarih;
            txtTutar.Text = tutar;
            txtKisi.Text = kisi;
            txtAciklama.Text = detay;
            label5.Text = id;
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutgüncelle = new SqlCommand("update Harcamalar set HarcamaTarih=@a1, HarcamaKisi=@a2,HarcamaTutar=@a3,HarcamaDetay=@a4  where HarcamaId=@a5", bgl.baglanti());
            komutgüncelle.Parameters.AddWithValue("@a1", mskTarih.Text);
            komutgüncelle.Parameters.AddWithValue("@a2", txtKisi.Text);
            komutgüncelle.Parameters.AddWithValue("@a3", txtTutar.Text);
            komutgüncelle.Parameters.AddWithValue("@a4", txtAciklama.Text);
            komutgüncelle.Parameters.AddWithValue("@a5", label5.Text);
            komutgüncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Harcama Güncellendi...");
            this.harcamalarTableAdapter2.Fill(this.yurtOtomasyonuDataSet21.Harcamalar);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            mskTarih.Clear();
            txtKisi.Clear();
            txtTutar.Clear();
            txtAciklama.Clear();
            
        }
    }
}
