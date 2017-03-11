using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubistutionPeinciple.JeitoCerto
{
    public class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; set; }

        public override string GetDocumento()
        {
            return Cnpj;
        }
    }
}
