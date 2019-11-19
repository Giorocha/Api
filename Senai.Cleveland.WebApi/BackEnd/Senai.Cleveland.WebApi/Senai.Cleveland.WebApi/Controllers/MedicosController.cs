using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Senai.Cleveland.WebApi.Domains;
using Senai.Cleveland.WebApi.Repositories;

namespace Senai.Cleveland.WebApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class MedicosController : Controller
    {
        MedicoRepository MedicoRepository = new MedicoRepository();

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(MedicoRepository.Listar());
        }

        [HttpPost]
        public IActionResult Cadastrar(Medicos medico)
        {
            try
            {
                MedicoRepository.Cadastrar(medico);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = "erro ao cadastrar" + ex.Message });
            }
        }
    }
}