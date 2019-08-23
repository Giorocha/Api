using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.BookStore.ebApi.Domains;
using Senai.BookStore.ebApi.Repositories;

namespace Senai.BookStore_.ebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class AutoresController : ControllerBase
    {
        AutoresRepository autoresRepository = new AutoresRepository();

        [HttpPost]
        public IActionResult Cadastrar(AutoresDomain autor)
        {
            autoresRepository.Cadastrar(autor);
            return Ok();
        }
    }
}