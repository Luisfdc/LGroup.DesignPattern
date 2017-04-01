using flyweight.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyweight.DomainModels
{
    public class Cabecada : IGolpe
    {
        public void Executar()
        {
            Console.WriteLine("Cabeçada sendo executada!");
        }
    }
}
