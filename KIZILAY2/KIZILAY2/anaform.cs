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
    public partial class anaform : Form
    {
        public anaform()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-CMEGFEH\\SQLEXPRESS;Initial Catalog=kızlay2;Integrated Security=True");

        void temizle()
        {
            txtid.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            txtşehir.Text = "";
            txtmeslek.Text = "";
            cmbkangrubu.Text = "";
            msdmaaş.Text = "";
            rdbekar.Checked = false;
            rdevli.Checked = false;
            txtad.Focus();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            this.tblkızılayTableAdapter.Fill(this.kızlay2DataSet1.tblkızılay);
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into tblkızılay (kişiad,kişisoyad,kişişehir,kişimaaş,kişimeslek,kişikangrubu,kişidurum) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglantı);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtşehir.Text);
            komut.Parameters.AddWithValue("@p4", msdmaaş.Text);
            komut.Parameters.AddWithValue("@p5", txtmeslek.Text);
            komut.Parameters.AddWithValue("@p6", cmbkangrubu.Text);
            komut.Parameters.AddWithValue("@p7", label9.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("KİŞİ KAYDEDİLDİ");
        }

        private void rdevli_CheckedChanged(object sender, EventArgs e)
        {
            if (rdevli.Checked==true)
            {
                label9.Text = "true";
            }
        }

        private void rdbekar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbekar.Checked==true)
            {
                label9.Text = "false"; 
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtşehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            msdmaaş.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtmeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            cmbkangrubu.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            label9.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void label9_TextChanged(object sender, EventArgs e)
        {
            if (label9.Text == "true")
            {
                rdevli.Checked = true;
            }
            if (label9.Text=="false")
            {
                rdbekar.Checked = false;
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komutsil = new SqlCommand("delete from tblkızılay where kişiid=@k1", baglantı);
            komutsil.Parameters.AddWithValue("@k1", txtid.Text);
            komutsil.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("KAYIT SİLİNDİ");
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komutguncelle = new SqlCommand("update tblkızılay set kişiad=@a1,kişisoyad=@a2,kişişehir=@a3,kişimaaş=@a4,kişidurum=@a5,kişimeslek=@a6,kişikangrubu=@a7 where kişiid=@a8", baglantı);
            komutguncelle.Parameters.AddWithValue("@a1", txtad.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtsoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", txtşehir.Text);
            komutguncelle.Parameters.AddWithValue("@a4", msdmaaş.Text);
            komutguncelle.Parameters.AddWithValue("@a5", label9.Text);
            komutguncelle.Parameters.AddWithValue("@a6", txtmeslek.Text);
            komutguncelle.Parameters.AddWithValue("@a7", cmbkangrubu.Text);
            komutguncelle.Parameters.AddWithValue("@a8", txtid.Text);
            komutguncelle.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("PERSONEL GÜNCELLENDİ");
        }

        private void btnistatislik_Click(object sender, EventArgs e)
        {
            istatislik fr = new istatislik();
            fr.Show();
        }

        private void btngrafik_Click(object sender, EventArgs e)
        {
            grafikler fr2 = new grafikler();
            fr2.Show();
        }
    }
}
