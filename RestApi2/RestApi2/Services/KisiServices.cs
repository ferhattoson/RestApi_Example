using RestApi2.Entity;
using RestApi2.model;
using RestApi2.Repostory;
using RestApi2.Services.Abstract;
using System.Linq;

namespace RestApi2.Services
{
    public class KisiS4ervices : IKisiServices
    {
        private readonly IRepository<KisiEntity> _repository;

        public KisiS4ervices(IRepository<KisiEntity> repository)
        {
            _repository = repository;
        }

        public IQueryable<kisi> GetAll()
        {
            return (IQueryable<kisi>)_repository.GetAll();
        }

        public kisi InsertKisi(kisi k)
        {
            var entity = new KisiEntity { ad = k.Ad, soyad = k.Soyad };
            //var result = _repository.Insert(entity);
            KisiEntity KisiEntity = _repository.Insert(Entity);
            return KisiEntity;
        }
    }
}
