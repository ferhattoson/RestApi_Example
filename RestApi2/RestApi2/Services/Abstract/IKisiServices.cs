using RestApi2.model;

namespace RestApi2.Services.Abstract
{
    public interface IKisiServices
    {
        kisi InsertKisi(kisi K);
        IQueryable<kisi> GetAll();
    }
}
