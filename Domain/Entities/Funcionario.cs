using Domain.Entities.Enums;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Funcionario : BaseDomain, IFuncionario
    {
        public bool Ativo { get; set; }
        public double Salario { get; set; }
        public Cargos cargos { get; set; }
    }
}
