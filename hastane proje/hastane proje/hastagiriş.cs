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
    public partial class hastagiriş : Form
    {
        public hastagiriş()
        {
            InitializeComponent();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();

        private void lnküyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hastakayıt fr = new hastakayıt();
            fr.Show();
        }

        private void btngirişyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tblhastalar where hastatc=@p1 and hastaşifre=@p2", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2", txtşifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                hastakayıtdetay fr = new hastakayıtdetay();
                fr.tc = msktc.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı tc veya Şifre");
            }
            bgl.baglantı().Close();

        }
    }
}
