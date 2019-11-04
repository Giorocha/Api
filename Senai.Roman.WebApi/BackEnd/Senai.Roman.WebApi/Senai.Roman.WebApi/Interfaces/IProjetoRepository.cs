using Senai.Roman.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Roman.WebApi.Interfaces
{
    interface IProjetoRepository
    {
        List<Projetos> Listar();
        void Cadastrar(Projetos projeto);
    }
}
