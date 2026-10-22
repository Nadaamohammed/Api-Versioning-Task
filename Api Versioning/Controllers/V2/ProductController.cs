using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Api_Versioning.Controllers.V2
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ProductController : ControllerBase
    {

        public IActionResult GetProductById(int id)
        {
            var product = new
            {
                Id = id,
                Name = "Laptop",
                Price = 19.99m,
                Category = "Electronics"
            };
            return Ok(product);
        }

    }
}
