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
    public partial class FormYöneticiAyarları : Form
    {
        public FormYöneticiAyarları()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();

        private void FormYöneticiAyarları_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet4.Admin' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet4.Admin);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Yönetici Güncelleme 
            SqlCommand komutgüncelle = new SqlCommand("update Admin set YoneticiAd=@p1, YoneticiSifre=@p2 where Yoneticiid=@p3", bgl.baglanti());
            komutgüncelle.Parameters.AddWithValue("@p1", textKullaniciAd.Text);
            komutgüncelle.Parameters.AddWithValue("@p2", textParola.Text);
            komutgüncelle.Parameters.AddWithValue("@p3", textid.Text);
            komutgüncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yönetici Güncellendi...");
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet4.Admin);
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            //Yönetici Ekleme
            SqlCommand komut = new SqlCommand("insert into Admin (YoneticiAd,YoneticiSifre) values (@p1,@p2)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", textParola.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yönetici Eklendi...");
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet4.Admin);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string ad, parola, id;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            parola = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textKullaniciAd.Text = ad;
            textParola.Text= parola;
            textid.Text = id;
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            // Yönetici Silme
            SqlCommand komutsil = new SqlCommand("delete from Admin where Yoneticiid=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", textid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yönetici Silindi......");
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet4.Admin);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textid.Clear();
            textKullaniciAd.Clear();
            textParola.Clear();
        }
    }
}
