using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IService _service;

        public ServiceManager(IService service)
        {
            _service = service;
        }

        public void TDelete(Service entity)
        {
            _service.Delete(entity);
        }

        public Service TGetByID(int id)
        {
            return _service.GetByID(id);
        }

        public List<Service> TGetList()
        {
            return _service.GetList();
        }

        public void TInsert(Service entity)
        {
            _service.Insert(entity);
        }

        public void TUpdate(Service entity)
        {
            _service.Update(entity);
        }
    }
}
