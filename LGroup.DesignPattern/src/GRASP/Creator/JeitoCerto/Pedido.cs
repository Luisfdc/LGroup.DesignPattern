using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creator.JeitoCerto
{
    public class Pedido
    {
        public List<ItemPedido> Itens { get; set; }
        
        public void AddItemPedido(int idProduto, int qtd)
        {
            var item = new ItemPedido(idProduto, qtd);
            Itens.Add(item);
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
