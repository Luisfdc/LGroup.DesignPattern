using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Contracts
{
    public interface INewsLetters
    {
        void EnviarEmail();
        void Registrar(IAssinante assinantes);
        void Remove(IAssinante assinantes);
    }
}
