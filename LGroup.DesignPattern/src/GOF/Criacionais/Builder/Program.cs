using Builder.Builders;
using Builder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {

            Carro carro = new Carro
            {
                Motor = "V4",
                Ano = 2017,
                Cor = "Amarelo",
                Preco = 35000M,
            };

            var fiat = new VwBuilder();
            var director = new DirectorBuilder(fiat);

            director.Builder(carro);

            decimal total = director.GetCarro().GetTotal();
            Console.WriteLine(total);
            Console.ReadKey();
        }
    }
}
