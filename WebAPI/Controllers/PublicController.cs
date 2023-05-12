using Business.Abstract;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IO;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicController : ControllerBase
    {
        IUserService _userService;
        private readonly IWebHostEnvironment _hostEnvironment;
        public PublicController(IWebHostEnvironment hostEnvironment, IUserService userService)
        {
            _hostEnvironment = hostEnvironment;
            _userService = userService;
        }

        [HttpPost("getimagefile")]
        public async Task<IActionResult> GetImageFile(IFormFile file,int userId)
        {
            var user = _userService.GetById(userId);
            Random rnd = new Random();
            var rndInt = rnd.Next(1, 10000);
            var fileNameWithRandomNumber = rndInt.ToString() + "-" + file.FileName;
            var filePath = Path.Combine(_hostEnvironment.WebRootPath, "uploads","images" , fileNameWithRandomNumber);
            using(var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            var userImageName = user.Data.ImageUrl = fileNameWithRandomNumber;
            _userService.Update(user.Data);
            return Ok();
        }   
    }
}
