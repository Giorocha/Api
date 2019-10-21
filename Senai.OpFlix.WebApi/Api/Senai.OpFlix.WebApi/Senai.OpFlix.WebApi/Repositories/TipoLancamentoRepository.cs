using Senai.OpFlix.WebApi.Domains;
using Senai.OpFlix.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.OpFlix.WebApi.Repositories
{
    public class TipoLancamentoRepository : ITipoLancamentoRepository
    {
        public void Atualizar(TipoLancamento tipoLancamento)
        {
            using (OpFlixContext ctx = new OpFlixContext())
            {
                TipoLancamento TipinhoRetornado = ctx.TipoLancamento.FirstOrDefault(x => x.IdTipoLancamento == tipoLancamento.IdTipoLancamento);
                TipinhoRetornado.Tipo = tipoLancamento.Tipo;
                ctx.TipoLancamento.Update(TipinhoRetornado);
                ctx.SaveChanges();
            }
        }

        public TipoLancamento BuscarPorId(int id)
        {
            using (OpFlixContext ctx = new OpFlixContext())
            {
                return ctx.TipoLancamento.FirstOrDefault(x => x.IdTipoLancamento == id);
            }
        }

        public void Cadastrar(TipoLancamento tipoLancamento)
        {
            using (OpFlixContext ctx = new OpFlixContext())
            {
                ctx.TipoLancamento.Add(tipoLancamento);
                ctx.SaveChanges();
            }
        }

        public List<TipoLancamento> Listar()
        {
            using (OpFlixContext ctx = new OpFlixContext())
            {
                return ctx.TipoLancamento.ToList();
            }
        }
    }
}
