using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace NetCoreIntroduction
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder isimli metodu çaðýrarak bir host inþa etmek ve bunu çalýþtýrmaktayýz. Burda bulunan CreateHostBuilder metodu Startup.cs içerisinde bulunan yapýyý tetikleyerek kullanýlacak host yapýlandýrmasýný ayaða kaldýrýr.
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
