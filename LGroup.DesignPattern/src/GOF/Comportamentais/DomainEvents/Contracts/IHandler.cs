using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEvents.Contracts
{
    //O Handler é a classe que vai receber o envento
    //Logo a assinatura dela é a seguinte:
    public interface IHandler<T> where T : IDomainEvents
    {
        //Mandando a menssagem
        void Handler(T arg);
    }
}
