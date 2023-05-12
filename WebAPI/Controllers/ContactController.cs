using Business.Abstract;
using Entity.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        ISupportContactService _supportService;
        public ContactController(ISupportContactService supportContactService)
        {
            _supportService = supportContactService;
        }
        [HttpGet("getallteacher")]
        public IActionResult GetSupportTeacher(int teacherId)
        {
            var result = _supportService.GetAllByTeacherId(teacherId);
            if(result!=null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(SupportContact supportContact)
        {
            var result = _supportService.Add(supportContact);
            if(result!=null)
            {
                return Ok(result);
            }
            return Ok(result);
        }
        [HttpPost("update")]
        public IActionResult Update(SupportContact supportContact)
        {
            var contact = _supportService.GetById(supportContact.Id);
            contact.Data.IsRead= false;
            var result = _supportService.Update(contact.Data);
            if(result!=null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
