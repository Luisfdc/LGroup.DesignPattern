using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expert.JeitoCerto
{
    public class ItemPedido
    {
        public Produto Produto { get; set; }
        public int Qtd { get; set; }

        public decimal TotalParcial()
        {
            return Produto.Preco * Qtd;
        }
    }
}
