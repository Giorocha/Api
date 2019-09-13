using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Peoples.WebApi.Domains;
using Senai.Peoples.WebApi.Repositories;

namespace Senai.Peoples.WebApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class FuncionariosController : ControllerBase
    {
        FuncionariosRepository funcionariosRepository = new FuncionariosRepository();

        [HttpGet]
        public IEnumerable<FuncionariosDomain> ListarTodos()
        {
            return funcionariosRepository.Listar();
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            FuncionariosDomain funcionariosDomain = funcionariosRepository.BuscarPorId(id);
            if (funcionariosDomain == null)
                return NotFound();
            return Ok(funcionariosDomain);

        }

        [HttpPost]
        public IActionResult Cadastrar (FuncionariosDomain funcionariosDomain)
        {
            funcionariosRepository.Cadastrar(funcionariosDomain);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            funcionariosRepository.Deletar(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar (FuncionariosDomain funcionariosDomain, int id)
        {
            funcionariosDomain.IdFuncionario = id;
            funcionariosRepository.Atualizar(funcionariosDomain);
            return Ok();
        }
    }
}