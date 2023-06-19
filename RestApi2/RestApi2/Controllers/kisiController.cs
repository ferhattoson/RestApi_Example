using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApi2.connect;
using RestApi2.model;
using RestApi2.Services.Abstract;

namespace RestApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class kisiController : ControllerBase
    {
        // private readonly MyAppDbContext _context;

        /* public kisiController(MyAppDbContext context)
         {
             _context = context;
         }*/
        private readonly IKisiServices _kisiServices;

        public kisiController(IKisiServices kisiServices)
        {
            _kisiServices = kisiServices;
        }
        [HttpPost]
        public IActionResult Insert(kisi k)
        {
            var result = _kisiServices.InsertKisi(k);
            return Ok(result);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _kisiServices.GetAll();
            return Ok(result);
        }
    }

}

