using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EFMessageCategory : GenericRepository<MessageCategory>, IMessageCategory
    {
        public EFMessageCategory(Context context) : base(context)
        {
        }
    }
}
