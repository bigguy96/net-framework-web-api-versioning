using System.Web.Http;
using Microsoft.Web.Http;

namespace WebApiVersioning.Controllers
{
    [ApiVersion("1.0")]
    [RoutePrefix("api")]
    public class HelloController : ApiController
    {
        [HttpGet]
        [Route("v{version:apiVersion}/hello")]
        public IHttpActionResult Index(string name)
        {
            return Ok(new { Message = $"Hello {name} Version 1" });
        }
    }

    [ApiVersion("2.0")]
    [ApiVersion("3.0")]
    [RoutePrefix("api")]
    public class HelloV2Controller : ApiController
    {
        [HttpGet]
        [Route("v{version:apiVersion}/hello")]
        public IHttpActionResult IndexV2(string name)
        {
            return Ok( new { Message = $"Hello {name} Version 2"});
        }

        [HttpGet, MapToApiVersion("3.0")]
        [Route("v{version:apiVersion}/hello")]
        public IHttpActionResult IndexV3(string name)
        {
            return Ok(new { Message = $"Hello {name} Version 3" });
        }
    }
}