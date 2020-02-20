using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_EFSorgular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NorthwindEntities db = new NorthwindEntities();

        private void Form1_Load(object sender, EventArgs e)
        {
            //Entity Framework

            /*
                3 yaklaşım
                    --DBFirst
                        --ORM (Object Relational Mapping)
                            --Veritabanında bulunan tabloları class haline ve tablo içerisindeki kolonları da property haline dönüştüren teknoloji.
                    --CodeFirst
                        -- tamamen kod taraflı veritabanı oluşturma ve veritabanına ulaşma..
                    --ModelFirst

             */
        }

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            //--Fiyatı 20 ile 50 arasında olan ürünlerin id, ürün adı, fiyatı, stok miktarı, kategori adını getiren sorguyu yazınız.

            //T-Sql Sorgusu
            /*
             select p.ProductID,p.ProductName,p.UnitPrice,p.UnitsInStock,c.CategoryName from Products p
inner join Categories c
on p.CategoryID=c.CategoryID
where p.UnitPrice between 20 and 50
             */


            //Linq To Sql

            //var result = from p in db.Products
            //             where p.UnitPrice > 20 && p.UnitPrice < 50
            //             orderby p.UnitPrice descending
            //             select new
            //             {
            //                ÜrünID= p.ProductID,
            //                ÜrünAdı= p.ProductName,
            //                ÜrünFiyat= p.UnitPrice,
            //                ÜrünStok= p.UnitsInStock,
            //                KategoriAdı=p.Category.CategoryName
            //             };
            //dataGridView1.DataSource = result.ToList();


            //Linq To Entity

            //Lambda Calculus

            var result = db.Products.Where(p => p.UnitPrice > 20 && p.UnitPrice < 50).Select(p => new
            {
                ÜrünID = p.ProductID,
                ÜrünAdı = p.ProductName,
                ÜrünFiyat = p.UnitPrice,
                ÜrünStok = p.UnitsInStock,
                KategoriAdı = p.Category.CategoryName
            }).ToList();

            dataGridView1.DataSource = result;





        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            //Siparişler tablosundan Müşteri şirket adı, çalışan adı ve soyadı, sipariş ıd, sipariş tarihi ve kargo şirket adını getiren sorgu.

            //T-Sql
            /*
             select c.CompanyName,e.FirstName, e.LastName,o.OrderID,o.ShippedDate,s.CompanyName from Orders o
                join Employees e on o.EmployeeID=e.EmployeeID
                join Customers c on c.CustomerID=o.CustomerID
            join Shippers s on s.ShipperID=o.ShipVia
             */

            //Linq To Sql
            //var result = from o in db.Orders
            //             select new
            //             {
            //                 o.Customer.CompanyName,
            //                 ÇalışanAdıSoyadı = o.Employee.FirstName + " " + o.Employee.LastName,
            //                 o.OrderID,
            //                 o.ShippedDate,
            //                KargoŞirketi= o.Shipper.CompanyName,
            //             };
            //dataGridView1.DataSource = result.ToList();

            //Linq To Entity
            var result = db.Orders.Select(o => new
            {
                o.Customer.CompanyName,
                ÇalışanAdıSoyadı = o.Employee.FirstName + " " + o.Employee.LastName,
                o.OrderID,
                o.ShippedDate,
                KargoŞirketi = o.Shipper.CompanyName
            });
            dataGridView1.DataSource = result.ToList();
        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            //Müşteriler tablosu içerisinde CompanyName kolonunda "restaurant" geçen müşterileri listeleyin.

            //T-Sql
            //select * from Customers where CompanyName like '%restaurant%'

            //Linq To Sql
            //var result = from c in db.Customers where c.CompanyName.Contains("restaurant") select c;
            //dataGridView1.DataSource = result.ToList();

            //Linq To Entity
            dataGridView1.DataSource = db.Customers.Where(x => x.CompanyName.Contains("restaurant")).ToList();


            //Not: Detaylı anlatım için https://www.entityframeworktutorial.net/
        }

        private void btnOrnek4_Click(object sender, EventArgs e)
        {
            //Kategorisi Beverages olan ve ürün adı "Armut" fiyatı 10, stok adeti 500 olan ürünü ekleyin.

            //Product product = new Product();
            //product.ProductName = "Armut";
            //product.UnitPrice = 10;
            //product.UnitsInStock = 500;

            //int catId = db.Categories.FirstOrDefault(x => x.CategoryName == "beverages").CategoryID;

            //product.CategoryID = catId;
            //db.Products.Add(product);
            //db.SaveChanges();
            //MessageBox.Show("Ürün Eklendi");

            //Object Initializer

            db.Products.Add(
                new Product
                {
                    ProductName = "Elma",
                    UnitPrice = 5,
                    UnitsInStock = 1000,
                    CategoryID = db.Categories.FirstOrDefault(x => x.CategoryName == "beverages").CategoryID
                }
                );
            db.SaveChanges();



        }
    }
}
