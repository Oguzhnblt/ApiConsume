using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IAppUser : IGeneric<AppUser>
    {
        List<AppUser> UserListWithWorkLocation();
        int AppUserCount();
    }
}
