using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_CodeFirstSamples.ORM.Entity;
using WFA_CodeFirstSamples.ORM.Entity.ManyToMany;
using WFA_CodeFirstSamples.ORM.Entity.OneToMany;

namespace WFA_CodeFirstSamples.ORM.Context
{
    //entityframework'u dilerseniz package manager console içerisinde "install-package entityframework" yazdıktan sonra projeye dahil edebilirsiniz.
    public class ProjectContext:DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = "server=.;database=CodeFirstSampleDB;uid=sa;pwd=123";
        }
        //"enable-migrations -enableautomaticmigration" => Migration içerisindeki Configuration.cs de bulunan automaticmigration özelliğini oluştururken "true" olarak tanımlanmasını sağlar.

        //Tables
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Entity Splitting: AppUser için tek bir tablo oluşturmak yerine 2 tabloya ayırıyoruz. Tablolardan birisinde kullanıcı hakkında bağlantı bilgilerini tutarken diğerinde hesap bilgilerini tutacağız. Bunu "OnModelCreating" metodunu override ederek sağlıyoruz. Bu ayar sonucunda 1'e 1 bağlanmış 2 tablo oluşturulacak. Ancak C# tarafında hala tek bir class objesi üzerinden işlem yapılacaktır.
            modelBuilder.Entity<AppUser>().Map(map =>
            {
                map.Properties(p => new
                {
                    p.ID,
                    p.UserName,
                    p.Password
                });
                map.ToTable("UserAccountInfo");
            }).Map(map =>
            {
                map.Properties(p => new
                {
                    p.ID,
                    p.FirstName,
                    p.LastName,
                    p.Email,
                    p.PhoneNumber,
                    p.Address,
                    p.Gender,
                    p.BirthDate
                });
                map.ToTable("UserAccountDetail");
            });

            //Many To Many
            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.Students)
                .WithMany(s => s.Teachers)
                .Map(map =>
                {
                    map.ToTable("TeacherStudents");
                    map.MapLeftKey("TeacherID");
                    map.MapRightKey("StudentID");
                });



            base.OnModelCreating(modelBuilder);
        }

        
    }
}
