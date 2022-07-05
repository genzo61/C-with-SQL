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
    public partial class hastakayıtdetay : Form
    {
        public hastakayıtdetay()
        {
            InitializeComponent();
        }
        public string tc;

        sqlbaglantısı bgl = new sqlbaglantısı();


        private void hastakayıtdetay_Load(object sender, EventArgs e)
        {
            lbltcno.Text = tc;
            //ad soyad çekme
            SqlCommand komut = new SqlCommand("select hastaad,hastasoyad from tblhastalar where hastatc=@p1", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", lbltcno.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + "" + dr[1];
            }
            bgl.baglantı().Close();

            //randevu geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select  *  from tblrandevu where hastatc=" + tc, bgl.baglantı());
            da.Fill(dt);
            dataGridView2.DataSource = dt;

            //branşları çekme
            SqlCommand komut2 = new SqlCommand("select branşad from tblbranşlar", bgl.baglantı());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbranş.Items.Add(dr2[0]);
            }
            bgl.baglantı().Close();

        }

        private void cmbbranş_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("select doktorad,doktorsoyad from tbldoktorlar where doktorbranş=@p1", bgl.baglantı());
            komut3.Parameters.AddWithValue("@p1", cmbbranş.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbdoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglantı().Close();
        }

        private void cmbdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblrandevu where randevubranş='" + cmbbranş.Text + "'" +" and  randevudoktor='" + cmbdoktor.Text +"' and randevudurum=0", bgl.baglantı());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void lnkbilgidüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bilgidüzenle fr = new bilgidüzenle();
            fr.tcno = lbltcno.Text;
            fr.Show();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[seçilen].Cells[0].Value.ToString();
        }

        private void btnrandevual_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tblrandevu set randevudurum=1,hastatc=@p1,hastaşikayet=@p2 where randevuid=@p3", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", lbltcno.Text);
            komut.Parameters.AddWithValue("@p2", rchşikayet.Text);
            komut.Parameters.AddWithValue("@p3", textBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("randevu alındı");

        }
    }
}
