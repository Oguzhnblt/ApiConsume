using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EFStaffDal : GenericRepository<Staff>, IStaff
    {
        public EFStaffDal(Context context) : base(context)
        {
        }
    }
}
