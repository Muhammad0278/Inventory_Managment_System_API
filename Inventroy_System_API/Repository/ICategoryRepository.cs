using Inventroy_System_API.Models;

namespace Inventroy_System_API.Repository
{
    public interface ICategoryRepository
    {
        Task<List<CategoryModel>> GetAllCategory();
        Task<CategoryModel> GetCategoryByIdAsync(int CategoryId);
        Task<int> AddCategoryAsync(CategoryModel CategoryModel);
        Task UpdateCategoryAsync(int CategoryId, CategoryModel categoryModel);
        Task DeleteCategoryAsync(int categoryid);
    }
}
