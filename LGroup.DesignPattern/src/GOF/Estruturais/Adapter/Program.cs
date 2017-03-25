using Adapter.Contracts;
using Adapter.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogistica estoque = EstoqueFactory.Create(TipoEstoque.LGroup);
            estoque.BaixarEstoque(1, 1);

            ILogistica estoqueM = EstoqueFactory.Create(TipoEstoque.Magento);
            estoqueM.BaixarEstoque(2, 2);

            Console.ReadKey();
        }
    }
}
