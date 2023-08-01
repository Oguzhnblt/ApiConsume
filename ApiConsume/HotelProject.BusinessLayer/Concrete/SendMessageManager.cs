using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{

    public class SendMessageManager : ISendMessageService
    {
        private readonly ISendMessage _sendMessage;

        public SendMessageManager(ISendMessage sendMessage)
        {
            _sendMessage = sendMessage;
        }

        public void TDelete(SendMessage entity)
        {
            _sendMessage.Delete(entity);
        }

        public SendMessage TGetByID(int id)
        {
            return _sendMessage.GetByID(id);
        }

        public List<SendMessage> TGetList()
        {
            return _sendMessage.GetList();

        }

        public void TInsert(SendMessage entity)
        {
            _sendMessage.Insert(entity);
        }

        public void TUpdate(SendMessage entity)
        {
            _sendMessage.Update(entity);
        }
    }
}



