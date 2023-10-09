using Inventroy_System_API.Models;

namespace Inventroy_System_API.Repository
{
    public interface IProductRepository
    {
        Task<List<ProductModel>> GetAllProductAsyn();
    }
}
