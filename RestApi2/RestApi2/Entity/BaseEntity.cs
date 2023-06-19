using RestApi2.Entity.Abstract;

namespace RestApi2.Entity
{
    public class BaseEntity:IEntity
    {
        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }

    }
}
