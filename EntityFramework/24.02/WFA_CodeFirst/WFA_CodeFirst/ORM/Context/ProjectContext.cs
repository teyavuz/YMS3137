using System;
using System.Collections.Generic;
using System.Data.Entity;//DbContext sınıfına ulaşabilmek için kullandığımız kütüphane. Bu kütüphaneyi çağırabilmemiz için EntityFramework kurulu olması gerekir. <Nuget Package Manager>
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_CodeFirst.ORM.Entity;

namespace WFA_CodeFirst.ORM.Context
{
    public class ProjectContext:DbContext
    {
        //ProjectContext nesnesinden bir örnek alındığı anda aşağıda tanımlamış olduğumuz constructor tetiklenerek içerisinde barındırdığı connectionString (bağlantı cümlesi) bağlantı işlemini gerçekleştirecek.
        public ProjectContext()
        {
            Database.Connection.ConnectionString = "server=.;database=CodeFirstDB;uid=sa;pwd=123";
        }
        



        //DbSet<> generic bir tip olduğu için dışarıdan almış olduğu nesneyi connection string içerisinde tanımlanan veritabanında tablo haline getirir.

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products{ get; set; }


    }
}
