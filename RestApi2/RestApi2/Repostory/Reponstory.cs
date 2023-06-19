using RestApi2.Entity;
using RestApi2.Repostory.Abstract;

namespace RestApi2.Repostory
{
    public class Reponstory<T> : IRepository<T> where T : BaseEntity

    {
        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }


}
