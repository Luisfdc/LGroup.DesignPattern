using DomainEvents.Contracts;
using DomainEvents.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEvents.Handlers
{
    public class SistemaFaturamentoHandler : IHandler<EncomendaEvent>
    {
        public void Handler(EncomendaEvent arg)
        {
            Console.WriteLine("<<= Faturamento =>>");
            Console.WriteLine(arg.DataOcorrencia.ToShortDateString());
            Console.WriteLine(arg.Mensagem);
        }

    }
}
