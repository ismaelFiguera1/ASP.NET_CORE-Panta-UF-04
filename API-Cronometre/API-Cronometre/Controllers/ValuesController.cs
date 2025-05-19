using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace API_Cronometre.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Salutacio()
        {
            var persona = new Persona(02, "Ismael");
            var persona1 = new Persona(03, "Pau");
            var persona2 = new Persona(23, "Eric");

            var array = new List<Object> { 1, 3, 5, 7, 9, 11, persona, persona1, persona2 };

            return Ok(array);
        }
    }
}
