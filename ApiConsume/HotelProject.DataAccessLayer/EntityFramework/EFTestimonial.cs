using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EFTestimonial : GenericRepository<Testimonial>, ITestimonial
    {
        public EFTestimonial(Context context) : base(context)
        {
        }
    }
}
