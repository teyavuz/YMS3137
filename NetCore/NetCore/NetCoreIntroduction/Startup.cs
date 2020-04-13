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
        //Projeimizi ilk olu�turdu�umuzda bu proje bir mvc projesi olarak olu�turulmamaktad�r. Dor�udan Core projesidir. bizler burdaki servis metodu i�erisinde MVC projesi oldu�unu g�steren servisi �a��rd���mz�da bu proje bir mvc projesi olarak �al��acakt�r. 
        public void ConfigureServices(IServiceCollection services)
        {
            //Uygulamada kullan�lacak servisleri ve m�dolleri projeye dahil etmemiz gerekmektedir.
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //wwwroot isimli klas�re ula�abilmek i�in app.UseStaticFiles(); midleware eklememiz gerekmektedir.
            app.UseStaticFiles();
            app.UseRouting();

            //Custom olarak route tan�mlamas� i�in a�a��daki kodu kulland�k.
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
           
               //varsay�lan route yap�s�n�n en altta olmas�na dikkat edin.
               routes.MapRoute(
               name: "default",
               template: "{Controller=Home}/{Action=Index}/{id?}");
           });

            //E�er varsay�lam MVC routing tan�mlamas� (HomeController/Index) istenirse a�a��daki kodu kullanabilirsiniz.

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
