using Business.Abstract;
using Core.Entities.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserClaimController : ControllerBase
    {
        IUserOperationClaimService _cliamService;
        public UserClaimController(IUserOperationClaimService cliamService)
        {
            _cliamService = cliamService;
        }

        [HttpPost("add")]
        public IActionResult Add(UserOperationClaim claim)
        {
            var result = _cliamService.Add(claim);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getalloperationclaim")]
        public IActionResult GetAllOperationClaim()
        {
            var result = _cliamService.GetOperationClaim();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
