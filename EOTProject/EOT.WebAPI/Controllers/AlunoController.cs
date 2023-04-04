
using System.Collections.Generic;
using System.Linq;
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
                Id = 2,
                Nome = "Maria",
                Sobrenome = "Olimpio",
                Telefone = "78456321"

            },
            new Aluno() {
                Id = 3,
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

        // api/aluno/id
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var alunos = Alunos.FirstOrDefault( a => a.Id == id);
            if(alunos == null) return BadRequest("O aluno não foi encontrado.");
            return Ok(id);
        }

         // api/aluno/byname?nome=Eduardo&sobrenome=Olimpio
        [HttpGet("ByName")]
        public IActionResult GetByName(string nome, string Sobrenome)
        {
            var aluno = Alunos.FirstOrDefault( a => a.Nome.Contains(nome) && a.Sobrenome.Contains(Sobrenome));
            if(aluno == null) return BadRequest("O aluno não foi encontrado.");
            return Ok(aluno);
        }

        //query string byid?id=1
        // api/aluno/id
        [HttpGet("ById")]
        public IActionResult QueryString(int id)
        {
            var alunos = Alunos.FirstOrDefault( a => a.Id == id);
            if(alunos == null) return BadRequest("O aluno não foi encontrado.");
            return Ok(id);
        }

        [HttpPost()]
        public IActionResult Post()
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
            var alunos = Alunos.FirstOrDefault( a => a.Id == id);
            if(alunos == null) return BadRequest("O aluno não foi encontrado.");
            return Ok(id);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var alunos = Alunos.FirstOrDefault( a => a.Id == id);
            if(alunos == null) return BadRequest("O aluno não foi encontrado.");
            return Ok(id);
        }
    }
}