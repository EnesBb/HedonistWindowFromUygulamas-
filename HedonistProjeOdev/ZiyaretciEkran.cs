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
    public partial class ZiyaretciEkran : Form
    {
        public ZiyaretciEkran()
        {
            InitializeComponent();
        }
         public  void Lİstele()
        {
            dataGridView1.DataSource = entities.Products.Select(t => new
            {
                t.ProductName,
                t.Category.CategoryName,
                t.UnitPrice,
                t.Brand.BrandName


            }).ToList();
        }
        Random rnd = new Random();
        HedonistDBEntities entities = DBTool.DBInstance;
        private void ZiyaretciEkran_Load(object sender, EventArgs e)
        {
         
            timer1.Start();
            timer1.Enabled = true;
            timer1.Interval = 1000;

            Lİstele();
            dataGridView1.DataSource = entities.Products.Select(t=>new
            {
              t.ProductName,
              t.Category.CategoryName,
              t.UnitPrice,
              t.Brand.BrandName


            }).ToList();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int a = rnd.Next(0, 255);
            label2.ForeColor = Color.FromArgb(a);
            label2.Visible = !(label2.Visible); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = entities.OrderDetails.OrderByDescending(x => x.UnitPrice).Select(x => new
            {
               x.Product.ProductName,
               x.Product.Category.CategoryName,
               x.UnitPrice,
               x.Product.Brand.BrandName

            }).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = entities.OrderDetails.OrderBy(x => x.UnitPrice).Select(x => new
            {
                x.Product.ProductName,
                x.Product.Category.CategoryName,
                x.UnitPrice,
                x.Product.Brand.BrandName

            }).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lİstele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OrderDetail order = new OrderDetail();
            
                dataGridView1.DataSource = entities.OrderDetails.Where(x => x.Quantity >=3).Select(x => new
                {

                    x.Product.ProductName,
                    x.Product.Category.CategoryName,
                    x.UnitPrice,
                    x.Product.Brand.BrandName

                }).ToList();
                    
         
        }
    }
}
