using NTierNorthwindProject.BLL.Repositories;
using NTierNorthwindProject.BLL.Repositories.Service;
using NTierNorthwindProject.DAL.MODEL;
using System;
using System.Linq;
using System.Windows.Forms;


namespace NTierNorthwindProject.WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductRepository productRepository = new ProductRepository();
        CategoryRepository categoryRepository = new CategoryRepository();
        SupplierRepository supplierRepository = new SupplierRepository();
        private void Form1_Load(object sender, EventArgs e)
        {
            #region Örnek Veri Ekleme
            //NorthwindEntities db = new NorthwindEntities();
            //Category category = new Category();
            //category.CategoryName = "Test 1";
            //category.Description = "Description 1";

            //db.Categories.Add(category);
            //db.SaveChanges();


            //dataGridView1.DataSource = db.Categories.ToList(); 
            #endregion

            //CategoryService categoryService = new CategoryService();
            //Category category = new Category();
            //category.CategoryName = "Test 1";
            //category.Description = "Description 1";

            //categoryService.Add(category);

            cmbKategori.DataSource = categoryRepository.SelectAll();
            cmbKategori.DisplayMember = "CategoryName";
            cmbKategori.ValueMember = "CategoryId";

            cmbTedarikci.DataSource = supplierRepository.SelectAll();
            cmbTedarikci.DisplayMember = "CompanyName";
            cmbTedarikci.ValueMember = "SupplierId";

        }
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductName = txtUrunAd.Text;
            product.UnitPrice = nudFiyat.Value;
            product.UnitsInStock = Convert.ToInt16(nudStok.Value);
            int categoryId = (int)cmbKategori.SelectedValue;
            product.CategoryID = categoryRepository.SelectById(categoryId).CategoryID;
            int supplierId = (int)cmbTedarikci.SelectedValue;
            product.SupplierID = supplierRepository.SelectById(supplierId).SupplierID;

            productRepository.Add(product);
        }
    }
}
