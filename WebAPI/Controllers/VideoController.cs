using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoController : ControllerBase
    {
        ICourseVideoService _courseVideoService;
        IVideoDetailsService _videoDetailsService;
        public VideoController(ICourseVideoService courseVideoService, IVideoDetailsService videoDetailsService)
        {
            _courseVideoService = courseVideoService;
            _videoDetailsService = videoDetailsService;
        }
        [HttpGet("getvideodetails")]
        public IActionResult GetByIdVideoDetails(int videoDetailsId)
        {
            var result = _videoDetailsService.GetById(videoDetailsId);
            if(result!=null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getallvideobycourse")]
        public IActionResult GetAllVideoByCourse(int courseId)
        {
            var result = _courseVideoService.GetAllVideoByCourse(courseId);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

