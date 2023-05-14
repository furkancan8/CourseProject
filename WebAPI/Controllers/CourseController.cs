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
        [HttpGet("getallteachingcourse")]
        public IActionResult GetAllTeachingCourse(int teacherId)
        {
            var result = _courseService.GetAllTeacherOfCourse(teacherId);
            if(result!=null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getcourse")]
        public IActionResult GetCourseId(int courseId)
        {
            var result = _courseService.GetCourseById(courseId);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getallcoursebycateogry")]
        public IActionResult GetAllCourseByCategory(int categoryId)
        {
            var result = _courseService.GetAllCategoryByCourse(categoryId);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getcoursebyname")]
        public IActionResult GetAllCourseByCategory(string name)
        {
            var resultName=name.Replace("sharp","#");
            var resultName2= resultName.Replace("plus","+");
            var result = _courseService.GetCourseByName(resultName2);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
