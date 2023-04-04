
using System.Collections.Generic;
using EOT.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EOT.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>() {
            new Aluno() {
                Id = 1,
                Nome = "Eduardo",
                Sobrenome = "Olimpio",
                Telefone = "123456789",

            },
            new Aluno() {
                Id = 1,
                Nome = "Maria",
                 Sobrenome = "Olimpio",
                Telefone = "78456321"

            },
            new Aluno() {
                Id = 1,
                Nome = "Marcele",
                 Sobrenome = "Olimpio",
                Telefone = "123456"

            },
        };

        public AlunoController() { }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }
    }
}