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

        public IHttpActionResult ProductOlustur(Product product)
        {
            if (product != null)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return Ok(product);
            }
            else
            {
                return NotFound();
            }

        }



    }
}
//HTTP