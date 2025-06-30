using Microsoft.AspNetCore.Mvc;

namespace API_VERSIOING.Controllers.V1
{
    [ApiController]
    [ApiVersion("1.0")]
    [ApiExplorerSettings(GroupName="v1")]
    [Route("api/v{version:apiVersion}/[Controller]")]
    public class ProductController : Controller
    {
        [HttpGet]
       public IActionResult ShowProducts()
        {
            var product = new[] { "Mango","Apple","Gruva"};
            return Ok(product);
        }
    }
}
