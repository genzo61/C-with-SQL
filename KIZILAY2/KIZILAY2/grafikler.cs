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
    public partial class grafikler : Form
    {
        public grafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-CMEGFEH\\SQLEXPRESS;Initial Catalog=kızlay2;Integrated Security=True");
        private void grafikler_Load(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komutg1 = new SqlCommand("select kişişehir,count(*) from tblkızılay group by kişişehir", baglantı);
            SqlDataReader dr1 = komutg1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["şehirler"].Points.AddXY(dr1[0], dr1[1]);
            }
            baglantı.Close();

            baglantı.Open();
            SqlCommand komutg2 = new SqlCommand("select kişimeslek,avg(kişimaaş) from tblkızılay group by kişimeslek", baglantı);
            SqlDataReader dr2 = komutg2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["maaşlar"].Points.AddXY(dr2[0], dr2[1]);
            }
            baglantı.Close();
        }
    }
}
