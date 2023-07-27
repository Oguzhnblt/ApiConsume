using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EFAboutDal : GenericRepository<About>, IAbout
    {
        public EFAboutDal(Context context) : base(context)
        {
        }
    }
}
