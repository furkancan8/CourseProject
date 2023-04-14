using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserCourseController : ControllerBase
    {
        ICourseUserService _courseUserService;
        ICourseService _courseService;
        public UserCourseController(ICourseUserService courseUserService, ICourseService courseService)
        {
            _courseUserService = courseUserService;
            _courseService = courseService;
        }
        [HttpGet("getcourse")]
        public IActionResult GetCourseId(int courseId)
        {
            var result = _courseService.GetCourseById(courseId);
            if(result!=null)
            {
                return Ok(result);
            }
            return BadRequest(result);
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
    }
}
