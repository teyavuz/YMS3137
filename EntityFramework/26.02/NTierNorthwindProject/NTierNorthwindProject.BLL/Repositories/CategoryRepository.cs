using NTierNorthwindProject.DAL.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierNorthwindProject.BLL.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        NorthwindEntities db = new NorthwindEntities();
        public void Add(Category item)
        {
            db.Categories.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Categories.Remove(SelectById(id));
        }

        public List<Category> SelectAll()
        {
            return db.Categories.ToList();
        }

        public Category SelectById(int id)
        {
            return db.Categories.Find(id);
        }

        public void Update(Category item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }

    }
}
