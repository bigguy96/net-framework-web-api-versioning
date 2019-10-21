using Microsoft.Web.Http;
using System.Web.Http;
using Entities.DTO;

namespace WebApiVersioning.Controllers
{
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [RoutePrefix("api")]
    public class HomeController : ApiController
    {

        [HttpGet]
        [Route("v{version:apiVersion}/home")]
        public IHttpActionResult Index()
        {
            return Ok("V1");
        }

        [HttpGet]
        [MapToApiVersion("2.0")]
        [Route("v{version:apiVersion}/home")]
        public IHttpActionResult IndexV2()
        {
            return Ok("V2");
        }

        [HttpPost]
        [Route("v{version:apiVersion}/home")]
        public IHttpActionResult Add([FromBody] UserDTO userDTO)
        {
            if (userDTO is null) throw new System.ArgumentNullException(nameof(userDTO));

            return Ok(userDTO);
        }

        [HttpPost]
        [MapToApiVersion("2.0")]
        [Route("v{version:apiVersion}/home")]
        public IHttpActionResult AddV2([FromBody] UserDTO userDTO)
        {
            if (userDTO is null) throw new System.ArgumentNullException(nameof(userDTO));

            return Ok(userDTO);
        }

        [HttpPut]
        [Route("v{version:apiVersion}/home")]
        public IHttpActionResult Put([FromBody] UserDTO userDTO)
        {
            if (userDTO is null) throw new System.ArgumentNullException(nameof(userDTO));

            return Ok(userDTO);
        }

        [HttpPut]
        [MapToApiVersion("2.0")]
        [Route("v{version:apiVersion}/home")]
        public IHttpActionResult PutV2([FromBody] UserDTO userDTO)
        {
            if (userDTO is null) throw new System.ArgumentNullException(nameof(userDTO));

            return Ok(userDTO);
        }

        [HttpDelete]
        [Route("v{version:apiVersion}/home")]
        public IHttpActionResult Delete()
        {
            return Ok();
        }

        [HttpDelete]
        [MapToApiVersion("2.0")]
        [Route("v{version:apiVersion}/home")]
        public IHttpActionResult DeleteV2()
        {
            return Ok();
        }
    }
}