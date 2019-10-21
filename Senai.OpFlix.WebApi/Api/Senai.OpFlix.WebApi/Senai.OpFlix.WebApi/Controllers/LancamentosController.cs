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
    public class LancamentosController : ControllerBase
    {
        private ILancamentoRepository LancamentoRepository { get; set; }

        public LancamentosController()
        {
            LancamentoRepository = new LancamentoRepository();
        }

        [Authorize(Roles = "ADMINISTRADOR")]
        [HttpPost]
        public IActionResult Cadastrar(Lancamentos lancamento)
        {
            try
            {
                LancamentoRepository.Cadastrar(lancamento);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = "Erro ao cadastrar" + ex.Message });
            }
        }

        [Authorize]
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(LancamentoRepository.Listar());
        }

        [Authorize(Roles = "ADMINISTRADOR")]
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            LancamentoRepository.Deletar(id);
            return Ok();
        }

        [Authorize(Roles = "ADMINISTRADOR")]
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            Lancamentos lancamento = LancamentoRepository.BuscarPorId(id);
            if (lancamento == null)
                return NotFound();
            return Ok(lancamento);
        }

        [Authorize(Roles = "ADMINISTRADOR")]
        [HttpPut]
        public IActionResult Atualizar(Lancamentos lancamento)
        {
            try
            {
                Lancamentos LancamentoBuscado = LancamentoRepository.BuscarPorId(lancamento.IdLancamento);
                if (LancamentoBuscado == null)
                    return NotFound();

                LancamentoRepository.Atualizar(lancamento);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = "Erro ao atualizar" + ex.Message });
            }
        }

        [Authorize(Roles = "ADMINISTRADOR")]
        [HttpGet("filtroplataforma/{nome}")]
        public IActionResult BuscarLancamentoPorPlataforma(string nome)
        {
            List<Lancamentos> Lancamento = LancamentoRepository.BuscarPorPlataforma(nome);

            if (Lancamento == null)
            {
                return NotFound();
            }
            return Ok(Lancamento);
        }

        [Authorize(Roles = "ADMINISTRADOR")]
        [HttpGet("filtrodata/{data}")]
        public IActionResult BuscarLancamentoPorData(DateTime data)
        {
            List<Lancamentos> Lancamento = LancamentoRepository.BuscarPorDataLancamento(data);

            if (Lancamento == null)
            {
                return NotFound();
            }
            return Ok(Lancamento);
        }
    }
}