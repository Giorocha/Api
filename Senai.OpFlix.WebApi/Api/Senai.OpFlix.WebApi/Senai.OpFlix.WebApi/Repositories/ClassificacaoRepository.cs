using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Senai.OpFlix.WebApi.Domains;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Senai.OpFlix.WebApi.Repositories
{
   
    
        public class ClassificacaoRepository
        {
            OpFlixContext ctx = new OpFlixContext();

            public List<Classificacoes> Listar()
            {
                return ctx.Classificacoes.ToList();
            }
        }
    }

