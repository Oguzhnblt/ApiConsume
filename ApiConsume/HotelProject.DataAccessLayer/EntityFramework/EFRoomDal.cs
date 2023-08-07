using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EFRoomDal : GenericRepository<Room>, IRoom
    {
        public EFRoomDal(Context context) : base(context)
        {

        }

        public int RoomCount()
        {
            var context = new Context();
            var values = context.Rooms.Count();
            return values;
        }
    }
}
