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
    public partial class KullaniciKayit : Form
    {
        public KullaniciKayit()
        {
            InitializeComponent();
        }
        HedonistDBEntities db = DBTool.DBInstance;

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            Users1 us = new Users1();
            us.UserName = txtAd.Text;
            us.Password = txtSifre.Text;
            us.Email = txtEmail.Text;
            us.Address = txtAdress.Text;
            us.LastName = txtSoyad.Text;
            us.FirstName = txtAd.Text;

            if (txtAdress.Text == "" || txtKulAdi.Text == "" || txtSifre.Text == "" || txtEmail.Text == "" || txtAd.Text == "" || txtSoyad.Text == "")
            {

                MessageBox.Show("Kayıt Gerçekleştirilemedi. Girdiğiniz bilgileri kontrol lütfen ediniz.");
            }
            if (db.Users1.Any(x => x.Email == txtEmail.Text))
            {
                MessageBox.Show("Bu E-Mail daha önce kullanılmıştır. Lütfen başka bir E-Mail adresi giriniz.");
                txtEmail.Clear();
            }


            else
            {
                db.Users1.Add(us);
                db.SaveChanges();
                txtKulAdi.Clear();
                txtAdress.Clear();
                txtEmail.Clear();
                txtSifre.Clear();
                txtAd.Clear();
                txtSoyad.Clear();

                DialogResult dg = new DialogResult();
                dg = MessageBox.Show("Kaydınız başarı ile gerçekleşti. Kullanıcı Giriş Sayfasına Yönlendiriliyorsunuz.", "", MessageBoxButtons.YesNo);
                if (dg == DialogResult.Yes)
                {
                    Form2 frm2 = new Form2();
                    frm2.Show();
                }
                else
                {
                    Form1 frm = new Form1();
                    frm.Show();
                }
            }

        }
    }
}
