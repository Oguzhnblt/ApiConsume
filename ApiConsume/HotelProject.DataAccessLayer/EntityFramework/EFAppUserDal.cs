using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EFAppUserDal : GenericRepository<AppUser>, IAppUser
    {
        public EFAppUserDal(Context context) : base(context)
        {
        }

        public int AppUserCount()
        {
           var context = new Context();
            var value = context.Users.Count();
            return value;
        }

        public List<AppUser> UserListWithWorkLocation()
        {
            var context = new Context();
            return context.Users.Include(x => x.WorkLocation).ToList();
        }
    }
}
