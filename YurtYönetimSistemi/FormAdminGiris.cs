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
    public partial class FormAdminGiris : Form
    {
        public FormAdminGiris()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormYöneticiAyarlarıGiris frm = new FormYöneticiAyarlarıGiris();
            frm.ShowDialog();
        }

        private void FormAdminGiris_Load(object sender, EventArgs e)
        {

        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from admin where YoneticiAd =@p1 and YoneticiSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textKullanici.Text);
            komut.Parameters.AddWithValue("@p2", textParola.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                AnaForm frm = new AnaForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre...");
                textKullanici.Clear();
                textParola.Clear();
                textKullanici.Focus();
            }
            bgl.baglanti().Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
