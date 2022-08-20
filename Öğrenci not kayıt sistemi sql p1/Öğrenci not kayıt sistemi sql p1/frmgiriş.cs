using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Öğrenci_not_kayıt_sistemi_sql_p1
{
    public partial class frmgiriş : Form
    {
        public frmgiriş()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            öğrenci_sayfa fr = new öğrenci_sayfa();
            fr.numara = maskedTextBox1.Text; 
            fr.Show();
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text=="1111")
            {
                frmöğretmendetay fr = new frmöğretmendetay();
                fr.Show();
                this.Hide();
            }
        }
    }
}
