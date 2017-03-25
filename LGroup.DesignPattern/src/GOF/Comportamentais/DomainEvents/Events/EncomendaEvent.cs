using DomainEvents.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEvents.Events
{
    public class EncomendaEvent : IDomainEvents
    {
        public DateTime DataOcorrencia { get; private set; }

        public string Mensagem { get; private set; }

        public EncomendaEvent(string message)
        {
            DataOcorrencia = DateTime.Now;

            if (string.IsNullOrWhiteSpace(message))
                throw new ApplicationException("Messagem não informada");

            Mensagem = message;
        }


    }
}
