using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.AutoPecas.WebApi.Domains;
using Senai.AutoPecas.WebApi.Repositories;

namespace Senai.AutoPecas.WebApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class PecasController : ControllerBase
    {
        PecasRepository PecasRepository = new PecasRepository();

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(PecasRepository.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            Pecas peca = PecasRepository.BuscarPorId(id);
            if (peca == null)
                return NotFound();
            return Ok(peca);
        }

        [HttpPost]
        public IActionResult Cadastrar (Pecas peca)
        {
            try
            {
                PecasRepository.Cadastrar(peca);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = "Erro ao cadastrar" + ex.Message });
            }
        }
    }
}