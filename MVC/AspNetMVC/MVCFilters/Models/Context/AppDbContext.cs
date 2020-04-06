using MVCFilters.Models.Entity;
using System.Data.Entity;//DbContext(Entityframework)

namespace MVCFilters.Models.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {
            Database.Connection.ConnectionString = "server=.;database=MVCFilterDB;uid=sa;pwd=123";
        }

        //tablolar arasında herhangi bir ilişki bulunmuyor.
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Log> Logs { get; set; }

    }
}