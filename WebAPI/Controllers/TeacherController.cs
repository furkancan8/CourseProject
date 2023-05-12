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

        ITeacherStudentService _teacherStudentService;

        public TeacherController(ITeacherCourseService courseService, ITeacherStudentService studentService)
        {
            _courseService = courseService;
            _teacherStudentService = studentService;
        }
        [HttpGet("getteacher")]
        public IActionResult GetTeacherOfCourse(int teacherId)
        {
            var result = _courseService.GetTeacherId(teacherId);
            if(result!=null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getallteacherofstudent")]
        public IActionResult GetAllTeacherOfStudent(int teacherId)
        {
            var result = _teacherStudentService.GetAllTeacherOfStudent(teacherId);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
