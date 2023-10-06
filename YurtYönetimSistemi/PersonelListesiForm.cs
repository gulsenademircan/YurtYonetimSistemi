using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtYönetimSistemi
{
    public partial class PersonelListesiForm : Form
    {
        public PersonelListesiForm()
        {
            InitializeComponent();
        }

        private void PersonelListesiForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet9.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter1.Fill(this.yurtOtomasyonuDataSet9.Personel);
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet8.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet8.Personel);

        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            secilen = dataGridView1.SelectedCells[0].RowIndex;
            PersonelIslemleriForm frm = new PersonelIslemleriForm();
            frm.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            frm.adsoyad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            frm.departman = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            frm.tarih = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            frm.telefon = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            frm.adres = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            frm.photo = (byte[])dataGridView1.Rows[secilen].Cells[6].Value;
            frm.Show();
        }
    }
}
