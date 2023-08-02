using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IContact : IGeneric<Contact>
    {
        public int GetContactCount();
    }
}
