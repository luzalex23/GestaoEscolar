using Domain.Entities;
using Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IFuncionarioService
    {
        Task AddFuncionario(Funcionario funcionario);
        Task UpdateFuncionario(Funcionario funcionario);
    }
}
