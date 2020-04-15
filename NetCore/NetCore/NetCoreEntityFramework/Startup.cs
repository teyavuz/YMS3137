using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NetCoreEntityFramework.Models.Context;
using Microsoft.EntityFrameworkCore;


namespace NetCoreEntityFramework
{
    public class Startup
    {
        
        public void ConfigureServices(IServiceCollection services)
        {
            //servis olarak MVC dahil ediyoruz.
            services.AddMvc(options=>options.EnableEndpointRouting=false);
            //Microsoft.EntityframeworkCore.SqlServer

            //Microsoft.EntityFrameworkCore.Design paketini y�kleyerek migration yap�s�n� kullanabiliriz.
            services.AddDbContext<AppDbContext>(options=>options.UseSqlServer("server=.;database=NetCoreEF;uid=sa;pwd=123"));
            //projenin ba�l� bulundu konum �zerinde komut dosyas�n� a�arak;
            //dotnet ef migrations add initialMigration 
            //dotnet ef database update komutunu kullanrak veritaban�n� olu�turuyoruz.
            //yukar�daki komutu yaz�p migration'� aktif hale getirmeliyiz.
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            //pipeline'a MVC varsay�lan route tan�mlamas�n� ger�ekle�tiriyoruz.
            app.UseMvcWithDefaultRoute();

            //wwwroot klas�r�n� eri�e a�mak i�in
            app.UseStaticFiles();

            //SeedData
            SeedData.Seed(app);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
