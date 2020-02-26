using NTierNorthwindProject.DAL.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierNorthwindProject.BLL.Repositories
{
    //aşağıda tanımlamış olduğumuz interface dışarıdan bir tip alacağını (generic) belirttik. Bu tip herhangi bir tip olabilir. Almış olduğu tip ile beraber T artık o tipin kendisi olacaktır. Örneği incelemek için (bknz.CategoryRepository.cs)
    public interface IRepository<T>//Örneğin T Category ise;
    {
        void Add(T item);//T=> Category
        void Update(T item);//T=> Category
        void Delete(int id);
        List<T> SelectAll();//List<T>=> List<Category>
        T SelectById(int id);//T=> Category



    }
}
