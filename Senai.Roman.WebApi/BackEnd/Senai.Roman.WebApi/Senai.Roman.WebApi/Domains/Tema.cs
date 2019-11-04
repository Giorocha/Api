using System;
using System.Collections.Generic;

namespace Senai.Roman.WebApi.Domains
{
    public partial class Tema
    {
        public Tema()
        {
            Projetos = new HashSet<Projetos>();
        }

        public int IdTema { get; set; }
        public string Nome { get; set; }

        public ICollection<Projetos> Projetos { get; set; }
    }
}
