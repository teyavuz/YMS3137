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
            //CreateHostBuilder isimli metodu �a��rarak bir host in�a etmek ve bunu �al��t�rmaktay�z. Burda bulunan CreateHostBuilder metodu Startup.cs i�erisinde bulunan yap�y� tetikleyerek kullan�lacak host yap�land�rmas�n� aya�a kald�r�r.
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
