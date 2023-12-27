using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public abstract class BaseDomain : Valida
    {
        [Display(Name = "Codigo")]

        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Display(Name = "Idade")]
        public int Idade {  get; set; }
        [Display(Name = "DtCriacao")]
        public DateTime CadastradoEm {  get; set; }
    }
}
