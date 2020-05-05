using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Abstract;
using BLL.Service;
using DAL.Context;
using DAL.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

//install-package Microsoft.EntityFrameworkCore.SqlServer
//install-package Microsoft.EntityFrameworkCore.Design
//install-package Microsoft.EntityFrameworkCore.Tools

    /*
     yukar�daki k�t�phaneleri y�kledikten sonra Package manager console �zerinden add-migration komutu yaz�l�p bizden bu migration'a bir isim isteyecek. Migration ismini tan�mlad�ktan sonra e�er herhangi hata almadan migration i�lemi ba�ar�l� �ekilde tan�mlan�rsa ard�ndan update-database komutu ile veritaban� olu�turulur.
     */
namespace MVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

       
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            //DbConnection
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),b => b.MigrationsAssembly("MVC")));

            //Entity Services
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddIdentity<AppUser, AppUserRole>(x =>
            {
                x.Password.RequiredLength = 6;
                x.Password.RequireDigit = false;
                x.Password.RequireLowercase = false;
                x.Password.RequireUppercase = false;
                x.Password.RequireNonAlphanumeric = false;
            }).AddEntityFrameworkStores<AppDbContext>();
            //cookie
            services.ConfigureApplicationCookie(x =>
            {
                x.Cookie = new Microsoft.AspNetCore.Http.CookieBuilder
                {
                    Name = "Login",
                    HttpOnly = false
                   
                };
                x.SlidingExpiration = true;
                x.ExpireTimeSpan = TimeSpan.FromMinutes(5);
            });

            //session
            services.AddSession(x =>
            {
                x.Cookie.Name = "Cart.Session";
                x.IdleTimeout = TimeSpan.FromMinutes(5);

            });
        }

      
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
          
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthentication();//kimlik do�rulama

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "area",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
