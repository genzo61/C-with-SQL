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

namespace filmkütüphaensi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source=DESKTOP-CMEGFEH\SQLEXPRESS;Initial Catalog=dbfilimkütüphanesi;Integrated Security=True");

        void filmler()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLFİLMLER",baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filmler();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into TBLFİLMLER (AD,KATEGORI,LINK) values(@p1,@p2,@p3)", baglantı);
            komut.Parameters.AddWithValue("@p1", txtfilmad.Text);
            komut.Parameters.AddWithValue("@p2", txtkategori.Text);
            komut.Parameters.AddWithValue("@p3", txtlink.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Film Başarılı Bir Şekilde Kaydedildi","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            filmler();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilen = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[seçilen].Cells[3].Value.ToString();

            webBrowser1.Navigate(link);
        }

        private void btnhakkımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bu proje Ali Haydar Düzenli Tarafından 26.08.2022 tarihinde yapılmıştır sevgili aziz ve ustam için inşallah beğenirler :)", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnçıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnrenkdeğiştir_Click(object sender, EventArgs e)
        {
            // string[] renkler = new string[5];
            // renkler[0] = 
            // renkler[1] = "red";
            //renkler[2] = "yellow";
            //renkler[3] = "khaki";
            //renkler[4] = "aqua";
            //for (int i = 0; i <5; i++)
            // {
            // this.BackColor = Color.FromArgb(i);
        }

    }
    }
}
