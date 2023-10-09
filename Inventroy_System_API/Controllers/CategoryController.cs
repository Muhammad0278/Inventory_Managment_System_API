using Inventroy_System_API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Inventroy_System_API.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository) 
        {
            _categoryRepository = categoryRepository;
        }


    }
}
