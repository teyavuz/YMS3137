using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;//bu kütüphane DbContext nesnesini barındıran kütüphanedir.
using CodeFirstSample2.Entity;

namespace CodeFirstSample2.Context
{
    public class CodeFirstContext:DbContext
    {
        //Constructor => Yapıcı Metot.

        /*
         Nuget Package manager ile entityframework projeye dahil edilir.
         Entity ve Context isminde klasörler oluşturulur.
         Entity klasörü içerisinde tablo haline gelecek olan classlar tanımlanır.
         Context klasörüsü içerisine ContextClassı oluşturulur.
         Context classı System.Data.Entity kütüphanesi ile birlikte DBContext classından miras alır.
         tablo haline gelmesini istediğimiz classlar DbSet<Product> şeklinde propertyler tanımlanırç.
         Nuget Console açılarak "enable-migrations" komutu yazılır
         Son olarak yine console ekranın "update-database" yazılarak veritabanı oluşturulur.
         */
        public CodeFirstContext()
        {
            Database.Connection.ConnectionString = "server=.;database=codefirstsample2;uid=sa;pwd=123";
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        //Fluent Api.
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
