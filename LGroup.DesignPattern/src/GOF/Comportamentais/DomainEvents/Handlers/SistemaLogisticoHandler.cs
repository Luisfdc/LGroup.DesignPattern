using DomainEvents.Contracts;
using DomainEvents.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEvents.Handlers
{
    public class SistemaLogisticoHandler : IHandler<EncomendaEvent>
    {
        public void Handler(EncomendaEvent arg)
        {
            //Isto aqui no mundo real estariamos instanciando uma api
            //de um outro sistema e enviando o evento como parametro da api
            Console.WriteLine("<<= Logistica =>>");
            Console.WriteLine(arg.DataOcorrencia.ToShortDateString());
            Console.WriteLine(arg.Mensagem);
        }
    }
}
