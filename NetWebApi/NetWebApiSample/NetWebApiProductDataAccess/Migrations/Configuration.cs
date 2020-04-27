namespace NetWebApiProductDataAccess.Migrations
{
    using NetWebApiProductDataAccess.Models.Entity;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NetWebApiProductDataAccess.Models.Context.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(NetWebApiProductDataAccess.Models.Context.AppDbContext context)
        {

            if (!context.Products.Any())
            {
                List<Product> products = new List<Product>()
                {
                    new Product{ProductName="Kola",UnitPrice=15,UnitsInStock=200},
                    new Product{ProductName="Fanta",UnitPrice=10,UnitsInStock=200},
                    new Product{ProductName="Kola",UnitPrice=5,UnitsInStock=200}
                };

                foreach (var p in products)
                {
                    context.Products.Add(p);
                }
            }
        }
    }
}
