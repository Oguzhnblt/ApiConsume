using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class RoomManager : IRoomService
    {
        private readonly IRoom _room;

        public RoomManager(IRoom room)
        {
            _room = room;
        }

        public void TDelete(Room entity)
        {
            _room.Delete(entity);
        }

        public Room TGetByID(int id)
        {
            return _room.GetByID(id);
        }

        public List<Room> TGetList()
        {
            return _room.GetList();

        }

        public void TInsert(Room entity)
        {
            _room.Insert(entity);
        }

        public void TUpdate(Room entity)
        {
            _room.Update(entity);
        }
    }
}
