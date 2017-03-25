using Decorator.DomainModel;
using Decorator.DomainModel.Decorators.Arma;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var arma = new ArmaSimples();
            arma.Nome = "Taurus";
            arma.Montar();

            var montadorDeMira = new ArmaComMira(arma);
            montadorDeMira.Montar();

            var montadorDeSilenciador = new ArmaComSilenciador(arma);
            montadorDeSilenciador.Montar();
            Console.WriteLine(arma.Nome);
            Console.ReadKey();

        }
    }
}
