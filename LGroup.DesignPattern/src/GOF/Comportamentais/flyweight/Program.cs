using flyweight.DomainModels.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            //Estou em jogo de Luta...
            //Este item seria meis ou menos um pool de singleton
            GolpeService.Get("voadora").Executar();
            GolpeService.Get("chutefraco").Executar();
            GolpeService.Get("chutefraco").Executar();
            GolpeService.Get("chutefraco").Executar();
            GolpeService.Get("chutefraco").Executar();
            GolpeService.Get("chutefraco").Executar();
            GolpeService.Get("chutefraco").Executar();
            GolpeService.Get("chutefraco").Executar();
            GolpeService.Get("chutefraco").Executar();
            GolpeService.Get("chutefraco").Executar();
            GolpeService.Get("chutefraco").Executar();
            GolpeService.Get("voadora").Executar();
            GolpeService.Get("voadora").Executar();
            GolpeService.Get("voadora").Executar();
            GolpeService.Get("voadora").Executar();
            GolpeService.Get("voadora").Executar();
            GolpeService.Get("voadora").Executar();
            GolpeService.Get("voadora").Executar();
            GolpeService.Get("voadora").Executar();
            GolpeService.Get("voadora").Executar();
            Console.ReadKey();
        }
    }
}
