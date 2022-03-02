using contactosPruebas.Entities;
using contactosPruebas.Services;
using Microsoft.AspNetCore.Mvc;

namespace contactosPruebas.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ContactoController : ControllerBase
    {

        private IContactoService _contactoService;
        public ContactoController(IContactoService contactoService)
        {
            _contactoService = contactoService;
        }

        [HttpGet]
      //  [Route("GettAll")]
        public IActionResult GetAll()
        {
            try
            {
                return StatusCode(200, _contactoService.Get());
            }
            catch (System.Exception err)
            {
                return StatusCode(500, err.Message);
            }
        }

        [HttpPost]
       // [Route("Save")]
        public IActionResult Save(Contacto contacto)
        {
            try
            {
                _contactoService.Save(contacto);
                return StatusCode(201);
            }
            catch (System.Exception err)
            {
                return StatusCode(500, err.Message);
            }
        }

    }
}
