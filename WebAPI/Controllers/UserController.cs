using Business.Abstract;
using Core.Entities.Concrate;
using Entity.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserService _userService;
        IUserContactService _userContactService;
        public UserController(IUserService userService, IUserContactService userContactService)
        {
            _userService = userService;
            _userContactService = userContactService;
        }
        [HttpGet("getalluser")]
        public IActionResult GetAllUser()
        {
            var result = _userService.GetAll();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getuser")]
        public ActionResult GetUser(string userMail)
        {
            var result = _userService.GetByMail(userMail);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Massage);
        }
        [HttpGet("getbyuserid")]
        public ActionResult GetById(int userId)
        {
            var result = _userService.GetById(userId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Massage);
        }
        [HttpGet("getuserclaim")]
        public ActionResult GetUserClaims(int userId)
        {
            var result = _userService.GetUserClaims(userId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Massage);
        }
        [HttpPost("update")]
        public IActionResult Update(User user, int id)
        {
            var result = _userService.GetById(id);
            result.Data.FullName = user.FullName;
            result.Data.Email = user.Email;
            result.Data.Number= user.Number;
            result.Data.IsSendMail = user.IsSendMail;
            if (user.Email != null)
            {
                result.Data.Email = user.Email;
            }
            var update = _userService.Update(result.Data);
            if (update != null)
            {
                return Ok(update);
            }
            return BadRequest(update);
        }
        [HttpPost("sendmailofchangepassword")]
        public IActionResult SendMailOfChangePassword(string email)
        {
            _userService.SendMailOfChangePassword("furkan_can45@hotmail.com");
            return Ok();
        }
        [HttpPost("addcontact")]
        public IActionResult ContactAdd(UserContact contact)
        {
            var result = _userContactService.Add(contact);
            if(result!=null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
