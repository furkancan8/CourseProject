using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        ICommentService _commentService;
        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }
        [HttpGet("getallusercomment")]
        public IActionResult GetAllCommentUser(int userId)
        {
            var result=_commentService.GetAllUserComment(userId);
            if(result!=null)
            {
                return  Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getallcommentbycourse")]
        public IActionResult GetAllCommentByCourse(int courseId)
        {
            var result = _commentService.GetAllCourse(courseId);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
