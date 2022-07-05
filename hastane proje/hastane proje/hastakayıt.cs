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

namespace hastane_proje
{
    public partial class hastakayıt : Form
    {
        public hastakayıt()
        {
            InitializeComponent();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();

        private void btnkayıtyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tblhastalar (hastaad,hastasoyad,hastatc,hastatelefon,hastaşifre,hastacinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", msktc.Text);
            komut.Parameters.AddWithValue("@p4", msktelefon.Text);
            komut.Parameters.AddWithValue("@p5", txtşifre.Text);
            komut.Parameters.AddWithValue("@p6", cmbcinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Kaydınız Yapılmıştır","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void hastakayıt_Load(object sender, EventArgs e)
        {

        }
    }
}
