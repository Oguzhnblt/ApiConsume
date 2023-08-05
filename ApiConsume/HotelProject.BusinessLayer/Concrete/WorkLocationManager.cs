using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class WorkLocationManager : IWorkLocationService
    {
        private readonly IWorkLocation _workLocation;

        public WorkLocationManager(IWorkLocation about)
        {
            _workLocation = about;
        }

        public void TDelete(WorkLocation entity)
        {
            _workLocation.Delete(entity);
        }

        public WorkLocation TGetByID(int id)
        {
            return _workLocation.GetByID(id);
        }

        public List<WorkLocation> TGetList()
        {
            return _workLocation.GetList();

        }

        public void TInsert(WorkLocation entity)
        {
            _workLocation.Insert(entity);
        }

        public void TUpdate(WorkLocation entity)
        {
            _workLocation.Update(entity);
        }
    }
}
