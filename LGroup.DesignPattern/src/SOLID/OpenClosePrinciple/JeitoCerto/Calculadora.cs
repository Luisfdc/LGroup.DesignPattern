using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple.JeitoCerto
{
    public class Calculadora
    {
        //Não estou passando uma classe concreta e sim uma abstração
        //A classe calculadora não conhece a implementacao da operação que esta vindo
        //Quem decide qual operação cai ser executada é o cliente que chama a calculadora
        //Ou seja eu inverti o controle da operação... que tem o controle da implementação é o cliente
        public decimal Operar(IOperacacao operacao)
        {
            return operacao.Operar();
        }
    }
}
