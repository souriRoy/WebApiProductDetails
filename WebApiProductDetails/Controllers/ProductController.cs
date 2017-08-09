using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductDataAccess;

namespace WebApiProductDetails.Controllers
{
    public class ProductController : ApiController
    {
       public IEnumerable<Product> Get()
       {
           using (MyDBEntities entities = new MyDBEntities())
             {
                return entities.Products.ToList();
             }
        }

        public HttpResponseMessage Get( int id)
        {
            using (MyDBEntities entities = new MyDBEntities())
            {
                var entity= entities.Products.FirstOrDefault(p => p.ProductId == id);
                if(entity != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, entity);
                }
                else 
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Product with ID " + id.ToString() + "not found.");
                }
            }
        }

        public HttpResponseMessage Post([FromUri]Product Product)
        {
            try
            {
                using (MyDBEntities entities = new MyDBEntities())
                {
                    entities.Products.Add(Product);
                    entities.SaveChanges();

                    var message = Request.CreateResponse(HttpStatusCode.Created, Product);
                    message.Headers.Location = new Uri(Request.RequestUri + Product.ProductId.ToString());
                    return message;
                }
            }
            catch   (Exception ex)
            {
                 return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }

        }

        public HttpResponseMessage Delete(int id)
        {
            try
            {
                using (MyDBEntities entities = new MyDBEntities())
                {
                    var entity = entities.Products.FirstOrDefault(p => p.ProductId == id);

                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Product with id : " + id.ToString() + "not found");
                    }
                    else
                    {
                        entities.Products.Remove(entity);
                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }

                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
            
        }

    }
}
