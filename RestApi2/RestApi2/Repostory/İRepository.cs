namespace RestApi2.Repostory
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();
        T Get(int id);
        T Insert(T entity);
        T Update(T entity);
    }
}
