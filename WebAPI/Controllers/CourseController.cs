using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
       ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result=_courseService.GetAll(); 
            if(result!=null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
