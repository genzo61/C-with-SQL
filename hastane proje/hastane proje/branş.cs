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
    public partial class branş : Form
    {
        public branş()
        {
            InitializeComponent();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();

        private void branş_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblbranşlar", bgl.baglantı());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tblbranşlar (branşad) values(@p1)", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", txtbranş.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("branş eklendi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[seçilen].Cells[0].Value.ToString();
            txtbranş.Text = dataGridView1.Rows[seçilen].Cells[1].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tblbranşlar  where branşid=@p1", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("branş silindi");


        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tblbranşlar set branşad=@p1 where branşid=@p2", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", txtbranş.Text);
            komut.Parameters.AddWithValue("@p2", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("branş güncellendi");

        }
    }
}
