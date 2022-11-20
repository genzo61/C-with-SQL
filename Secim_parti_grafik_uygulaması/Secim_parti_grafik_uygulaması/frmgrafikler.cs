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

namespace Secim_parti_grafik_uygulaması
{
    public partial class frmgrafikler : Form
    {
        public frmgrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-CMEGFEH\\SQLEXPRESS;Initial Catalog=Dbsecimuygulaması;Integrated Security=True");
        private void frmgrafikler_Load(object sender, EventArgs e)
        {
            //ilçe adlarını komboboxa çekme işlemi...
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select ILCEAD from TBLILCE", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            baglanti.Close();

            //grafiğe toplam sonuçları getirme.
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(APARTI),sum(BPARTI),sum(CPARTI),sum(DPARTI) from TBLILCE", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A Parti", dr2[0]);
                chart1.Series["Partiler"].Points.AddXY("B Parti", dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("C Parti", dr2[2]);
                chart1.Series["Partiler"].Points.AddXY("D Parti", dr2[3]);
            }
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from TBLILCE where ILCEAD=@p1", baglanti);
            komut3.Parameters.AddWithValue("@p1", comboBox1.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                progressBar1.Value =int.Parse( dr3[2].ToString());
                progressBar2.Value = int.Parse(dr3[3].ToString());
                progressBar3.Value = int.Parse(dr3[4].ToString());
                progressBar4.Value = int.Parse(dr3[5].ToString());

                lbla.Text = dr3[2].ToString();
                lblb.Text = dr3[3].ToString();
                lblc.Text = dr3[4].ToString();
                lbld.Text = dr3[5].ToString();
            }
            baglanti.Close();
        }
    }
}
