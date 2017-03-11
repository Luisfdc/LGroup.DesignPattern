using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.JeitoErrado
{
    public abstract class Funcionario
    {
        public double Salario { get; set; }
        public virtual double GetSelarioTotal()
        {
            return Salario;
        }

        public abstract void SairDeFerias();

        public abstract double GetComissao();
    }
}
