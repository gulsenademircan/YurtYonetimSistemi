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
 
    public partial class PersonelKayitForm : Form
    {
        public PersonelKayitForm()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        string dosyayolu;
        private void Deneme4_Load(object sender, EventArgs e)
        {

        }

        private void textAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(dosyayolu, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] seciliresim = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();

            SqlCommand komutekle = new SqlCommand("insert into Personel (PersonelAdSoyad,PersonelDepartman,PersonelTarih,PersonelTelefon,PersonelAdres,PersonelResim) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komutekle.Parameters.AddWithValue("@p1", textAd.Text);
            komutekle.Parameters.AddWithValue("@p2", textGorev.Text);
            komutekle.Parameters.AddWithValue("@p3", MskisGiris.Text);
            komutekle.Parameters.AddWithValue("@p4", MskTelefon.Text);
            komutekle.Parameters.AddWithValue("@p5", RchAdres.Text);
            komutekle.Parameters.Add("@p6", SqlDbType.Image, seciliresim.Length).Value = seciliresim;
            komutekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Eklendi...");
            textAd.Clear();
            textGorev.Clear();
            MskTelefon.Clear();
            RchAdres.Clear();
            MskisGiris.Clear();
            pictureBox1.Image = null;
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

        private void button1_Click(object sender, EventArgs e)
        {
            PersonelListesiForm frm = new PersonelListesiForm();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PersonelListesiForm frm = new PersonelListesiForm();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonelListesiForm frm = new PersonelListesiForm();
            frm.ShowDialog();
        }
    }
}
