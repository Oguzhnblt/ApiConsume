using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        [HttpGet]
        public IActionResult TestimonialList() // Tüm odaları listeleme
        {
            var values = _testimonialService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial) // Oda ekleme
        {
            _testimonialService.TInsert(testimonial);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id) // Oda silme
        {
            var values = _testimonialService.TGetByID(id);
            _testimonialService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTestimonial(Testimonial testimonial) // Oda güncelleme
        {
            _testimonialService.TUpdate(testimonial);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id) // ID'ye göre oda listeleme 
        {
            var values = _testimonialService.TGetByID(id);
            return Ok(values);
        }
    }
}
