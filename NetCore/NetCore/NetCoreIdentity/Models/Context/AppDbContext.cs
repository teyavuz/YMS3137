using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NetCoreIdentity.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreIdentity.Models.Context
{
    //Bundan önceki projelerimizi DbContext sınıfından miras alarak tanımlıyorduk ancak varsayılan bir kullanıcı tablosu ile veritabanımızı oluşturmak istediğimizde IdentityDbContext<> sınıfından türetmemiz gerekmektedir. IdentityDbContext<>  generic olduğu için <> içerisine hangi kullanıcı nesnesinin özelliklerini yüklemek istiyorsak tanımlamamız gerekmektedir. 
    //IdentityDbContext<>  kullanmak için projemize Microsoft.AspNetCore.Identity.EntityFramworkCore kütüphanesini kurmamız gerekmektedir.
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        //constructor da AppDbContext'i ram üzerine çıkarıyoruz. Fakat bu işlem StartUp.cs içerisindeki service kısmında dahil ediliyor.

        //Microsoft.EntityFrameworkCore
        //Microsoft.EntityFrameworkCore.SqlServer
        //Microsoft.EntityFrameworkCore.Design
        //Microsoft.EntityFrameworkCore.Tools

        //yukarıdaki kütüphaneleri package manager üzerinden install yaptıktan sonra proje konumunu açarak konsol ekranında;
        //dotnet ef migrations add initial
        //dotnet ef database update
        //komutlarını çalıştırın.
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}

        //public DbSet<AppUser> AppUsers { get; set; }

        
    }
}
