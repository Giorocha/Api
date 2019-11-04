using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Roman.WebApi.Domains;
using Senai.Roman.WebApi.Interfaces;
using Senai.Roman.WebApi.Repositories;

namespace Senai.Roman.WebApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ProjetosController : ControllerBase
    {
        private IProjetoRepository ProjetoRepository { get; set; }

        public ProjetosController()
        {
            ProjetoRepository = new ProjetoRepository();
        }

        [Authorize]
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(ProjetoRepository.Listar());
        }

        [Authorize]
        [HttpPost]
        public IActionResult Cadastrar(Projetos projeto)
        {
            try
            {
                ProjetoRepository.Cadastrar(projeto);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(new { mensagem = "Erro de cadastro" + ex.Message });
            }
        }
    }
}