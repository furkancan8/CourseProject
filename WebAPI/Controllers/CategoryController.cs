using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService; 
        }
        [HttpGet("getallcategory")]
        public IActionResult GetAllCategory()
        {
            var result = _categoryService.GetAll();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbycategoryId")]
        public IActionResult GetByCategoryId(int categoryId)
        {
            var result = _categoryService.GetById(categoryId);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
