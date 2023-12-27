using Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class FuncionarioDTO
    {
        public int id {  get; set; }
        public string nome { get; set; }
        public int idade {  get; set; }
        public bool ativo { get; set; }
        public double salario {  get; set; }
        public Cargos cargo { get; set; }
        public DateTime CadastradoEm { get; set; }

    }
}
