using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        IPaymentService _paymentService;
        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpGet("getbyuserid")]
        public IActionResult GetByUserId(int userId)
        {
            var result = _paymentService.GetByUserId(userId);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(int Id)
        {
            var result = _paymentService.Delete(Id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Payment payment)
        {
            var result = _paymentService.Add(payment);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(int Id,Payment payment)
        {
            var entity= _paymentService.GetById(Id);
             entity.Data.CardName=payment.CardName;
            entity.Data.CardNumber = payment.CardNumber;
            entity.Data.Expiration = payment.Expiration;
            entity.Data.CvcCode = payment.CvcCode;
            var result = _paymentService.Update(entity.Data);
            if (entity.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
