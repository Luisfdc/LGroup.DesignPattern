using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.JeitoCerto
{
    public class Publico : IAssalariado
    {
        public string Nome { get; set; }

        public decimal SalarioFixo { get; set; }

        public decimal GetSalario()
        {
            return SalarioFixo;
        }

        public void SairDeFerias()
        {
            Console.WriteLine("Fui para Praia!");
        }
    }
}
