using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtYönetimSistemi
{
    public partial class FormYöneticiAyarlarıGiris : Form
    {
        public FormYöneticiAyarlarıGiris()
        {
            InitializeComponent();
        }

        private void FormYöneticiAyarlarıGiris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sifre = "123456";
            if (textBox1.Text== sifre)
            {
                
                FormYöneticiAyarları frm= new FormYöneticiAyarları();
                this.Close();
                frm.ShowDialog();
         



            }
            else
            {
                MessageBox.Show("Şifre Yanlış ! Anasayfaya Yönlendiriliyorsunuz....");
                
            }

        }
    }
}
