using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _service;

        public ServiceController(IServiceService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult ServiceList() // Tüm odaları listeleme
        {
            var values = _service.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddService(Service service) // Oda ekleme
        {
            _service.TInsert(service);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteService(int id) // Oda silme
        {
            var values = _service.TGetByID(id);
            _service.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateService(Service service) // Oda güncelleme
        {
            _service.TUpdate(service);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetService(int id) // ID'ye göre oda listeleme 
        {
            var values = _service.TGetByID(id);
            return Ok(values);
        }
    }
}
