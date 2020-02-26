using NTierNorthwindProject.DAL.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierNorthwindProject.BLL.Repositories
{
    public class SupplierRepository : IRepository<Supplier>
    {
        NorthwindEntities db = new NorthwindEntities();
        public void Add(Supplier item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Supplier> SelectAll()
        {
            return db.Suppliers.ToList();
        }

        public Supplier SelectById(int id)
        {
            return db.Suppliers.Find(id);
        }

        public void Update(Supplier item)
        {
            throw new NotImplementedException();
        }
    }
}
