using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowCoupling.JeitoCerto
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

        public void AddPagamento(string formaPgto, int qtdParcela)
        {
            //Objeto de valor
            Pagamento = new Pagamento { FormaPgto = formaPgto, QtdParcela = qtdParcela };
            var total = 0M;
            foreach(var item in Itens)
            {
                total += item.TotalParcial();
            }

            Pagamento.Total = total;
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
