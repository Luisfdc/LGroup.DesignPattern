using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.JeitoCerto
{
    public class Vendedor : IComissionado
    {
        public string Nome { get; set; }

        public decimal TaxaComissao { get; set; }

        public decimal GetSalario()
        {
            return GetTotalVendas() * TaxaComissao;
        }

        public decimal GetTotalVendas()
        {
            return 120000;
        }
    }
}
