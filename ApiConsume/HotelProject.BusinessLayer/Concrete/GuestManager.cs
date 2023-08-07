using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class GuestManager : IGuestService
    {
        private readonly IGuest _guest;

        public GuestManager(IGuest guest)
        {
            _guest = guest;
        }

        public void TDelete(Guest entity)
        {
            _guest.Delete(entity);
        }

        public Guest TGetByID(int id)
        {
            return _guest.GetByID(id);
        }

        public List<Guest> TGetList()
        {
            return _guest.GetList();

        }

        public void TInsert(Guest entity)
        {
            _guest.Insert(entity);
        }

        public void TUpdate(Guest entity)
        {
            _guest.Update(entity);
        }
    }
}
