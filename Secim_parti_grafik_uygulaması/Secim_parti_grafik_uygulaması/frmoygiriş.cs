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
    public partial class frmoygiriş : Form
    {
        public frmoygiriş()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-CMEGFEH\\SQLEXPRESS;Initial Catalog=Dbsecimuygulaması;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnoygiriiş_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLILCE (ILCEAD,APARTI,BPARTI,CPARTI,DPARTI) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtilçead.Text);
            komut.Parameters.AddWithValue("@p2", txtapartisi.Text);
            komut.Parameters.AddWithValue("@p3", txtbpartisi.Text);
            komut.Parameters.AddWithValue("@p4", txtcpartisi.Text);
            komut.Parameters.AddWithValue("@p5", txtdpartisi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oy Girişi Gerçekleşti.");
        }

        private void btngrafikler_Click(object sender, EventArgs e)
        {
            frmgrafikler fr = new frmgrafikler();
            fr.Show();
        }
    }
}
