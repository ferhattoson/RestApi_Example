using System.ComponentModel.DataAnnotations;

namespace RestApi2.model
{
    public class kisi
    {
        public int Id { get; set; }
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        
    }
}
