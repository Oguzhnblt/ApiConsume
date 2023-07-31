using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {

        private readonly IContact _contact;

        public ContactManager(IContact contact)
        {
            _contact = contact;
        }

        public void TDelete(Contact entity)
        {
            _contact.Delete(entity);
        }

        public Contact TGetByID(int id)
        {
            return _contact.GetByID(id);
        }

        public List<Contact> TGetList()
        {
            return _contact.GetList();

        }

        public void TInsert(Contact entity)
        {
            _contact.Insert(entity);
        }

        public void TUpdate(Contact entity)
        {
            _contact.Update(entity);
        }
    }

}
