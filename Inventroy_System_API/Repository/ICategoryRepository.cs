using Inventroy_System_API.Models;

namespace Inventroy_System_API.Repository
{
    public interface ICategoryRepository
    {
        Task<List<CategoryModel>> GetAllCategory();
    }
}
