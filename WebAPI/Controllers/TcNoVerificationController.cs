using Business.Abstract;
using Business.Adapters.SmsService;
using Entities;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using TCKimlikNoDogrulama.Core;

namespace WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TcNoVerificationController : Controller
    {
        private readonly ITcNoVerificationService _tcNoVerificationService;
        private readonly ISmsSender _smsSender;

        public TcNoVerificationController(ITcNoVerificationService tcNoVerificationService,ISmsSender smsSender)
        {
            _tcNoVerificationService = tcNoVerificationService;
            _smsSender = smsSender;
        }
        [HttpPost("Add")]
        public IActionResult Add(TcNoVerification tcNoVerification)
        {
            var result = _tcNoVerificationService.Add(tcNoVerification);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _tcNoVerificationService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(string id)
        {
            var result = _tcNoVerificationService.GetByPeople(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(TcNoVerification tcNoVerification)
        {
            var result = _tcNoVerificationService.Update(tcNoVerification);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("delete")]
        public IActionResult Delete(string id)
        {
            var result = _tcNoVerificationService.Delete(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);


        }
        [HttpPost("tcverification")]
        public IActionResult TcNoVerification(TcNoVerification tcNoVerification)
        {

            bool tcVerification = new TCKimlikNoDogrulamaCORE(tcNoVerification.TCKimlikNo, tcNoVerification.Ad, tcNoVerification.Soyad, tcNoVerification.DogumYili).KisiVarMi();

            if (tcVerification == true)
            {
                _tcNoVerificationService.Add(tcNoVerification);
                return Ok(tcVerification);
            }
            return BadRequest(tcVerification);

        }
        [HttpPost("smsverification")]
        public IActionResult SmsVerification(SendSmsDto sendSmsDto)
        {
          
            var result = _smsSender.SendSmsAsync(sendSmsDto.MobileNumber,sendSmsDto.Body);
            if (!string.IsNullOrEmpty(result.ErrorMessage))
            {
                return BadRequest(result.ErrorMessage);
               
            }
            return Ok(result);





        }
    }
}
