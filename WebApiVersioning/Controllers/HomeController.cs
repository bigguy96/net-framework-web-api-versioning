using Microsoft.Web.Http;
using System.Web.Http;
using WebApiVersioning.DTO;

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
        public IHttpActionResult IndexV2()
        {
            return Ok(new { Version = "V2" });
        }

        [HttpPost]
        public IHttpActionResult Add([FromBody] UserDTO userDTO)
        {
            if (userDTO is null)
            {
                throw new System.ArgumentNullException(nameof(userDTO));
            }

            return Ok(new
            {
                Version = "V1",
                Id = userDTO.Id,
                FullName = $"{userDTO.FirstName} {userDTO.LastName}"
            });
        }

        [HttpPost]
        [MapToApiVersion("2.0")]
        public IHttpActionResult AddV2([FromBody] UserDTO userDTO)
        {
            if (userDTO is null)
            {
                throw new System.ArgumentNullException(nameof(userDTO));
            }

            return Ok(new
            {
                Version = "V2",
                Id = userDTO.Id,
                FullName = $"{userDTO.FirstName} {userDTO.LastName}"
            });
        }


    }
}
