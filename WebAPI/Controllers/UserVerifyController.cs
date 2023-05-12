using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrate.EntityFramework;
using Entity.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserVerifyController : ControllerBase
    {
        IUserVerifyService _userVerifyService;
        IAuthService _authService;
        IUserService _userService;
        public UserVerifyController(IUserVerifyService userVerifyService, IAuthService authService, IUserService userService)
        {
            _userVerifyService = userVerifyService;
            _authService = authService;
            _userService = userService;
        }
        [HttpPost("add")]
        public IActionResult Add(UserVerify userVerify)
        {
            //Email kontrol ediliyor mesaj gönderildi,email yoksa uyarı ver
            var checkSameMail = _userService.GetByMail(userVerify.UserMail);
            if(checkSameMail.Data==null)
            {
                return Ok(checkSameMail);
            }
            var result = _userVerifyService.Add(userVerify);
            if(result!=null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("verifyemailuseradd")]
        public IActionResult VerifyEmailUserAdd(UserVerify userVerify,int userId)
        {
            var result = _userVerifyService.VerifyEmailUserAdd(userVerify, userId);
            if(result!=null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(int userVerifyId)
        {
            var result = _userVerifyService.Delete(userVerifyId);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbymail")]
        public IActionResult GetByMail(string userMail)
        {
            var result = _userVerifyService.GetByMail(userMail);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
