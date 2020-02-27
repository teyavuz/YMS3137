using NTierMovieProject.DAL.ORM.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierMovieProject.BLL.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : class //Actor//Category//Movie
    {
        MovieDBContext db = new MovieDBContext();
        public void Add(T item)
        {
            db.Set(typeof(T)).Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var deleted = db.Set(typeof(T)).Find(id);
            db.Set(typeof(T)).Remove(deleted);
            db.SaveChanges();
        }

        public List<T> SelectAll()
        {
            return db.Set(typeof(T)).Cast<T>().ToList();
        }

        public T SelectById(int id)
        {
            return db.Set(typeof(T)).Cast<T>().Find(id);
        }

        public void Update(T item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
