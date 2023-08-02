using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class MessageCategoryManager : IMessageCategoryService
    {
        private readonly IMessageCategory _messageCategory;

        public MessageCategoryManager(IMessageCategory guest)
        {
            _messageCategory = guest;
        }

        public void TDelete(MessageCategory entity)
        {
            _messageCategory.Delete(entity);
        }

        public MessageCategory TGetByID(int id)
        {
            return _messageCategory.GetByID(id);
        }

        public List<MessageCategory> TGetList()
        {
            return _messageCategory.GetList();

        }

        public void TInsert(MessageCategory entity)
        {
            _messageCategory.Insert(entity);
        }

        public void TUpdate(MessageCategory entity)
        {
            _messageCategory.Update(entity);
        }
    }
}

