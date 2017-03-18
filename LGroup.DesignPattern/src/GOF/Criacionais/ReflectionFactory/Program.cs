using ReflectionFactory.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var quadrado = DesenhoFactory.Create("quadrado");
            var circulo = DesenhoFactory.Create("circulo");
            quadrado.Desenhar();
            circulo.Desenhar();

            Console.ReadKey();

        }
    }
}
