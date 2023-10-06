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
    public partial class FormIzin : Form
    {
        public FormIzin()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void FormIzin_Load(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Select OdaNo From Odalar ", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                CmbOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Izin(OgrenciAdi,OdaNo,OgrenciTelefon,IzinBaslangic,IzınBitis,IzinSebebi,KisiAdi,YakinlikDerecesi,KisiTelefon,KisiAdres) values (@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@a1", TxtOgrAd.Text);
            komutkaydet.Parameters.AddWithValue("@a2", CmbOdaNo.Text);
            komutkaydet.Parameters.AddWithValue("@a3", MskOgrTelefon.Text);
            komutkaydet.Parameters.AddWithValue("@a4", MskIzinBaslangic.Text);
            komutkaydet.Parameters.AddWithValue("@a5", MskIzinBitis.Text);
            komutkaydet.Parameters.AddWithValue("@a6", TxtIzinSebebi.Text);
            komutkaydet.Parameters.AddWithValue("@a7", TxtIzinAd.Text);
            komutkaydet.Parameters.AddWithValue("@a8", TxtYakinlik.Text);
            komutkaydet.Parameters.AddWithValue("@a9", MskIzinTelefon.Text);
            komutkaydet.Parameters.AddWithValue("@a10", RchIzinAdres.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("İzin Kayıt İşlemi Başarılı...");

            //
            TxtOgrAd.Clear();
            MskOgrTelefon.Text = "";
            MskIzinBaslangic.Text = "";
            MskIzinBitis.Text = "";
            TxtIzinSebebi.Text= "";
            TxtIzinAd.Text = "";
            MskIzinTelefon.Text = "";
            TxtYakinlik.Text = "";
            RchIzinAdres.Text = "";


        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            IzinBulForm frm = new IzinBulForm();    
            frm.ShowDialog();
        }
    }
}
