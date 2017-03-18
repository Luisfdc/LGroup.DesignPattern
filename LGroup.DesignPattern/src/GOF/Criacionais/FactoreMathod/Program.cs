using FactoryMathod.Factoreis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMathod
{
    class Program
    {
        static void Main(string[] args)
        {
            var abacaxiUSA = AbacaxiFactory.Create(Models.EstacaoAno.Inverno);

            var abacaxiBR = AbacaxiFactory.Create(Models.EstacaoAno.Verao);

            Console.WriteLine(abacaxiBR.GetDescricao());
            Console.WriteLine(abacaxiUSA.GetDescricao());
            Console.ReadKey();
        }
    }
}
