namespace RestApi2.Repostory
{
    public class Reponstory<t> : IRepository<t> where t : BaseEntiity

    {
        public void Add(t entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(t entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<t> GetAll()
        {
            throw new NotImplementedException();
        }

        public t GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(t entity)
        {
            throw new NotImplementedException();
        }
    }

    
}
