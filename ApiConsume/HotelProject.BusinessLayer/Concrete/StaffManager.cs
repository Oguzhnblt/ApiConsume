using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class StaffManager : IStaffService
    {
        private readonly IStaff _staff;

        public StaffManager(IStaff staff)
        {
            _staff = staff;
        }

        public void TDelete(Staff entity)
        {
            _staff.Delete(entity);
        }

        public Staff TGetByID(int id)
        {
            return _staff.GetByID(id);
        }

        public List<Staff> TGetList()
        {
            return _staff.GetList();
        }

        public void TInsert(Staff entity)
        {
            _staff.Insert(entity);
        }

        public void TUpdate(Staff entity)
        {
            _staff.Update(entity);
        }
    }
}
