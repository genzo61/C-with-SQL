using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace kitaplık
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglantı = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\aliha\OneDrive\Masaüstü\kitaplık.mdb");

        string durum = "";

        void listele()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from kıtaplar ", baglantı);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            OleDbCommand komut1 = new OleDbCommand("insert into kıtaplar (kitapad,yazar,tür,sayfa,durum) values(@p1,@p2,@p3,@p4,@p5)", baglantı);
            komut1.Parameters.AddWithValue("@p1", textkitapad.Text);
            komut1.Parameters.AddWithValue("@p2", textyazar.Text);
            komut1.Parameters.AddWithValue("@p3", combtür.Text);
            komut1.Parameters.AddWithValue("@p4", textsayfa.Text);
            komut1.Parameters.AddWithValue("@p5",durum);
            komut1.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Kitap Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void rdkullanılmış_CheckedChanged(object sender, EventArgs e)
        {
            durum = "0";
        }

        private void rdsıfır_CheckedChanged(object sender, EventArgs e)
        {
            durum = "1";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilen = dataGridView1.SelectedCells[0].RowIndex;

            txtkitapid.Text = dataGridView1.Rows[seçilen].Cells[0].Value.ToString();
            textkitapad.Text = dataGridView1.Rows[seçilen].Cells[1].Value.ToString();
            textyazar.Text = dataGridView1.Rows[seçilen].Cells[2].Value.ToString();
            combtür.Text = dataGridView1.Rows[seçilen].Cells[3].Value.ToString();
            textsayfa.Text = dataGridView1.Rows[seçilen].Cells[4].Value.ToString();
            if (dataGridView1.Rows[seçilen].Cells[5].Value.ToString()=="True")
            {
                rdsıfır.Checked = true;
            }
            else
            {
                rdkullanılmış.Checked = true;
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand(" Delete from kıtaplar where kitapid=@p1", baglantı);
            komut.Parameters.AddWithValue("@p1", txtkitapid.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show(" Kitap Silindi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("update kıtaplar set kitapad=@p1,yazar=@p2,tür=@p3,sayfa=@p4,durum=@p5 where kitapid=@p6", baglantı);
            komut.Parameters.AddWithValue("@p1", textkitapad.Text);
            komut.Parameters.AddWithValue("@p2", textyazar.Text);
            komut.Parameters.AddWithValue("@p3", combtür.Text);
            komut.Parameters.AddWithValue("@p4", textsayfa.Text);
            if (rdkullanılmış.Checked==true)
            {
                komut.Parameters.AddWithValue("@p5", durum);
            }
            if (rdsıfır.Checked==true)
            {
                komut.Parameters.AddWithValue("@p5", durum);
            }
            komut.Parameters.AddWithValue("@p6", txtkitapid.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Kitap Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();


        }

        private void btnbul_Click(object sender, EventArgs e)
        {
           
            OleDbCommand komut = new OleDbCommand("select * from kıtaplar where kitapad=@p1", baglantı);
            komut.Parameters.AddWithValue("@p1", txtkitapbul.Text);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
          

        }
    }
}
