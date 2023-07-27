using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DTOLayer.DTOs.RoomDTO;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Room2Controller : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;

        public Room2Controller(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult RoomList() // Tüm odaları listeleme
        {
            var values = _roomService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddRoom(AddRoomDTO addRoomDTO) // Oda ekleme
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Room>(addRoomDTO);
            _roomService.TInsert(values);
            return Ok();
        }


        [HttpDelete]
        public IActionResult DeleteRoom(int id) // Oda silme
        {
            var values = _roomService.TGetByID(id);
            _roomService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRoom(UpdateRoomDTO updateRoomDTO) // Oda güncelleme
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Room>(updateRoomDTO);
            _roomService.TUpdate(values);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetRoom(int id) // ID'ye göre oda listeleme 
        {
            var values = _roomService.TGetByID(id);
            return Ok(values);
        }
    }
}
