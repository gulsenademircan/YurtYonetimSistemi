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
using System.Reflection.Emit;

namespace YurtYönetimSistemi
{
    public partial class KayipEsyaForm : Form
    {
        public KayipEsyaForm()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
      
            
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                try
                {
                    SqlCommand komutkaydet = new SqlCommand("insert into Esya (Esya,EsyaYer,EsyaTarih,Detay,EsyaSahip,EsyaNumara,Durum) values (@a1,@a2,@a3,@a4,@a5,@a6,@a7)", bgl.baglanti());
                    textBox1.Text = "kayip";
                    komutkaydet.Parameters.AddWithValue("@a1", txtEsya.Text);
                    komutkaydet.Parameters.AddWithValue("@a2", txtYer.Text);
                    komutkaydet.Parameters.AddWithValue("@a3", txtTarih.Text);
                    komutkaydet.Parameters.AddWithValue("@a4", rchDetay.Text);
                    komutkaydet.Parameters.AddWithValue("@a5", txtKisi.Text);
                    komutkaydet.Parameters.AddWithValue("@a6", MskTelefon.Text);
                    komutkaydet.Parameters.AddWithValue("@a7", textBox1.Text);
                    komutkaydet.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Eşya Kayıt İşlemi Başarılı...");
                   
                 
                }
                catch (Exception)
                {
                    MessageBox.Show("Eşya Kayıt İşlemi Başarısız. Lütfen Yeniden Deneyin...");
                }
            }

            else if (tabControl1.SelectedIndex == 1)
            {
                try
                {
                    SqlCommand komutkaydet = new SqlCommand("insert into Esya (Esya,EsyaYer,EsyaTarih,Detay,EsyaSahip,EsyaNumara,Durum) values (@a1,@a2,@a3,@a4,@a5,@a6,@a7)", bgl.baglanti());
                    textBox1.Text = "bulunan";
                    komutkaydet.Parameters.AddWithValue("@a1", txtEsya1.Text);
                    komutkaydet.Parameters.AddWithValue("@a2", txtYer1.Text);
                    komutkaydet.Parameters.AddWithValue("@a3", txtTarih1.Text);
                    komutkaydet.Parameters.AddWithValue("@a4", rchDetay1.Text);
                    komutkaydet.Parameters.AddWithValue("@a5", txtKisi1.Text);
                    komutkaydet.Parameters.AddWithValue("@a6", mskTelefon1.Text);
                    komutkaydet.Parameters.AddWithValue("@a7", textBox1.Text);
                    komutkaydet.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Eşya Kayıt İşlemi Başarılı...");
                   

                }
                catch (Exception)
                {
                    MessageBox.Show("Eşya Kayıt İşlemi Başarısız. Lütfen Yeniden Deneyin...");
                }
            }


        }
        
        private void label13_Click(object sender, EventArgs e)
        {

        }
          
        private void KayipEsyaForm_Load(object sender, EventArgs e)
        {
      

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
