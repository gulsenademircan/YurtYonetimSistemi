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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void öğrenciKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
           OgrenciKayitForm frm = new OgrenciKayitForm();
            frm.ShowDialog();
        }

        private void öğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
           OgrenciListesiForm frm = new OgrenciListesiForm();
            frm.ShowDialog();
        }

        private void öğrenciDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciListesiForm frm = new OgrenciListesiForm();
            frm.ShowDialog();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void personelİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void personelİşlemleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PersonelListesiForm frm =new PersonelListesiForm();
            frm.ShowDialog();
        }

        private void personelKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelKayitForm frm = new PersonelKayitForm();
            frm.ShowDialog();
        }

        private void personelListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelListesiForm frm = new PersonelListesiForm();
            frm.ShowDialog();
        }

        private void yöneticiİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void izinEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIzin frm = new FormIzin();
            frm.ShowDialog();
        }

        private void izinBulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IzinBulForm frm = new IzinBulForm();
            frm.ShowDialog();
        }

        private void kayıpEşyaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KayipEsyaForm frm = new KayipEsyaForm();
            frm.ShowDialog();
        }

        private void kayıpEşyaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EsyaListeForm frm = new EsyaListeForm();    
            frm.ShowDialog();
        }

        private void borçÖdemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdemeForm frm = new OdemeForm();
            frm.ShowDialog();
        }

        private void ödemeKayıtlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdemeKayitForm frm = new OdemeKayitForm();
            frm.ShowDialog();   
        }

        private void giderlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           HarcamaForm frm = new HarcamaForm();
            frm.ShowDialog();
        }

        private void yöneticiAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYöneticiAyarlarıGiris frm = new FormYöneticiAyarlarıGiris();
            frm.ShowDialog();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void odalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdalarForm frm = new OdalarForm();
            frm.ShowDialog();
        }

        private void hakkımızdaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fırat Öğrenci Yurdu..." );

        }

        private void notDefteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword.exe");
        }

        private void mSExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("excel.exe");
        }
    }
}
