﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IFuncionario : IGeneric<Funcionario>
    {
        public bool Ativo { get; set; }
        public double Salario {  get; set; }
    }
}
