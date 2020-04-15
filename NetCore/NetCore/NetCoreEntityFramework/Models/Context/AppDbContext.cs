using Microsoft.EntityFrameworkCore;
using NetCoreEntityFramework.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreEntityFramework.Models.Context
{
    public class AppDbContext:DbContext
    {
        //eğer db first yaklaşımı ile veritabanı yansımasını almak isterseniz package manager console tarafına
        //Scaffold-DbContext "Server=.;Database=Northwind;uid=sa;pwd=123;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public virtual DbSet<Product> Products { get; set; }
    }
}
