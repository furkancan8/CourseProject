using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        ITeacherCourseService _courseService;
        ITeacherService _teacherService;
        public TeacherController(ITeacherCourseService courseService, ITeacherService teacherService)
        {
            _courseService = courseService;
            _teacherService = teacherService;
        }
        [HttpGet("getteachercourse")]
        public IActionResult GetTeacherOfCourse(int teacherId)
        {
            var result = _courseService.GetTeacherId(teacherId);
            if(result!=null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getallteacher")]
        public IActionResult GetAllTeacher()
        {
            var result = _teacherService.GetAll();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
