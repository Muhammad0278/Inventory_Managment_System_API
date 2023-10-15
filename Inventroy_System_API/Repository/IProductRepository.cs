using Inventroy_System_API.Models;

namespace Inventroy_System_API.Repository
{
    public interface IProductRepository
    {
        Task<List<ProductModel>> GetAllProductAsyn();
        Task<ProductModel> GetProdctByIdAsync(int productId);
        Task<int> AddProductAsync(ProductModel productModel);
        Task UpdateProductAsync(int productId, ProductModel productModel);
        Task DeleteProductAsync(int productId);
         
    }
}
