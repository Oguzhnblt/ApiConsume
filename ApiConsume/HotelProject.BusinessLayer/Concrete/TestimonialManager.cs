using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonial _testimonial;

        public TestimonialManager(ITestimonial testimonial)
        {
            _testimonial = testimonial;
        }

        public void TDelete(Testimonial entity)
        {
            _testimonial.Delete(entity);
        }

        public Testimonial TGetByID(int id)
        {
            return _testimonial.GetByID(id);
        }

        public List<Testimonial> TGetList()
        {
            return _testimonial.GetList();
        }

        public void TInsert(Testimonial entity)
        {
            _testimonial.Insert(entity);    
        }

        public void TUpdate(Testimonial entity)
        {
           _testimonial.Update(entity);
        }
    }
}
