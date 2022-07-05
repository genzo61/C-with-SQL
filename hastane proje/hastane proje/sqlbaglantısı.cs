using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace hastane_proje
{
    class sqlbaglantısı
    {
        public SqlConnection baglantı()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-CMEGFEH\\SQLEXPRESS;Initial Catalog=hastane;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
