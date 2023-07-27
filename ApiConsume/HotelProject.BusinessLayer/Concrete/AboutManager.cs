using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAbout _about;

        public AboutManager(IAbout about)
        {
            _about = about;
        }

        public void TDelete(About entity)
        {
            _about.Delete(entity);
        }

        public About TGetByID(int id)
        {
            return _about.GetByID(id);
        }

        public List<About> TGetList()
        {
            return _about.GetList();

        }

        public void TInsert(About entity)
        {
            _about.Insert(entity);
        }

        public void TUpdate(About entity)
        {
            _about.Update(entity);
        }
    }
}
