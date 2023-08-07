using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IBookingService : IGenericService<Booking>
    {
        void TBookingStatusApproved(Booking booking);
        void TBookingStatusApproved2(int id);
        int TGetBookingCount();
        List<Booking> TLast6Bookings();

    }
}
