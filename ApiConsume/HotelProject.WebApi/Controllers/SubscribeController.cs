using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService;

        public SubscribeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        [HttpGet]
        public IActionResult SubscribeList() // Tüm odaları listeleme
        {
            var values = _subscribeService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddSubscribe(Subscribe subscribe) // Oda ekleme
        {
            _subscribeService.TInsert(subscribe);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteSubscribe(int id) // Oda silme
        {
            var values = _subscribeService.TGetByID(id);
            _subscribeService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateSubscribe(Subscribe subscribe) // Oda güncelleme
        {
            _subscribeService.TUpdate(subscribe);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetSubscribe(int id) // ID'ye göre oda listeleme 
        {
            var values = _subscribeService.TGetByID(id);
            return Ok(values);
        }
    }
}
