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
    public partial class doktorpaneli : Form
    {
        public doktorpaneli()
        {
            InitializeComponent();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();


        private void doktorpaneli_Load(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from tbldoktorlar", bgl.baglantı());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;


            //branşları getirme
            SqlCommand komut2 = new SqlCommand("select branşad from tblbranşlar", bgl.baglantı());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbranş.Items.Add(dr2[0]);
            }
            bgl.baglantı().Close();


        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbldoktorlar (doktorad,doktorsoyad,doktorbranş,doktortc,doktorşifre) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbbranş.Text);
            komut.Parameters.AddWithValue("@p4", msktc.Text);
            komut.Parameters.AddWithValue("@p5", txtşifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("doktor eklendi");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilen = dataGridView1.SelectedCells[0].RowIndex;
            txtad.Text = dataGridView1.Rows[seçilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[seçilen].Cells[2].Value.ToString();
            cmbbranş.Text = dataGridView1.Rows[seçilen].Cells[3].Value.ToString();
            msktc.Text = dataGridView1.Rows[seçilen].Cells[4].Value.ToString();
            txtşifre.Text = dataGridView1.Rows[seçilen].Cells[5].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbldoktorlar where doktortc=@p1", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("kayıt silindi");

        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbldoktorlar set doktorad=@p1,doktorsoyad=@p2,doktorbranş=@p3,doktorşifre=@p5 where doktortc=@p4", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbbranş.Text);
            komut.Parameters.AddWithValue("@p4", msktc.Text);
            komut.Parameters.AddWithValue("@p5", txtşifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("doktor güncellendi");

        }

       
        
    }
}
