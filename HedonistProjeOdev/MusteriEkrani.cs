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
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;




namespace HedonistProjeOdev
{
    public partial class MusteriEkrani : Form
    {
        public MusteriEkrani()
        {
            InitializeComponent();
        }
       
        public string yazi;
        public string yazi2;
        public string yazi3;
        public string ad;
        public string soyad;
        public string adres;
        public object kargo;
        public int kargo2;

        HedonistDBEntities entities = DBTool.DBInstance;

        private void MusteriEkrani_Load(object sender, EventArgs e)
        {
            this.Height = 1400;
            this.Width = 1300;

            textBox2.Visible = false;
            textBox1.Text = yazi;
            label10.Text = yazi2;
            label11.Text = yazi3;
            textBox1.Visible = false;

            dataGridView1.ForeColor = Color.Black;

            int yak = Convert.ToInt32(textBox1.Text);

            dataGridView1.DataSource = entities.OrderDetails.Where(x => x.Order.UserID == yak).Select(x => new
            {
                
                SiparisId = x.OrderID,
                Kullanici_Adi = x.Order.Users1.UserName,
                Urun_Adi = x.Product.ProductName,
                Birim_Fiyat = x.Product.UnitPrice,
                Urun_Miktar = x.Quantity,
                ToplamFiyat = x.UnitPrice,
                Siparis_Tarih = x.Order.OrderDate,
                Adres = x.Order.Users1.Address,
                

            }).ToList();

            
            listBox1.DataSource = entities.Products.ToList();

            comboBox1.DataSource = entities.Shippers.ToList();
            comboBox1.DisplayMember = "CompanyName";
            comboBox1.ValueMember = "ShipperID";
            

        }

       

        private void listBox1_Format(object sender, ListControlConvertEventArgs e)
        {
            string urunad = (e.ListItem as Product).ProductName;
            decimal? urunfiyat = (e.ListItem as Product).UnitPrice;
            string categoriadi = (e.ListItem as Product).Category.CategoryName;
            string markaadi = (e.ListItem as Product).Brand.BrandName;

            e.Value = $"Ürün Adı : {urunad}   /* {categoriadi}       {markaadi}  */    {urunfiyat:C2}";
        }

      


        private void listBox2_Format(object sender, ListControlConvertEventArgs e)
        {
            DateTime dateTime = (e.ListItem as Order).OrderDate;
            string tasiyici = (e.ListItem as Order).Shipper.CompanyName;
            string kullanici = (e.ListItem as Order).Users1.UserName;

            e.Value = $"{dateTime}  {kullanici}  { tasiyici} ";
        }

        Order order = new Order();
       
        private void button1_Click(object sender, EventArgs e)
        {

            Shipper shipper = comboBox1.SelectedItem as Shipper;

          
            order.ShipperID = shipper.ShipperID;
            kargo = shipper.CompanyName;
            kargo2 = shipper.ShipperID;
            order.UserID = Convert.ToInt32(textBox1.Text);

            order.OrderDate = DateTime.Now;


            entities.Orders.Add(order);


            entities.SaveChanges();

            button1.Visible = false;
            textBox2.Text = order.OrderID.ToString();
            int yak = Convert.ToInt32(textBox1.Text);

            label6.Text = "Siparişlerinizi Ekleyebilirsiniz ==>";

        }

        

        private void btn_Sil_Click(object sender, EventArgs e)
        {

            entities.Orders.Remove(order);
            entities.SaveChanges();

            int yak = Convert.ToInt32(textBox1.Text);
            dataGridView1.DataSource = entities.Orders.Where(x => x.Users1.UserID == yak).Select(x => new
            {
                Id = x.OrderID,
                Adi = x.Users1.UserName,
                Adres = x.Users1.Address,
                x.Users1.Email

            }).ToList();

        }


        private void button2_Click(object sender, EventArgs e)
        {


            decimal eklenen = 0;
            int sonuc = 0;

            foreach (Product item in listBox1.SelectedItems)
            {
                OrderDetail order = new OrderDetail();

                if (kargo2 == 0)
                {
                    MessageBox.Show("Lütfen Kargo Firması Seçiniz.");
                }
                else
                {

                    if (numericUpDown1.Value < 1)
                    {
                        MessageBox.Show("Lütfen Miktar Seçiniz.");

                    }



                    else
                    {

                        order.OrderID = Convert.ToInt32(textBox2.Text);

                        order.ProductID = item.ProductsID;

                        order.Quantity = Convert.ToInt16(numericUpDown1.Value);
                        sonuc = (Convert.ToInt32(order.Quantity) * Convert.ToInt32(item.UnitPrice));

                        order.UnitPrice = sonuc;
                        entities.OrderDetails.Add(order);

                        eklenen += order.Product.UnitPrice;

                        order.UnitPrice = sonuc = (Convert.ToInt32(order.Quantity) * Convert.ToInt32(item.UnitPrice));

                        entities.SaveChanges();
                    }
                }


            }

            ID();

            label6.Text = "";


        }

        private void ID()
        {
            if (entities.OrderDetails.Any(x => x.OrderID != order.OrderID))
            {

                listBox2.DataSource = entities.OrderDetails.Where(x => x.OrderID == order.OrderID).ToList();


            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            OrderDetail order = listBox2.SelectedItem as OrderDetail;

            if (order == null)
            {
                MessageBox.Show("Silmek için Ürün Gereklidir.");
            }
            else
            {


                entities.OrderDetails.Remove(order);
                entities.SaveChanges();
                ID();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            decimal yeni = 0;

            int sayac = 0;
            try
            {
                foreach (OrderDetail item in listBox2.Items)
                {
                    
                    yeni += item.UnitPrice;
                    sayac++;


                }
                if (yeni<=0)
                {
                    MessageBox.Show("Toplam Fiyat İçin Ürün Gereklidir.");
                }
                else
                {
                    button2.Visible = false;
                    button3.Visible = false;
                    label7.Text = $"AlışVerişiniz Tamamlandı" + Environment.NewLine+
                        $". Toplam Tutar: { yeni:C2} dir.";
                

                    label12.Text = $" Adiniz: {ad} ," + Environment.NewLine +
                    $" Soyadiniz: {soyad}, " + Environment.NewLine +
                    $" Adresiniz: {adres}, " + Environment.NewLine +
                    $" Kargo Şirketi: {kargo}, " + Environment.NewLine +
                    $" Toplam Alışveriş Tutarınız: {yeni:C2} dir";
                    MailGönder mail = new MailGönder();
                    mail.atama = label12.Text;
                    mail.atama2 = label10.Text;
                    mail.ShowDialog();

                }
                
            }
            catch (Exception a)
            {

                MessageBox.Show(a.Message);
            }
           
            
        }

        private void listBox2_Format_1(object sender, ListControlConvertEventArgs e)
        {
            string a = (e.ListItem as OrderDetail).Product.ProductName;
            short? c = (e.ListItem as OrderDetail).Quantity;
            decimal b = (e.ListItem as OrderDetail).UnitPrice;

            e.Value = $" ProductName: {a},    Quantity: {b},     UnitPrice: {c}";


        }

        private void listBox1_Format_1(object sender, ListControlConvertEventArgs e)
        {
            string a = (e.ListItem as Product).ProductName;
            decimal? c = (e.ListItem as Product).UnitPrice;


            e.Value = $" ProductName: {a},     UnitPrice: {c}";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dataGridView1.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {

                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                    myRange.Select();


                }
            }


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
