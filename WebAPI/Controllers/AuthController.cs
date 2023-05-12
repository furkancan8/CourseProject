using Business.Abstract;
using Core.Entities.Concrate;
using Core.Utilities.Security.JWT;
using Entity.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IAuthService _authService;

        public AuthController(IAuthService authService, IUserService userService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public ActionResult Login(UserForLoginDto userForLoginDto)
        {
            var userToLogin = _authService.Login(userForLoginDto);
            if (!userToLogin.Success)
            {
                return BadRequest(userToLogin.Massage);
            }

            var result = _authService.CreateAccessToken(userToLogin.Data);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Massage);
        }
        [HttpPost("register")]
        public ActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            var userExists = _authService.UserExists(userForRegisterDto.Email);
            if (!userExists.Success)
            {
                return BadRequest(userExists.Massage);
            }

            var registerResult = _authService.Register(userForRegisterDto, userForRegisterDto.Password);
            var result = _authService.CreateAccessToken(registerResult.Data);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpPost("changepassword")]
        public ActionResult ChangePassword(UserForRegisterDto userForRegisterDto, int id)
        {
            var result = _authService.ChangePassword(userForRegisterDto.Password, id);
            var resultToken = _authService.CreateAccessToken(result.Data);
            if (resultToken.Success)
            {
                return Ok(resultToken);
            }
            return BadRequest(resultToken);
        }
        [HttpPost("verifypassword")]
        public ActionResult VerifyPassword(UserForLoginDto userForLoginDto)
        {
            var result = _authService.VerifyPassword(userForLoginDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("decodetoken")]
        public ActionResult DecodeToken(User user)
        {
            var result = _authService.DecodeAccessToken(user);
            if(result!=null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
