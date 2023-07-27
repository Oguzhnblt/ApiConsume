using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _booking;

        public BookingController(IBookingService booking)
        {
            _booking = booking;
        }

        [HttpGet]
        public IActionResult BookingList() // Tüm odaları listeleme
        {
            var values = _booking.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddBooking(Booking booking) // Oda ekleme
        {
            _booking.TInsert(booking);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id) // Oda silme
        {
            var values = _booking.TGetByID(id);
            _booking.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateBooking(Booking booking) // Oda güncelleme
        {
            _booking.TUpdate(booking);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetBooking(int id) // ID'ye göre oda listeleme 
        {
            var values = _booking.TGetByID(id);
            return Ok(values);
        }
    }
}
