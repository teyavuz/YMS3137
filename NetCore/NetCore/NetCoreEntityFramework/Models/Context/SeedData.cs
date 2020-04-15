using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NetCoreEntityFramework.Models.Entity;

namespace NetCoreEntityFramework.Models.Context
{
    
    public class SeedData
    {
        //Bu metot IApplicationBuilder tipinde bir interface alacaktır. Bu interface Microsoft.AspNetCore.Builder altında bulunmaktadır.
        public static void Seed(IApplicationBuilder app)
        {
            //using bloğunu middleware'de servis dışında kalmamak için kullanıyoruz. Middleware yapısı sadece singleyon yapıları desteklemektedir. Servis yapısını seek classı içerisinde kullanmak için using bloğuna ihtiyacımız bulunmaktadır.
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                //Veritabanı işlemlerini yapabilmek amacıyla  AppDbContext'den bir instance almamız gerekmektedir. Bu referansı app üzerinden alıyoruz..
                //App nesnesi uygulama içerisinde middleware komponentlerini tanıtmak için kullanılır.

                
                AppDbContext context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                //Bu komut inital ismi ile oluşturulan migration dosyasını çalıştırır.
                context.Database.Migrate();
                //Product tablosunda veri var mı? eğer daha önce oluşturulmuş bir veri yoksa işlemleri yap.
                if (!context.Products.Any())
                {
                    context.Products.AddRange(
                        new Product { ProductName = "Chai", UnitPrice = 18m },
                        new Product { ProductName = "Chang", UnitPrice = 18m },
                        new Product { ProductName = "Tofu", UnitPrice = 10m },
                        new Product { ProductName = "Ikura", UnitPrice = 15m }
                        );
                }
                context.SaveChanges();
            }
        }
    }
}
