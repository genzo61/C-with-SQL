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
    public partial class frmürün : Form
    {
        public frmürün()
        {
            InitializeComponent();
        }
        DbentityürünEntities db = new DbentityürünEntities();
        private void btnlistele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.TBLURUN select new { x.URUNID, x.URUNAD, x.MARKA, x.STOK, x.FIYAT, x.TBLKATAGORİ.AD, x.DURUM }).ToList();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.URUNAD = txtürünad.Text;
            t.MARKA = txtmarka.Text;
            t.STOK = short.Parse(txtstok.Text);
            t.KATEGORI = int.Parse(cmbkategori.SelectedValue.ToString());
            t.FIYAT = decimal.Parse(txtfiyat.Text);
            t.DURUM = true;
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("ürün sisteme kaydedildi");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtid.Text);
            var urun = db.TBLURUN.Find(x);
            db.TBLURUN.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("ürün kaldırıldı");
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtid.Text);
            var urun = db.TBLURUN.Find(x);
            urun.URUNAD = txtürünad.Text;
            urun.MARKA = txtmarka.Text;
            urun.STOK = short.Parse(txtstok.Text);
            urun.KATEGORI = int.Parse(cmbkategori.SelectedValue.ToString());
            urun.FIYAT = decimal.Parse(txtfiyat.Text);
            urun.DURUM = true;
            db.SaveChanges();
            MessageBox.Show("ürün güncellendi");
        }

        private void frmürün_Load(object sender, EventArgs e)
        {
            var katagoriler = (from x in db.TBLKATAGORİ select new { x.ID, x.AD }).ToList();
            cmbkategori.ValueMember = "ID";
            cmbkategori.DisplayMember = "AD";
            cmbkategori.DataSource = katagoriler;
        }
    }
}
