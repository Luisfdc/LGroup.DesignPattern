using FactoryMathod.DomainModel.Cotracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMathod.Models
{
    public class AbacaxiAmericano : IAbacaxi
    {
        public string Localizacao { get; set; }

        public string Nome { get; set; }

        public string GetDescricao()
        {
            return $"{this.Nome} - {this.Localizacao}";
        }
    }
}
