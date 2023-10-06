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
  
    public partial class OgrenciIslemleriForm : Form
    {
       
        public OgrenciIslemleriForm()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        public string id, ad, soyad, Tc, telefon, dogumtarih, bolum, mail, odano, yillik, veliad, velitelefon, veliadres, saglik, kangrubu;

        private void btnTemizle_Click(object sender, EventArgs e)
        {
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
            pictureBoxResim.Image = null;
        }

        public byte[] resim;
        public byte[] resim2;


        private void buttonResimsec_Click(object sender, EventArgs e)
        {
            String imageLocation;
            //Fotoğraf seçme
            try
            {
                
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "all files(*.*)| *.*|png Files(*.png)|*.png|jpg Files(*.jpg)|*.jpg";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName.ToString();
                    pictureBoxResim.ImageLocation = imageLocation;

                    FileStream fileStream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryReader = new BinaryReader(fileStream);
                    resim2 = binaryReader.ReadBytes((int)fileStream.Length);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Fotoğraf seçilirken bir hata oluştu!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
      
        private void button3_Click(object sender, EventArgs e)
        {
          
            //Silme İşlemi
            SqlCommand komutsil = new SqlCommand("delete from Ogrenci where Ogrid=@a1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@a1", label15.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi...");

            //Odanın aktif öğrenci sayısını azalatma
            SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktifKalan = OdaAktifKalan-1 where OdaNo = @o1", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@o1", CmbOdaNo.Text);
            komutoda.ExecuteNonQuery();

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
            pictureBoxResim.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                //Güncelleme İşlemi
                SqlCommand komut = new SqlCommand("update Ogrenci set OgrAd=@p2,OgrSoyad=@p3,OgrTC=@p4,OgrTelefon=@p5,OgrDogum=@p6,OgrBolum=@p7,OgrMail=@p8,OgrOdaNo=@p9,OgrYillik=@p10,OgrVeliAdSoyad=@p11,OgrVeliTelefon=@p12,OgrVeliAdres=@p13,OgrSaglik=@p14,OgrKanGrubu=@p15,OgrResim=@p16 where Ogrid=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", label15.Text);
                komut.Parameters.AddWithValue("@p2", TxtOgrAd.Text);
                komut.Parameters.AddWithValue("@p3", TxtOgrSoyad.Text);
                komut.Parameters.AddWithValue("@p4", MskTC.Text);
                komut.Parameters.AddWithValue("@p5", MskOgrTelefon.Text);
                komut.Parameters.AddWithValue("@p6", MskDogum.Text);
                komut.Parameters.AddWithValue("@p7", CmbBolum.Text);
                komut.Parameters.AddWithValue("@p8", TxtMail.Text);
                komut.Parameters.AddWithValue("@p9", CmbOdaNo.Text);
                komut.Parameters.AddWithValue("@p10", TxtYillik.Text);
                komut.Parameters.AddWithValue("@p11", TxtVeliAdSoyad.Text);
                komut.Parameters.AddWithValue("@p12", MskVeliTelefon.Text);
                komut.Parameters.AddWithValue("@p13", RchAdres.Text);
                komut.Parameters.AddWithValue("@p14", rchSaglik.Text);
                komut.Parameters.AddWithValue("@p15", textKanGrup.Text);
                komut.Parameters.Add("@p16", SqlDbType.Image, resim2.Length).Value = resim2;
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Başarıyla Güncellenmiştir .....");

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
                pictureBoxResim.Image = null;

            }
            catch (Exception)
            {
                MessageBox.Show("Hata! ");
            }

        }

        private void Deneme3_Load(object sender, EventArgs e)
        {
            //Resim görüntüleme
            using (MemoryStream ms = new MemoryStream(resim))
            {
                pictureBoxResim.Image = Image.FromStream(ms);
            }

            //  Boş Oda ve Bölümlerin Comboboxa çekilmesi
            SqlCommand komut = new SqlCommand("Select BolumAd From Bolumler", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                CmbBolum.Items.Add(oku[0].ToString());
            }
            SqlCommand komut2 = new SqlCommand("Select OdaNo From Odalar where OdaKapasite != OdaAktifKalan", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                CmbOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();

            label15.Text = id;
            TxtOgrAd.Text = ad;
            TxtOgrSoyad.Text = soyad;
            MskTC.Text = Tc;
            MskOgrTelefon.Text = telefon;
            MskDogum.Text = dogumtarih;
            CmbBolum.Text = bolum;
            TxtMail.Text = mail;
            CmbOdaNo.Text = odano;
            TxtYillik.Text = yillik;
            TxtVeliAdSoyad.Text = veliad;
            MskVeliTelefon.Text = velitelefon;
            RchAdres.Text = veliadres;
            rchSaglik.Text = saglik;
            textKanGrup.Text = kangrubu;
        }
    }
}
