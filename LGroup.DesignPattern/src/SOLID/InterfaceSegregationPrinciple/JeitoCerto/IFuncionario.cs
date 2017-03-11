using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.JeitoCerto
{
    public interface IFuncionario
    {
        string Nome { get; set; }
        decimal GetSalario();
    }
}
