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
    public partial class sekreter_giriş : Form
    {
        public sekreter_giriş()
        {
            InitializeComponent();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();

        private void btngirişyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tblsekreter where sekretertc=@p1 and sekreterşifre=@p2", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2", txtşifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                sekreter_detay fr = new sekreter_detay();
                fr.tcnumara = msktc.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Girişi ");
            }
            bgl.baglantı().Close();

        }
    }
}
