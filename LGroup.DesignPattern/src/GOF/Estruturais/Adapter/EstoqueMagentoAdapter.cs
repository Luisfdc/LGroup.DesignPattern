using Adapter.Contracts;
using Adapter.SistemasTerceiros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    //Quais são as condições para esse cara estar no nosso dominio?
    //Resp: Ele deve ser um ILogistica 
    public class EstoqueMagentoAdapter : ILogistica
    {
        //Para que o magento se integre com o nosso
        //precisamos passar toda a regra de negocio do magento para o nosso
        //Como fazer?
        //Por compesição

        private EstoqueMagento _estoqueMagento;

        public EstoqueMagentoAdapter()
        {
            _estoqueMagento = new EstoqueMagento();
        }
        public void BaixarEstoque(int idProduto, int qtde)
        {
            _estoqueMagento.Baixar(idProduto, qtde);
        }
    }
}
