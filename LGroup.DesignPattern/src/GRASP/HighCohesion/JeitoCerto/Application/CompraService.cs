using HighCohesion.JeitoCerto.DomainModel;
using HighCohesion.JeitoCerto.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighCohesion.JeitoCerto.Application
{
    public class CompraService
    {
        //Responsavel por finalizar compra
        private CarrinhoRepository _carrinhoRepository;
        private PedidoRespository _pedidoRespository;
        public CompraService()
        {
            _carrinhoRepository = new CarrinhoRepository();
            _pedidoRespository = new PedidoRespository();
        }

        public void FinalizarCompra()
        {
            Carrinho carrinho = _carrinhoRepository.GetCarrinho("sessao");
            var pedido = carrinho.CriarPedidoAPartirdoCarrinho();

            _pedidoRespository.AddPedido(pedido);
        }

    }
}
