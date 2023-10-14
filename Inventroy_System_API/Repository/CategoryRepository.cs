using Inventroy_System_API.Data;
using Inventroy_System_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventroy_System_API.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDBContext _context;

        public CategoryRepository(AppDBContext context)
        {
            _context = context;
        }
        public async Task<List<CategoryModel>> GetAllCategory()
        {
            var records = await _context.tbl_Category.Select(x => new CategoryModel()
            {
                CategoryId = x.CategoryId,
                Name = x.Name,
                Description = x.Description,
            }).ToListAsync();

            return records;
        }
        public async Task<CategoryModel> GetCategoryByIdAsync(int CategoryId)
        {
            var records = await _context.tbl_Category.Where(x => x.CategoryId == CategoryId).Select(x => new CategoryModel()
            {
                CategoryId = x.CategoryId,
                Name = x.Name,
                Description = x.Description,
            }).FirstOrDefaultAsync();
            return records;
        }
        public async Task<int> AddCategoryAsync(CategoryModel CategoryModel)
        {
            var category = new Category()
            {
                Name = CategoryModel.Name,
                Description = CategoryModel.Description
            };
            _context.tbl_Category.Add(category);
            await _context.SaveChangesAsync();
            return category.CategoryId;

        }
        public async Task UpdateCategoryAsync(int CategoryId, CategoryModel categoryModel)
        {
            var category = await _context.tbl_Category.FindAsync(CategoryId);
            if (category != null)
            {
                category.Name = categoryModel.Name;
                category.Description = categoryModel.Description;
                await _context.SaveChangesAsync();
            }
        }
        public async Task DeleteCategoryAsync(int categoryid)
        {
            var category = new Category() { CategoryId = categoryid };
            _context.tbl_Category.Remove(category);
            await _context.SaveChangesAsync();
        }
    }
}
