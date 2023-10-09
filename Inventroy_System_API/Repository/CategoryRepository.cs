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
    }
}
