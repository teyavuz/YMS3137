using NetCoreDependencyInjection.Models.Abstract;
using NetCoreDependencyInjection.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreDependencyInjection.Models.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public List<Category> Categories()
        {
            List<Category> categories = new List<Category>()
           {
               new Category{CategoryID=1,CategoryName="İçecek"}
           };
            return categories;
        }
    }
}
