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
    public partial class bilgidüzenle : Form
    {
        public bilgidüzenle()
        {
            InitializeComponent();
        }
        public string tcno;

        sqlbaglantısı bgl = new sqlbaglantısı();
        private void bilgidüzenle_Load(object sender, EventArgs e)
        {
            msktc.Text = tcno;
            SqlCommand komut = new SqlCommand("select * from tblhastalar where hastatc=@p1", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtad.Text = dr[1].ToString();
                txtsoyad.Text = dr[2].ToString();
                msktelefon.Text = dr[4].ToString();
                txtşifre.Text = dr[5].ToString();
                cmbcinsiyet.Text = dr[6].ToString();
            }
            bgl.baglantı().Close();


        }

        private void btnbilgigüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update tblhastalar set hastaad=@p1,hastasoyad=@p2,hastatelefon=@p3,hastaşifre=@p4,hastacinsiyet=@p5", bgl.baglantı());
            komut2.Parameters.AddWithValue("@p1", txtad.Text);
            komut2.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut2.Parameters.AddWithValue("@p3", msktelefon.Text);
            komut2.Parameters.AddWithValue("@p4", txtşifre.Text);
            komut2.Parameters.AddWithValue("@p5", cmbcinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", msktc.Text);
            komut2.ExecuteNonQuery();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
