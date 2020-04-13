using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace NetCoreIntroduction
{
    public class Startup
    {
        //Projeimizi ilk oluþturduðumuzda bu proje bir mvc projesi olarak oluþturulmamaktadýr. Dorðudan Core projesidir. bizler burdaki servis metodu içerisinde MVC projesi olduðunu gösteren servisi çaðýrdýðýmzýda bu proje bir mvc projesi olarak çalýþacaktýr. 
        public void ConfigureServices(IServiceCollection services)
        {
            //Uygulamada kullanýlacak servisleri ve müdolleri projeye dahil etmemiz gerekmektedir.
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //wwwroot isimli klasöre ulaþabilmek için app.UseStaticFiles(); midleware eklememiz gerekmektedir.
            app.UseStaticFiles();
            app.UseRouting();

            //Custom olarak route tanýmlamasý için aþaðýdaki kodu kullandýk.
            app.UseMvc(routes =>
           {


               //routes.MapRoute(
               //    name: "Contact",
               //    template: "{Controller=Home}/{Action=Contact}"
               //    );

               routes.MapRoute(
                   name: "ProductRoute",
                   template: "SelectedProduct/{ProductName}/{ProductId}",
                   defaults: new { controller = "Product", action = "GetProduct" }
                   );

               routes.MapRoute(
                  name: "ProductCategoryRoute",
                  template: "SelectedProductCategory/{CategoryName}/{categoryId}",
                  defaults: new { controller = "Product", action = "GetProducts" }
                  );

               routes.MapRoute(
                   name: "CategoryRoute",
                   template: "SelectedCategory/{CategoryName}/{CategoryID}",
                   defaults: new { controller = "Category", action = "GetCategory" }
                   );
           
               //varsayýlan route yapýsýnýn en altta olmasýna dikkat edin.
               routes.MapRoute(
               name: "default",
               template: "{Controller=Home}/{Action=Index}/{id?}");
           });

            //Eðer varsayýlam MVC routing tanýmlamasý (HomeController/Index) istenirse aþaðýdaki kodu kullanabilirsiniz.

            //app.UseMvc();
            /*
            Controller=Home
            Action=Index 
            */

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync(".Net Core Dersleri");
                });
            });


        }
    }
}
