using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowCoupling.JeitoErrado
{
    public class Carrinho
    {
        public Pedido Pedido { get; set; }
        public Pagamento Pagamento { get; set; }
        public List<ItensCarrinho> Itens { get; set; }


        public void AddPagamento()
        {
            var Pagamento = new Pagamento();

            Pagamento.QtdParcela = 2;
            Pagamento.FormaPgto = "Boleto";

            decimal total = 0m;

            foreach (var item in Itens)
            {
                total += item.TotalParcial();
            }

            Pagamento.Total = total;

            Pedido.AddPagamento(Pagamento);
            Pedido.RealizarPagamento();
        }

    }
}
