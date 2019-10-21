using Microsoft.Web.Http;
using System.Web.Http;

namespace WebApiVersioning.Controllers
{
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [RoutePrefix("api")]
    public class TestController : ApiController
    {
        [HttpGet]
        [Route("v{version:apiVersion}/test/{id}")]
        public IHttpActionResult Index([FromUri] string id, string name = "")
        {
            return Ok($"Version 1: {id}, Name: {name}");
        }

        [HttpGet, MapToApiVersion("2.0")]
        [Route("v{version:apiVersion}/test/{id}")]
        public IHttpActionResult IndexV2([FromUri] string id, string name = "")
        {
            return Ok($"Version 2: {id}, Name: {name}");
        }
    }
}
