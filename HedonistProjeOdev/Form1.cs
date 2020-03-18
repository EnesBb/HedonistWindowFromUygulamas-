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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        HedonistDBEntities entities = DBTool.DBInstance;



        public void Listele()
        {
            #region ListelemeYontemleri





            lst_Urunler.DataSource = entities.Products.ToList();
            lst_Urunler.DisplayMember = "ProductName";

            cmb_Marka.DataSource = entities.Brands.ToList();
            cmb_Marka.DisplayMember = "BrandName";
            cmb_Marka.ValueMember = "BrandID";

            cmb_Kategori.DataSource = entities.Categories.ToList();
            cmb_Kategori.DisplayMember = "CategoryName";
            cmb_Kategori.ValueMember = "CategoryID";
            lst_Urunler.SelectedIndex = -1;
            #endregion
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
            dataGridView1.DataSource = entities.OrderDetails.Select(x => new
            {
                x.OrderID,
                x.Order.UserID,
                x.Order.Users1.UserName,
                x.Product.ProductName,
                x.Product.Category.CategoryName,
                x.UnitPrice,
                x.Quantity

            }).ToList();
        }
        Product product;
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            
            Product product = new Product();
            product.ProductName = txt_Urun.Text;
            product.CategoryID = (cmb_Kategori.SelectedItem as Category).CategoryID;
            product.BrandID = (cmb_Marka.SelectedItem as Brand).BrandID;

            product.UnitPrice = Convert.ToDecimal(txt_Fiyat.Text);

            entities.Products.Add(product);
            entities.SaveChanges();
            Listele();

        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            //OrderDetail detail = new OrderDetail();

            product = (lst_Urunler.SelectedItem as Product);
            if (lst_Urunler.SelectedItem == null)
            {
                MessageBox.Show("Test");

            }
            else
            {
                DialogResult sor = new DialogResult();

                sor = MessageBox.Show("Silmek istiyormusunuz ?", "Uyarı", MessageBoxButtons.YesNo);

                if (sor == DialogResult.Yes)
                {
                    entities.Products.Remove(product);
                    entities.SaveChanges();
                    Listele();

                }

            }
        }
  
        private void lst_Urunler_Click(object sender, EventArgs e)
        {
            product = lst_Urunler.SelectedItem as Product;
            
            try
            {
                txt_Urun.Text = product.ProductName;
                txt_Fiyat.Text = product.UnitPrice.ToString();
                cmb_Kategori.SelectedValue = product.CategoryID;
                cmb_Marka.SelectedValue = product.BrandID;
            }
            catch (Exception)
            {

                cmb_Marka.SelectedIndex = -1;
                cmb_Kategori.SelectedIndex = -1;
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            DialogResult guncelle = new DialogResult();

            guncelle = MessageBox.Show("Güncellemek istiyormusunuz ?", "Uyarı", MessageBoxButtons.YesNo);

            if (guncelle == DialogResult.Yes)
            {
                try
                {


                    product.ProductName = txt_Urun.Text;
                    product.UnitPrice = Convert.ToDecimal(txt_Fiyat.Text);
                    product.BrandID = (cmb_Marka.SelectedItem as Brand).BrandID;
                    product.CategoryID = (cmb_Kategori.SelectedItem as Category).CategoryID;
                    entities.SaveChanges();
                }
                catch (NullReferenceException)
                {

                    MessageBox.Show("Kategori veya Marka İsmi Listeden Seçilmelidir.");
                }

                finally
                {
                    Listele();
                }

            }

        }

        private void lst_Urunler_Format(object sender, ListControlConvertEventArgs e)
        {
            string urunad = (e.ListItem as Product).ProductName;
            decimal? urunfiyat = (e.ListItem as Product).UnitPrice;
            string categoriadi = (e.ListItem as Product).Category.CategoryName;
            string markaadi = (e.ListItem as Product).Brand.BrandName;

            e.Value = $"Ürün Adı : {urunad}   /* {categoriadi}       {markaadi}  */    {urunfiyat:C2}";
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = entities.OrderDetails.Where(c => c.Product.ProductName.Contains(textBox1.Text)).Select(x => new
            {
                x.OrderID,
                x.Order.UserID,
                x.Order.Users1.UserName,
                x.Product.ProductName,
                x.Product.Category.CategoryName,
                x.UnitPrice,
                x.Quantity

            }).ToList();
        }

        private void btn_azalan_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = entities.OrderDetails.OrderByDescending(x => x.UnitPrice).Select(x => new
            {
                x.OrderID,
                x.Order.UserID,
                x.Order.Users1.UserName,
                x.Product.ProductName,
                x.Product.Category.CategoryName,
                x.UnitPrice,
                x.Quantity

            }).ToList();
        }

        private void btn_varsayılan_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = entities.OrderDetails.Select(x => new
            {
                x.OrderID,
                x.Order.UserID,
                x.Order.Users1.UserName,
                x.Product.ProductName,
                x.Product.Category.CategoryName,
                x.UnitPrice,
                x.Quantity

            }).ToList();
        }
    }
}
