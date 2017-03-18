using FactoryMathod.DomainModel.Cotracts;
using FactoryMathod.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMathod.Factoreis
{
    //Se a regra para criar meu objeto for muito complexa e depende de muitas condições
    //Podemos delar esta contrução para ima factoryMethod
    public static class AbacaxiFactory
    {
        public static IAbacaxi Create(EstacaoAno estacao)
        {
            switch (estacao)
            {
                case EstacaoAno.Inverno:
                    return new AbacaxiAmericano { Nome = "Abacaxi - USA", Localizacao = "New York" };
                case EstacaoAno.Verao:
                    return new AbacaxiBrasileiro { Nome = "Abacaxi - BR", Localizacao = "São Paulo" };
                default:
                    throw new ArgumentException("Estação Invalida");
            }
        }
    }
}
