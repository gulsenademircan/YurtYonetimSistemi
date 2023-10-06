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
    public partial class IzinBulForm : Form
    {
        public IzinBulForm()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void IzinBulForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet10.Izin' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.izinTableAdapter.Fill(this.yurtOtomasyonuDataSet10.Izin);

        }

        private void radioAd_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (radioAd.Checked == true)
            {
                SqlCommand komut = new SqlCommand("Select * from Izin where OgrenciAdi like '%" + txtAd.Text + "%'", bgl.baglanti());
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                bgl.baglanti().Close();
            }
            if (radioAra.Checked == true)
            {
                SqlCommand komut = new SqlCommand("Select * from Izin where OdaNo like '%" + txtAd.Text + "%'", bgl.baglanti());
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                bgl.baglanti().Close();
            }
        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
             YazdirForm frm = new YazdirForm();
            frm.ad = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            frm.odano = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            frm.izinbaslangic = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            frm.izinbitis = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            frm.izinsebebi = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            frm.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
