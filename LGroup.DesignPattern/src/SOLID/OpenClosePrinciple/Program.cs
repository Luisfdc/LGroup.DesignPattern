using OpenClosePrinciple.JeitoCerto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    class Program
    {
        public static object Calculadora { get; private set; }

        static void Main(string[] args)
        {
            //Jeito Errado
            var operar1 = new JeitoErrado.OperacoesMatematica();
            var soma = operar1.Operar(1, 1, JeitoErrado.TipoOperacao.Soma);

            // Jeito Certo
            var operar2 = new Calculadora();
            var soma2 = new Soma { NumA = 1, NumB = 1 };

            var somar = operar2.Operar(soma2);

            Console.WriteLine(string.Concat("Soma ", somar));

            var subtracao = new Subtracao { NumA = 1, NumB = 1 };

            var subtrair = operar2.Operar(subtracao);
            Console.WriteLine(string.Concat("Subtracao ", subtrair));


            var multiplicacao = new Multiplicacao { NumA = 1, NumB = 1 };

            var multiplicar = operar2.Operar(multiplicacao);

            Console.WriteLine(string.Concat("Multiplicação ", multiplicar));
            Console.ReadKey();


        }
    }
}
