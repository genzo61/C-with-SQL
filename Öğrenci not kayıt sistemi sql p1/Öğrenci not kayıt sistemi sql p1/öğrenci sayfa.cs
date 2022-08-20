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

namespace Öğrenci_not_kayıt_sistemi_sql_p1
{
    public partial class öğrenci_sayfa : Form
    {
        public öğrenci_sayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source=DESKTOP-CMEGFEH\SQLEXPRESS;Initial Catalog=Dbnotkayıt;Integrated Security=True");
        public string numara;
        private void öğrenci_sayfa_Load(object sender, EventArgs e)
        {
            lblnumara.Text = numara;

            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from TBLBİLGİ where OGRNUMARA=@p1", baglantı);
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[2].ToString() + " " + dr[3].ToString();
                lbls1.Text = dr[4].ToString();
                lbls2.Text = dr[5].ToString();
                lbls3.Text = dr[6].ToString();
                lblortalama.Text = dr[7].ToString();
                lbldurum.Text = dr[8].ToString();
            }
            baglantı.Close();


        }
    }
}
