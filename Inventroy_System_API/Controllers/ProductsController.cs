using Inventroy_System_API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Inventroy_System_API.Controllers
{

    [Route("api/controller")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet("")]
        public async Task<IActionResult> GetAllProduct()
        {
            var products = await _productRepository.GetAllProductAsyn();
            return Ok(products);
        }

        }
  
}
