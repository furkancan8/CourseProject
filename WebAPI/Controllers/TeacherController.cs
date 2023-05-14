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
        ITeacherStudentService _teacherStudentService;

        public TeacherController(ITeacherCourseService courseService, ITeacherStudentService studentService,ITeacherService teacherService)
        {
            _courseService = courseService;
            _teacherStudentService = studentService;
            _teacherService = teacherService;
        }
        [HttpGet("getteacherofcourse")]
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
        [HttpGet("getteacher")]
        public IActionResult GetTeacher(int teacherId)
        {
            var result = _teacherService.GetTeacher(teacherId);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
