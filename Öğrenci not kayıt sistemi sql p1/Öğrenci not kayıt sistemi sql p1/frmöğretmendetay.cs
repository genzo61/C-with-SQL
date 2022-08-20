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

namespace Öğrenci_not_kayıt_sistemi_sql_p1
{
    public partial class frmöğretmendetay : Form
    {
        public frmöğretmendetay()
        {
            InitializeComponent();
        }

        private void frmöğretmendetay_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbnotkayıtDataSet.TBLBİLGİ' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //otomatik doldurma komutu :).
            this.tBLBİLGİTableAdapter.Fill(this.dbnotkayıtDataSet.TBLBİLGİ);

        }
        SqlConnection baglantı = new SqlConnection(@"Data Source=DESKTOP-CMEGFEH\SQLEXPRESS;Initial Catalog=Dbnotkayıt;Integrated Security=True");

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into TBLBİLGİ (OGRNUMARA,OGRAD,OGRSOYAD) values (@p1,@p2,@p3)", baglantı);
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox1.Text);
            komut.Parameters.AddWithValue("@p3", textBox2.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Öğrenci Kaydedildi");
            this.tBLBİLGİTableAdapter.Fill(this.dbnotkayıtDataSet.TBLBİLGİ);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilen = dataGridView1.SelectedCells[0].RowIndex;

            textBox1.Text = dataGridView1.Rows[seçilen].Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.Rows[seçilen].Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.Rows[seçilen].Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.Rows[seçilen].Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.Rows[seçilen].Cells[6].Value.ToString();

        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            s1 = Convert.ToDouble(textBox3.Text);
            s2 = Convert.ToDouble(textBox4.Text);
            s3 = Convert.ToDouble(textBox5.Text);
            ortalama = (s1 + s2 + s3) / 3;
            lblortalama.Text = ortalama.ToString();



            baglantı.Open();
            SqlCommand komut = new SqlCommand("update TBLBİLGİ set OGRS1=@p1,OGRS2=@P2,OGRS3=@P3,ORTALAMA=@P4 WHERE OGRNUMARA=@P5", baglantı);
            komut.Parameters.AddWithValue("@p1", textBox3.Text);
            komut.Parameters.AddWithValue("@p2", textBox4.Text);
            komut.Parameters.AddWithValue("@p3", textBox5.Text);
            komut.Parameters.AddWithValue("@p4",decimal.Parse( lblortalama.Text));
            komut.Parameters.AddWithValue("@p5", maskedTextBox1.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Öğrenci Bilgileri Güncellendi");
            this.tBLBİLGİTableAdapter.Fill(this.dbnotkayıtDataSet.TBLBİLGİ);
        }
    }
}
