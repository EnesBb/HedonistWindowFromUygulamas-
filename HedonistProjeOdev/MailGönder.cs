using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace HedonistProjeOdev
{
    public partial class MailGönder : Form
    {
        public MailGönder()
        {
            InitializeComponent();
        }
        public string atama;

        public string atama2;
        MailMessage message = new MailMessage();
        private void button1_Click(object sender, EventArgs e)
        {
            SmtpClient client = new SmtpClient();
            try
            {

           
                MailMessage message = new MailMessage();
          
                client.Credentials = new System.Net.NetworkCredential("hedonistbilge@hotmail.com", "eso123456");

                client.Port = 587;
                client.Host = "smtp.live.com";
                client.EnableSsl = true;
                message.To.Add(txt_kim.Text);
                message.From = new MailAddress("hedonistbilge@hotmail.com");
                message.Subject = txt_baslik.Text;
                message.Body = txt_icerik.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                client.Send(message);
            }
          finally
            {
                MessageBox.Show("Mesaj Başarılı Şekilde gönderildi.");
            }


        }

        private void MailGönder_Load_1(object sender, EventArgs e)
        {
            txt_kim.Text = atama2;
            txt_icerik.Text = atama;
            txt_baslik.Text = "Hedonist.com  AlışVeriş Detaylarınız..";
            message.Subject = txt_baslik.Text;
        }
    }
}
