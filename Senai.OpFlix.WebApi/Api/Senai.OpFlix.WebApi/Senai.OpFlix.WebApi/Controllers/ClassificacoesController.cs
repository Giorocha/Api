using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Senai.OpFlix.WebApi.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Senai.OpFlix.WebApi.Controllers
{
        [Route("api/[controller]")]
        [Produces("application/json")]
        [ApiController]
    public class ClassificacoesController : Controller
    { 
   
            ClassificacaoRepository ClassificacaoRepository = new ClassificacaoRepository();

            [Authorize]
            [HttpGet]
            public IActionResult ListarClassificacoes()
            {
                return Ok(ClassificacaoRepository.Listar());
            }
        
    }
}
