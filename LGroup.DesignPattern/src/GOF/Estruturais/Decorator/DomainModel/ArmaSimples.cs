using Decorator.Contracts;
using System;

namespace Decorator.DomainModel
{
    public class ArmaSimples : IArma
    {
        public string Nome { get; set; }

        //Arma crua sem acessórios
        //Preciso adicionar acessorios nesta arma
        //Vou charmar o acessorio de Decorator
        public void Montar()
        {
            Console.WriteLine($"{this.Nome} => Montando a minha arma simples \n");
        }
    }
}
