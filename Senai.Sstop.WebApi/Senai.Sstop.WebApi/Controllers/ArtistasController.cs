using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Sstop.WebApi.Domains;
using Senai.Sstop.WebApi.Repositories;

namespace Senai.Sstop.WebApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ArtistasController : ControllerBase
    {

        ArtistaRepository artistaRepository = new ArtistaRepository();

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(artistaRepository.Listar());
        }

        [HttpPost]
        public IActionResult Cadastrar(ArtistaDomain artista)
        {
            try
            {
                // tenta fazer alguma coisa
                artistaRepository.Cadastrar(artista);
                // 200
                return Ok();
                // notfound - 404
            }
            catch (Exception ex )
            {
                // plano b
                //400
                return BadRequest(new { mensagem = "Deu erro ai rapaz!" + ex.Message });
            }
          
        }
    }
}