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
    public partial class randevu_listesi : Form
    {
        public randevu_listesi()
        {
            InitializeComponent();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();

        private void randevu_listesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblrandevu", bgl.baglantı());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

     
        
    }
}
