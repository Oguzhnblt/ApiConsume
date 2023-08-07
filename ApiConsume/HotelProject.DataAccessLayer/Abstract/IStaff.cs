using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IStaff : IGeneric<Staff>
    {
        int GetStaffCount();
        List<Staff> Last4Staff();
    }
}
