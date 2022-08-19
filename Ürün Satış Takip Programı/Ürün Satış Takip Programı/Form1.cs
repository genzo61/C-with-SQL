using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ürün_Satış_Takip_Programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbentityürünEntities db = new DbentityürünEntities();
        private void btnlistele_Click(object sender, EventArgs e)
        {
            var katagori = db.TBLKATAGORİ.ToList();
            dataGridView1.DataSource = katagori;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            TBLKATAGORİ t = new TBLKATAGORİ();
            t.AD = textBox2.Text;
            db.TBLKATAGORİ.Add(t);
            db.SaveChanges();
            MessageBox.Show("kategori eklendi");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ktgr = db.TBLKATAGORİ.Find(x);
            db.TBLKATAGORİ.Remove(ktgr);
            db.SaveChanges();
            MessageBox.Show("kategori silindi");
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ktgr = db.TBLKATAGORİ.Find(x);
            ktgr.AD = textBox2.Text;
            db.SaveChanges();
            MessageBox.Show("kategori güncellendi");
        }
    }
}
