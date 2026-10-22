using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Api_Versioning.Controllers.V1
{
    [ApiController]
    [ApiVersion("1.0")]
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
            };
            return Ok(product);
        }

    }
}
