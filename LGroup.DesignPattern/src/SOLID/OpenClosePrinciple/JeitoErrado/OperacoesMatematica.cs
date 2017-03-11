using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple.JeitoErrado
{
    public class OperacoesMatematica
    {
        public decimal Operar(decimal numA, decimal numB, TipoOperacao tipo)
        {
            if (tipo == TipoOperacao.Soma)
                return numA + numB;

            if (tipo == TipoOperacao.Subtracao)
                return numA - numB;

            if (tipo == TipoOperacao.Divisao)
            {
                if (numB == 0)
                    throw new DivideByZeroException("O denominador não pode ser 0");
                else
                    return numA / numB;
            }
            else
                return numA * numB;

        }
    }
    public enum TipoOperacao
    {
        Soma,
        Subtracao,
        Divisao,
        Multiplicacao
    }
}
