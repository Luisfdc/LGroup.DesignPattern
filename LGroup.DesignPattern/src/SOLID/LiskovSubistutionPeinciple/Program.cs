using LiskovSubistutionPeinciple.JeitoCerto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubistutionPeinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var emailService = new EmailService();

            var pessoafisica = new PessoaFisica
            {
                Cpf = "12312312312",
                Nome = "Maria"
            };

            emailService.EnviarEmail(pessoafisica);


            var pessoaJuridica = new PessoaJuridica
            {
                Cnpj = "12312312312/123-12",
                Nome = "Maria"
            };

            emailService.EnviarEmail(pessoaJuridica);

            Console.ReadKey();
        }
    }
}
