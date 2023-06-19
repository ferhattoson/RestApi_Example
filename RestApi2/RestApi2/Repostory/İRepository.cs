using RestApi2.Entity;

namespace RestApi2.Repostory.Abstract
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        T Get(int id);
        T Insert(T entity);
        T Update(T entity);
    }
}
