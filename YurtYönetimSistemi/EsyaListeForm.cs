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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YurtYönetimSistemi
{
    public partial class EsyaListeForm : Form
    {
        public EsyaListeForm()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();



        private void EsyaListeForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet12.Esya' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.esyaTableAdapter1.Fill(this.yurtOtomasyonuDataSet12.Esya);
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet11.Esya' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void esyaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            EsyaIslemleriForm frm = new EsyaIslemleriForm();
            frm.esya= dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            frm.yer= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            frm.tarih = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            frm.detay = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            frm.isim= dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            frm.telefon = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            frm.durum = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("Select * from Esya where Esya like '%" + textBox1.Text + "%'", bgl.baglanti());
            SqlDataAdapter da1 = new SqlDataAdapter(komut3);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            dataGridView1.DataSource = ds1.Tables[0];
            bgl.baglanti().Close();
            if (rdBulunan.Checked == true)
            {
                SqlCommand komut = new SqlCommand("Select * from Esya where Durum like'%" + "bulunan" + "%'", bgl.baglanti());
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                bgl.baglanti().Close();
            }
            if (rdKayip.Checked == true)
            {
                SqlCommand komut = new SqlCommand("Select * from Esya where Durum like'%" + "kayip" + "%'", bgl.baglanti());
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                bgl.baglanti().Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rdBulunan_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
