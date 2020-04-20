using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NetCoreIdentity.Models.Context;
using NetCoreIdentity.Models.Entity;

namespace NetCoreIdentity
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            //ilk olarak projeye MVC servisini dahil ediyoruz.
            services.AddMvc(x=>x.EnableEndpointRouting=false);
            //olu�turmu� oldu�umuz Context'in instance(�rne�ini) AddDbContext metodunu kullanarak servis alan�nda al�yoruz. DefaultConnection olarak tan�mlanan yap� appsettins.json i�erisinde gelmektedir.
            services.AddDbContext<AppDbContext>(x => x.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();
        }

     
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            //wwwroot klas�r�n� d��ar�dan eri�ime a��yoruz.
            app.UseStaticFiles();
            //servis taraf�nda eklemi� oldu�umuz MVC yap�s�na bir route tan�mlamas� ger�ekle�tiriyoruz.
            app.UseMvc(routes=>{
                routes.MapRoute(
                    name: "default",
                    template: "{controller=home}/{action=index}/{id?}"
                    );
            });
            //app.UseMvcWithDefaultRoute();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});
        }
    }
}
