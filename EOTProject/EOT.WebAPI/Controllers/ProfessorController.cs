
using Microsoft.AspNetCore.Mvc;

namespace EOT.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {
        public ProfessorController() { }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Professores: Eduardo, Marcele, Maria.");
        }
    }
}