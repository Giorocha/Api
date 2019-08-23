using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Filmes.WebApi.Domains;
using Senai.Filmes.WebApi.Repositories;

namespace Senai.Filmes.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class FilmesController : ControllerBase
    {
        FilmesRepository filmesRepository = new FilmesRepository();

        [HttpGet]
        public IEnumerable<FilmesDomain> Listar()
        {
            return filmesRepository.Listar();
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            FilmesDomain filmesDomain = filmesRepository.BuscarPorId(id);
            if (filmesDomain == null)
                return NotFound();
            return Ok(filmesDomain);
        }



        [HttpPost]
        public IActionResult Cadastrar(FilmesDomain filme)
        {
            try
            {
                filmesRepository.Cadastrar(filme);
                return Ok();
            }
            catch (Exception ex )
            {
                return BadRequest(new { mensagem = "Deu erro ai rapaz!" + ex.Message });
                
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            filmesRepository.Deletar(id);
            return Ok();
        }

    }   
}