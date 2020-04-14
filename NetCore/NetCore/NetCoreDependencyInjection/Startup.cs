using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NetCoreDependencyInjection.Models;
using NetCoreDependencyInjection.Models.Abstract;

namespace NetCoreDependencyInjection
{
    public class Startup
    {
      
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options=>options.EnableEndpointRouting=false);
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<ICategoryRepository, ICategoryRepository>();
            //AddTransient 100 100
            //AddScoped 1 100
            //AddSingleton 1 => 1
        }

       
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseMvcWithDefaultRoute();
            app.UseStaticFiles();

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
