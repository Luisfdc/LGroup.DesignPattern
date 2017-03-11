using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowCoupling.JeitoErrado
{
    public class Pedido
    {
        public List<ItemPedido> Itens { get; set; }

        public Pagamento Pagamento { get; private set; }

        public void AddItemPedido(int idProduto, int qtd)
        {
            var item = new ItemPedido(idProduto, qtd);
            Itens.Add(item);
        }
        public void AddPagamento(Pagamento pgto)
        {
            if (pgto == null)
                throw new Exception("Pagamento não informado");

            Pagamento = pgto;
        }

        public void RealizarPagamento()
        {
            if (Pagamento == null)
                throw new Exception("Pagamento não informado");

            Console.WriteLine("Pagamento Realizado");
        }

        public decimal GetTotal()
        {
            var total = 0M;

            foreach (var item in Itens)
            {
                total += item.TotalParcial();
            }

            return total;
        }
    }
}
