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
    public partial class OdaKalan : Form
    {
        public OdaKalan()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        public string AktarilanDeger { get; set; }
        private void label1_Click(object sender, EventArgs e)
        {

        }
 
        private void YataklarForm_Load(object sender, EventArgs e)
        {
            label1.Text = AktarilanDeger;
        }
    }
}
