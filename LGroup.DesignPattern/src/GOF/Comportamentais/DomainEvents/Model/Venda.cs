using DomainEvents.Events;
using DomainEvents.Handlers;
using DomainEvents.ServiceLocators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEvents.Model
{
    public class Venda
    {
        private readonly object _lock = new object();
        public List<int> Produtos { get; set; }

        public Venda()
        {
            Produtos = new List<int>() { 1, 2 };
        }
        public void Finalizar()
        {
            Console.WriteLine("Finalizei a venda com sucesso");
            Task.Run(() =>
            {
                foreach (var produto in Produtos)
                {
                    lock (_lock)
                        DisparadorEventoEncomenda.Disparar(new EncomendaEvent(produto.ToString()));
                }

            });
        }
    }
}
