using Microsoft.AspNetCore.Mvc;

namespace API_VERSIOING.Controllers.V2
{
    [ApiController]
    [ApiVersion("2.0")]
    [ApiExplorerSettings(GroupName = "v2")]
    [Route("api/v{version:apiversion}/[Controller]")]
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult ShowProducts()
        {
            var product = new[] { "Orange", "JackFruit", "SweetLemon" };
            return Ok(product);
        }
    }
}
