using HedonistProjeOdev.Models;
using HedonistProjeOdev.SingletonPattern;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        HedonistDBEntities entities = DBTool.DBInstance;

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            if (entities.Admins.Any(x => x.UserName == txtAdminKullaniciAdi.Text && x.Password == txtAdminSifre.Text))
            {
                Form1 frm1 = new Form1();
                frm1.Show();
            }

            else MessageBox.Show("Girdiğiniz Bilgiler Hatalıdır.");
        }
    }
}
