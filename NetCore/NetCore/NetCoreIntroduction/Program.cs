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
            //CreateHostBuilder isimli metodu çağırarak bir host inşa etmek ve bunu çalıştırmaktayız. Burda bulunan CreateHostBuilder metodu Startup.cs içerisinde bulunan yapıyı tetikleyerek kullanılacak host yapılandırmasını ayağa kaldırır.
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
