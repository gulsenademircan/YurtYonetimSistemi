using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtYönetimSistemi
{
    public partial class PersonelIslemleriForm : Form
    {
        public string id, adsoyad, departman, tarih, telefon, adres;
        public byte[] photo;
        public byte[] photo2;


        private void btnAra_Click(object sender, EventArgs e)
        {
           PersonelListesiForm frm = new PersonelListesiForm();
            frm.ShowDialog();
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonResimsec_Click(object sender, EventArgs e)
        {
            String imageLocation;

            try
            {
                //Select Photo From Disk And Place To The PictureBox.
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "all files(*.*)| *.*|png Files(*.png)|*.png|jpg Files(*.jpg)|*.jpg";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName.ToString();
                    pictureBox1.ImageLocation = imageLocation;

                    FileStream fileStream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryReader = new BinaryReader(fileStream);
                    photo2 = binaryReader.ReadBytes((int)fileStream.Length);

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Fotoğraf seçilirken bir hata oluştu!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("delete from Personel where Personelid=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txtid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Silindi...");
            textAd.Clear();
            textGorev.Clear();
            MskTelefon.Clear();
            RchAdres.Clear();
            MskisGiris.Clear();
            pictureBox1.Image = null;
        }

        SqlBaglanti bgl = new SqlBaglanti();
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutgüncelle = new SqlCommand("update Personel set PersonelAdSoyad=@p1, PersonelDepartman=@p2,PersonelTarih=@p3,PersonelTelefon=@p4,PersonelAdres=@p5,PersonelResim=@p7  where Personelid=@p6", bgl.baglanti());
            komutgüncelle.Parameters.AddWithValue("@p1", textAd.Text);
            komutgüncelle.Parameters.AddWithValue("@p2", textGorev.Text);
            komutgüncelle.Parameters.AddWithValue("@p3", MskisGiris.Text);
            komutgüncelle.Parameters.AddWithValue("@p4", MskTelefon.Text);
            komutgüncelle.Parameters.AddWithValue("@p5", RchAdres.Text);
            komutgüncelle.Parameters.AddWithValue("@p6", txtid.Text);
            komutgüncelle.Parameters.Add("@p7", SqlDbType.Image, photo2.Length).Value = photo2;
            komutgüncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Güncellendi...");
            textAd.Clear();
            textGorev.Clear();
            MskTelefon.Clear();
            RchAdres.Clear();
            MskisGiris.Clear();
            pictureBox1.Image = null;
        }

        public PersonelIslemleriForm()
        {
            InitializeComponent();
        }

        private void PersonelIslemleriForm_Load(object sender, EventArgs e)
        {
            using (MemoryStream ms = new MemoryStream(photo))
            {
                pictureBox1.Image = Image.FromStream(ms);
            }
           
            txtid.Text = id;
            textAd.Text= adsoyad;   
            MskTelefon.Text= telefon;
            MskisGiris.Text = tarih;
            textGorev.Text = departman;
            RchAdres.Text = adres;
    }
    }
}
