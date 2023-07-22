using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class SubscribeManager : IGenericService<Subscribe>
    {
        private readonly ISubscribe _subscribe;

        public SubscribeManager(ISubscribe subscribe)
        {
            _subscribe = subscribe;
        }

        public void TDelete(Subscribe entity)
        {
            _subscribe.Delete(entity);
        }

        public Subscribe TGetByID(int id)
        {
            return _subscribe.GetByID(id);
        }

        public List<Subscribe> TGetList()
        {
            return _subscribe.GetList();
        }

        public void TInsert(Subscribe entity)
        {
            _subscribe.Insert(entity);
        }

        public void TUpdate(Subscribe entity)
        {
            _subscribe.Update(entity);
        }
    }
}
