using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFTekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ETicaretEntities db = new ETicaretEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            //EntityFramework
            /*
              1-Db First
              2-Code First
              3-Model First
             */
            ProductList();
            CategoryList();
            SupplierList();
        }

        public void ProductList()
        {
            foreach (Product p in db.Products.ToList())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = p.ID.ToString();
                lvi.SubItems.Add(p.ProductName);
                lvi.SubItems.Add(p.UnitPrice.ToString());
                lvi.SubItems.Add(p.UnitsInStock.ToString());
                lvi.SubItems.Add(p.Category.CategoryName);
                lvi.SubItems.Add(p.Supplier.CompanyName);
                lvi.Tag = p.ID;
                listView1.Items.Add(lvi);

            }
        }

        public void CategoryList()
        {
            comboBox1.DataSource = db.Categories.ToList();
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "ID";
            comboBox1.SelectedIndex = -1;
        }

        public void SupplierList()
        {
            cmbTedarikci.DataSource = db.Suppliers.ToList();
            cmbTedarikci.DisplayMember = "CompanyName";
            cmbTedarikci.ValueMember = "ID";
            cmbTedarikci.SelectedIndex = -1;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        public void AddProduct()
        {
            listView1.Items.Clear();
            Product p = new Product();
            p.ProductName = txtUrunAd.Text;
            p.UnitPrice = nudFiyat.Value;
            p.UnitsInStock = Convert.ToInt32(nudStok.Value);
            p.CategoryId = (int)comboBox1.SelectedValue;
            p.SupplierId = (int)cmbTedarikci.SelectedValue;
            db.Products.Add(p);
            db.SaveChanges();
            ProductList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
            int id = Convert.ToInt32(listView1.SelectedItems[0].Tag);
            Product deleted = db.Products.Find(id);
            db.Products.Remove(deleted);
            db.SaveChanges();
            listView1.Items.Clear();
            ProductList();
        }
        Product updated;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(listView1.SelectedItems[0].Tag);
            updated = db.Products.Find(id);
            txtUrunAd.Text = updated.ProductName;
            cmbTedarikci.SelectedValue = updated.SupplierId;
            comboBox1.SelectedValue = updated.CategoryId;
            nudFiyat.Value = updated.UnitPrice;
            nudStok.Value = Convert.ToDecimal(updated.UnitsInStock);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count <= 0 && updated == null) return;
            updated.ProductName = txtUrunAd.Text;
            updated.UnitPrice = nudFiyat.Value;
            updated.UnitsInStock =Convert.ToInt32( nudStok.Value);
            comboBox1.SelectedValue = updated.CategoryId;
            cmbTedarikci.SelectedValue = updated.SupplierId;

            //güncelleme işlemini gerçekleştirir.
            db.Entry(db.Products.Find(updated.ID)).CurrentValues.SetValues(updated);
            db.SaveChanges();
            ProductList();
        }
    }
}
