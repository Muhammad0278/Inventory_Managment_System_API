using AutoMapper;
using Inventroy_System_API.Data;
using Inventroy_System_API.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Inventroy_System_API.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDBContext _context;
        private readonly IMapper _mapper;

        public ProductRepository(AppDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<ProductModel>> GetAllProductAsyn()
        {
            //var records = await _context.tbl_Products.Select(x=>  new ProductModel()
            //{
            //ProductId= x.ProductId,   
            //Name= x.Name,
            //Description= x.Description,
            //StockQuantity= x.StockQuantity,
            //Price= x.Price,
            //CategoryId= x.CategoryId,
            //}).ToListAsync();

            //return records;
            var Products = await _context.tbl_Products.ToListAsync();
            return _mapper.Map<List<ProductModel>>(Products);
        }
        public async Task<ProductModel> GetProdctByIdAsync(int productId)
        {
            var Products = await _context.tbl_Products.FindAsync(productId);
            return _mapper.Map<ProductModel>(Products);
        }

        public async Task<int> AddProductAsync(ProductModel productModel)
        {
            var Product = new Products()
            {
                Name = productModel.Name,
                Description = productModel.Description,
                Price = productModel.Price,
                StockQuantity= productModel.StockQuantity,
                CategoryId = productModel.CategoryId,
            };
            _context.tbl_Products.Add(Product);
            await _context.SaveChangesAsync();
            return Product.ProductId;

        }
        public async Task UpdateProductAsync(int productId, ProductModel productModel)
        {
            var Product = await _context.tbl_Products.FindAsync(productId);
            if (Product != null)
            {
                Product.Name = productModel.Name;
                Product.Description = productModel.Description;
                Product.Price = productModel.Price;
                Product.StockQuantity = productModel.StockQuantity;
                Product.CategoryId = productModel.CategoryId;

                await _context.SaveChangesAsync();
            }
        }
        public async Task DeleteProductAsync(int productId)
        {
            var product = new Products() { ProductId = productId };
            _context.tbl_Products.Remove(product);
            await _context.SaveChangesAsync();
        }
    }
}
