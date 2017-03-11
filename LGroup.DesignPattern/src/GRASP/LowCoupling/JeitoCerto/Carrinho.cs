using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowCoupling.JeitoCerto
{
    public class Carrinho
    {
        public Pedido Pedido { get; set; }
        public List<ItensCarrinho> Itens { get; set; }

        public void CriarPedido()
        {
            Console.WriteLine("Pedido sendo criado...");
        }
    }
}
