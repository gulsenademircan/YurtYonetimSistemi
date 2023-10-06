using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtYönetimSistemi
{
    public partial class EsyaIslemleriForm : Form
    {
        public EsyaIslemleriForm()
        {
            InitializeComponent();
        }
        public string esya, yer, tarih, detay, isim, telefon, durum;

        private void btnBul_Click(object sender, EventArgs e)
        {
            EsyaListeForm frm = new EsyaListeForm();
            frm.ShowDialog();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                try
                {
                    SqlCommand komut = new SqlCommand("update Esya set Esya=@p1,EsyaYer=@p2,EsyaTarih=@p3,Detay=@p4,EsyaNumara=@p5,Durum=@p6 where EsyaSahip=@p7", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", txtEsya.Text);
                    komut.Parameters.AddWithValue("@p2", txtYer.Text);
                    komut.Parameters.AddWithValue("@p3", txtTarih.Text);
                    komut.Parameters.AddWithValue("@p4", rchDetay.Text);
                    komut.Parameters.AddWithValue("@p5", MskTelefon.Text);
                    komut.Parameters.AddWithValue("@p6", txtDurum.Text);
                    komut.Parameters.AddWithValue("@p7", txtKisi.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Eşya Güncelleme İşlemi Başarılı...");
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                SqlCommand komut = new SqlCommand("update Esya set Esya=@p1,EsyaYer=@p2,EsyaTarih=@p3,Detay=@p4,EsyaNumara=@p5,Durum=@p6 where EsyaSahip=@p7", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtEsya1.Text);
                komut.Parameters.AddWithValue("@p2", txtYer1.Text);
                komut.Parameters.AddWithValue("@p3", txtTarih1.Text);
                komut.Parameters.AddWithValue("@p4", rchDetay1.Text);
                komut.Parameters.AddWithValue("@p5", mskTelefon1.Text);
                komut.Parameters.AddWithValue("@p6", txtdurum1.Text);
                komut.Parameters.AddWithValue("@p7", txtKisi1.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Eşya Güncelleme İşlemi Başarılı...");
            }
          
            
        }

        private void EsyaIslemleriForm_Load(object sender, EventArgs e)
        {
            if (durum=="kayip")
            {
                txtEsya.Text = esya;
                txtYer.Text = yer;
                txtTarih.Text = tarih;  
                rchDetay.Text = detay;
                txtKisi.Text = isim;
                MskTelefon.Text = telefon;  
                txtDurum.Text = durum;  
            }
            else if (durum == "bulunan")
            {
                txtEsya1.Text = esya;
                txtYer1.Text = yer;
                txtTarih1.Text = tarih;
                rchDetay1.Text = detay;
                txtKisi1.Text = isim;
                mskTelefon1.Text = telefon;
                txtdurum1.Text = durum;
            }
        }
    }
}
