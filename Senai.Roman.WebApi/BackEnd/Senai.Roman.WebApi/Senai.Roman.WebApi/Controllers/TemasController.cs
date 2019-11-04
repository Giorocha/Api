using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Roman.WebApi.Interfaces;
using Senai.Roman.WebApi.Repositories;

namespace Senai.Roman.WebApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class TemasController : ControllerBase
    {

        private ITemaRepository TemaRepository { get; set; }

        public TemasController()
        {
            TemaRepository = new TemaRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(TemaRepository.Listar());
        }
    }
}