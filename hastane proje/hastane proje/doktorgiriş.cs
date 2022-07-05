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
    public partial class doktorgiriş : Form
    {
        public doktorgiriş()
        {
            InitializeComponent();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();

        private void btngirişyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbldoktorlar where doktortc=@p1 and doktorşifre=@p2", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2", txtşifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                doktordetay fr = new doktordetay();
                fr.tc = msktc.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("hatalı kullanıcı adı veya şifre");
            }
            bgl.baglantı().Close();
        }
    }
}
