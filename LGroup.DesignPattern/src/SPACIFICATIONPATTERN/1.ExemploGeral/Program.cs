using ExemploGeral.DomainModel.Especificacoes;
using ExemploGeral.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploGeral
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new PessoaRepository();
            var pessoas = repository.GetAll();
            var mulheresDisponiveis = pessoas.Where(MulherDisponivel.IsValid().Compile());
        }

    }
}
