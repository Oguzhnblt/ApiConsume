using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public IActionResult StaffList() // Tüm odaları listeleme
        {
            var values = _staffService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddStaff(Staff staff) // Oda ekleme
        {
            _staffService.TInsert(staff);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteStaff(int id) // Oda silme
        {
            var values = _staffService.TGetByID(id);
            _staffService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateStaff(Staff staff) // Oda güncelleme
        {
            _staffService.TUpdate(staff);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetStaff(int id) // ID'ye göre oda listeleme 
        {
            var values = _staffService.TGetByID(id);
            return Ok(values);
        }
    }
}
