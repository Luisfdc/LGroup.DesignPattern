using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.JeitoErrado
{
    public class Representante : Funcionario
    {
        //Exemplo para não perder tempo
        public override double GetSelarioTotal()
        {
            return 12000;
        }
        public override double GetComissao()
        {
            return 0.12;
        }

        public override void SairDeFerias()
        {
            throw new NotImplementedException();
        }
    }
}
