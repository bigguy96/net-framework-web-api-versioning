using Microsoft.Web.Http;
using System.Web.Http;

namespace ApiVersioning.Controllers
{
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/home")]
    public class HomeController : ApiController
    {

        [HttpGet]
        public IHttpActionResult Index()
        {
            return Ok(new { Version = "V1" });
        }

        [HttpGet]
        [MapToApiVersion("2.0")]
        public IHttpActionResult Index2()
        {
            return Ok(new { Version = "V2" });
        }
    }
}
