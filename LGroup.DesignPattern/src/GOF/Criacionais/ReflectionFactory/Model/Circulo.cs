using ReflectionFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionFactory.Model
{
    public class Circulo : IDesenho
    {
        public void Desenhar()
        {
            Console.WriteLine("Desenhando um Circulo...");
        }
    }
}
