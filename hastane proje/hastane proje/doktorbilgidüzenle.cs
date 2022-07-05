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
    public partial class doktorbilgidüzenle : Form
    {
        public doktorbilgidüzenle()
        {
            InitializeComponent();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();
        public string tcno;
        private void doktorbilgidüzenle_Load(object sender, EventArgs e)
        {
            msktc.Text = tcno;

            SqlCommand komut = new SqlCommand("select * from tbldoktorlar where doktortc=@p1", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtad.Text = dr[1].ToString();
                txtsoyad.Text = dr[2].ToString();
                cmbbranş.Text = dr[3].ToString();
                msktc.Text = dr[4].ToString();
                txtşifre.Text = dr[5].ToString();
            }
            bgl.baglantı().Close();

        }

        private void btnbilgigüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbldoktorlar set doktorad=@p1,doktorsoyad=@p2,doktorbranş=@p3,doktorşifre=@p4 where doktortc=@p5", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbbranş.Text);
            komut.Parameters.AddWithValue("@p4", txtşifre.Text);
            komut.Parameters.AddWithValue("@p5", msktc.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("kayıt güncellendi");

        }
    }
}
