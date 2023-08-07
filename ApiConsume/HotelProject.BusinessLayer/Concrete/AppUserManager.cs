using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUser _appUser;

        public AppUserManager(IAppUser about)
        {
            _appUser = about;
        }

        public int TAppUserCount()
        {
            return _appUser.AppUserCount();
        }

        public void TDelete(AppUser entity)
        {
            _appUser.Delete(entity);
        }

        public AppUser TGetByID(int id)
        {
            return _appUser.GetByID(id);
        }

        public List<AppUser> TGetList()
        {
            return _appUser.GetList();

        }

        public void TInsert(AppUser entity)
        {
            _appUser.Insert(entity);
        }

        public void TUpdate(AppUser entity)
        {
            _appUser.Update(entity);
        }

        public List<AppUser> TUserListWithWorkLocation()
        {
            return _appUser.UserListWithWorkLocation();
        }
    }
}
