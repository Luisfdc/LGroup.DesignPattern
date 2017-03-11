using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighCohesion.JeitoCerto.DomainModel
{
    public class Carrinho
    {
        public Pedido Pedido { get; set; }
        public List<ItensCarrinho> Itens { get; set; }

        //seria como uma factory interna
        public Pedido CriarPedidoAPartirdoCarrinho()
        {
            return new Pedido();
        }

        public void CriarItens(int idProduto, int qtd)
        {
            Itens.Add(new ItensCarrinho(idProduto, qtd));
        }
    }
}
