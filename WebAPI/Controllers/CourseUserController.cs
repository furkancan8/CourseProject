using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseUserController : ControllerBase
    {
        ICourseUserService _courseUserService;
        ICourseService _courseService;
        public CourseUserController(ICourseUserService courseUserService, ICourseService courseService)
        {
            _courseUserService = courseUserService;
            _courseService = courseService;
        }
        [HttpGet("getuserbycourse")]
        public IActionResult GetCourseByUserId(int userId)
        {
            var result = _courseUserService.GetByUserId(userId);
            if(result!=null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getallcourseidbyuser")]
        public IActionResult GetAllCourseIdByUser(int courseId)
        {
            var result = _courseUserService.GetByCourseId(courseId);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
