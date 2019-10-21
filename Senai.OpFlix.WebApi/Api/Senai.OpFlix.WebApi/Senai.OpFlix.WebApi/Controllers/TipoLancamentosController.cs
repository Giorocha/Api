using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.OpFlix.WebApi.Domains;
using Senai.OpFlix.WebApi.Interfaces;
using Senai.OpFlix.WebApi.Repositories;

namespace Senai.OpFlix.WebApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class TipoLancamentosController : ControllerBase
    {
        private ITipoLancamentoRepository TipoLancamentoRepository { get; set; }

        public TipoLancamentosController()
        {
            TipoLancamentoRepository = new TipoLancamentoRepository();
        }

        [Authorize]
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(TipoLancamentoRepository.Listar());
        }

        [Authorize(Roles = "ADMINISTRADOR")]
        [HttpPost]
        public IActionResult Cadastrar(TipoLancamento tipinho)
        {
            try
            {
                TipoLancamentoRepository.Cadastrar(tipinho);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = "Erro ao cadastrar" + ex.Message });
            }
        }

        [Authorize(Roles = "ADMINISTRADOR")]
        [HttpPut]
        public IActionResult Atualizar(TipoLancamento tipinho)
        {
            try
            {
                TipoLancamento TipinhoBuscado = TipoLancamentoRepository.BuscarPorId(tipinho.IdTipoLancamento);
                if (TipinhoBuscado == null)
                    return NotFound();
                TipoLancamentoRepository.Atualizar(tipinho);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = "Erro ao atualizar" + ex.Message });
            }
        }
    }
}