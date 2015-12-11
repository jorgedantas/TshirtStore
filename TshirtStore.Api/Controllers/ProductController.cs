using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using TshirtStore.Domain.Commands.ProductCommands;
using TshirtStore.Domain.Services;

namespace TshirtStore.Api.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductApplicationService _service;

        public ProductController(IProductApplicationService service)
        {
            this._service = service;
        }

        [System.Web.Mvc.HttpGet]
        //[Authorize]
        [System.Web.Mvc.Route("api/products")]
        public Task<HttpResponseMessage> Get()
        {
            var products = _service.Get();
            return CreateResponse(HttpStatusCode.OK, products);
        }

        [System.Web.Mvc.HttpGet]
        //[Authorize]
        [System.Web.Mvc.Route("api/products/{skip:int:min(0)}/{take:int:min(1)}")]
        public Task<HttpResponseMessage> GetByRange(int skip, int take)
        {
            var products = _service.Get(skip, take);
            return CreateResponse(HttpStatusCode.OK, products);
        }

        [System.Web.Mvc.HttpGet]
        //[Authorize]
        [System.Web.Mvc.Route("api/products/outofstock")]
        public Task<HttpResponseMessage> GetInStock()
        {
            var products = _service.GetOutOfStock();
            return CreateResponse(HttpStatusCode.OK, products);
        }

        [System.Web.Mvc.HttpPost]
        //[Authorize]
        [System.Web.Mvc.Route("api/products")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var command = new CreateProductCommand(
                title: (string)body.title,
                category: (int)body.category,
                description: (string)body.description,
                price: (decimal)body.price,
                image: (string)body.image,
                quantityOnHand: (int)body.quantityOnHand
            );

            var product = _service.Create(command);
            return CreateResponse(HttpStatusCode.Created, product);
        }

        [System.Web.Mvc.HttpPut]
        //[Authorize]
        [System.Web.Mvc.Route("api/products/{id:int:min(1)}")]
        public Task<HttpResponseMessage> Put(int id, [FromBody]dynamic body)
        {
            var command = new UpdateProductInfoCommand(
                id: id,
                title: (string)body.title,
                category: (int)body.category,
                description: (string)body.description
            );

            var product = _service.UpdateBasicInformation(command);
            return CreateResponse(HttpStatusCode.OK, product);
        }
    }
}