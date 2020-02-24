using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_EFUrunEkleme
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
            #region Yapılacaklar
            //DbFirst kullanarak Northwind veritabanı yansımasını projeye dahil ediniz.

            //Formu kullanarak yeni bir ürün ekleyin.

            //Ara isimli textbox içerisine yazılan kelime ile ürünlerde eşleştirme yapma (Arama işlemi)

            //Fiyata göre artan radio butonuna tıklandığında fiyatı en az olandan en fazla olana kadar listeleme

            //Fiyata göre azalan radio butonuna tıklandığında fiyatı en fazla olandan en az olana kadar listeleme işlemi 
            #endregion

            UrunListele();
            ComboBoxDoldur();
            

        }

        void UrunListele()
        {
            dataGridView1.DataSource = db.Products.OrderByDescending(x => x.ProductID).ToList();
        }

        void ComboBoxDoldur()
        {
            cmbKategori.DataSource = db.Categories.ToList();
            cmbKategori.DisplayMember = "CategoryName";//Condiments
            cmbKategori.ValueMember = "CategoryId";//2

            cmbTedarikci.DataSource = db.Suppliers.ToList();
            cmbTedarikci.DisplayMember = "CompanyName";
            cmbTedarikci.ValueMember = "supplierId";
        }
       
        void UrunEkle()
        {
            Product product = new Product();
            product.ProductName = txtUrunAd.Text;
            product.UnitPrice = nudFiyat.Value;
            product.UnitsInStock = Convert.ToInt16(nudStok.Value);
            product.CategoryID = (int)cmbKategori.SelectedValue;
            product.SupplierID = (int)cmbTedarikci.SelectedValue;

            db.Products.Add(product);
            if (db.SaveChanges() > 0)
            {
                //MessageBox.Show(string.Format("{0} ürün başarılı bir şekilde kaydedildi",product.ProductName));
                MessageBox.Show($"{product.ProductName} ürün başarılı bir şekilde kaydedildi");
            }
            else
            {
                MessageBox.Show("Bir şeyler oldu!");
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            UrunEkle();
            UrunListele();

        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string metin = txtAra.Text;
            dataGridView1.DataSource= db.Products.Where(x => x.ProductName.Contains(metin)).ToList();
        }

        private void rbArtan_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource= db.Products.OrderBy(x => x.UnitPrice).ToList();
            MessageBox.Show("Ürünler fiyata göre artan şelilde listeleniyor");
        }

        private void rbAzalan_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.OrderByDescending(x => x.UnitPrice).ToList();
            MessageBox.Show("Ürünler fiyata göre azalan şelilde listeleniyor");
        }
    }
}
