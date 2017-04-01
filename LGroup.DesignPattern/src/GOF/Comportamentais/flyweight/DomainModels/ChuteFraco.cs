using flyweight.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyweight.DomainModels
{
    public class ChuteFraco : IGolpe
    {
        public void Executar()
        {
            Console.WriteLine("Chute Fraco sendo executado!");
        }
    }
}
