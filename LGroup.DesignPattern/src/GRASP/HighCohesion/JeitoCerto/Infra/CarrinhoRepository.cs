using HighCohesion.JeitoCerto.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighCohesion.JeitoCerto.Infra
{
    public class CarrinhoRepository
    {
        public void AddPedido(Carrinho carrinho)
        {
            Console.WriteLine("Adicionando Carrinho");
        }

        public Carrinho GetCarrinho(string sessao)
        {
            return new Carrinho();
        }
    }
}
