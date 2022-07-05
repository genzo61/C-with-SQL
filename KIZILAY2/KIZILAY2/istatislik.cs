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

namespace KIZILAY2
{
    public partial class istatislik : Form
    {
        public istatislik()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-CMEGFEH\\SQLEXPRESS;Initial Catalog=kızlay2;Integrated Security=True");

        private void istatislik_Load(object sender, EventArgs e)
        {
            //toplam kişi sayısı
            baglantı.Open();
            SqlCommand komut1 = new SqlCommand("select count(*) from tblkızılay", baglantı);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lbltoplamkişi.Text = dr1[0].ToString();
            }
            baglantı.Close();

            //evli kişi sayısı
            baglantı.Open();
            SqlCommand komut2 = new SqlCommand("select count(*) from tblkızılay where kişidurum=1", baglantı);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LBLEVLİ.Text = dr2[0].ToString();
            }
            baglantı.Close();

            //bekar personel sayısı
            baglantı.Open();
            SqlCommand komut3 = new SqlCommand("select count(*) from tblkızılay where kişidurum=0", baglantı);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LBLBEKAR.Text = dr3[0].ToString();
            }
            baglantı.Close();

            //toplam maaş
            baglantı.Open();
            SqlCommand komut4 = new SqlCommand("select sum(kişimaaş) from tblkızılay ", baglantı);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lbltoplammmaaş.Text = dr4[0].ToString();
            }
            baglantı.Close();

            //ortalama maaş
            baglantı.Open();
            SqlCommand komut5 = new SqlCommand("select avg(kişimaaş)from tblkızılay", baglantı);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblortalamamaaş.Text = dr5[0].ToString();
            }
            baglantı.Close();

        }
    }
}
