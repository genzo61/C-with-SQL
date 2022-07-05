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
    public partial class giriş : Form
    {
        public giriş()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-CMEGFEH\\SQLEXPRESS;Initial Catalog=kızlay2;Integrated Security=True");

        private void btngirişyap_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from tblyöneticikızılay where kullanıcıad=@p1 and şifre=@p2", baglantı);
            komut.Parameters.AddWithValue("@p1", txtkullanıcıad.Text);
            komut.Parameters.AddWithValue("@p2", txtşifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                anaform fr61 = new anaform();
                fr61.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("HATALI KULLANICI GİRİŞİ");
            }
            baglantı.Close();
            
        }
    }
}
