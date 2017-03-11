using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubistutionPeinciple.JeitoCerto
{
    public class EmailService
    {
        public void EnviarEmail(Pessoa pessoa)
        {
            Console.WriteLine("Nome: " + pessoa.Nome);
            Console.WriteLine("Documento: " + pessoa.GetDocumento());
        }
    }
}
