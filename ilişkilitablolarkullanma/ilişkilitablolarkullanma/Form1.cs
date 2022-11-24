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

namespace ilişkilitablolarkullanma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbilişkiliveritabanlıhareketDataSet.proje6' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.proje6TableAdapter.Fill(this.dbilişkiliveritabanlıhareketDataSet.proje6);
            // TODO: Bu kod satırı 'dbilişkiliveritabanlıhareketDataSet.proje6' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.proje6TableAdapter.Fill(this.dbilişkiliveritabanlıhareketDataSet.proje6);

        }
    }
}
