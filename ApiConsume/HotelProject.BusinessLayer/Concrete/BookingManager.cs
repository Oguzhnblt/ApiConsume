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

        public void TBookingStatusApproved(Booking booking)
        {
           _booking.BookingStatusChangeApproved(booking);
        }

        public void TBookingStatusApproved2(int id)
        {
            _booking.BookingStatusChangeApproved2(id);
        }

        public void TDelete(Booking entity)
        {
            _booking.Delete(entity);
        }

        public int TGetBookingCount()
        {
            return _booking.GetBookingCount();
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

        public List<Booking> TLast6Bookings()
        {
           return _booking.Last6Bookings();
        }

        public void TUpdate(Booking entity)
        {
            _booking.Update(entity);
        }
    }
}
