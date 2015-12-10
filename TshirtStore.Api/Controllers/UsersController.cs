using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using TshirtStore.Domain.Commands.UserCommands;
using TshirtStore.Domain.Services;

namespace TshirtStore.Api.Controllers
{
    public class UsersController : BaseController
    {
        private readonly IUserApplicationService _service;

        public UsersController(IUserApplicationService service)
        {
            _service = service;
        }
        //[System.Web.Mvc.HttpGet]
        //[System.Web.Mvc.Route("api/users")]
        //[System.Web.Mvc.Authorize(Roles = "admin")]
        //public Task<HttpResponseMessage> Get()
        //{
        //    var users = _service.List();
        //    return CreateResponse(HttpStatusCode.OK, users);
        //}

        [System.Web.Mvc.HttpPost]
        [System.Web.Mvc.Route("api/users")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var command = new RegisterUserCommand(
                email: (string)body.email,
                password: (string)body.password,
                isAdmin: (bool)body.isadmin
            );

            var user = _service.Register(command);

            return CreateResponse(HttpStatusCode.Created, user);
        }

    }
}