using Observer.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var assinanteA = new AssinanteA();
            var assinanteB = new AssinanteB();
            var assinanteC = new AssinanteC();

            var newsLatter = new NewsLetter();

            newsLatter.Registrar(assinanteA);
            newsLatter.Registrar(assinanteB);
            newsLatter.EnviarEmail();
            Console.WriteLine("<<<<<<<<<<<<<<<<<<");


            newsLatter.Registrar(assinanteC);
            newsLatter.EnviarEmail();
            Console.WriteLine("<<<<<<<<<<<<<<<<<<");

            newsLatter.Remove(assinanteA);
            newsLatter.EnviarEmail();
            Console.WriteLine("<<<<<<<<<<<<<<<<<<");

            Console.ReadKey();

        }
    }
}
