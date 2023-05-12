using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoldCourseController : ControllerBase
    {
        ISoldCourseService _soldCourseService;
        public SoldCourseController(ISoldCourseService soldCourseService)
        {
            _soldCourseService = soldCourseService;
        }
        [HttpGet("getalluserforsoldcourse")]
        public IActionResult GetAllUserId(int userId)
        {
            var result = _soldCourseService.GetAllUserId(userId);
            if(result!=null)
            {
                return Ok(result);
            }
             return BadRequest(result);
        }
        [HttpGet("getallcourseforsoldcourse")]
        public IActionResult GetAllCourseId(int courseId)
        {
            var result = _soldCourseService.GetAllCourseId(courseId);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int soldCourseId)
        {
            var result = _soldCourseService.GetById(soldCourseId);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
