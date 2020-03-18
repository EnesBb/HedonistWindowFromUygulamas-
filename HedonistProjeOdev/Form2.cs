using HedonistProjeOdev.Models;
using HedonistProjeOdev.SingletonPattern;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HedonistProjeOdev
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            this.Text = "Kullanıcı Giriş Ekranı";
        }

        HedonistDBEntities db = DBTool.DBInstance;


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (db.Users1.Any(x => x.UserName == txtKullaniciAdi.Text && x.Password == txtSifre.Text))
                {
                    #region AtamaTipleri
                    int yakalanan = db.Users1.Where(x => x.UserName == txtKullaniciAdi.Text).Single().UserID;
                    string yakalanan5 = db.Users1.Where(x => x.UserName == txtKullaniciAdi.Text).Single().FirstName;
                    string yakalanan6 = db.Users1.Where(x => x.UserName == txtKullaniciAdi.Text).Single().LastName;
                    string yakalanan4 = db.Users1.Where(x => x.UserName == txtKullaniciAdi.Text).Single().Address;
                    string yakalanan2 = db.Users1.Where(x => x.UserName == txtKullaniciAdi.Text).Single().Email;
                    string yakalanan3 = db.Users1.Where(x => x.UserName == txtKullaniciAdi.Text).Single().UserName;

                    #endregion

                    #region Aktarma
                    textBox1.Text = yakalanan.ToString();
                    MusteriEkrani ekrani = new MusteriEkrani();

                    ekrani.yazi = textBox1.Text;
                    ekrani.yazi2 = yakalanan2.ToString();
                    ekrani.yazi3 = yakalanan3.ToString();
                    ekrani.ad = yakalanan5.ToString();
                    ekrani.soyad = yakalanan6.ToString();
                    ekrani.adres = yakalanan4.ToString();
                    ekrani.Show();
                    this.Hide();
                  #endregion
                }
                
                else MessageBox.Show("Girdiğiniz Bilgiler Hatalıdır.");

            }
            finally
            {
                this.Hide();
            }
        }

    }
}
