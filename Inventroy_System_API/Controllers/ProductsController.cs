using Inventroy_System_API.Models;
using Inventroy_System_API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Inventroy_System_API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [Route("GetAllProducts")]
        [HttpGet]
        public async Task<IActionResult> GetAllProduct()
        {
            var products = await _productRepository.GetAllProductAsyn();
            return Ok(products);
        }

        [Route("GetProductById")]
        [HttpGet]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await _productRepository.GetProdctByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [Route("AddProduct")]
        [HttpPost]
        public async Task<IActionResult> AddNewProduct([FromBody] ProductModel productModel)
        {
            var id = await _productRepository.AddProductAsync(productModel);
            return CreatedAtAction(nameof(GetProductById), new { id = id, controller = "Product" }, id);
        }
        [Route("UpdateProduct")]
        [HttpPut]
        public async Task<IActionResult> updateProduct([FromBody] ProductModel productModel, int id)
        {
            await _productRepository.UpdateProductAsync(id, productModel);
            return Ok();
        }
        [Route("DeleteProduct")]
        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(int productId)
        {
            await _productRepository.DeleteProductAsync(productId);
            return Ok();
        }
    }

}
