using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendMessageController : ControllerBase
    {
        private readonly ISendMessageService _sendMessageService;

        public SendMessageController(ISendMessageService sendMessageService)
        {
            _sendMessageService = sendMessageService;
        }

        [HttpGet]
        public IActionResult SendMessageList() // Tüm personelları listeleme
        {
            var values = _sendMessageService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddSendMessage(SendMessage sendMessage) // personel ekleme
        {
            _sendMessageService.TInsert(sendMessage);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteSendMessage(int id) // personel silme
        {
            var values = _sendMessageService.TGetByID(id);
            _sendMessageService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateSendMessage(SendMessage sendMessage) // personel güncelleme
        {
            _sendMessageService.TUpdate(sendMessage);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetSendMessage(int id) // ID'ye göre personel listeleme 
        {
            var values = _sendMessageService.TGetByID(id);
            return Ok(values);
        }
    }
}
