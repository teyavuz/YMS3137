using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Abstract;
using BLL.Service;
using DAL.Context;
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

            app.UseRouting();

            app.UseAuthorization();

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
