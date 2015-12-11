using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using TshirtStore.Domain.Commands.CategoryCommands;
using TshirtStore.Domain.Services;

namespace TshirtStore.Api.Controllers
{
  
        public class CategoryController : BaseController
        {
            private readonly ICategoryApplicationService _service;

            public CategoryController(ICategoryApplicationService service)
            {
                this._service = service;
            }

            [System.Web.Mvc.HttpGet]
            //[Authorize]
            [System.Web.Mvc.Route("api/categories")]
            public Task<HttpResponseMessage> Get()
            {
                var categories = _service.Get();
                return CreateResponse(HttpStatusCode.Created, categories);
            }

            [System.Web.Mvc.HttpGet]
            //[Authorize]
            [System.Web.Mvc.Route("api/categories/{skip}/{take}")]
            public Task<HttpResponseMessage> Get(int skip, int take)
            {
                var categories = _service.Get(skip, take);
                return CreateResponse(HttpStatusCode.Created, categories);
            }

            [System.Web.Mvc.HttpGet]
            //[Authorize]
            [System.Web.Mvc.Route("api/categories/{id}")]
            public Task<HttpResponseMessage> Get(int id)
            {
                var category = _service.Get(id);
                return CreateResponse(HttpStatusCode.Created, category);
            }

            [System.Web.Mvc.HttpPost]
            //[Authorize]
            [System.Web.Mvc.Route("api/categories")]
            public Task<HttpResponseMessage> Post([FromBody]dynamic body)
            {
                var command = new CreateCategoryCommand(
                    title: (string)body.title
                );

                var category = _service.Create(command);
                return CreateResponse(HttpStatusCode.Created, category);
            }

            [System.Web.Mvc.HttpPut]
            //[Authorize]
            [System.Web.Mvc.Route("api/categories/{id}")]
            public Task<HttpResponseMessage> Put(int id, [FromBody]dynamic body)
            {
                var command = new EditCategoryCommand(
                    id: id,
                    title: (string)body.title
                );

                var category = _service.Update(command);
                return CreateResponse(HttpStatusCode.OK, category);
            }

            [System.Web.Mvc.HttpDelete]
            //[Authorize]
            [System.Web.Mvc.Route("api/categories/{id}")]
            public Task<HttpResponseMessage> Delete(int id)
            {
                var category = _service.Delete(id);
                return CreateResponse(HttpStatusCode.OK, category);
            }
        }
    }
