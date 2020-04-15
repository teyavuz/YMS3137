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

            //Microsoft.EntityFrameworkCore.Design paketini yükleyerek migration yapýsýný kullanabiliriz.
            services.AddDbContext<AppDbContext>(options=>options.UseSqlServer("server=.;database=NetCoreEF;uid=sa;pwd=123"));
            //projenin baðlý bulundu konum üzerinde komut dosyasýný açarak;
            //dotnet ef migrations add initialMigration 
            //dotnet ef database update komutunu kullanrak veritabanýný oluþturuyoruz.
            //yukarýdaki komutu yazýp migration'ý aktif hale getirmeliyiz.
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            //pipeline'a MVC varsayýlan route tanýmlamasýný gerçekleþtiriyoruz.
            app.UseMvcWithDefaultRoute();

            //wwwroot klasörünü eriþe açmak için
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
