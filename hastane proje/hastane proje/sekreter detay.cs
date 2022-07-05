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
    public partial class sekreter_detay : Form
    {
        public sekreter_detay()
        {
            InitializeComponent();
        }
        public string tcnumara;
        sqlbaglantısı bgl = new sqlbaglantısı();

        private void sekreter_detay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tcnumara;

            //ad soyad
            SqlCommand komut1 = new SqlCommand("select sekreteradsoyad from tblsekreter where sekretertc=@p1", bgl.baglantı());
            komut1.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lbladsoyad.Text = dr1[0].ToString();
            }
            bgl.baglantı().Close();


            //branşları datagride aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblbranşlar", bgl.baglantı());
            da.Fill(dt1);
            dataGridView3.DataSource = dt1;


            //doktorları listeye aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from tbldoktorlar", bgl.baglantı());
            da2.Fill(dt2);
            dataGridView4.DataSource = dt2;

            //branşları getirme
            SqlCommand komut2 = new SqlCommand("select branşad from tblbranşlar", bgl.baglantı());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbranş.Items.Add(dr2[0]);
            }
            bgl.baglantı().Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into tblrandevu (randevutarih,randevusaat,randevubranş,randevudoktor) values(@r1,@r2,@r3,@r4)", bgl.baglantı());
            komutkaydet.Parameters.AddWithValue("@r1", msktarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", msksaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", cmbbranş.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cmbdoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Randevu Oluşturuldu");
        }

        private void cmbbranş_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();

            SqlCommand komut = new SqlCommand("select doktorad,doktorsoyad from tbldoktorlar where doktorbranş=@p1", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", cmbbranş.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbdoktor.Items.Add(dr[0] + "" + dr[1]);
            }
            bgl.baglantı().Close();

        }

        private void btndoktorpaneli_Click(object sender, EventArgs e)
        {
            doktorpaneli fr = new doktorpaneli();
            fr.Show();
        }

        private void btnduyuruoluştur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into duyuru (duyuru) values (@p1)", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", rchduyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("duyuru oluşturuldu");

        }

        private void btnbranşpaneli_Click(object sender, EventArgs e)
        {
            branş fr = new branş();
            fr.Show();
        }

        private void btnrandevuliste_Click(object sender, EventArgs e)
        {
            randevu_listesi fr = new randevu_listesi();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            duyurular fr = new duyurular();
            fr.Show();

        }
    }
}
