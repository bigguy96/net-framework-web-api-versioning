using System.Web.Http;

namespace WebApiVersioningTwo.Controllers
{
    [RoutePrefix("api")]
    public class HomeController : ApiController
    {
        // GET api/<controller>
        [Route("v1/home")]
        public IHttpActionResult Get()
        {
            return Ok(new {Version = "Version 1" });
        }
    }

    [RoutePrefix("api")]
    public class HomeV2Controller : ApiController
    {
        // GET api/<controller>
        [Route("v2/home")]
        public IHttpActionResult Get(string name)
        {
            return Ok(new { Version = "Version 2", Name = name });
        }
    }
}