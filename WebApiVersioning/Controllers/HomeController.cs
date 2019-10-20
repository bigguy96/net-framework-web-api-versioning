using Microsoft.Web.Http;
using System.Web.Http;
using Entities.DTO;

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
            return Ok("V1");
        }

        [HttpGet]
        [MapToApiVersion("2.0")]
        public IHttpActionResult IndexV2()
        {
            return Ok("V2");
        }

        [HttpPost]
        public IHttpActionResult Add([FromBody] UserDTO userDTO)
        {
            if (userDTO is null) throw new System.ArgumentNullException(nameof(userDTO));

            return Ok(userDTO);
        }

        [HttpPost]
        [MapToApiVersion("2.0")]
        public IHttpActionResult AddV2([FromBody] UserDTO userDTO)
        {
            if (userDTO is null) throw new System.ArgumentNullException(nameof(userDTO));

            return Ok(userDTO);
        }

        [HttpPut]
        public IHttpActionResult Put([FromBody] UserDTO userDTO)
        {
            if (userDTO is null) throw new System.ArgumentNullException(nameof(userDTO));

            return Ok(userDTO);
        }

        [HttpPut]
        [MapToApiVersion("2.0")]
        public IHttpActionResult PutV2([FromBody] UserDTO userDTO)
        {
            if (userDTO is null) throw new System.ArgumentNullException(nameof(userDTO));

            return Ok(userDTO);
        }

        [HttpDelete]
        public IHttpActionResult Delete()
        {
            return Ok();
        }

        [HttpDelete]
        [MapToApiVersion("2.0")]
        public IHttpActionResult DeleteV2()
        {
            return Ok();
        }
    }
}
