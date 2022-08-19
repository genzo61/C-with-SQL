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
    public partial class frmistatislik : Form
    {
        public frmistatislik()
        {
            InitializeComponent();
        }
        DbentityürünEntities db = new DbentityürünEntities();
        private void frmistatislik_Load(object sender, EventArgs e)
        {
            label2.Text = db.TBLKATAGORİ.Count().ToString();
            label3.Text = db.TBLURUN.Count().ToString();
            label5.Text = db.TBLMUSTERI.Count(x => x.DURUM == true).ToString();
            label11.Text = db.TBLMUSTERI.Count(x => x.DURUM == false).ToString();
            label7.Text = db.TBLURUN.Sum(y => y.STOK).ToString();
            label23.Text = db.TBLSATIS.Sum(z => z.FIYAT).ToString() + "TL";
            label17.Text = (from x in db.TBLURUN orderby x.FIYAT descending select x.URUNAD).FirstOrDefault();
            label15.Text = (from x in db.TBLURUN orderby x.FIYAT ascending select x.URUNAD).FirstOrDefault();
            label9.Text = db.TBLURUN.Count(x => x.KATEGORI == 1).ToString();
            label13.Text = (from x in db.TBLMUSTERI select x.SEHIR).Distinct().Count().ToString();
            

        }
    }
}
