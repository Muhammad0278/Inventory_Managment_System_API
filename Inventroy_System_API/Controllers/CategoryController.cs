using Inventroy_System_API.Models;
using Inventroy_System_API.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Inventroy_System_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository) 
        {
            _categoryRepository = categoryRepository;
        }
        [Route("GetAllCategories")]
        [HttpGet]
        public async Task<IActionResult> GetAllCategory()
        {
            var Categorys = await _categoryRepository.GetAllCategory();
            return Ok(Categorys);
        }
        [Route("GetCategoryById")]
        [HttpGet]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            var Category = await _categoryRepository.GetCategoryByIdAsync(id);
            if(Category == null)
            {
                return NotFound();
            }
            return Ok(Category);
        }
        [Route("AddCategory")]
        [HttpPost]
        public async Task<IActionResult> AddNewCategory([FromBody]CategoryModel categoryModel)
        {
            var id = await _categoryRepository.AddCategoryAsync(categoryModel);
            return CreatedAtAction(nameof(GetCategoryById), new {id=id,controller ="Category"},id );
        }

        [Route("UpdateCategory")]
        [HttpPut]
        public async Task<IActionResult> updateCategory([FromBody]CategoryModel categoryModel,int id)
        {
            await _categoryRepository.UpdateCategoryAsync(id, categoryModel);
            return Ok();
        }
        [Route("DeleteCategory")]
        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int categoryid)
        {
            await _categoryRepository.DeleteCategoryAsync(categoryid);
            return Ok();
        }


    }
}
