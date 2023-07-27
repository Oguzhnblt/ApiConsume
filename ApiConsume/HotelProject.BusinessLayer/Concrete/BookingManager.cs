using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBooking _booking;

        public BookingManager(IBooking booking)
        {
            _booking = booking;
        }

        public void TDelete(Booking entity)
        {
            _booking.Delete(entity);
        }

        public Booking TGetByID(int id)
        {
            return _booking.GetByID(id);
        }

        public List<Booking> TGetList()
        {
            return _booking.GetList();

        }

        public void TInsert(Booking entity)
        {
            _booking.Insert(entity);
        }

        public void TUpdate(Booking entity)
        {
            _booking.Update(entity);
        }
    }
}
