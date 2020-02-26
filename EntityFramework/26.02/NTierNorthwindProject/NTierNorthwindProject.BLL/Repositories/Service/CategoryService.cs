using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTierNorthwindProject.DAL.MODEL;

namespace NTierNorthwindProject.BLL.Repositories.Service
{
    public class CategoryService
    {
        NorthwindEntities db = new NorthwindEntities();

        //Ekleme

        public void Add(Category category)
        {
            if (category != null)
            {
                db.Categories.Add(category);
                db.SaveChanges();
            }

        }

        //Delete
        public void Delete(int categoryId)//11
        {
            //var silinecek= db.Categories.Find(categoryId);
            var silinecek = SelectById(categoryId);
            if (silinecek != null)
            {
                db.Categories.Remove(silinecek);
                db.SaveChanges();
            }
        }

        //Update
        public void Update(Category category)
        {
            //Todo: İşlemi kontrol et.
            //var guncellenecek = db.Categories.Find(category.CategoryID);//10

            //guncellenecek.CategoryName = category.CategoryName;
            //guncellenecek.Description = category.Description;



            db.Entry(category).State = System.Data.Entity.EntityState.Modified;

            db.SaveChanges();

        }

        //Listeleme

        public List<Category> SelectAll()
        {
            return db.Categories.ToList();
        }

        //Tekil veri getirme

        public Category SelectById(int id)
        {
            return db.Categories.Find(id);
        }


    }
}
