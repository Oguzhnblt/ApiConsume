using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EFGuestDal : GenericRepository<Guest>, IGuest
    {
        public EFGuestDal(Context context) : base(context)
        {
        }
    }
}
