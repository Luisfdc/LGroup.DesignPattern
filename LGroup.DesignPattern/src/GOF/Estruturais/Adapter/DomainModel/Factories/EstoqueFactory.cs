using Adapter.Contracts;
using Adapter.DomainModel;
using Adapter.SistemasTerceiros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Factories
{
    public static class EstoqueFactory
    {
        public static ILogistica Create(TipoEstoque tipo)
        {
            switch (tipo)
            {
                case TipoEstoque.LGroup:
                    return new EstoqueLGroup();
                case TipoEstoque.Magento:
                    return new EstoqueMagentoAdapter();
                default:
                    throw new Exception("Error");
            }
        }
    }
    
    public enum TipoEstoque
    {
        LGroup,
        Magento
    }
}
