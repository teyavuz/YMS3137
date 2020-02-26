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


        }
    }
}
