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
using System.IO;

namespace YurtYönetimSistemi
{
    public partial class OgrenciKayitForm : Form
    {
        string dosyayolu;
        public OgrenciKayitForm()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonResimsec_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Jpeg Dosyası (*.jpg)|*.jpg|Gif Dosyası (*.gif)|*.gif|Png Dosyası (*.png)|*.png|Tif Dosyası (*.tif)|*.tif";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                dosyayolu = openFileDialog1.FileName.ToString();
            }
        }

        private void Deneme2_Load(object sender, EventArgs e)
        {
            //Bölümler
            SqlCommand komut = new SqlCommand("Select BolumAd From Bolumler", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                CmbBolum.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();
           
            //Boş Oda
            SqlCommand komut2 = new SqlCommand("Select OdaNo From Odalar where OdaKapasite != OdaAktifKalan", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                CmbOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();
        }
   
        private void button2_Click(object sender, EventArgs e)
        {
            //RESİM
            FileStream fs = new FileStream(dosyayolu, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] seciliresim = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();

            //Öğrenci ekleme
            try
            {
                SqlCommand komutkaydet = new SqlCommand("insert into Ogrenci (OgrAd,OgrSoyad,OgrTC,OgrTelefon,OgrDogum,OgrBolum,OgrMail,OgrOdaNo,OgrYillik,OgrVeliAdSoyad,OgrVeliTelefon,OgrVeliAdres,OgrSaglik,OgrKanGrubu,OgrResim) values (@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10,@a11,@a12,@a13,@a14,@a15)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@a1", TxtOgrAd.Text);
                komutkaydet.Parameters.AddWithValue("@a2", TxtOgrSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@a3", MskTC.Text);
                komutkaydet.Parameters.AddWithValue("@a4", MskOgrTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@a5", MskDogum.Text);
                komutkaydet.Parameters.AddWithValue("@a6", CmbBolum.Text);
                komutkaydet.Parameters.AddWithValue("@a7", TxtMail.Text);
                komutkaydet.Parameters.AddWithValue("@a8", CmbOdaNo.Text);
                komutkaydet.Parameters.AddWithValue("@a9", TxtYillik.Text);
                komutkaydet.Parameters.AddWithValue("@a10", TxtVeliAdSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@a11", MskVeliTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@a12", RchAdres.Text);
                komutkaydet.Parameters.AddWithValue("@a13", rchSaglik.Text);
                komutkaydet.Parameters.AddWithValue("@a14", textKanGrup.Text);
                komutkaydet.Parameters.Add("@a15", SqlDbType.Image, seciliresim.Length).Value =seciliresim;
                komutkaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Öğrenci Kayıt İşlemi Başarılı...");
               
            }
            catch (Exception)
            {
                MessageBox.Show("Öğrenci Kayıt İşlemi Başarısız. Lütfen Yeniden Deneyin...");
            }

            // Borçlar tablosuna öğrenci ekleme
            SqlCommand komutborclar = new SqlCommand("insert into Borclar (OgrAd,OgrSoyad,OgrKalanBorc) values (@b1,@b2,@b3)", bgl.baglanti());
            komutborclar.Parameters.AddWithValue("@b1", TxtOgrAd.Text);
            komutborclar.Parameters.AddWithValue("@b2", TxtOgrSoyad.Text);
            komutborclar.Parameters.AddWithValue("@b3", TxtYillik.Text);
            komutborclar.ExecuteNonQuery();
            bgl.baglanti().Close();

            // Odanın aktif öğrenci sayısını arttırma
            SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktifKalan = OdaAktifKalan+1 where OdaNo = @o1", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@o1", CmbOdaNo.Text);
            komutoda.ExecuteNonQuery();

            bgl.baglanti().Close();
            TxtOgrAd.Clear();
            TxtMail.Clear();
            TxtOgrSoyad.Clear();
            MskTC.Clear();
            MskOgrTelefon.Clear();
            MskDogum.Clear();
            CmbOdaNo.Text = String.Empty;
            CmbBolum.Text = String.Empty;
            TxtYillik.Clear();
            TxtVeliAdSoyad.Clear();
            MskVeliTelefon.Clear();
            RchAdres.Clear();
            rchSaglik.Clear();
            textKanGrup.Clear();
            pictureBox1.Image = null;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OgrenciListesiForm frm = new OgrenciListesiForm();
            frm.ShowDialog();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OgrenciListesiForm frm = new OgrenciListesiForm();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciListesiForm frm = new OgrenciListesiForm();
            frm.ShowDialog();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
