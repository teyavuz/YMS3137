using NetWebApiProductDataAccess.Models.Context;
using NetWebApiProductDataAccess.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiProductService.Controllers
{
    [Authorize]
    public class ProductController : ApiController
    {
        AppDbContext db = new AppDbContext();

        //Crud
        /*
         Create
         Read
         Update
         Delete
         */

        //List
        public IEnumerable<Product> GetProduct()
        {
            return db.Products.ToList();
        }

        public HttpResponseMessage GetProduct(int id)//5
        {
            Product product = db.Products.FirstOrDefault(x => x.ID == id);
            if (product != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, product);

            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, $"{id} numaralı herhangi bir ürün bulunamadı.");
            }

        }

        //public IHttpActionResult ProductOlustur(Product product)
        //{
        //    if (product != null)
        //    {
        //        db.Products.Add(product);
        //        db.SaveChanges();
        //        return Ok(product);
        //    }
        //    else
        //    {
        //        return NotFound();
        //    }

        //}
        [HttpPost]
        public HttpResponseMessage CreateProduct(Product product)
        {
            if (product != null)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, product);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound,"ürün boş olamaz");
            }
        }
        [HttpDelete]
        public HttpResponseMessage DeleteProduct(int id)
        {
            Product product = db.Products.FirstOrDefault(x => x.ID == id);
            if (product != null)
            {
                db.Products.Remove(product);
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, $"{id} numaralı herhangi bir ürün bulunamadı.");
            }
        }

        [HttpPut]
        public HttpResponseMessage UpdateProduct(int id,Product product)
        {
            Product updated = db.Products.FirstOrDefault(x => x.ID == id);
            if (updated != null)
            {
                updated.ProductName = product.ProductName;
                updated.UnitPrice = product.UnitPrice;
                updated.UnitsInStock = product.UnitsInStock;
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, $"{id} numaralı herhangi bir ürün bulunamadı.");
            }
        }

    }
}
//HTTP