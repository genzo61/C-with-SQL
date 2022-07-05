using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastane_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhastagiriş_Click(object sender, EventArgs e)
        {
            hastagiriş fr = new hastagiriş();
            fr.Show();
            this.Hide();

        }

        private void btndoktorgiriş_Click(object sender, EventArgs e)
        {
            doktorgiriş fr = new doktorgiriş();
            fr.Show();
            this.Hide();
        }

        private void btnsekretergiriş_Click(object sender, EventArgs e)
        {
            sekreter_giriş fr = new sekreter_giriş();
            fr.Show();
            this.Hide();
        }
    }
}
