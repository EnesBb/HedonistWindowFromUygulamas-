using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HedonistProjeOdev
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KullaniciKayit kul = new KullaniciKayit();
            kul.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ZiyaretciEkran ziyaretci = new ZiyaretciEkran();
            ziyaretci.Show();
        }
    }
}
