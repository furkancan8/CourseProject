using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimController : ControllerBase
    {
        IUserOperationClaimService _userOperationClaimService;
        public ClaimController(IUserOperationClaimService userOperationClaimService)
        {
            _userOperationClaimService = userOperationClaimService;
        }
        [HttpGet("getallteacherbyclaim")]
        public IActionResult GetAll()
        {
            var result = _userOperationClaimService.GetAllTeacherByClaim();
            if(result!=null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
    
}
