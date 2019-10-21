using Microsoft.EntityFrameworkCore;
using Senai.OpFlix.WebApi.Domains;
using Senai.OpFlix.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.OpFlix.WebApi.Repositories
{
    public class LancamentoRepository : ILancamentoRepository
    {
        public void Atualizar(Lancamentos lancamento)
        {
            using (OpFlixContext ctx = new OpFlixContext())
            {
                Lancamentos LancamentosRetornado = ctx.Lancamentos.FirstOrDefault(x => x.IdLancamento == lancamento.IdLancamento);
                LancamentosRetornado.Titulo = lancamento.Titulo;
                LancamentosRetornado.Sinopse = lancamento.Sinopse;
                LancamentosRetornado.DuracaoMin = lancamento.DuracaoMin;
                LancamentosRetornado.DataLancamento = lancamento.DataLancamento;
                LancamentosRetornado.IdPlataforma = lancamento.IdPlataforma;
                LancamentosRetornado.IdCategoria = lancamento.IdCategoria;
                LancamentosRetornado.IdClassificao = lancamento.IdClassificao;
                LancamentosRetornado.IdTipoLancamento = lancamento.IdTipoLancamento;
                ctx.Lancamentos.Update(LancamentosRetornado);
                ctx.SaveChanges();

            }
        }

        public Lancamentos BuscarPorId(int id)
        {
            using (OpFlixContext ctx = new OpFlixContext())
            {
                return ctx.Lancamentos.Include(x => x.IdPlataformaNavigation).Include(x => x.IdCategoriaNavigation).Include(x => x.IdClassificaoNavigation).Include(x => x.IdTipoLancamentoNavigation).FirstOrDefault(x => x.IdLancamento == id);

            }
        }

       
        public void Cadastrar(Lancamentos lancamento)
        {
            using (OpFlixContext ctx = new OpFlixContext())
            {
                ctx.Lancamentos.Add(lancamento);
                ctx.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            using (OpFlixContext ctx = new OpFlixContext())
            {
                Lancamentos lancamento = ctx.Lancamentos.Find(id);
                ctx.Lancamentos.Remove(lancamento);
                ctx.SaveChanges();
            }
        }

        public List<Lancamentos> Listar()
        {
            using (OpFlixContext ctx = new OpFlixContext())
            {
                return ctx.Lancamentos.Include(x => x.IdPlataformaNavigation).Include(x => x.IdCategoriaNavigation).Include(x => x.IdClassificaoNavigation).Include(x => x.IdTipoLancamentoNavigation).ToList();
            }
        }

        public List<Lancamentos> BuscarPorPlataforma(string nome)
        {
            using (OpFlixContext ctx = new OpFlixContext())

                return ctx.Lancamentos.Include(x => x.IdPlataformaNavigation).Where(x => x.IdPlataformaNavigation.Nome == nome).ToList();
            
        }

        public List<Lancamentos> BuscarPorDataLancamento(DateTime data)
        {
            using (OpFlixContext ctx = new OpFlixContext())

                return ctx.Lancamentos.Where(x => x.DataLancamento == data).ToList();
        }
    }
}
