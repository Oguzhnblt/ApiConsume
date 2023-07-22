namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IGeneric<T> where T : class
    {
        // CRUD işlemleri için gerekli metodlar
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);

        List<T> GetList();
        T GetByID(int id);
    }
}
