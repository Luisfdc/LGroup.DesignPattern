using DomainEvents.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            var venda = new Venda();

            venda.Finalizar();
            Console.ReadKey();
        }
    }
}
