using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Domains
{
    public class FuncionariosDomain
    {
        public int IdFuncionario { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string  Nome { get; set; }

        [Required(ErrorMessage = "O sobrenome é obrigatório.")]
        public string Sobrenome { get; set; }
    }
}
