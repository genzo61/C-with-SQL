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
    public partial class doktordetay : Form
    {
        public doktordetay()
        {
            InitializeComponent();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();
        public string tc;
        private void doktordetay_Load(object sender, EventArgs e)
        {
            lbltcno.Text = tc;

            //doktor ad soyad 
            SqlCommand komut = new SqlCommand("select doktorad,doktorsoyad from tbldoktorlar where doktortc=@p1", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", lbltcno.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + "" + dr[1];
            }
            bgl.baglantı().Close();

            //randevular
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblrandevu where randevudoktor='" + lbladsoyad.Text + "'", bgl.baglantı());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            bgl.baglantı().Close();

        }

        private void btnbilgidüzenle_Click(object sender, EventArgs e)
        {
            doktorbilgidüzenle fr = new doktorbilgidüzenle();
            fr.tcno = lbltcno.Text;
            fr.Show();
        }

        private void btnduyurular_Click(object sender, EventArgs e)
        {
            duyurular fr = new duyurular();
            fr.Show();
        }

        private void btnçıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilen = dataGridView2.SelectedCells[0].RowIndex;
            rchşikayet.Text = dataGridView2.Rows[seçilen].Cells[7].Value.ToString();
        }
    }
}
