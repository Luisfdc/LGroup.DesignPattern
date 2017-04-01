using ExemploGeral.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploGeral.Repositories
{
    public class PessoaRepository
    {
        public IEnumerable<Pessoa> GetAll()
        {
            var pessoa = new List<Pessoa>
            {
                new Pessoa
                {
                    DataNascimento = DateTime.Now,
                    EstadoCivil = EstadoCivil.Amigado,
                    Sexo = Sexo.Feminino,
                    Nome = "Marta"
                },
                new Pessoa
                {
                    DataNascimento = DateTime.Now,
                    EstadoCivil = EstadoCivil.Solteiro,
                    Sexo = Sexo.Masculino,
                    Nome = "João"
                },
                new Pessoa
                {
                    DataNascimento = DateTime.Now,
                    EstadoCivil = EstadoCivil.Viuvo,
                    Sexo = Sexo.Feminino,
                    Nome = "Renata"
                }
            };

            return pessoa;
        }
    }
}
