using Inventroy_System_API.Data;
using Inventroy_System_API.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Inventroy_System_API.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDBContext _context;

        public ProductRepository(AppDBContext context)
        {
            _context = context;
        }
        public async Task<List<ProductModel>> GetAllProductAsyn()
        {
            var records = await _context.tbl_Products.Select(x=>  new ProductModel()
            {
            ProductId= x.ProductId,   
            Name= x.Name,
            Description= x.Description,
            StockQuantity= x.StockQuantity,
            Price= x.Price,
            
            }).ToListAsync();

            return records;
        }
    }
}
