using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamplateMethod.DomainModel;

namespace TamplateMethod
{
    class Program
    {
        //O tamplante method pressupoe que você tenha um template de base
        //Seria como um espelho para sua classe
        static void Main(string[] args)
        {
            var vendaAmericanas = new VendaAmericanas();
            vendaAmericanas.Finalizar("11111111111");


            var vendasCasasBahia = new VendasCasasBahia();
            vendaAmericanas.Finalizar("11111111111");

            Console.ReadKey();
        }
    }
}
