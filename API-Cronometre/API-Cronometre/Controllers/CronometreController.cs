using Microsoft.AspNetCore.Mvc;
using API_Cronometre.Services;
using API_Cronometre;

namespace API_Cronometre.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CronometreController : ControllerBase
    {
        private readonly CronometreService _servei;

        public CronometreController(CronometreService servei)
        {
            _servei = servei;
        }

        [HttpPost("{id}/iniciar")]
        public IActionResult IniciarPorId(Guid id)
        {
            bool iniciat = _servei.IniciarCronometre(id);

            if (iniciat)
            {
                return Ok($"Cronòmetre {id} iniciat.");
            }
            else
            {
                return NotFound($"No s'ha trobat cap cronòmetre amb ID {id}");
            }

            
        }





        [HttpGet("llistar")]
        public ActionResult<Cronometre> Llistar()
        {
            List<Cronometre> llistaCronometres = _servei.ObtenirCronometres();
            return Ok(llistaCronometres);
        }




        [HttpGet("{id}/estat")]
        public ActionResult<Cronometre> EstatPerId(Guid id)
        {
            Cronometre? resultat = _servei.EstatCronometre(id);

            if (resultat == null)
            {
                return NotFound($"No s'ha trobat cap cronòmetre amb ID {id}");
            }

            return Ok(resultat);
        }
    }
}
