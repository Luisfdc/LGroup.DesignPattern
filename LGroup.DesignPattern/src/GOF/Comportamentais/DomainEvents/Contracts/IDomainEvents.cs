using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEvents.Contracts
{
    //Algo que aconteceu no passado e quero informar à alguem
    //Então Domain Events é algo que aconteceu de importante no seu negocio
    //E que é necessário informar a algo
    public interface IDomainEvents
    {
        DateTime DataOcorrencia { get; }
        string Mensagem { get; }
    }
}
