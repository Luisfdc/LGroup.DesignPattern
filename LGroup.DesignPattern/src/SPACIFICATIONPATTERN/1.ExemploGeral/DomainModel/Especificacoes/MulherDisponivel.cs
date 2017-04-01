using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExemploGeral.DomainModel.Especificacoes
{
    public static class MulherDisponivel
    {
        //Estou dizendoque dado uma pessoa vou verificar se ela é valida ou não
        public static Expression<Func<Pessoa, bool>> IsValid()
        {
            //Uma especificação é um a expressão
            Expression<Func<Pessoa, bool>> expression = (Pessoa pessoa) => pessoa.Sexo == Sexo.Feminino
            && (pessoa.EstadoCivil == EstadoCivil.Solteiro ||
            pessoa.EstadoCivil == EstadoCivil.Viuvo ||
            pessoa.EstadoCivil == EstadoCivil.Divorciado);

            return expression;
        }
    }
}
