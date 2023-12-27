using Application.Services.Interfaces;
using Domain.Entities;
using Domain.Entities.Enums;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class FuncionarioService : IFuncionarioService
    {
        private readonly IFuncionario _ifuncionario;
        public FuncionarioService(IFuncionario ifuncionario)
        {
            _ifuncionario = ifuncionario;
        }
      

        public async Task AddFuncionario(Funcionario funcionario)
        {
            var valido = funcionario.ValidarPropriedadeString(funcionario.Nome, "Nome");
            if (valido)
                await _ifuncionario.Add(funcionario);
        }

        public async Task UpdateFuncionario(Funcionario funcionario)
        {
            var valido = funcionario.ValidarPropriedadeString(funcionario.Nome, "Nome");
            if (valido)
                await _ifuncionario.Update(funcionario);
        }
    }
}
