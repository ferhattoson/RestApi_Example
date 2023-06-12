using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApi2.connect;
using RestApi2.model;

namespace RestApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class kisiController : ControllerBase
    {
        private readonly MyAppDbContext _context;

        public kisiController(MyAppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var kisil= _context.Kisi.ToList();
                if (kisil.Count == 0)
            {
                return NotFound("veri yok");
            }
                return Ok(kisil);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var kisil = _context.Kisi.Find(id);
            if (kisil == null)
            {
                return NotFound($"{id } kişi detayı yok yok");
            }
            return Ok(kisil);

        }
        [HttpPost]
        public IActionResult Post(kisi model)
        {
            _context.Kisi.Add(model);
            _context.SaveChanges();
            return Ok("kişi yarattıldı");
        }
        [HttpPut]
        public IActionResult Put(kisi model)
        {
            if (model == null)
            {
                return BadRequest("yok");

            }
            var kisil=_context.Kisi.Find(model.Id);
            kisil.Ad=model.Ad;
            kisil.Soyad=model.Soyad;
            _context.SaveChanges();
            return Ok("kayıt başarılı");
                
        }
    }
}
