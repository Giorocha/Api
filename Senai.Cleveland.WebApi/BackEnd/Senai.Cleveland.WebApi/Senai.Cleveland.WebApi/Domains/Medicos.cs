using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.Cleveland.WebApi.Domains
{
    public partial class Medicos
    {
        public int IdMedico { get; set; }
        public string Nome { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Nascimento { get; set; } 
        public long? Crm { get; set; }
        public string Especialidade { get; set; }
        public string Ativo { get; set; }
    }
}
