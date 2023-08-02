using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface ISendMessage : IGeneric<SendMessage>
    {
        public int GetSendMessageCount();

    }
}
